<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryForm))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.PBGood = New System.Windows.Forms.PictureBox()
        Me.PBKeepCalm = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PBDog = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBGood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBKeepCalm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Permanent Marker", 50.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Cyan
        Me.lblTitle.Location = New System.Drawing.Point(46, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(300, 198)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Order " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "History"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(47, 218)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(1266, 447)
        Me.DGV.TabIndex = 1
        '
        'PBGood
        '
        Me.PBGood.Image = CType(resources.GetObject("PBGood.Image"), System.Drawing.Image)
        Me.PBGood.Location = New System.Drawing.Point(352, 13)
        Me.PBGood.Name = "PBGood"
        Me.PBGood.Size = New System.Drawing.Size(247, 199)
        Me.PBGood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBGood.TabIndex = 5
        Me.PBGood.TabStop = False
        '
        'PBKeepCalm
        '
        Me.PBKeepCalm.BackgroundImage = CType(resources.GetObject("PBKeepCalm.BackgroundImage"), System.Drawing.Image)
        Me.PBKeepCalm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBKeepCalm.Location = New System.Drawing.Point(605, 13)
        Me.PBKeepCalm.Name = "PBKeepCalm"
        Me.PBKeepCalm.Size = New System.Drawing.Size(272, 199)
        Me.PBKeepCalm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBKeepCalm.TabIndex = 6
        Me.PBKeepCalm.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Permanent Marker", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Yellow
        Me.btnBack.Location = New System.Drawing.Point(1228, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 41)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PBDog
        '
        Me.PBDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBDog.ErrorImage = CType(resources.GetObject("PBDog.ErrorImage"), System.Drawing.Image)
        Me.PBDog.Image = CType(resources.GetObject("PBDog.Image"), System.Drawing.Image)
        Me.PBDog.Location = New System.Drawing.Point(883, 13)
        Me.PBDog.Name = "PBDog"
        Me.PBDog.Size = New System.Drawing.Size(272, 199)
        Me.PBDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBDog.TabIndex = 8
        Me.PBDog.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Yellow
        Me.lblTime.Location = New System.Drawing.Point(1161, 132)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(50, 23)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Permanent Marker", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Yellow
        Me.lblDate.Location = New System.Drawing.Point(1161, 74)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(152, 58)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date"
        '
        'Timer1
        '
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1355, 691)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.PBDog)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PBKeepCalm)
        Me.Controls.Add(Me.PBGood)
        Me.Controls.Add(Me.DGV)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HistoryForm"
        Me.Text = "Cheerful Cafe System (HF)"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBGood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBKeepCalm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As DataGridView
    Friend WithEvents PBGood As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents PBKeepCalm As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PBDog As PictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
End Class
