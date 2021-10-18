<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPaymentSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPaymentSystem))
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.PBCake = New System.Windows.Forms.PictureBox()
        Me.PBForkSpoon = New System.Windows.Forms.PictureBox()
        Me.PBCoffee = New System.Windows.Forms.PictureBox()
        Me.PBDog = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PanelDessert = New System.Windows.Forms.Panel()
        Me.txtIceCake = New System.Windows.Forms.TextBox()
        Me.CBCoffee = New System.Windows.Forms.CheckBox()
        Me.txtForest = New System.Windows.Forms.TextBox()
        Me.txtChocolateCake = New System.Windows.Forms.TextBox()
        Me.txtCoffee = New System.Windows.Forms.TextBox()
        Me.CBIceCream = New System.Windows.Forms.CheckBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.CBChocolateCake = New System.Windows.Forms.CheckBox()
        Me.txtFruit = New System.Windows.Forms.TextBox()
        Me.CBStrawCake = New System.Windows.Forms.CheckBox()
        Me.txtDarkChocolate = New System.Windows.Forms.TextBox()
        Me.CBDarkChocolate = New System.Windows.Forms.CheckBox()
        Me.txtStrawCake = New System.Windows.Forms.TextBox()
        Me.CBFruit = New System.Windows.Forms.CheckBox()
        Me.CBRed = New System.Windows.Forms.CheckBox()
        Me.txtIceCream = New System.Windows.Forms.TextBox()
        Me.CBForest = New System.Windows.Forms.CheckBox()
        Me.CBIceCake = New System.Windows.Forms.CheckBox()
        Me.PanelTotal1 = New System.Windows.Forms.Panel()
        Me.txtServiceCharged = New System.Windows.Forms.TextBox()
        Me.lblServiceCharge = New System.Windows.Forms.Label()
        Me.lblCostofDesserts = New System.Windows.Forms.Label()
        Me.txtDesserts = New System.Windows.Forms.TextBox()
        Me.lblCostofDrinks = New System.Windows.Forms.Label()
        Me.txtBeverage = New System.Windows.Forms.TextBox()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtTaxCharged = New System.Windows.Forms.TextBox()
        Me.lblTaxCharged = New System.Windows.Forms.Label()
        Me.PanelTotal2 = New System.Windows.Forms.Panel()
        Me.Change = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.PanelReceipt = New System.Windows.Forms.Panel()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.TSBFunctions = New System.Windows.Forms.ToolStrip()
        Me.TSBBlank = New System.Windows.Forms.ToolStripButton()
        Me.TSBOpen = New System.Windows.Forms.ToolStripButton()
        Me.TSBSave = New System.Windows.Forms.ToolStripButton()
        Me.TSBPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSBCut = New System.Windows.Forms.ToolStripButton()
        Me.TSBCopy = New System.Windows.Forms.ToolStripButton()
        Me.TSBPaste = New System.Windows.Forms.ToolStripButton()
        Me.rtfReceipt = New System.Windows.Forms.RichTextBox()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.PanelBeverage = New System.Windows.Forms.Panel()
        Me.txtLemon = New System.Windows.Forms.TextBox()
        Me.CBChocolate = New System.Windows.Forms.CheckBox()
        Me.txtPepermint = New System.Windows.Forms.TextBox()
        Me.txtAmericano = New System.Windows.Forms.TextBox()
        Me.txtChocolate = New System.Windows.Forms.TextBox()
        Me.CBCappucino = New System.Windows.Forms.CheckBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.CBAmericano = New System.Windows.Forms.CheckBox()
        Me.txtRootbeer = New System.Windows.Forms.TextBox()
        Me.CBEspresso = New System.Windows.Forms.CheckBox()
        Me.txtLatte = New System.Windows.Forms.TextBox()
        Me.CBLatte = New System.Windows.Forms.CheckBox()
        Me.txtEspresso = New System.Windows.Forms.TextBox()
        Me.CBRootbeer = New System.Windows.Forms.CheckBox()
        Me.CBGreen = New System.Windows.Forms.CheckBox()
        Me.txtCappucino = New System.Windows.Forms.TextBox()
        Me.CBPepermint = New System.Windows.Forms.CheckBox()
        Me.CBLemon = New System.Windows.Forms.CheckBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PBCake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBForkSpoon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCoffee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBDog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDessert.SuspendLayout()
        Me.PanelTotal1.SuspendLayout()
        Me.PanelTotal2.SuspendLayout()
        Me.PanelReceipt.SuspendLayout()
        Me.TSBFunctions.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        Me.PanelBeverage.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.White
        Me.PanelTitle.Controls.Add(Me.lblDate)
        Me.PanelTitle.Controls.Add(Me.lblTime)
        Me.PanelTitle.Controls.Add(Me.PBCake)
        Me.PanelTitle.Controls.Add(Me.PBForkSpoon)
        Me.PanelTitle.Controls.Add(Me.PBCoffee)
        Me.PanelTitle.Controls.Add(Me.PBDog)
        Me.PanelTitle.Controls.Add(Me.lblTitle)
        Me.PanelTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.PanelTitle.Location = New System.Drawing.Point(12, 12)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1328, 100)
        Me.PanelTitle.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Permanent Marker", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(405, 84)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 15)
        Me.lblDate.TabIndex = 38
        Me.lblDate.Text = "Label1"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Permanent Marker", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(1159, 79)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(42, 15)
        Me.lblTime.TabIndex = 37
        Me.lblTime.Text = "Label1"
        '
        'PBCake
        '
        Me.PBCake.BackgroundImage = Global.LoginRegistration.My.Resources.Resources.Cake
        Me.PBCake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCake.Location = New System.Drawing.Point(246, 5)
        Me.PBCake.Name = "PBCake"
        Me.PBCake.Size = New System.Drawing.Size(147, 92)
        Me.PBCake.TabIndex = 36
        Me.PBCake.TabStop = False
        '
        'PBForkSpoon
        '
        Me.PBForkSpoon.BackgroundImage = Global.LoginRegistration.My.Resources.Resources.Fork_and_Spoon2
        Me.PBForkSpoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBForkSpoon.Location = New System.Drawing.Point(124, 5)
        Me.PBForkSpoon.Name = "PBForkSpoon"
        Me.PBForkSpoon.Size = New System.Drawing.Size(116, 92)
        Me.PBForkSpoon.TabIndex = 35
        Me.PBForkSpoon.TabStop = False
        '
        'PBCoffee
        '
        Me.PBCoffee.BackgroundImage = Global.LoginRegistration.My.Resources.Resources.Coffee
        Me.PBCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBCoffee.Location = New System.Drawing.Point(3, 5)
        Me.PBCoffee.Name = "PBCoffee"
        Me.PBCoffee.Size = New System.Drawing.Size(115, 92)
        Me.PBCoffee.TabIndex = 18
        Me.PBCoffee.TabStop = False
        '
        'PBDog
        '
        Me.PBDog.BackgroundImage = Global.LoginRegistration.My.Resources.Resources.Dogo
        Me.PBDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBDog.Location = New System.Drawing.Point(1204, 5)
        Me.PBDog.Name = "PBDog"
        Me.PBDog.Size = New System.Drawing.Size(121, 92)
        Me.PBDog.TabIndex = 34
        Me.PBDog.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Permanent Marker", 50.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(387, -3)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(820, 95)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "CHEERFUL CAFE MENU"
        '
        'PanelDessert
        '
        Me.PanelDessert.BackColor = System.Drawing.Color.Black
        Me.PanelDessert.Controls.Add(Me.txtIceCake)
        Me.PanelDessert.Controls.Add(Me.CBCoffee)
        Me.PanelDessert.Controls.Add(Me.txtForest)
        Me.PanelDessert.Controls.Add(Me.txtChocolateCake)
        Me.PanelDessert.Controls.Add(Me.txtCoffee)
        Me.PanelDessert.Controls.Add(Me.CBIceCream)
        Me.PanelDessert.Controls.Add(Me.txtRed)
        Me.PanelDessert.Controls.Add(Me.CBChocolateCake)
        Me.PanelDessert.Controls.Add(Me.txtFruit)
        Me.PanelDessert.Controls.Add(Me.CBStrawCake)
        Me.PanelDessert.Controls.Add(Me.txtDarkChocolate)
        Me.PanelDessert.Controls.Add(Me.CBDarkChocolate)
        Me.PanelDessert.Controls.Add(Me.txtStrawCake)
        Me.PanelDessert.Controls.Add(Me.CBFruit)
        Me.PanelDessert.Controls.Add(Me.CBRed)
        Me.PanelDessert.Controls.Add(Me.txtIceCream)
        Me.PanelDessert.Controls.Add(Me.CBForest)
        Me.PanelDessert.Controls.Add(Me.CBIceCake)
        Me.PanelDessert.ForeColor = System.Drawing.SystemColors.Control
        Me.PanelDessert.Location = New System.Drawing.Point(488, 129)
        Me.PanelDessert.Name = "PanelDessert"
        Me.PanelDessert.Size = New System.Drawing.Size(486, 362)
        Me.PanelDessert.TabIndex = 2
        '
        'txtIceCake
        '
        Me.txtIceCake.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIceCake.Location = New System.Drawing.Point(397, 321)
        Me.txtIceCake.Name = "txtIceCake"
        Me.txtIceCake.Size = New System.Drawing.Size(57, 29)
        Me.txtIceCake.TabIndex = 54
        Me.txtIceCake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBCoffee
        '
        Me.CBCoffee.AutoSize = True
        Me.CBCoffee.BackColor = System.Drawing.Color.Black
        Me.CBCoffee.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCoffee.ForeColor = System.Drawing.Color.Yellow
        Me.CBCoffee.Location = New System.Drawing.Point(33, 241)
        Me.CBCoffee.Name = "CBCoffee"
        Me.CBCoffee.Size = New System.Drawing.Size(262, 31)
        Me.CBCoffee.TabIndex = 49
        Me.CBCoffee.Text = "Shiba Inu Coffee Cake"
        Me.CBCoffee.UseVisualStyleBackColor = False
        '
        'txtForest
        '
        Me.txtForest.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForest.Location = New System.Drawing.Point(397, 284)
        Me.txtForest.Name = "txtForest"
        Me.txtForest.Size = New System.Drawing.Size(57, 29)
        Me.txtForest.TabIndex = 52
        Me.txtForest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChocolateCake
        '
        Me.txtChocolateCake.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChocolateCake.Location = New System.Drawing.Point(397, 52)
        Me.txtChocolateCake.Name = "txtChocolateCake"
        Me.txtChocolateCake.Size = New System.Drawing.Size(57, 29)
        Me.txtChocolateCake.TabIndex = 40
        Me.txtChocolateCake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCoffee
        '
        Me.txtCoffee.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoffee.Location = New System.Drawing.Point(397, 243)
        Me.txtCoffee.Name = "txtCoffee"
        Me.txtCoffee.Size = New System.Drawing.Size(57, 29)
        Me.txtCoffee.TabIndex = 50
        Me.txtCoffee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBIceCream
        '
        Me.CBIceCream.AutoSize = True
        Me.CBIceCream.BackColor = System.Drawing.Color.Black
        Me.CBIceCream.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBIceCream.ForeColor = System.Drawing.Color.Yellow
        Me.CBIceCream.Location = New System.Drawing.Point(33, 13)
        Me.CBIceCream.Name = "CBIceCream"
        Me.CBIceCream.Size = New System.Drawing.Size(241, 31)
        Me.CBIceCream.TabIndex = 37
        Me.CBIceCream.Text = "Shiba Inu Ice Cream"
        Me.CBIceCream.UseVisualStyleBackColor = False
        '
        'txtRed
        '
        Me.txtRed.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRed.Location = New System.Drawing.Point(397, 206)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(57, 29)
        Me.txtRed.TabIndex = 48
        Me.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBChocolateCake
        '
        Me.CBChocolateCake.AutoSize = True
        Me.CBChocolateCake.BackColor = System.Drawing.Color.Black
        Me.CBChocolateCake.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBChocolateCake.ForeColor = System.Drawing.Color.Yellow
        Me.CBChocolateCake.Location = New System.Drawing.Point(33, 50)
        Me.CBChocolateCake.Name = "CBChocolateCake"
        Me.CBChocolateCake.Size = New System.Drawing.Size(300, 31)
        Me.CBChocolateCake.TabIndex = 39
        Me.CBChocolateCake.Text = "Shiba Inu Chocolate Cake"
        Me.CBChocolateCake.UseVisualStyleBackColor = False
        '
        'txtFruit
        '
        Me.txtFruit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFruit.Location = New System.Drawing.Point(397, 169)
        Me.txtFruit.Name = "txtFruit"
        Me.txtFruit.Size = New System.Drawing.Size(57, 29)
        Me.txtFruit.TabIndex = 46
        Me.txtFruit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBStrawCake
        '
        Me.CBStrawCake.AutoSize = True
        Me.CBStrawCake.BackColor = System.Drawing.Color.Black
        Me.CBStrawCake.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBStrawCake.ForeColor = System.Drawing.Color.Yellow
        Me.CBStrawCake.Location = New System.Drawing.Point(35, 90)
        Me.CBStrawCake.Name = "CBStrawCake"
        Me.CBStrawCake.Size = New System.Drawing.Size(310, 31)
        Me.CBStrawCake.TabIndex = 41
        Me.CBStrawCake.Text = "Shiba Inu Strawberry Cake"
        Me.CBStrawCake.UseVisualStyleBackColor = False
        '
        'txtDarkChocolate
        '
        Me.txtDarkChocolate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDarkChocolate.Location = New System.Drawing.Point(397, 132)
        Me.txtDarkChocolate.Name = "txtDarkChocolate"
        Me.txtDarkChocolate.Size = New System.Drawing.Size(57, 29)
        Me.txtDarkChocolate.TabIndex = 44
        Me.txtDarkChocolate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBDarkChocolate
        '
        Me.CBDarkChocolate.AutoSize = True
        Me.CBDarkChocolate.BackColor = System.Drawing.Color.Black
        Me.CBDarkChocolate.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBDarkChocolate.ForeColor = System.Drawing.Color.Yellow
        Me.CBDarkChocolate.Location = New System.Drawing.Point(35, 130)
        Me.CBDarkChocolate.Name = "CBDarkChocolate"
        Me.CBDarkChocolate.Size = New System.Drawing.Size(356, 31)
        Me.CBDarkChocolate.TabIndex = 43
        Me.CBDarkChocolate.Text = "Shiba Inu Dark Chocolate Cake"
        Me.CBDarkChocolate.UseVisualStyleBackColor = False
        '
        'txtStrawCake
        '
        Me.txtStrawCake.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStrawCake.Location = New System.Drawing.Point(397, 92)
        Me.txtStrawCake.Name = "txtStrawCake"
        Me.txtStrawCake.Size = New System.Drawing.Size(57, 29)
        Me.txtStrawCake.TabIndex = 42
        Me.txtStrawCake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBFruit
        '
        Me.CBFruit.AutoSize = True
        Me.CBFruit.BackColor = System.Drawing.Color.Black
        Me.CBFruit.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBFruit.ForeColor = System.Drawing.Color.Yellow
        Me.CBFruit.Location = New System.Drawing.Point(33, 167)
        Me.CBFruit.Name = "CBFruit"
        Me.CBFruit.Size = New System.Drawing.Size(254, 31)
        Me.CBFruit.TabIndex = 45
        Me.CBFruit.Text = "Shiba Inu Fruit Cake "
        Me.CBFruit.UseVisualStyleBackColor = False
        '
        'CBRed
        '
        Me.CBRed.AutoSize = True
        Me.CBRed.BackColor = System.Drawing.Color.Black
        Me.CBRed.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRed.ForeColor = System.Drawing.Color.Yellow
        Me.CBRed.Location = New System.Drawing.Point(33, 204)
        Me.CBRed.Name = "CBRed"
        Me.CBRed.Size = New System.Drawing.Size(301, 31)
        Me.CBRed.TabIndex = 47
        Me.CBRed.Text = "Shiba Inu Red Velvet Cake"
        Me.CBRed.UseVisualStyleBackColor = False
        '
        'txtIceCream
        '
        Me.txtIceCream.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIceCream.Location = New System.Drawing.Point(397, 15)
        Me.txtIceCream.Name = "txtIceCream"
        Me.txtIceCream.Size = New System.Drawing.Size(57, 29)
        Me.txtIceCream.TabIndex = 38
        Me.txtIceCream.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBForest
        '
        Me.CBForest.AutoSize = True
        Me.CBForest.BackColor = System.Drawing.Color.Black
        Me.CBForest.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBForest.ForeColor = System.Drawing.Color.Yellow
        Me.CBForest.Location = New System.Drawing.Point(35, 282)
        Me.CBForest.Name = "CBForest"
        Me.CBForest.Size = New System.Drawing.Size(330, 31)
        Me.CBForest.TabIndex = 51
        Me.CBForest.Text = "Shiba Inu Black Forest Cake"
        Me.CBForest.UseVisualStyleBackColor = False
        '
        'CBIceCake
        '
        Me.CBIceCake.AutoSize = True
        Me.CBIceCake.BackColor = System.Drawing.Color.Black
        Me.CBIceCake.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBIceCake.ForeColor = System.Drawing.Color.Yellow
        Me.CBIceCake.Location = New System.Drawing.Point(35, 319)
        Me.CBIceCake.Name = "CBIceCake"
        Me.CBIceCake.Size = New System.Drawing.Size(298, 31)
        Me.CBIceCake.TabIndex = 53
        Me.CBIceCake.Text = "Shiba Inu Ice Cream Cake"
        Me.CBIceCake.UseVisualStyleBackColor = False
        '
        'PanelTotal1
        '
        Me.PanelTotal1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelTotal1.Controls.Add(Me.txtServiceCharged)
        Me.PanelTotal1.Controls.Add(Me.lblServiceCharge)
        Me.PanelTotal1.Controls.Add(Me.lblCostofDesserts)
        Me.PanelTotal1.Controls.Add(Me.txtDesserts)
        Me.PanelTotal1.Controls.Add(Me.lblCostofDrinks)
        Me.PanelTotal1.Controls.Add(Me.txtBeverage)
        Me.PanelTotal1.Controls.Add(Me.txtSubtotal)
        Me.PanelTotal1.Controls.Add(Me.lblSubtotal)
        Me.PanelTotal1.ForeColor = System.Drawing.SystemColors.Control
        Me.PanelTotal1.Location = New System.Drawing.Point(12, 497)
        Me.PanelTotal1.Name = "PanelTotal1"
        Me.PanelTotal1.Size = New System.Drawing.Size(497, 182)
        Me.PanelTotal1.TabIndex = 3
        '
        'txtServiceCharged
        '
        Me.txtServiceCharged.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceCharged.Location = New System.Drawing.Point(259, 98)
        Me.txtServiceCharged.Name = "txtServiceCharged"
        Me.txtServiceCharged.Size = New System.Drawing.Size(211, 32)
        Me.txtServiceCharged.TabIndex = 39
        Me.txtServiceCharged.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblServiceCharge
        '
        Me.lblServiceCharge.AutoSize = True
        Me.lblServiceCharge.Font = New System.Drawing.Font("Permanent Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCharge.ForeColor = System.Drawing.Color.Yellow
        Me.lblServiceCharge.Location = New System.Drawing.Point(59, 100)
        Me.lblServiceCharge.Name = "lblServiceCharge"
        Me.lblServiceCharge.Size = New System.Drawing.Size(167, 30)
        Me.lblServiceCharge.TabIndex = 5
        Me.lblServiceCharge.Text = "Service Charge"
        '
        'lblCostofDesserts
        '
        Me.lblCostofDesserts.AutoSize = True
        Me.lblCostofDesserts.Font = New System.Drawing.Font("Permanent Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostofDesserts.ForeColor = System.Drawing.Color.Yellow
        Me.lblCostofDesserts.Location = New System.Drawing.Point(43, 51)
        Me.lblCostofDesserts.Name = "lblCostofDesserts"
        Me.lblCostofDesserts.Size = New System.Drawing.Size(183, 30)
        Me.lblCostofDesserts.TabIndex = 3
        Me.lblCostofDesserts.Text = "Cost of Desserts"
        '
        'txtDesserts
        '
        Me.txtDesserts.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesserts.Location = New System.Drawing.Point(259, 51)
        Me.txtDesserts.Name = "txtDesserts"
        Me.txtDesserts.Size = New System.Drawing.Size(211, 32)
        Me.txtDesserts.TabIndex = 38
        Me.txtDesserts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCostofDrinks
        '
        Me.lblCostofDrinks.AutoSize = True
        Me.lblCostofDrinks.Font = New System.Drawing.Font("Permanent Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostofDrinks.ForeColor = System.Drawing.Color.Yellow
        Me.lblCostofDrinks.Location = New System.Drawing.Point(34, 3)
        Me.lblCostofDrinks.Name = "lblCostofDrinks"
        Me.lblCostofDrinks.Size = New System.Drawing.Size(192, 30)
        Me.lblCostofDrinks.TabIndex = 1
        Me.lblCostofDrinks.Text = "Cost of Beverage"
        '
        'txtBeverage
        '
        Me.txtBeverage.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeverage.Location = New System.Drawing.Point(259, 3)
        Me.txtBeverage.Name = "txtBeverage"
        Me.txtBeverage.Size = New System.Drawing.Size(211, 32)
        Me.txtBeverage.TabIndex = 37
        Me.txtBeverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(259, 145)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(211, 32)
        Me.txtSubtotal.TabIndex = 41
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Permanent Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.Color.Yellow
        Me.lblSubtotal.Location = New System.Drawing.Point(118, 145)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(108, 30)
        Me.lblSubtotal.TabIndex = 9
        Me.lblSubtotal.Text = "SubTotal"
        '
        'txtTaxCharged
        '
        Me.txtTaxCharged.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaxCharged.Location = New System.Drawing.Point(197, 4)
        Me.txtTaxCharged.Name = "txtTaxCharged"
        Me.txtTaxCharged.Size = New System.Drawing.Size(211, 32)
        Me.txtTaxCharged.TabIndex = 40
        Me.txtTaxCharged.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTaxCharged
        '
        Me.lblTaxCharged.AutoSize = True
        Me.lblTaxCharged.Font = New System.Drawing.Font("Permanent Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxCharged.ForeColor = System.Drawing.Color.Yellow
        Me.lblTaxCharged.Location = New System.Drawing.Point(38, 6)
        Me.lblTaxCharged.Name = "lblTaxCharged"
        Me.lblTaxCharged.Size = New System.Drawing.Size(140, 30)
        Me.lblTaxCharged.TabIndex = 7
        Me.lblTaxCharged.Text = "Tax Charged"
        '
        'PanelTotal2
        '
        Me.PanelTotal2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelTotal2.Controls.Add(Me.Change)
        Me.PanelTotal2.Controls.Add(Me.lblAmountPaid)
        Me.PanelTotal2.Controls.Add(Me.txtTaxCharged)
        Me.PanelTotal2.Controls.Add(Me.lblTaxCharged)
        Me.PanelTotal2.Controls.Add(Me.txtChange)
        Me.PanelTotal2.Controls.Add(Me.lblTotal)
        Me.PanelTotal2.Controls.Add(Me.txtAmountPaid)
        Me.PanelTotal2.Controls.Add(Me.txtTotal)
        Me.PanelTotal2.ForeColor = System.Drawing.SystemColors.Control
        Me.PanelTotal2.Location = New System.Drawing.Point(515, 497)
        Me.PanelTotal2.Name = "PanelTotal2"
        Me.PanelTotal2.Size = New System.Drawing.Size(459, 182)
        Me.PanelTotal2.TabIndex = 4
        '
        'Change
        '
        Me.Change.AutoSize = True
        Me.Change.Font = New System.Drawing.Font("Permanent Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.ForeColor = System.Drawing.Color.Yellow
        Me.Change.Location = New System.Drawing.Point(91, 144)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(87, 30)
        Me.Change.TabIndex = 14
        Me.Change.Text = "Change"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.Font = New System.Drawing.Font("Permanent Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.ForeColor = System.Drawing.Color.Yellow
        Me.lblAmountPaid.Location = New System.Drawing.Point(36, 98)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(142, 30)
        Me.lblAmountPaid.TabIndex = 13
        Me.lblAmountPaid.Text = "Amount Paid"
        '
        'txtChange
        '
        Me.txtChange.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(197, 144)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(211, 32)
        Me.txtChange.TabIndex = 44
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Permanent Marker", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Yellow
        Me.lblTotal.Location = New System.Drawing.Point(106, 50)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(72, 30)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "Total"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(197, 98)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(211, 32)
        Me.txtAmountPaid.TabIndex = 43
        Me.txtAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(197, 50)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(211, 32)
        Me.txtTotal.TabIndex = 42
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelReceipt
        '
        Me.PanelReceipt.BackColor = System.Drawing.SystemColors.Control
        Me.PanelReceipt.Controls.Add(Me.lblCustomerID)
        Me.PanelReceipt.Controls.Add(Me.txtCustomerID)
        Me.PanelReceipt.Controls.Add(Me.TSBFunctions)
        Me.PanelReceipt.Controls.Add(Me.rtfReceipt)
        Me.PanelReceipt.ForeColor = System.Drawing.SystemColors.Control
        Me.PanelReceipt.Location = New System.Drawing.Point(984, 129)
        Me.PanelReceipt.Name = "PanelReceipt"
        Me.PanelReceipt.Size = New System.Drawing.Size(360, 490)
        Me.PanelReceipt.TabIndex = 6
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCustomerID.Location = New System.Drawing.Point(13, 29)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(126, 27)
        Me.lblCustomerID.TabIndex = 10
        Me.lblCustomerID.Text = "CustomerID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(145, 27)
        Me.txtCustomerID.Multiline = True
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(196, 29)
        Me.txtCustomerID.TabIndex = 9
        '
        'TSBFunctions
        '
        Me.TSBFunctions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBBlank, Me.TSBOpen, Me.TSBSave, Me.TSBPrint, Me.ToolStripSeparator1, Me.TSBCut, Me.TSBCopy, Me.TSBPaste})
        Me.TSBFunctions.Location = New System.Drawing.Point(0, 0)
        Me.TSBFunctions.Name = "TSBFunctions"
        Me.TSBFunctions.Size = New System.Drawing.Size(360, 25)
        Me.TSBFunctions.TabIndex = 8
        Me.TSBFunctions.Text = "ToolStrip1"
        '
        'TSBBlank
        '
        Me.TSBBlank.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBBlank.Image = Global.LoginRegistration.My.Resources.Resources.blank
        Me.TSBBlank.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBBlank.Name = "TSBBlank"
        Me.TSBBlank.Size = New System.Drawing.Size(23, 22)
        '
        'TSBOpen
        '
        Me.TSBOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBOpen.Image = CType(resources.GetObject("TSBOpen.Image"), System.Drawing.Image)
        Me.TSBOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBOpen.Name = "TSBOpen"
        Me.TSBOpen.Size = New System.Drawing.Size(23, 22)
        '
        'TSBSave
        '
        Me.TSBSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBSave.Image = Global.LoginRegistration.My.Resources.Resources.Save
        Me.TSBSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBSave.Name = "TSBSave"
        Me.TSBSave.Size = New System.Drawing.Size(23, 22)
        '
        'TSBPrint
        '
        Me.TSBPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBPrint.Image = Global.LoginRegistration.My.Resources.Resources.Print
        Me.TSBPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBPrint.Name = "TSBPrint"
        Me.TSBPrint.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TSBCut
        '
        Me.TSBCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBCut.Image = Global.LoginRegistration.My.Resources.Resources.cut
        Me.TSBCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBCut.Name = "TSBCut"
        Me.TSBCut.Size = New System.Drawing.Size(23, 22)
        '
        'TSBCopy
        '
        Me.TSBCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBCopy.Image = Global.LoginRegistration.My.Resources.Resources.Copy
        Me.TSBCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBCopy.Name = "TSBCopy"
        Me.TSBCopy.Size = New System.Drawing.Size(23, 22)
        '
        'TSBPaste
        '
        Me.TSBPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBPaste.Image = Global.LoginRegistration.My.Resources.Resources.Paste
        Me.TSBPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBPaste.Name = "TSBPaste"
        Me.TSBPaste.Size = New System.Drawing.Size(23, 22)
        '
        'rtfReceipt
        '
        Me.rtfReceipt.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfReceipt.Location = New System.Drawing.Point(14, 63)
        Me.rtfReceipt.Name = "rtfReceipt"
        Me.rtfReceipt.Size = New System.Drawing.Size(327, 413)
        Me.rtfReceipt.TabIndex = 0
        Me.rtfReceipt.Text = ""
        '
        'PanelButtons
        '
        Me.PanelButtons.BackColor = System.Drawing.Color.Black
        Me.PanelButtons.Controls.Add(Me.btnCash)
        Me.PanelButtons.Controls.Add(Me.btnExit)
        Me.PanelButtons.Controls.Add(Me.btnReset)
        Me.PanelButtons.Controls.Add(Me.btnReceipt)
        Me.PanelButtons.Controls.Add(Me.btnConfirm)
        Me.PanelButtons.ForeColor = System.Drawing.SystemColors.Control
        Me.PanelButtons.Location = New System.Drawing.Point(980, 625)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(367, 54)
        Me.PanelButtons.TabIndex = 5
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.Black
        Me.btnCash.Font = New System.Drawing.Font("Permanent Marker", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.Yellow
        Me.btnCash.Location = New System.Drawing.Point(3, 9)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(63, 37)
        Me.btnCash.TabIndex = 49
        Me.btnCash.Text = "CASH"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Permanent Marker", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(313, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(51, 37)
        Me.btnExit.TabIndex = 48
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.Font = New System.Drawing.Font("Permanent Marker", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Yellow
        Me.btnReset.Location = New System.Drawing.Point(243, 11)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(64, 37)
        Me.btnReset.TabIndex = 47
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.Black
        Me.btnReceipt.Font = New System.Drawing.Font("Permanent Marker", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.Color.Yellow
        Me.btnReceipt.Location = New System.Drawing.Point(162, 11)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(75, 37)
        Me.btnReceipt.TabIndex = 46
        Me.btnReceipt.Text = "RECEIPT"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Black
        Me.btnConfirm.Font = New System.Drawing.Font("Permanent Marker", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.Yellow
        Me.btnConfirm.Location = New System.Drawing.Point(72, 11)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(84, 37)
        Me.btnConfirm.TabIndex = 45
        Me.btnConfirm.Text = "CONFIRM"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'PanelBeverage
        '
        Me.PanelBeverage.BackColor = System.Drawing.Color.Black
        Me.PanelBeverage.Controls.Add(Me.txtLemon)
        Me.PanelBeverage.Controls.Add(Me.CBChocolate)
        Me.PanelBeverage.Controls.Add(Me.txtPepermint)
        Me.PanelBeverage.Controls.Add(Me.txtAmericano)
        Me.PanelBeverage.Controls.Add(Me.txtChocolate)
        Me.PanelBeverage.Controls.Add(Me.CBCappucino)
        Me.PanelBeverage.Controls.Add(Me.txtGreen)
        Me.PanelBeverage.Controls.Add(Me.CBAmericano)
        Me.PanelBeverage.Controls.Add(Me.txtRootbeer)
        Me.PanelBeverage.Controls.Add(Me.CBEspresso)
        Me.PanelBeverage.Controls.Add(Me.txtLatte)
        Me.PanelBeverage.Controls.Add(Me.CBLatte)
        Me.PanelBeverage.Controls.Add(Me.txtEspresso)
        Me.PanelBeverage.Controls.Add(Me.CBRootbeer)
        Me.PanelBeverage.Controls.Add(Me.CBGreen)
        Me.PanelBeverage.Controls.Add(Me.txtCappucino)
        Me.PanelBeverage.Controls.Add(Me.CBPepermint)
        Me.PanelBeverage.Controls.Add(Me.CBLemon)
        Me.PanelBeverage.ForeColor = System.Drawing.SystemColors.Control
        Me.PanelBeverage.Location = New System.Drawing.Point(12, 129)
        Me.PanelBeverage.Name = "PanelBeverage"
        Me.PanelBeverage.Size = New System.Drawing.Size(470, 362)
        Me.PanelBeverage.TabIndex = 1
        '
        'txtLemon
        '
        Me.txtLemon.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLemon.Location = New System.Drawing.Point(382, 319)
        Me.txtLemon.Name = "txtLemon"
        Me.txtLemon.Size = New System.Drawing.Size(57, 29)
        Me.txtLemon.TabIndex = 36
        Me.txtLemon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBChocolate
        '
        Me.CBChocolate.AutoSize = True
        Me.CBChocolate.BackColor = System.Drawing.Color.Black
        Me.CBChocolate.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBChocolate.ForeColor = System.Drawing.Color.Yellow
        Me.CBChocolate.Location = New System.Drawing.Point(32, 241)
        Me.CBChocolate.Name = "CBChocolate"
        Me.CBChocolate.Size = New System.Drawing.Size(275, 31)
        Me.CBChocolate.TabIndex = 31
        Me.CBChocolate.Text = "Shiba Inu Hot Choclate"
        Me.CBChocolate.UseVisualStyleBackColor = False
        '
        'txtPepermint
        '
        Me.txtPepermint.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPepermint.Location = New System.Drawing.Point(382, 282)
        Me.txtPepermint.Name = "txtPepermint"
        Me.txtPepermint.Size = New System.Drawing.Size(57, 29)
        Me.txtPepermint.TabIndex = 34
        Me.txtPepermint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAmericano
        '
        Me.txtAmericano.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmericano.Location = New System.Drawing.Point(382, 50)
        Me.txtAmericano.Name = "txtAmericano"
        Me.txtAmericano.Size = New System.Drawing.Size(57, 29)
        Me.txtAmericano.TabIndex = 22
        Me.txtAmericano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtChocolate
        '
        Me.txtChocolate.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChocolate.Location = New System.Drawing.Point(382, 241)
        Me.txtChocolate.Name = "txtChocolate"
        Me.txtChocolate.Size = New System.Drawing.Size(57, 29)
        Me.txtChocolate.TabIndex = 32
        Me.txtChocolate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBCappucino
        '
        Me.CBCappucino.AutoSize = True
        Me.CBCappucino.BackColor = System.Drawing.Color.Black
        Me.CBCappucino.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCappucino.ForeColor = System.Drawing.Color.Yellow
        Me.CBCappucino.Location = New System.Drawing.Point(32, 13)
        Me.CBCappucino.Name = "CBCappucino"
        Me.CBCappucino.Size = New System.Drawing.Size(239, 31)
        Me.CBCappucino.TabIndex = 19
        Me.CBCappucino.Text = "Shiba Inu Cappucino"
        Me.CBCappucino.UseVisualStyleBackColor = False
        '
        'txtGreen
        '
        Me.txtGreen.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGreen.Location = New System.Drawing.Point(382, 204)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(57, 29)
        Me.txtGreen.TabIndex = 30
        Me.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBAmericano
        '
        Me.CBAmericano.AutoSize = True
        Me.CBAmericano.BackColor = System.Drawing.Color.Black
        Me.CBAmericano.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBAmericano.ForeColor = System.Drawing.Color.Yellow
        Me.CBAmericano.Location = New System.Drawing.Point(32, 50)
        Me.CBAmericano.Name = "CBAmericano"
        Me.CBAmericano.Size = New System.Drawing.Size(244, 31)
        Me.CBAmericano.TabIndex = 21
        Me.CBAmericano.Text = "Shiba Inu Americano"
        Me.CBAmericano.UseVisualStyleBackColor = False
        '
        'txtRootbeer
        '
        Me.txtRootbeer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRootbeer.Location = New System.Drawing.Point(382, 167)
        Me.txtRootbeer.Name = "txtRootbeer"
        Me.txtRootbeer.Size = New System.Drawing.Size(57, 29)
        Me.txtRootbeer.TabIndex = 28
        Me.txtRootbeer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBEspresso
        '
        Me.CBEspresso.AutoSize = True
        Me.CBEspresso.BackColor = System.Drawing.Color.Black
        Me.CBEspresso.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEspresso.ForeColor = System.Drawing.Color.Yellow
        Me.CBEspresso.Location = New System.Drawing.Point(34, 90)
        Me.CBEspresso.Name = "CBEspresso"
        Me.CBEspresso.Size = New System.Drawing.Size(226, 31)
        Me.CBEspresso.TabIndex = 23
        Me.CBEspresso.Text = "Shiba Inu Espresso"
        Me.CBEspresso.UseVisualStyleBackColor = False
        '
        'txtLatte
        '
        Me.txtLatte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatte.Location = New System.Drawing.Point(382, 130)
        Me.txtLatte.Name = "txtLatte"
        Me.txtLatte.Size = New System.Drawing.Size(57, 29)
        Me.txtLatte.TabIndex = 26
        Me.txtLatte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBLatte
        '
        Me.CBLatte.AutoSize = True
        Me.CBLatte.BackColor = System.Drawing.Color.Black
        Me.CBLatte.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLatte.ForeColor = System.Drawing.Color.Yellow
        Me.CBLatte.Location = New System.Drawing.Point(34, 130)
        Me.CBLatte.Name = "CBLatte"
        Me.CBLatte.Size = New System.Drawing.Size(193, 31)
        Me.CBLatte.TabIndex = 25
        Me.CBLatte.Text = "Shiba Inu Latte"
        Me.CBLatte.UseVisualStyleBackColor = False
        '
        'txtEspresso
        '
        Me.txtEspresso.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspresso.Location = New System.Drawing.Point(382, 90)
        Me.txtEspresso.Name = "txtEspresso"
        Me.txtEspresso.Size = New System.Drawing.Size(57, 29)
        Me.txtEspresso.TabIndex = 24
        Me.txtEspresso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBRootbeer
        '
        Me.CBRootbeer.AutoSize = True
        Me.CBRootbeer.BackColor = System.Drawing.Color.Black
        Me.CBRootbeer.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRootbeer.ForeColor = System.Drawing.Color.Yellow
        Me.CBRootbeer.Location = New System.Drawing.Point(32, 167)
        Me.CBRootbeer.Name = "CBRootbeer"
        Me.CBRootbeer.Size = New System.Drawing.Size(343, 31)
        Me.CBRootbeer.TabIndex = 27
        Me.CBRootbeer.Text = "Shiba Inu Ice Cream Rootbeer"
        Me.CBRootbeer.UseVisualStyleBackColor = False
        '
        'CBGreen
        '
        Me.CBGreen.AutoSize = True
        Me.CBGreen.BackColor = System.Drawing.Color.Black
        Me.CBGreen.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBGreen.ForeColor = System.Drawing.Color.Yellow
        Me.CBGreen.Location = New System.Drawing.Point(32, 204)
        Me.CBGreen.Name = "CBGreen"
        Me.CBGreen.Size = New System.Drawing.Size(262, 31)
        Me.CBGreen.TabIndex = 29
        Me.CBGreen.Text = "Shiba Inu Green Latte"
        Me.CBGreen.UseVisualStyleBackColor = False
        '
        'txtCappucino
        '
        Me.txtCappucino.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCappucino.Location = New System.Drawing.Point(382, 13)
        Me.txtCappucino.Name = "txtCappucino"
        Me.txtCappucino.Size = New System.Drawing.Size(57, 29)
        Me.txtCappucino.TabIndex = 20
        Me.txtCappucino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBPepermint
        '
        Me.CBPepermint.AutoSize = True
        Me.CBPepermint.BackColor = System.Drawing.Color.Black
        Me.CBPepermint.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPepermint.ForeColor = System.Drawing.Color.Yellow
        Me.CBPepermint.Location = New System.Drawing.Point(34, 282)
        Me.CBPepermint.Name = "CBPepermint"
        Me.CBPepermint.Size = New System.Drawing.Size(177, 31)
        Me.CBPepermint.TabIndex = 33
        Me.CBPepermint.Text = "Pepermint Tea"
        Me.CBPepermint.UseVisualStyleBackColor = False
        '
        'CBLemon
        '
        Me.CBLemon.AutoSize = True
        Me.CBLemon.BackColor = System.Drawing.Color.Black
        Me.CBLemon.Font = New System.Drawing.Font("Permanent Marker", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBLemon.ForeColor = System.Drawing.Color.Yellow
        Me.CBLemon.Location = New System.Drawing.Point(34, 319)
        Me.CBLemon.Name = "CBLemon"
        Me.CBLemon.Size = New System.Drawing.Size(181, 31)
        Me.CBLemon.TabIndex = 35
        Me.CBLemon.Text = "Ice Lemon Tea"
        Me.CBLemon.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.White
        Me.ImageList1.Images.SetKeyName(0, "cut.png")
        Me.ImageList1.Images.SetKeyName(1, "Paste.png")
        Me.ImageList1.Images.SetKeyName(2, "Open File.png")
        Me.ImageList1.Images.SetKeyName(3, "Copy.png")
        Me.ImageList1.Images.SetKeyName(4, "blank.png")
        Me.ImageList1.Images.SetKeyName(5, "save.png")
        Me.ImageList1.Images.SetKeyName(6, "Print.png")
        '
        'Timer1
        '
        '
        'printPreviewDialog1
        '
        Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.printPreviewDialog1.Enabled = True
        Me.printPreviewDialog1.Icon = CType(resources.GetObject("printPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.printPreviewDialog1.Name = "printPreviewDialog1"
        Me.printPreviewDialog1.Visible = False
        '
        'PrintDocument2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuPaymentSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1355, 691)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelButtons)
        Me.Controls.Add(Me.PanelTotal2)
        Me.Controls.Add(Me.PanelTotal1)
        Me.Controls.Add(Me.PanelReceipt)
        Me.Controls.Add(Me.PanelBeverage)
        Me.Controls.Add(Me.PanelDessert)
        Me.Controls.Add(Me.PanelTitle)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuPaymentSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheerful Cafe System (MPS)"
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.PBCake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBForkSpoon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCoffee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBDog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDessert.ResumeLayout(False)
        Me.PanelDessert.PerformLayout()
        Me.PanelTotal1.ResumeLayout(False)
        Me.PanelTotal1.PerformLayout()
        Me.PanelTotal2.ResumeLayout(False)
        Me.PanelTotal2.PerformLayout()
        Me.PanelReceipt.ResumeLayout(False)
        Me.PanelReceipt.PerformLayout()
        Me.TSBFunctions.ResumeLayout(False)
        Me.TSBFunctions.PerformLayout()
        Me.PanelButtons.ResumeLayout(False)
        Me.PanelBeverage.ResumeLayout(False)
        Me.PanelBeverage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitle As Panel
    Friend WithEvents PanelDessert As Panel
    Friend WithEvents PanelTotal1 As Panel
    Friend WithEvents PanelTotal2 As Panel
    Friend WithEvents PanelReceipt As Panel
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents PBDog As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents PBCoffee As PictureBox
    Friend WithEvents PBForkSpoon As PictureBox
    Friend WithEvents PBCake As PictureBox
    Friend WithEvents lblServiceCharge As Label
    Friend WithEvents txtTaxCharged As TextBox
    Friend WithEvents lblCostofDesserts As Label
    Friend WithEvents txtDesserts As TextBox
    Friend WithEvents lblCostofDrinks As Label
    Friend WithEvents txtBeverage As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents lblTaxCharged As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtServiceCharged As TextBox
    Friend WithEvents Change As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents txtChange As TextBox
    Friend WithEvents btnReceipt As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents PanelBeverage As Panel
    Friend WithEvents txtLemon As TextBox
    Friend WithEvents CBChocolate As CheckBox
    Friend WithEvents txtPepermint As TextBox
    Friend WithEvents txtAmericano As TextBox
    Friend WithEvents txtChocolate As TextBox
    Friend WithEvents CBCappucino As CheckBox
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents CBAmericano As CheckBox
    Friend WithEvents txtRootbeer As TextBox
    Friend WithEvents CBEspresso As CheckBox
    Friend WithEvents txtLatte As TextBox
    Friend WithEvents CBLatte As CheckBox
    Friend WithEvents txtEspresso As TextBox
    Friend WithEvents CBRootbeer As CheckBox
    Friend WithEvents CBGreen As CheckBox
    Friend WithEvents txtCappucino As TextBox
    Friend WithEvents CBPepermint As CheckBox
    Friend WithEvents CBLemon As CheckBox
    Friend WithEvents rtfReceipt As RichTextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TSBFunctions As ToolStrip
    Friend WithEvents TSBBlank As ToolStripButton
    Friend WithEvents TSBOpen As ToolStripButton
    Friend WithEvents TSBSave As ToolStripButton
    Friend WithEvents TSBPrint As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TSBCut As ToolStripButton
    Friend WithEvents TSBCopy As ToolStripButton
    Friend WithEvents TSBPaste As ToolStripButton
    Friend WithEvents printPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtIceCake As TextBox
    Friend WithEvents CBCoffee As CheckBox
    Friend WithEvents txtForest As TextBox
    Friend WithEvents txtChocolateCake As TextBox
    Friend WithEvents txtCoffee As TextBox
    Friend WithEvents CBIceCream As CheckBox
    Friend WithEvents txtRed As TextBox
    Friend WithEvents CBChocolateCake As CheckBox
    Friend WithEvents txtFruit As TextBox
    Friend WithEvents CBStrawCake As CheckBox
    Friend WithEvents txtDarkChocolate As TextBox
    Friend WithEvents CBDarkChocolate As CheckBox
    Friend WithEvents txtStrawCake As TextBox
    Friend WithEvents CBFruit As CheckBox
    Friend WithEvents CBRed As CheckBox
    Friend WithEvents txtIceCream As TextBox
    Friend WithEvents CBForest As CheckBox
    Friend WithEvents CBIceCake As CheckBox
    Friend WithEvents btnCash As Button
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
