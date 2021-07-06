Module variables

#Region "Config Variables "

    Public siteurl As String
    Public sitenews As String
    Public patchsite As String
    Public voteurl As String
    Public registerpage As String
    Public clientver As Byte
    Public patchver As Byte
    Public donotmodifiy As String
    Public rankurl As String

#End Region

    Public SiteList As New List(Of String)
    Public ListOfPatchFile As New List(Of String)
    Public ServerClientVer As Byte
    Public ServerCurrentPatch As Byte

    Public flags As Boolean = False

    Public exeHash As String

    'All files you want you file security to check
    Public GameHashes As String = Nothing

    'gets from the server the current valid game exe file name
    Public GameExe As String = Nothing
    'gets from the server the current valid game exe hash
    Public GameHash As String = Nothing


    'FS is for the File Security
    Public FS As String = Nothing
    'File security hash to check if it is modified or not
    Public FSHash As String = Nothing

End Module
