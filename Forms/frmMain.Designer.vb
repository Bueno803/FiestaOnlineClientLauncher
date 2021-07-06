<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblCurrentPercent = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.lblClientVer = New System.Windows.Forms.Label()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblFileSize = New System.Windows.Forms.Label()
        Me.lblDLSpeed = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblpatchVer = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CircularProgress1 = New DevComponents.DotNetBar.Controls.CircularProgress()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCurrentPercent
        '
        Me.lblCurrentPercent.AutoSize = True
        Me.lblCurrentPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPercent.Font = New System.Drawing.Font("Harabara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPercent.Location = New System.Drawing.Point(256, 335)
        Me.lblCurrentPercent.Name = "lblCurrentPercent"
        Me.lblCurrentPercent.Size = New System.Drawing.Size(20, 18)
        Me.lblCurrentPercent.TabIndex = 2
        Me.lblCurrentPercent.Text = "#"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(259, 42)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(23, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(373, 102)
        Me.WebBrowser1.TabIndex = 3
        Me.WebBrowser1.TabStop = False
        '
        'lblClientVer
        '
        Me.lblClientVer.AutoSize = True
        Me.lblClientVer.BackColor = System.Drawing.Color.Transparent
        Me.lblClientVer.Font = New System.Drawing.Font("Harabara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientVer.Location = New System.Drawing.Point(178, 466)
        Me.lblClientVer.Name = "lblClientVer"
        Me.lblClientVer.Size = New System.Drawing.Size(62, 13)
        Me.lblClientVer.TabIndex = 2
        Me.lblClientVer.Text = "Client Ver #"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Enabled = False
        Me.ButtonX1.Font = New System.Drawing.Font("Harabara", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Location = New System.Drawing.Point(638, 335)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.ButtonX1.Size = New System.Drawing.Size(147, 60)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.TabStop = False
        Me.ButtonX1.Text = "Checking"
        Me.ButtonX1.Tooltip = "Status is also updated here"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Font = New System.Drawing.Font("Harabara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Location = New System.Drawing.Point(485, 188)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.ButtonX2.Size = New System.Drawing.Size(99, 31)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX2.TabIndex = 5
        Me.ButtonX2.Text = "Vote"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Font = New System.Drawing.Font("Harabara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX3.Location = New System.Drawing.Point(485, 233)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.ButtonX3.Size = New System.Drawing.Size(99, 31)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX3.TabIndex = 5
        Me.ButtonX3.Text = "Register"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Font = New System.Drawing.Font("Harabara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX4.Location = New System.Drawing.Point(485, 271)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(5)
        Me.ButtonX4.Size = New System.Drawing.Size(99, 31)
        Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ButtonX4.TabIndex = 5
        Me.ButtonX4.Text = "Rankings"
        '
        'ProgressBarX1
        '
        Me.ProgressBarX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Location = New System.Drawing.Point(259, 356)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(373, 23)
        Me.ProgressBarX1.TabIndex = 6
        Me.ProgressBarX1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(26, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'BackgroundWorker3
        '
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(638, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(104, 82)
        Me.ListBox1.TabIndex = 10
        Me.ListBox1.Visible = False
        '
        'lblFileSize
        '
        Me.lblFileSize.BackColor = System.Drawing.Color.Transparent
        Me.lblFileSize.Font = New System.Drawing.Font("Harabara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileSize.Location = New System.Drawing.Point(256, 394)
        Me.lblFileSize.Name = "lblFileSize"
        Me.lblFileSize.Size = New System.Drawing.Size(204, 13)
        Me.lblFileSize.TabIndex = 2
        '
        'lblDLSpeed
        '
        Me.lblDLSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblDLSpeed.Font = New System.Drawing.Font("Harabara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDLSpeed.Location = New System.Drawing.Point(256, 261)
        Me.lblDLSpeed.Name = "lblDLSpeed"
        Me.lblDLSpeed.Size = New System.Drawing.Size(174, 13)
        Me.lblDLSpeed.TabIndex = 2
        Me.lblDLSpeed.Text = " "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Harabara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = " "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(639, 131)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 21)
        Me.TextBox1.TabIndex = 9
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(639, 156)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(103, 21)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Visible = False
        '
        'lblpatchVer
        '
        Me.lblpatchVer.AutoSize = True
        Me.lblpatchVer.BackColor = System.Drawing.Color.Transparent
        Me.lblpatchVer.Font = New System.Drawing.Font("Harabara", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpatchVer.Location = New System.Drawing.Point(314, 467)
        Me.lblpatchVer.Name = "lblpatchVer"
        Me.lblpatchVer.Size = New System.Drawing.Size(61, 13)
        Me.lblpatchVer.TabIndex = 2
        Me.lblpatchVer.Text = "Patch Ver #"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(33, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'CircularProgress1
        '
        Me.CircularProgress1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CircularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CircularProgress1.Location = New System.Drawing.Point(71, 323)
        Me.CircularProgress1.Name = "CircularProgress1"
        Me.CircularProgress1.ProgressColor = System.Drawing.SystemColors.HotTrack
        Me.CircularProgress1.ProgressTextVisible = True
        Me.CircularProgress1.Size = New System.Drawing.Size(106, 80)
        Me.CircularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP
        Me.CircularProgress1.TabIndex = 12
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(841, 454)
        Me.Controls.Add(Me.CircularProgress1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.Controls.Add(Me.ButtonX4)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.lblpatchVer)
        Me.Controls.Add(Me.lblClientVer)
        Me.Controls.Add(Me.lblCurrentPercent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDLSpeed)
        Me.Controls.Add(Me.lblFileSize)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trending Softwares Auto Updater"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCurrentPercent As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents lblClientVer As System.Windows.Forms.Label
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblFileSize As System.Windows.Forms.Label
    Friend WithEvents lblDLSpeed As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblpatchVer As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CircularProgress1 As DevComponents.DotNetBar.Controls.CircularProgress
End Class
