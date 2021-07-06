Imports System.IO
Imports System.Net

Public Class frmMain

    Delegate Sub ChangeText(val As Integer)
    Dim response As String
    Dim inisettings As ini
    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Long, ByVal percent As Double, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean)


    Delegate Sub Extracting(patch As String)

    Dim currentCount As Integer

    Dim downloading As Boolean
    Dim whereToSave As String

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
      
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(ClientChecker.GenerateFileMD5(System.AppDomain.CurrentDomain.FriendlyName))
        CircularProgress1.ProgressTextVisible = False
        Me.Show()
        Me.Focus()

        'ActivateControlsNow.LoadMain()

        StartApplication()
    End Sub

    Sub StartApplication()

        Me.Show()
        Application.DoEvents()
        Me.Refresh()
        lblCurrentPercent.Text = "Connecting to Server..."

        If File.Exists(Application.StartupPath & "\settings\config.ini") = False Then
            MsgBox("Configuration File is missing, Please ask for assistance!", MsgBoxStyle.Critical, "Trending Softwares Auto Updater")
            Exit Sub
        End If

        inisettings = New ini(Application.StartupPath & "\settings\config.ini")

        siteurl = inisettings.GetString("siteurl", "site", "")
        sitenews = inisettings.GetString("sitenews", "site", "")
        patchsite = inisettings.GetString("patchsite", "site", "")
        voteurl = inisettings.GetString("voteurl", "site", "")
        rankurl = inisettings.GetString("rankurl", "site", "")
        registerpage = inisettings.GetString("registerpage", "site", "")
        donotmodifiy = inisettings.GetString("donotmodify", "val", "")
        Try
            clientver = TripleDES_Decrypt(inisettings.GetString("clientver", "ver", ""), donotmodifiy)
            patchver = TripleDES_Decrypt(inisettings.GetString("patchver", "ver", ""), donotmodifiy)

            If IsNumeric(clientver) = False Or clientver = Nothing Or clientver = 0 Then

                MsgBox("You might have modified the config file DONOTMODIFY section!" & vbCrLf & _
                    "Please ask for assistance!", MsgBoxStyle.Critical, "Trending Softwares Auto Updater")
                End

            End If
            If IsNumeric(patchver) = False Then 'Or patchver = Nothing Then
                MsgBox("You might have modified the config file DONOTMODIFY section!" & vbCrLf & _
                    "Please ask for assistance!", MsgBoxStyle.Critical, "Trending Softwares Auto Updater")
                End
            End If

        Catch ex As Exception
            MsgBox("You might have modified the config file DONOTMODIFY section!" & vbCrLf & _
                "Please ask for assistance!", MsgBoxStyle.Critical, "Trending Softwares Auto Updater")
            End

        End Try

        lblClientVer.Text = "Client Ver " & clientver & ".0"
        lblpatchVer.Text = "Patch Ver " & patchver
        WebBrowser1.Navigate(sitenews)
        CircularProgress1.IsRunning = True
        wait(1000)
        CircularProgress1.IsRunning = False

        lblCurrentPercent.Text = "Downloading Patch File List"
        wait(1000)
        CircularProgress1.IsRunning = True

        If DownloadString(patchsite & "config.ini") <> "No Internet Connection" Then
            BackgroundWorker2.RunWorkerAsync()
        Else
            MsgBox("Please check your Internet Connectivity", MsgBoxStyle.Critical, "Trending Softwares Auto Updater")
            ButtonX1.Text = "No Connection"
            lblCurrentPercent.Text = "No Internet Connectivity"
            CircularProgress1.IsRunning = False
            Exit Sub
        End If



    End Sub

    Private Function DownloadString(ByVal address As String) As String
        Dim reply As String
        Try
            Dim client As WebClient = New WebClient()
            reply = client.DownloadString(address)
            Return reply
        Catch ex As Exception
            ' MsgBox(ex.Message.ToString)
            reply = "No Internet Connection"
            Return reply
        End Try
    End Function

    Sub ChangeMyProgress(val As Integer)
        ProgressBarX1.Value = val
        lblCurrentPercent.Text = val & "%"
        CircularProgress1.Value = val

        CircularProgress1.Text = val & "%"

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim c As Byte
        c = MsgBox("Do you want to close the launcher?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Trending Softwares Auto Updater")

        If c = 6 Then
            Me.Close()
            End
        Else : Exit Sub
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim t As New ChangeText(AddressOf ChangeMyProgress)

        For i = 1 To 100
            Invoke(t, i)
            System.Threading.Thread.Sleep(300)
        Next


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ButtonX1.Enabled = True
        ButtonX1.Text = "Play"
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

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Process.Start(voteurl)

    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Process.Start(registerpage)

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        Process.Start(rankurl)
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        response = DownloadString(patchsite & "config.ini")
        'GameHashes = DownloadString(patchsite & "s.txt")
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        If response <> Nothing Then

            Dim swrite As New StreamWriter(Application.StartupPath & "\settings\sc.ini")
            swrite.Write(response)
            swrite.Close()

            inisettings = New ini(Application.StartupPath & "\settings\sc.ini")

            exeHash = inisettings.GetString("LauncherHash", "val", "")
            ServerClientVer = inisettings.GetString("ClientVer", "ver", "")
            ServerCurrentPatch = inisettings.GetString("PatchVer", "ver", "")
            FS = inisettings.GetString("FSExe", "val", "")
            FSHash = inisettings.GetString("FSHash", "val", "")
            GameExe = inisettings.GetString("GameClientExe", "val", "")
            GameHash = inisettings.GetString("GameClientHash", "val", "")


         Try
                If exeHash <> GenerateFileMD5(Application.StartupPath & "\" & System.AppDomain.CurrentDomain.FriendlyName) Then
                    MsgBox("Game Launcher has been modified!You are not allowed to download any patches.", MsgBoxStyle.Critical, "File Security")
                    End
                End If

            Catch ex As Exception
                MsgBox("Error occured in your client", MsgBoxStyle.Critical, "File Security")
                End
            End Try


            Dim temp As String = patchsite & "download/"
            If patchver <> ServerCurrentPatch Or patchver > ServerCurrentPatch Then
                For i = patchver + 1 To ServerCurrentPatch
                    temp = patchsite & "download/" & inisettings.GetString("PatchLinks", i, "")
                    SiteList.Add(temp)
                    ListOfPatchFile.Add(inisettings.GetString("PatchLinks", i, ""))
                Next
                File.Delete(Application.StartupPath & "\settings\sc.ini")
                CircularProgress1.ProgressTextVisible = True
                DownloadPatches()

            Else
                CircularProgress1.ProgressTextVisible = False
                File.Delete(Application.StartupPath & "\settings\sc.ini")
                lblCurrentPercent.Text = "Client is upto Date"
                ProgressBarX1.Value = 100
                ButtonX1.Enabled = True
                ButtonX1.Text = "Play"
                CircularProgress1.IsRunning = False

                CheckClientVersion()

            End If




        Else

            MsgBox("Didn't get any response from the Patch Server", MsgBoxStyle.Exclamation, "Trending Softwares Auto Updater")
            Exit Sub

        End If
    End Sub

    Sub CheckClientVersion()
        If flags = True Then
            frmPatcher.Close()
        End If
      
        If ServerClientVer <> clientver Then
            Process.Start(Application.StartupPath & "\updater.exe", "ClientLauncherNew.exe|" & Replace(System.AppDomain.CurrentDomain.FriendlyName, " ", "_"))
            Me.Close()
            End

        End If

    End Sub

    Sub DownloadPatches()
        Dim totalNoOfPatches As Byte = SiteList.Count - 1

        ProgressBarX1.Maximum = 100
        ProgressBarX1.Minimum = 0
        ProgressBarX1.Value = 0

        Dim i As Integer = 0
        For x = 0 To SiteList.Count - 1
            ListBox1.Items.Add(SiteList(x).ToString)
        Next
        ButtonX1.Text = "Downloading"
        CircularProgress1.IsRunning = False
        Do While (i <= totalNoOfPatches)
            downloading = True
            whereToSave = Application.StartupPath & "\" & ListOfPatchFile.Item(i)
            lblCurrentPercent.Text = "Downloading " & ListOfPatchFile.Item(i)
            TextBox1.Text = SiteList.Item(i).ToString
            TextBox2.Text = ListOfPatchFile.Item(i).ToString
            BackgroundWorker3.RunWorkerAsync()
            CircularProgress1.Minimum = 0
            CircularProgress1.Maximum = 100
            Do While downloading = True
                Application.DoEvents()
            Loop
            i += 1

        Loop

        ButtonX1.Text = "Patching"
        Me.Enabled = False
        frmPatcher.Enabled = True
        frmPatcher.Show()
        frmPatcher.Focus()




    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try 'Checks if the file exist

            theRequest = WebRequest.Create(TextBox1.Text)
            theResponse = theRequest.GetResponse
        Catch ex As Exception

            MessageBox.Show("An error occurred while downloading file. Possibe causes:" & ControlChars.CrLf & _
                            "1) File doesn't exist" & ControlChars.CrLf & _
                            "2) Remote server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub
        End Try
        Dim length As Long = theResponse.ContentLength 'Size of the response (in bytes)

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0) 'Invoke the TreadsafeDelegate

        Dim writeStream As New IO.FileStream(Me.whereToSave, IO.FileMode.Create)

        'Replacement for Stream.Position (webResponse stream doesn't support seek)
        Dim nRead As Long

        'To calculate the download speed
        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Long = 0

        Do

            If BackgroundWorker2.CancellationPending Then 'If user abort download
                Exit Do
            End If

            speedtimer.Start()

            Dim readBytes(4095) As Byte
            Dim bytesread As Long = theResponse.GetResponseStream.Read(readBytes, 0, 4096)

            nRead += bytesread
            Dim percent As Double = (nRead * 100) / length

            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)

            If bytesread = 0 Then Exit Do

            writeStream.Write(readBytes, 0, bytesread)

            speedtimer.Stop()

            readings += 1
            If readings >= 5 Then 'For increase precision, the speed it's calculated only every five cicles
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        'Close the streams
        theResponse.GetResponseStream.Close()
        writeStream.Close()

        If Me.BackgroundWorker3.CancellationPending Then

            IO.File.Delete(Me.whereToSave)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True)

            Exit Sub

        End If

        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

        Me.Invoke(completeDelegate, False)
    End Sub

    Public Sub DownloadComplete(ByVal cancelled As Boolean)
       
        If cancelled Then
          
            MessageBox.Show("Download aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            currentCount = ListBox1.Items.Count
           
            ButtonX1.Enabled = True

            Me.ProgressBarX1.Value = 0
        
            lblFileSize.Text = "File size: "
            lblDLSpeed.Text = "Download speed: "
            CircularProgress1.ProgressTextVisible = False

            TextBox1.Clear()
            TextBox2.Clear()
        Else
            downloading = False
            CircularProgress1.ProgressTextVisible = False
            lblCurrentPercent.Text = "Patches Successfully Downloaded"
            Me.ProgressBarX1.Value = 100

            If currentCount = ListBox1.Items.Count Then

                lblCurrentPercent.Text = "Patches Successfully Downloaded"
                Me.ProgressBarX1.Value = 100

                lblFileSize.Text = "File size: "
                lblDLSpeed.Text = "Download speed: "

                TextBox1.Clear()
                TextBox2.Clear()

            End If


        End If

    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)

        lblFileSize.Text = "File Size: " & Math.Round((length / 1024), 2) & " KB"

        lblCurrentPercent.Text = "Downloading: " & TextBox2.Text

        CircularProgress1.Value = ProgressBarX1.Value

        Me.Label4.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((length / 1024), 2) & "KB (" & Me.ProgressBarX1.Value & "%)"

        If speed = -1 Then
            lblDLSpeed.Text = "Speed: calculating..."
        Else
            lblDLSpeed.Text = "Speed: " & Math.Round((speed / 1024), 2) & " KB/s"
        End If

        Me.ProgressBarX1.Value = percent


    End Sub

    Private Sub frmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y

        End If

    End Sub

    Private Sub frmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If IsFormBeingDragged Then

            Dim temp As Point = New Point()



            temp.X = Me.Location.X + (e.X - MouseDownX)

            temp.Y = Me.Location.Y + (e.Y - MouseDownY)

            Me.Location = temp

            temp = Nothing

        End If

    End Sub

    Private Sub frmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        'checks the current game file name from the server to the current
        If File.Exists(Application.StartupPath & "\" & GameExe) Then

            'checks the current game hash if its valid or not
            If GameHash <> GenerateFileMD5(Application.StartupPath & "\" & GameExe) Then
                MsgBox("Game Client has been modified! Game will close", MsgBoxStyle.Critical, "File Security")
                End
            Else
                'Checks the File Name of FS
                If File.Exists(Application.StartupPath & "\" & FS) Then
                    'Checks the FS Current Valid Hash
                    If FSHash <> GenerateFileMD5(Application.StartupPath & "\" & FS) Then
                        MsgBox("File Security has been modified!, Game will close", MsgBoxStyle.Critical, "File Security")
                        End
                    Else
                        'if game client hashes exes, fs and fs hashes are all valid. this will
                        'activate the File Security for checking of files

                        Dim sw As New StreamWriter(Application.StartupPath & "\start.bin")
                        Dim dt As String = Format(DateTime.Now, "h:mm tt")
                        sw.WriteLine(TripleDES_Encrypt(dt, donotmodifiy), True)
                        sw.Close()

                        Process.Start(Application.StartupPath & "\" & FS, FSHash)
                        End
                        End
                    End If
                Else

                End If
            End If


        Else
            MsgBox("Client cannot find the Game you want to play", MsgBoxStyle.Exclamation, "File Security")
            Exit Sub

        End If

    End Sub
End Class