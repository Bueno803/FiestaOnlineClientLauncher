Imports System.Security.Cryptography
Imports System.Text

Module Encryption

    Public Function MD5Hash(ByVal input As String) As String
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim Data As Byte()
        Dim Result As Byte()
        Dim Res As String = ""
        Dim Tmp As String = ""
        Data = System.Text.Encoding.ASCII.GetBytes(input)
        Result = MD5.ComputeHash(Data)
        For i As Integer = 0 To Result.Length - 1
            Tmp = Hex(Result(i))
            If Len(Tmp) = 1 Then Tmp = "0" & Tmp
            Res += Tmp
        Next
        Return Res
    End Function

    Public Function CustomXOR_Encrypt(ByVal Input As String, ByVal pass As String) As String
        Dim out As New System.Text.StringBuilder
        Dim Hash As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim XorHash As Byte() = Hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(pass))
        Dim u As Integer
        For i As Integer = 0 To Input.Length - 1
            Dim tmp As String = Hex(Asc(Input(i)) Xor XorHash(u))
            If tmp.Length = 1 Then tmp = "0" & tmp
            out.Append(tmp)
            If u = pass.Length - 1 Then u = 0 Else u = u + 1
        Next
        Return out.ToString
    End Function

    Public Function CustomXOR_Decrypt(ByVal Input As String, ByVal pass As String) As String
        Dim out As New System.Text.StringBuilder
        Dim Hash As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim XorHash As Byte() = Hash.ComputeHash(System.Text.Encoding.ASCII.GetBytes(pass))
        Dim u As Integer
        For i As Integer = 0 To Input.Length - 1 Step +2
            Dim tmp As String = Chr(("&H" & Input.Substring(i, 2)) Xor XorHash(u))
            out.Append(tmp)
            If u = pass.Length - 1 Then u = 0 Else u = u + 1
        Next
        Return out.ToString
    End Function

    Public Function TripleDES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim TripleDES As New System.Security.Cryptography.TripleDESCryptoServiceProvider
        Dim Hash_TripleDES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(23) As Byte
            Dim temp As Byte() = Hash_TripleDES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 8)
            TripleDES.Key = hash
            TripleDES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = TripleDES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function

    Public Function TripleDES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim TripleDES As New System.Security.Cryptography.TripleDESCryptoServiceProvider
        Dim Hash_TripleDES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(23) As Byte
            Dim temp As Byte() = Hash_TripleDES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 8)
            TripleDES.Key = hash
            TripleDES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = TripleDES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function

End Module
