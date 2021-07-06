
Imports System.IO


Public Class frmPatcher


    Dim inisettings As New ini(Application.StartupPath & "\settings\config.ini")


    Private UnByte As Long = 1024

    Dim extracting As Boolean = False
    Dim counter As Byte = 0

    Function RemoveME(Of T)(ByVal arr As T(), ByVal index As Integer) As T()
        Dim uBound = arr.GetUpperBound(0)
        Dim lBound = arr.GetLowerBound(0)
        Dim arrLen = uBound - lBound

        If index < lBound OrElse index > uBound Then
            Throw New ArgumentOutOfRangeException( _
            String.Format("Index must be from {0} to {1}.", lBound, uBound))

        Else
            'create an array 1 element less than the input array
            Dim outArr(arrLen - 1) As T
            'copy the first part of the input array
            Array.Copy(arr, 0, outArr, 0, index)
            'then copy the second part of the input array
            Array.Copy(arr, index + 1, outArr, index, uBound - index)

            Return outArr
        End If
    End Function

    

    Sub Unzipped(filename As String, Folder As String)
        ProgressBarX1.Maximum = UnByte
        ProgressBarX1.Minimum = 0
        Dim temp As String = Folder


        If Folder = "" Then Exit Sub

        If Folder.EndsWith("\") = False Then Folder &= "\"

        Dim FileToExtract As String

        Dim s As New ICSharpCode.SharpZipLib.Zip.ZipInputStream(File.OpenRead(filename))

        's.Password = _Password

        Dim theEntry As ICSharpCode.SharpZipLib.Zip.ZipEntry

        theEntry = s.GetNextEntry()
        lblFilePatch.Text = theEntry.Name.ToString
        lblFilePatch.Refresh()
       

        'Boucle tout les fichiers
        Dim tempFile As String
        Do Until theEntry Is Nothing
            Folder = temp
            FileToExtract = theEntry.Name


            tempFile = Nothing
           
            Dim Folders() As String = FileToExtract.Split("\")

            For j = 0 To Folders.Length - 1
                If Folders(j).Contains("/") Then
                    Folders = FileToExtract.Split("/")
                    tempFile = Folders(Folders.Length - 1)

                    If tempFile = Nothing Then
                        tempFile = "dmp"
                        FileToExtract = tempFile
                    Else
                        FileToExtract = tempFile
                        Folders = RemoveME(Folders, Folders.Length - 1)
                        If Folders.Length > 1 Then
                            For l = 0 To Folders.Length - 1
                                Folder = Folder & Folders(l) & "\"
                            Next
                            GoTo 2

                        Else
                            Folder = Folder & Folders(0) & "\"
                            Directory.CreateDirectory(Folder)
                        End If

                    End If

                End If

            Next
            Dim i As Integer

            'Dim iConcat As Integer

2:          Dim NewFolder As String = Nothing

            NewFolder = Folder


            For i = 0 To Folders.Length - 2

                NewFolder &= Folders(i)

                If NewFolder.EndsWith("\") = False Then NewFolder &= "\"

                If Directory.Exists(NewFolder) = False Then

                    Directory.CreateDirectory(NewFolder)
                    'MsgBox("Folder Created " & NewFolder)
                    GoTo 2
                End If

            Next



            'Efface le fichier si il existe

            If File.Exists(Folder & FileToExtract) = True Then

                Try

                    File.Delete(Folder & FileToExtract)

                Catch ex As Exception

                    Throw ex

                End Try

            End If



            Dim StreamWriter As FileStream = File.Create(Folder & FileToExtract)

            Dim Size As Integer = 2048

            Dim data(2048) As Byte

            While (True)

                Size = s.Read(data, 0, data.Length)

                If (Size > 0) Then

                    StreamWriter.Write(data, 0, Size)

                    ProgressBarX1.Value += 1
                    ProgressBarX1.Text = Format((ProgressBarX1.Value / UnByte) * 100, "0.00") & "%"

                    If ProgressBarX1.Value = UnByte Then ProgressBarX1.Value = 0

                Else

                    Exit While

                End If

            End While

            StreamWriter.Close()
            theEntry = s.GetNextEntry()
            If theEntry Is Nothing Then
                ProgressBarX1.Value = UnByte
                GoTo 1

                ' Exit Sub
            End If
            lblFilePatch.Text = theEntry.Name.ToString
1:          Me.Refresh()
            extracting = False
          
        Loop


        s.Close()
    End Sub
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Private Sub frmPatcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Refresh()
        wait(300)

        Dim currentPatchNo As Byte = 0
        Dim currentPatchNoEncrypted As String

        For i = 0 To ListOfPatchFile.Count - 1
            extracting = True
            lblPatch.Text = "Extracting " & ListOfPatchFile.Item(i).ToString
            Unzipped(Application.StartupPath & "\" & ListOfPatchFile.Item(i).ToString, Application.StartupPath & "\")

            While extracting = True
                Application.DoEvents()
            End While

            currentPatchNo = TripleDES_Decrypt(inisettings.GetString("patchver", "ver", ""), donotmodifiy)
            currentPatchNo += 1
            currentPatchNoEncrypted = TripleDES_Encrypt(currentPatchNo, donotmodifiy)
            inisettings.WriteString("patchver", "ver", currentPatchNoEncrypted)
            File.Delete(Application.StartupPath & "\" & ListOfPatchFile.Item(i).ToString)

        Next

       

        frmMain.Enabled = True
        frmMain.Show()
        frmMain.Focus()
        frmMain.ButtonX1.Enabled = True
        frmMain.ButtonX1.Text = "Play"
        frmMain.lblpatchVer.Text = "Patch Ver " & TripleDES_Decrypt(inisettings.GetString("patchver", "ver", ""), donotmodifiy)
        frmMain.lblCurrentPercent.Text = "Client is upto Date"
        frmMain.lblDLSpeed.Text = ""
        frmMain.lblFileSize.Text = ""
        frmMain.Label4.Text = ""
        frmMain.CircularProgress1.IsRunning = False
        flags = True
        File.Delete(Application.StartupPath & "\dmp")
        frmMain.CheckClientVersion()


        Me.Close()



    End Sub

    
End Class