Module ActivateControlsNow
    Dim inisettings As New ini(Application.StartupPath & "\settings\style.ini")


    Sub LoadMain()
        frmMain.ButtonX1.Location = New Point(inisettings.GetString("playbutton", "X", ""), inisettings.GetString("playbutton", "y", ""))
        frmMain.ButtonX1.Size = New Size(inisettings.GetString("playbutton", "width", ""), inisettings.GetString("playbutton", "height", ""))
        frmMain.ButtonX1.Font = New Font(inisettings.GetString("formsettings", "fontface", ""), inisettings.GetString("playbutton", "fontsize", ""))







    End Sub

End Module
