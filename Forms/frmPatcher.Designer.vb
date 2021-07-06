<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatcher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatcher))
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPatch = New System.Windows.Forms.Label()
        Me.lblFilePatch = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'ProgressBarX1
        '
        Me.ProgressBarX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Location = New System.Drawing.Point(12, 213)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(382, 23)
        Me.ProgressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.ProgressBarX1.TabIndex = 0
        Me.ProgressBarX1.TabStop = False
        Me.ProgressBarX1.TextVisible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Harabara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patch Name :"
        '
        'lblPatch
        '
        Me.lblPatch.AutoSize = True
        Me.lblPatch.BackColor = System.Drawing.Color.Transparent
        Me.lblPatch.Font = New System.Drawing.Font("Harabara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatch.Location = New System.Drawing.Point(96, 194)
        Me.lblPatch.Name = "lblPatch"
        Me.lblPatch.Size = New System.Drawing.Size(10, 15)
        Me.lblPatch.TabIndex = 1
        Me.lblPatch.Text = " "
        '
        'lblFilePatch
        '
        Me.lblFilePatch.AutoSize = True
        Me.lblFilePatch.BackColor = System.Drawing.Color.Transparent
        Me.lblFilePatch.Font = New System.Drawing.Font("Harabara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePatch.Location = New System.Drawing.Point(12, 240)
        Me.lblFilePatch.Name = "lblFilePatch"
        Me.lblFilePatch.Size = New System.Drawing.Size(17, 15)
        Me.lblFilePatch.TabIndex = 1
        Me.lblFilePatch.Text = "#"
        '
        'frmPatcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(481, 270)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFilePatch)
        Me.Controls.Add(Me.lblPatch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPatcher"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trending Softwares Auto Updater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPatch As System.Windows.Forms.Label
    Friend WithEvents lblFilePatch As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
