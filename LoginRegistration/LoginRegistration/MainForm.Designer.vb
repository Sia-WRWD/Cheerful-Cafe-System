<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelOption = New System.Windows.Forms.Panel()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnStaffRegistration = New System.Windows.Forms.Button()
        Me.btnCustomerRegistration = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.PanelWelcome = New System.Windows.Forms.Panel()
        Me.lblFun = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.PBMorning = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.PanelSearch = New System.Windows.Forms.Panel()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.PBHype = New System.Windows.Forms.PictureBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelStarting = New System.Windows.Forms.Panel()
        Me.lblSlogan = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.PanelOption.SuspendLayout()
        Me.PanelWelcome.SuspendLayout()
        CType(Me.PBMorning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSearch.SuspendLayout()
        CType(Me.PBHype, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelStarting.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelOption
        '
        Me.PanelOption.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelOption.Controls.Add(Me.btnHistory)
        Me.PanelOption.Controls.Add(Me.btnStaffRegistration)
        Me.PanelOption.Controls.Add(Me.btnCustomerRegistration)
        Me.PanelOption.Controls.Add(Me.btnMenu)
        Me.PanelOption.Location = New System.Drawing.Point(12, 221)
        Me.PanelOption.Name = "PanelOption"
        Me.PanelOption.Size = New System.Drawing.Size(230, 357)
        Me.PanelOption.TabIndex = 1
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHistory.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.Yellow
        Me.btnHistory.Location = New System.Drawing.Point(41, 93)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(144, 82)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "HISTORY"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'btnStaffRegistration
        '
        Me.btnStaffRegistration.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStaffRegistration.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffRegistration.ForeColor = System.Drawing.Color.Yellow
        Me.btnStaffRegistration.Location = New System.Drawing.Point(41, 269)
        Me.btnStaffRegistration.Name = "btnStaffRegistration"
        Me.btnStaffRegistration.Size = New System.Drawing.Size(144, 82)
        Me.btnStaffRegistration.TabIndex = 3
        Me.btnStaffRegistration.Text = "Staff Registration"
        Me.btnStaffRegistration.UseVisualStyleBackColor = False
        '
        'btnCustomerRegistration
        '
        Me.btnCustomerRegistration.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCustomerRegistration.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomerRegistration.ForeColor = System.Drawing.Color.Yellow
        Me.btnCustomerRegistration.Location = New System.Drawing.Point(41, 181)
        Me.btnCustomerRegistration.Name = "btnCustomerRegistration"
        Me.btnCustomerRegistration.Size = New System.Drawing.Size(144, 82)
        Me.btnCustomerRegistration.TabIndex = 1
        Me.btnCustomerRegistration.Text = "Customer Registration"
        Me.btnCustomerRegistration.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMenu.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.Yellow
        Me.btnMenu.Location = New System.Drawing.Point(41, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(144, 82)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "MENU"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'PanelWelcome
        '
        Me.PanelWelcome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelWelcome.Controls.Add(Me.lblFun)
        Me.PanelWelcome.Controls.Add(Me.lblWelcome)
        Me.PanelWelcome.Controls.Add(Me.PBMorning)
        Me.PanelWelcome.Controls.Add(Me.lblMessage)
        Me.PanelWelcome.Location = New System.Drawing.Point(248, 13)
        Me.PanelWelcome.Name = "PanelWelcome"
        Me.PanelWelcome.Size = New System.Drawing.Size(545, 305)
        Me.PanelWelcome.TabIndex = 2
        '
        'lblFun
        '
        Me.lblFun.AutoSize = True
        Me.lblFun.Font = New System.Drawing.Font("Permanent Marker", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFun.ForeColor = System.Drawing.Color.White
        Me.lblFun.Location = New System.Drawing.Point(81, 9)
        Me.lblFun.Name = "lblFun"
        Me.lblFun.Size = New System.Drawing.Size(116, 23)
        Me.lblFun.TabIndex = 10
        Me.lblFun.Text = "Fun Section:"
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Permanent Marker", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(277, 6)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(265, 68)
        Me.lblWelcome.TabIndex = 7
        Me.lblWelcome.Text = "lblWelcome"
        '
        'PBMorning
        '
        Me.PBMorning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBMorning.Image = Global.LoginRegistration.My.Resources.Resources.Morning
        Me.PBMorning.InitialImage = Nothing
        Me.PBMorning.Location = New System.Drawing.Point(277, 96)
        Me.PBMorning.Name = "PBMorning"
        Me.PBMorning.Size = New System.Drawing.Size(265, 206)
        Me.PBMorning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBMorning.TabIndex = 8
        Me.PBMorning.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Black
        Me.lblMessage.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Crimson
        Me.lblMessage.Location = New System.Drawing.Point(38, 40)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(209, 262)
        Me.lblMessage.TabIndex = 9
        Me.lblMessage.Text = "lblMessage"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Black
        Me.btnLogOut.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Yellow
        Me.btnLogOut.Location = New System.Drawing.Point(389, 210)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(144, 28)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'PanelSearch
        '
        Me.PanelSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelSearch.Controls.Add(Me.lblCustomerName)
        Me.PanelSearch.Controls.Add(Me.lblCustomerID)
        Me.PanelSearch.Controls.Add(Me.txtCustomerName)
        Me.PanelSearch.Controls.Add(Me.txtCustomerID)
        Me.PanelSearch.Controls.Add(Me.btnSearch)
        Me.PanelSearch.Controls.Add(Me.btnLogOut)
        Me.PanelSearch.Controls.Add(Me.PBHype)
        Me.PanelSearch.Location = New System.Drawing.Point(248, 324)
        Me.PanelSearch.Name = "PanelSearch"
        Me.PanelSearch.Size = New System.Drawing.Size(545, 254)
        Me.PanelSearch.TabIndex = 3
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Font = New System.Drawing.Font("Permanent Marker", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.Yellow
        Me.lblCustomerName.Location = New System.Drawing.Point(253, 101)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(175, 27)
        Me.lblCustomerName.TabIndex = 14
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Permanent Marker", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.ForeColor = System.Drawing.Color.Yellow
        Me.lblCustomerID.Location = New System.Drawing.Point(253, 35)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(145, 27)
        Me.lblCustomerID.TabIndex = 13
        Me.lblCustomerID.Text = "Customer ID:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(253, 131)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(280, 29)
        Me.txtCustomerName.TabIndex = 12
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(253, 68)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 29)
        Me.txtCustomerID.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Black
        Me.btnSearch.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Yellow
        Me.btnSearch.Location = New System.Drawing.Point(389, 176)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(144, 28)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'PBHype
        '
        Me.PBHype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBHype.Image = Global.LoginRegistration.My.Resources.Resources.Welcomeee
        Me.PBHype.InitialImage = Nothing
        Me.PBHype.Location = New System.Drawing.Point(3, 7)
        Me.PBHype.Name = "PBHype"
        Me.PBHype.Size = New System.Drawing.Size(244, 241)
        Me.PBHype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBHype.TabIndex = 9
        Me.PBHype.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Black
        Me.btnStop.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Yellow
        Me.btnStop.Location = New System.Drawing.Point(12, 160)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(144, 28)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop Music"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Black
        Me.btnPlay.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.Yellow
        Me.btnPlay.Location = New System.Drawing.Point(12, 126)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(144, 28)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play Music"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'PanelStarting
        '
        Me.PanelStarting.BackColor = System.Drawing.Color.Black
        Me.PanelStarting.Controls.Add(Me.lblSlogan)
        Me.PanelStarting.Controls.Add(Me.btnStop)
        Me.PanelStarting.Controls.Add(Me.lblDate)
        Me.PanelStarting.Controls.Add(Me.lblTimer)
        Me.PanelStarting.Controls.Add(Me.btnPlay)
        Me.PanelStarting.Location = New System.Drawing.Point(12, 12)
        Me.PanelStarting.Name = "PanelStarting"
        Me.PanelStarting.Size = New System.Drawing.Size(230, 203)
        Me.PanelStarting.TabIndex = 6
        '
        'lblSlogan
        '
        Me.lblSlogan.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlogan.ForeColor = System.Drawing.Color.White
        Me.lblSlogan.Location = New System.Drawing.Point(7, 59)
        Me.lblSlogan.Name = "lblSlogan"
        Me.lblSlogan.Size = New System.Drawing.Size(220, 54)
        Me.lblSlogan.TabIndex = 10
        Me.lblSlogan.Text = """May The Shibas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Be With You~!!! <3"""
        Me.lblSlogan.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Yellow
        Me.lblDate.Location = New System.Drawing.Point(3, 1)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(224, 23)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date"
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Yellow
        Me.lblTimer.Location = New System.Drawing.Point(3, 24)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(224, 23)
        Me.lblTimer.TabIndex = 2
        Me.lblTimer.Text = "Time"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(807, 581)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelStarting)
        Me.Controls.Add(Me.PanelSearch)
        Me.Controls.Add(Me.PanelWelcome)
        Me.Controls.Add(Me.PanelOption)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Cheerful Cafe System (MF)"
        Me.PanelOption.ResumeLayout(False)
        Me.PanelWelcome.ResumeLayout(False)
        Me.PanelWelcome.PerformLayout()
        CType(Me.PBMorning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSearch.ResumeLayout(False)
        Me.PanelSearch.PerformLayout()
        CType(Me.PBHype, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelStarting.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelOption As Panel
    Friend WithEvents btnStaffRegistration As Button
    Friend WithEvents btnCustomerRegistration As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents PanelWelcome As Panel
    Friend WithEvents PanelSearch As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents PanelStarting As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents PBMorning As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PBHype As PictureBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblSlogan As Label
    Friend WithEvents lblFun As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnHistory As Button
End Class
