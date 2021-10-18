Public Class MenuPaymentSystem

    'Exit Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MainForm.Show()
        Me.Close()
    End Sub

    'Form Codings
    Private Sub MenuOrderingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()

        txtCustomerID.Text = CustomerDisplayID.CustomerDisplay
        txtCustomerID.Enabled = False

        txtCappucino.Text = "0"
        txtAmericano.Text = "0"
        txtEspresso.Text = "0"
        txtLatte.Text = "0"
        txtRootbeer.Text = "0"
        txtGreen.Text = "0"
        txtChocolate.Text = "0"
        txtPepermint.Text = "0"
        txtLemon.Text = "0"
        txtIceCream.Text = "0"
        txtChocolateCake.Text = "0"
        txtStrawCake.Text = "0"
        txtDarkChocolate.Text = "0"
        txtFruit.Text = "0"
        txtRed.Text = "0"
        txtCoffee.Text = "0"
        txtForest.Text = "0"
        txtIceCake.Text = "0"
        txtBeverage.Text = "0"
        txtDesserts.Text = "0"
        txtServiceCharged.Text = "RM3"
        txtTaxCharged.Text = "0"
        txtTotal.Text = "0"
        txtSubtotal.Text = "0"
        txtChange.Text = "0"
        txtAmountPaid.Text = "0"

        txtCappucino.Enabled = False
        txtAmericano.Enabled = False
        txtEspresso.Enabled = False
        txtLatte.Enabled = False
        txtRootbeer.Enabled = False
        txtGreen.Enabled = False
        txtChocolate.Enabled = False
        txtPepermint.Enabled = False
        txtLemon.Enabled = False
        txtIceCream.Enabled = False
        txtChocolateCake.Enabled = False
        txtStrawCake.Enabled = False
        txtDarkChocolate.Enabled = False
        txtFruit.Enabled = False
        txtRed.Enabled = False
        txtCoffee.Enabled = False
        txtForest.Enabled = False
        txtIceCake.Enabled = False
        txtBeverage.Enabled = False
        txtDesserts.Enabled = False
        txtServiceCharged.Enabled = False
        txtSubtotal.Enabled = False
        txtTaxCharged.Enabled = False
        txtTotal.Enabled = False
        txtChange.Enabled = False
        txtAmountPaid.Enabled = False

        rtfReceipt.Clear()

        CBCappucino.Checked = False
        CBAmericano.Checked = False
        CBEspresso.Checked = False
        CBLatte.Checked = False
        CBRootbeer.Checked = False
        CBGreen.Checked = False
        CBChocolate.Checked = False
        CBPepermint.Checked = False
        CBLemon.Checked = False
        CBIceCream.Checked = False
        CBChocolateCake.Checked = False
        CBStrawCake.Checked = False
        CBDarkChocolate.Checked = False
        CBFruit.Checked = False
        CBRed.Checked = False
        CBCoffee.Checked = False
        CBForest.Checked = False
        CBIceCake.Checked = False

        btnCash.Enabled = False
    End Sub

    'Timer1 Code
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub

    'Reset Function
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtCappucino.Text = "0"
        txtAmericano.Text = "0"
        txtEspresso.Text = "0"
        txtLatte.Text = "0"
        txtRootbeer.Text = "0"
        txtGreen.Text = "0"
        txtChocolate.Text = "0"
        txtPepermint.Text = "0"
        txtLemon.Text = "0"
        txtIceCream.Text = "0"
        txtChocolateCake.Text = "0"
        txtStrawCake.Text = "0"
        txtDarkChocolate.Text = "0"
        txtFruit.Text = "0"
        txtRed.Text = "0"
        txtCoffee.Text = "0"
        txtForest.Text = "0"
        txtIceCake.Text = "0"
        txtBeverage.Text = "0"
        txtDesserts.Text = "0"
        txtServiceCharged.Text = "RM3"
        txtTaxCharged.Text = "0"
        txtTotal.Text = "0"
        txtSubtotal.Text = "0"
        txtChange.Text = "0"
        txtAmountPaid.Text = "0"

        txtCappucino.Enabled = False
        txtAmericano.Enabled = False
        txtEspresso.Enabled = False
        txtLatte.Enabled = False
        txtRootbeer.Enabled = False
        txtGreen.Enabled = False
        txtChocolate.Enabled = False
        txtPepermint.Enabled = False
        txtLemon.Enabled = False
        txtIceCream.Enabled = False
        txtChocolateCake.Enabled = False
        txtStrawCake.Enabled = False
        txtDarkChocolate.Enabled = False
        txtFruit.Enabled = False
        txtRed.Enabled = False
        txtCoffee.Enabled = False
        txtForest.Enabled = False
        txtIceCake.Enabled = False
        txtBeverage.Enabled = False
        txtDesserts.Enabled = False
        txtServiceCharged.Enabled = False
        txtSubtotal.Enabled = False
        txtTaxCharged.Enabled = False
        txtTotal.Enabled = False
        txtChange.Enabled = False
        txtAmountPaid.Enabled = False

        rtfReceipt.Clear()

        CBCappucino.Checked = False
        CBAmericano.Checked = False
        CBEspresso.Checked = False
        CBLatte.Checked = False
        CBRootbeer.Checked = False
        CBGreen.Checked = False
        CBChocolate.Checked = False
        CBPepermint.Checked = False
        CBLemon.Checked = False
        CBIceCream.Checked = False
        CBChocolateCake.Checked = False
        CBStrawCake.Checked = False
        CBDarkChocolate.Checked = False
        CBFruit.Checked = False
        CBRed.Checked = False
        CBCoffee.Checked = False
        CBForest.Checked = False
        CBIceCake.Checked = False

        CBCappucino.Enabled = True
        CBAmericano.Enabled = True
        CBEspresso.Enabled = True
        CBLatte.Enabled = True
        CBRootbeer.Enabled = True
        CBGreen.Enabled = True
        CBChocolate.Enabled = True
        CBPepermint.Enabled = True
        CBLemon.Enabled = True
        CBIceCream.Enabled = True
        CBChocolateCake.Enabled = True
        CBStrawCake.Enabled = True
        CBDarkChocolate.Enabled = True
        CBFruit.Enabled = True
        CBRed.Enabled = True
        CBCoffee.Enabled = True
        CBForest.Enabled = True
        CBIceCake.Enabled = True

        btnCash.Enabled = False
        btnConfirm.Enabled = True
    End Sub

    'CBCappucino
    Private Sub CBCappucino_CheckedChanged(sender As Object, e As EventArgs) Handles CBCappucino.CheckedChanged
        If (CBCappucino.Checked = True) Then
            txtCappucino.Enabled = True
        End If

        If (CBCappucino.Checked = False) Then
            txtCappucino.Enabled = False
        End If
    End Sub

    'txtCappucino
    Private Sub txtCappucino_Click(sender As Object, e As EventArgs) Handles txtCappucino.Click
        txtCappucino.Text = ""
        txtCappucino.Focus()
    End Sub

    'CBAmericano
    Private Sub CBAmericano_CheckedChanged(sender As Object, e As EventArgs) Handles CBAmericano.CheckedChanged
        If (CBAmericano.Checked = True) Then
            txtAmericano.Enabled = True
        End If

        If (CBAmericano.Checked = False) Then
            txtAmericano.Enabled = False
        End If
    End Sub

    'txtAmericano
    Private Sub txtAmericano_Click(sender As Object, e As EventArgs) Handles txtAmericano.Click
        txtAmericano.Text = ""
        txtAmericano.Focus()
    End Sub

    'CBEspresso
    Private Sub CBEspresso_CheckedChanged(sender As Object, e As EventArgs) Handles CBEspresso.CheckedChanged
        If (CBEspresso.Checked = True) Then
            txtEspresso.Enabled = True
        End If

        If (CBEspresso.Checked = False) Then
            txtEspresso.Enabled = False
        End If
    End Sub

    'txtEspresso
    Private Sub txtEspresso_Click(sender As Object, e As EventArgs) Handles txtEspresso.Click
        txtEspresso.Text = ""
        txtEspresso.Focus()
    End Sub

    'CBLatte
    Private Sub CBLatte_CheckedChanged(sender As Object, e As EventArgs) Handles CBLatte.CheckedChanged
        If (CBLatte.Checked = True) Then
            txtLatte.Enabled = True
        End If

        If (CBLatte.Checked = False) Then
            txtLatte.Enabled = False
        End If
    End Sub

    'txtLatte
    Private Sub txtLatte_Click(sender As Object, e As EventArgs) Handles txtLatte.Click
        txtLatte.Text = ""
        txtLatte.Focus()
    End Sub

    'CBRootbeer
    Private Sub CBRootbeer_CheckedChanged(sender As Object, e As EventArgs) Handles CBRootbeer.CheckedChanged
        If (CBRootbeer.Checked = True) Then
            txtRootbeer.Enabled = True
        End If

        If (CBRootbeer.Checked = False) Then
            txtRootbeer.Enabled = False
        End If
    End Sub

    'txtRootbeer
    Private Sub txtRootbeer_Click(sender As Object, e As EventArgs) Handles txtRootbeer.Click
        txtRootbeer.Text = ""
        txtRootbeer.Focus()
    End Sub

    'CBGreen
    Private Sub CBGreen_CheckedChanged(sender As Object, e As EventArgs) Handles CBGreen.CheckedChanged
        If (CBGreen.Checked = True) Then
            txtGreen.Enabled = True
        End If

        If (CBGreen.Checked = False) Then
            txtGreen.Enabled = False
        End If
    End Sub

    'txtGreen
    Private Sub txtGreen_Click(sender As Object, e As EventArgs) Handles txtGreen.Click
        txtGreen.Text = ""
        txtGreen.Focus()
    End Sub

    'CBChocolate
    Private Sub CBChocolate_CheckedChanged(sender As Object, e As EventArgs) Handles CBChocolate.CheckedChanged
        If (CBChocolate.Checked = True) Then
            txtChocolate.Enabled = True
        End If

        If (CBChocolate.Checked = False) Then
            txtChocolate.Enabled = False
        End If
    End Sub

    'txtChocolate
    Private Sub txtChocolate_Click(sender As Object, e As EventArgs) Handles txtChocolate.Click
        txtChocolate.Text = ""
        txtChocolate.Focus()
    End Sub

    'CBPepermint
    Private Sub CBPepermint_CheckedChanged(sender As Object, e As EventArgs) Handles CBPepermint.CheckedChanged
        If (CBPepermint.Checked = True) Then
            txtPepermint.Enabled = True
        End If

        If (CBPepermint.Checked = False) Then
            txtPepermint.Enabled = False
        End If
    End Sub

    'txtPepermint
    Private Sub txtPepermint_Click(sender As Object, e As EventArgs) Handles txtPepermint.Click
        txtPepermint.Text = ""
        txtPepermint.Focus()
    End Sub

    'CBLemon
    Private Sub CBLemon_CheckedChanged(sender As Object, e As EventArgs) Handles CBLemon.CheckedChanged
        If (CBLemon.Checked = True) Then
            txtLemon.Enabled = True
        End If

        If (CBLemon.Checked = False) Then
            txtLemon.Enabled = False
        End If
    End Sub

    'txtLemon
    Private Sub txtLemon_Click(sender As Object, e As EventArgs) Handles txtLemon.Click
        txtLemon.Text = ""
        txtLemon.Focus()
    End Sub

    'CBIceCream
    Private Sub CBIceCream_CheckedChanged(sender As Object, e As EventArgs) Handles CBIceCream.CheckedChanged
        If (CBIceCream.Checked = True) Then
            txtIceCream.Enabled = True
        End If

        If (CBIceCream.Checked = False) Then
            txtIceCream.Enabled = False
        End If
    End Sub

    'txtIceCream
    Private Sub txtIceCream_Click(sender As Object, e As EventArgs) Handles txtIceCream.Click
        txtIceCream.Text = ""
        txtIceCream.Focus()
    End Sub

    'CBChocolateCake
    Private Sub CBChocolateCake_CheckedChanged(sender As Object, e As EventArgs) Handles CBChocolateCake.CheckedChanged
        If (CBChocolateCake.Checked = True) Then
            txtChocolateCake.Enabled = True
        End If

        If (CBChocolateCake.Checked = False) Then
            txtChocolateCake.Enabled = False
        End If
    End Sub

    'txtChocolateCake
    Private Sub txtChocolateCake_Click(sender As Object, e As EventArgs) Handles txtChocolateCake.Click
        txtChocolateCake.Text = ""
        txtChocolate.Focus()
    End Sub

    'CBStrawCake
    Private Sub CBStrawCake_CheckedChanged(sender As Object, e As EventArgs) Handles CBStrawCake.CheckedChanged
        If (CBStrawCake.Checked = True) Then
            txtStrawCake.Enabled = True
        End If

        If (CBStrawCake.Checked = False) Then
            txtStrawCake.Enabled = False
        End If
    End Sub

    'txtStrawCake
    Private Sub txtStrawCake_Click(sender As Object, e As EventArgs) Handles txtStrawCake.Click
        txtStrawCake.Text = ""
        txtStrawCake.Focus()
    End Sub

    'CBDarkChocolate
    Private Sub CBDarkChocolate_CheckedChanged(sender As Object, e As EventArgs) Handles CBDarkChocolate.CheckedChanged
        If (CBDarkChocolate.Checked = True) Then
            txtDarkChocolate.Enabled = True
        End If

        If (CBDarkChocolate.Checked = False) Then
            txtDarkChocolate.Enabled = False
        End If
    End Sub

    'txtDarkChocolate
    Private Sub txtDarkChocolate_Click(sender As Object, e As EventArgs) Handles txtDarkChocolate.Click
        txtDarkChocolate.Text = ""
        txtDarkChocolate.Focus()
    End Sub

    'CBFruit
    Private Sub CBFruit_CheckedChanged(sender As Object, e As EventArgs) Handles CBFruit.CheckedChanged
        If (CBFruit.Checked = True) Then
            txtFruit.Enabled = True
        End If

        If (CBFruit.Checked = False) Then
            txtFruit.Enabled = False
        End If
    End Sub

    'txtFruit
    Private Sub txtFruit_Click(sender As Object, e As EventArgs) Handles txtFruit.Click
        txtFruit.Text = ""
        txtFruit.Focus()
    End Sub

    'CBRed
    Private Sub CBRed_CheckedChanged(sender As Object, e As EventArgs) Handles CBRed.CheckedChanged
        If (CBRed.Checked = True) Then
            txtRed.Enabled = True
        End If

        If (CBRed.Checked = False) Then
            txtRed.Enabled = False
        End If
    End Sub

    'txtRed
    Private Sub txtRed_Click(sender As Object, e As EventArgs) Handles txtRed.Click
        txtRed.Text = ""
        txtRed.Focus()
    End Sub

    'CBCoffee
    Private Sub CBCoffee_CheckedChanged(sender As Object, e As EventArgs) Handles CBCoffee.CheckedChanged
        If (CBCoffee.Checked = True) Then
            txtCoffee.Enabled = True
        End If

        If (CBCoffee.Checked = False) Then
            txtCoffee.Enabled = False
        End If
    End Sub

    'txtCoffee
    Private Sub txtCoffee_Click(sender As Object, e As EventArgs) Handles txtCoffee.Click
        txtCoffee.Text = ""
        txtCoffee.Focus()
    End Sub

    'CBForest
    Private Sub CBForest_CheckedChanged(sender As Object, e As EventArgs) Handles CBForest.CheckedChanged
        If (CBForest.Checked = True) Then
            txtForest.Enabled = True
        End If

        If (CBForest.Checked = False) Then
            txtForest.Enabled = False
        End If
    End Sub

    'txtForest
    Private Sub txtForest_Click(sender As Object, e As EventArgs) Handles txtForest.Click
        txtForest.Text = ""
        txtForest.Focus()
    End Sub

    'CBIceCake
    Private Sub CBIceCake_CheckedChanged(sender As Object, e As EventArgs) Handles CBIceCake.CheckedChanged
        If (CBIceCake.Checked = True) Then
            txtIceCake.Enabled = True
        End If

        If (CBIceCake.Checked = False) Then
            txtIceCake.Enabled = False
        End If
    End Sub

    'txtIceCake
    Private Sub txtIceCake_Click(sender As Object, e As EventArgs) Handles txtIceCake.Click
        txtIceCake.Text = ""
        txtIceCake.Focus()
    End Sub

    'txtBeverage
    Private Sub txtBeverage_Click(sender As Object, e As EventArgs) Handles txtBeverage.Click
        txtBeverage.Text = ""
        txtBeverage.Focus()
    End Sub

    'txtDesserts
    Private Sub txtDesserts_Click(sender As Object, e As EventArgs) Handles txtDesserts.Click
        txtDesserts.Text = ""
        txtDesserts.Focus()
    End Sub

    'txtServiceCharged
    Private Sub txtServiceCharged_Click(sender As Object, e As EventArgs) Handles txtServiceCharged.Click
        txtServiceCharged.Text = ""
        txtServiceCharged.Focus()
    End Sub

    'txtTaxCharged
    Private Sub txtTaxCharged_Click(sender As Object, e As EventArgs) Handles txtTaxCharged.Click
        txtTaxCharged.Text = ""
        txtTaxCharged.Focus()
    End Sub

    'txtSubtotal
    Private Sub txtSubtotal_Click(sender As Object, e As EventArgs) Handles txtSubtotal.Click
        txtSubtotal.Text = ""
        txtSubtotal.Focus()
    End Sub

    'txtTotal
    Private Sub txtTotal_Click(sender As Object, e As EventArgs) Handles txtTotal.Click
        txtTotal.Text = ""
        txtTotal.Focus()
    End Sub

    'txtAmountPaid
    Private Sub txtAmountPaid_Click(sender As Object, e As EventArgs) Handles txtAmountPaid.Click
        txtAmountPaid.Text = "RM"
        txtAmountPaid.Focus()
    End Sub

    'txtChange
    Private Sub txtChange_Click(sender As Object, e As EventArgs) Handles txtChange.Click
        txtChange.Text = ""
        txtChange.Focus()
    End Sub

    'Receipt
    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click

        If String.IsNullOrEmpty(txtCustomerID.Text) Then
            MessageBox.Show("Please input Customer ID!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCustomerID.Select()
            Return
        End If

        rtfReceipt.Clear()

        rtfReceipt.AppendText(vbTab + vbTab + vbTab + "Cheerful Cafe" + vbTab + vbTab + Environment.NewLine)
        rtfReceipt.AppendText(vbTab + vbTab + "May The Shibas Be With You!" + vbTab + vbTab + Environment.NewLine)
        rtfReceipt.AppendText("CustomerID:" + " " + txtCustomerID.Text + vbTab + vbTab + Environment.NewLine)
        rtfReceipt.AppendText("Username:" + " " + UserDisplayName.UsernameDisplay + vbTab + Environment.NewLine)
        rtfReceipt.AppendText(lblDate.Text + vbTab + vbTab + vbTab + lblTime.Text + Environment.NewLine)
        rtfReceipt.AppendText("----------------------------------------------------------------------------" + Environment.NewLine)

        rtfReceipt.AppendText("Shiba Inu Ice Cream" + vbTab + vbTab + vbTab + vbTab + txtIceCream.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Chocolate Cake" + vbTab + vbTab + vbTab + vbTab + txtChocolateCake.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Strawberry Cake" + vbTab + vbTab + vbTab + vbTab + txtStrawCake.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Dark Chocolate Cake" + vbTab + vbTab + vbTab + txtDarkChocolate.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Fruit Cake" + vbTab + vbTab + vbTab + vbTab + txtFruit.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Red Velvet Cake" + vbTab + vbTab + vbTab + vbTab + txtRed.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Coffee Cake" + vbTab + vbTab + vbTab + vbTab + txtCoffee.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Black Forest Cake" + vbTab + vbTab + vbTab + vbTab + txtForest.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Ice Cream Cake" + vbTab + vbTab + vbTab + vbTab + txtIceCake.Text + Environment.NewLine)

        rtfReceipt.AppendText("Shiba Inu Cappucino" + vbTab + vbTab + vbTab + vbTab + txtCappucino.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Americano" + vbTab + vbTab + vbTab + vbTab + txtAmericano.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Espresso" + vbTab + vbTab + vbTab + vbTab + vbTab + txtEspresso.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Latte" + vbTab + vbTab + vbTab + vbTab + vbTab + txtLatte.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Ice Cream Rootbeer" + vbTab + vbTab + vbTab + txtRootbeer.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Green Latte" + vbTab + vbTab + vbTab + vbTab + txtGreen.Text + Environment.NewLine)
        rtfReceipt.AppendText("Shiba Inu Hot Chocolate" + vbTab + vbTab + vbTab + vbTab + txtChocolate.Text + Environment.NewLine)
        rtfReceipt.AppendText("Pepermint Tea" + vbTab + vbTab + vbTab + vbTab + vbTab + txtPepermint.Text + Environment.NewLine)
        rtfReceipt.AppendText("Ice Lemon Tea" + vbTab + vbTab + vbTab + vbTab + vbTab + txtLemon.Text + Environment.NewLine)

        rtfReceipt.AppendText("---------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText("Service Charge" + vbTab + vbTab + vbTab + vbTab + txtServiceCharged.Text + Environment.NewLine)
        rtfReceipt.AppendText("---------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText("Tax Charged" + vbTab + vbTab + vbTab + vbTab + txtTaxCharged.Text + Environment.NewLine)
        rtfReceipt.AppendText("Sub Total" + vbTab + vbTab + vbTab + vbTab + vbTab + txtSubtotal.Text + Environment.NewLine)
        rtfReceipt.AppendText("Total Cost" + vbTab + vbTab + vbTab + vbTab + txtTotal.Text + Environment.NewLine)
        rtfReceipt.AppendText("---------------------------------------------------------------------" + Environment.NewLine)
        rtfReceipt.AppendText("Amount Paid" + vbTab + vbTab + vbTab + vbTab + txtAmountPaid.Text + Environment.NewLine)
        rtfReceipt.AppendText("Change" + vbTab + vbTab + vbTab + vbTab + vbTab + txtChange.Text + Environment.NewLine)
        rtfReceipt.AppendText("---------------------------------------------------------------------" + Environment.NewLine)

        rtfReceipt.AppendText(vbTab + vbTab + "Thank You For Your Patronage!" + vbTab + vbTab)
    End Sub

    'Restriction on Quantity textbox
    Private Sub txtNumbersOnly(sender As Object, e As KeyPressEventArgs) Handles txtRootbeer.KeyPress, txtPepermint.KeyPress, txtLemon.KeyPress, txtLatte.KeyPress, txtGreen.KeyPress, txtEspresso.KeyPress, txtChocolate.KeyPress, txtCappucino.KeyPress, txtAmericano.KeyPress, rtfReceipt.KeyPress, txtStrawCake.KeyPress, txtRed.KeyPress, txtIceCream.KeyPress, txtIceCake.KeyPress, txtFruit.KeyPress, txtForest.KeyPress, txtDarkChocolate.KeyPress, txtCoffee.KeyPress, txtChocolateCake.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MsgBox("Please Enter valid numbers", MsgBoxStyle.Information)
        End If
    End Sub

    'Paste Function
    Private Sub TSBPaste_Click(sender As Object, e As EventArgs) Handles TSBPaste.Click
        rtfReceipt.Paste()
    End Sub

    'Copy Function
    Private Sub TSBCopy_Click(sender As Object, e As EventArgs) Handles TSBCopy.Click
        rtfReceipt.Copy()
    End Sub

    'Cut Function
    Private Sub TSBCut_Click(sender As Object, e As EventArgs) Handles TSBCut.Click
        rtfReceipt.Cut()
    End Sub

    'Print Function
    Private Sub TSBPrint_Click(sender As Object, e As EventArgs) Handles TSBPrint.Click
        printPreviewDialog1.Document = PrintDocument2
        printPreviewDialog1.ShowDialog()
    End Sub

    'Print Preview
    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        e.Graphics.DrawString(rtfReceipt.Text, New Font("Times New Roman", 10, FontStyle.Regular), Brushes.Black, 120, 120)
    End Sub

    'Blank Function
    Private Sub TSBBlank_Click(sender As Object, e As EventArgs) Handles TSBBlank.Click
        rtfReceipt.Clear()
    End Sub

    'Open Function
    Private Sub TSBOpen_Click(sender As Object, e As EventArgs) Handles TSBOpen.Click
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*"

        If (OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            rtfReceipt.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    'Save Function
    Private Sub TSBSave_Click(sender As Object, e As EventArgs) Handles TSBSave.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, rtfReceipt.Text, True)
        End If
    End Sub

    'Confirm Function
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If Not CBCappucino.Checked And Not CBAmericano.Checked And Not CBEspresso.Checked And Not CBLatte.Checked And Not CBRootbeer.Checked And Not CBGreen.Checked And Not CBChocolate.Checked And Not CBPepermint.Checked And Not CBLemon.Checked And Not CBIceCream.Checked And Not CBChocolateCake.Checked And Not CBStrawCake.Checked And Not CBDarkChocolate.Checked And Not CBFruit.Checked And Not CBRed.Checked And Not CBCoffee.Checked And Not CBForest.Checked And Not CBIceCake.Checked Then
            MessageBox.Show("Please select at least one item!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim result As DialogResult

        result = MessageBox.Show("Proceed to Payment?", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            btnCash.Enabled = True
            btnConfirm.Enabled = False
            btnReceipt.PerformClick()
            txtAmountPaid.Enabled = True
            txtCappucino.Enabled = False
            txtAmericano.Enabled = False
            txtEspresso.Enabled = False
            txtLatte.Enabled = False
            txtRootbeer.Enabled = False
            txtGreen.Enabled = False
            txtChocolate.Enabled = False
            txtPepermint.Enabled = False
            txtLemon.Enabled = False
            txtIceCream.Enabled = False
            txtChocolateCake.Enabled = False
            txtStrawCake.Enabled = False
            txtDarkChocolate.Enabled = False
            txtFruit.Enabled = False
            txtRed.Enabled = False
            txtCoffee.Enabled = False
            txtForest.Enabled = False
            txtIceCake.Enabled = False

            CBCappucino.Enabled = False
            CBAmericano.Enabled = False
            CBEspresso.Enabled = False
            CBLatte.Enabled = False
            CBRootbeer.Enabled = False
            CBGreen.Enabled = False
            CBChocolate.Enabled = False
            CBPepermint.Enabled = False
            CBLemon.Enabled = False
            CBIceCream.Enabled = False
            CBChocolateCake.Enabled = False
            CBStrawCake.Enabled = False
            CBDarkChocolate.Enabled = False
            CBFruit.Enabled = False
            CBRed.Enabled = False
            CBCoffee.Enabled = False
            CBForest.Enabled = False
            CBIceCake.Enabled = False

        ElseIf result = DialogResult.No Then
            MessageBox.Show("Please edit the menu!", "ADVICE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rtfReceipt.Clear()
        End If

        Dim tax As Double
        tax = 6
        Dim Cappucino, Americano, Espresso, Latte, Rootbeer, Green, Chocolate, Pepermint, Lemon As Double
        Dim IceCream, ChocolateCake, StrawCake, DarkChocolate, Fruit, Red, Coffee, Forest, IceCake As Double

        'Beverage
        Cappucino = 5.5
        Americano = 5.5
        Espresso = 5.5
        Latte = 6.5
        Rootbeer = 7.5
        Green = 6.5
        Chocolate = 7.5
        Pepermint = 5.5
        Lemon = 5.5

        Dim Cappucino_Bev As Double = Convert.ToDouble(txtCappucino.Text)
        Dim Americano_Bev As Double = Convert.ToDouble(txtAmericano.Text)
        Dim Espresso_Bev As Double = Convert.ToDouble(txtEspresso.Text)
        Dim Latte_Bev As Double = Convert.ToDouble(txtLatte.Text)
        Dim Rootbeer_Bev As Double = Convert.ToDouble(txtRootbeer.Text)
        Dim Green_Bev As Double = Convert.ToDouble(txtGreen.Text)
        Dim Chocolate_Bev As Double = Convert.ToDouble(txtChocolate.Text)
        Dim Pepermint_Bev As Double = Convert.ToDouble(txtPepermint.Text)
        Dim Lemon_Bev As Double = Convert.ToDouble(txtLemon.Text)

        'Dessert
        IceCream = 6
        ChocolateCake = 7
        StrawCake = 7
        DarkChocolate = 7
        Fruit = 7
        Red = 10
        Coffee = 8
        Forest = 8
        IceCake = 11

        Dim IceCream_Des = Convert.ToDouble(txtIceCream.Text)
        Dim ChocolateCake_Des = Convert.ToDouble(txtChocolateCake.Text)
        Dim StrawCake_Des = Convert.ToDouble(txtStrawCake.Text)
        Dim DarkChocolate_Des = Convert.ToDouble(txtDarkChocolate.Text)
        Dim Fruit_Des = Convert.ToDouble(txtFruit.Text)
        Dim Red_Des = Convert.ToDouble(txtRed.Text)
        Dim Coffee_Des = Convert.ToDouble(txtCoffee.Text)
        Dim Forest_Des = Convert.ToDouble(txtForest.Text)
        Dim IceCake_Des = Convert.ToDouble(txtIceCake.Text)
        '___________________________________________________________________________________________
        Dim Cost_of_Beverage, Cost_of_Desserts As Double
        Dim Service_Charge, SSTax As String

        Cost_of_Beverage = (Cappucino_Bev * Cappucino) + (Americano_Bev * Americano) + (Espresso_Bev * Espresso) + (Latte_Bev * Latte) _
            + (Rootbeer_Bev * Rootbeer) + (Green_Bev * Green) + (Chocolate_Bev * Chocolate) + (Pepermint_Bev * Pepermint) + (Lemon_Bev * Lemon)
        txtBeverage.Text = "RM" & Convert.ToString(Cost_of_Beverage)

        Cost_of_Desserts = (IceCream_Des * IceCream) + (ChocolateCake_Des * ChocolateCake) + (StrawCake_Des * StrawCake) + (DarkChocolate_Des * DarkChocolate) _
            + (Fruit_Des * Fruit) + (Red_Des * Red) + (Coffee_Des * Coffee) + (Forest_Des * Forest) + (IceCake_Des * IceCake)
        txtDesserts.Text = "RM" & Convert.ToString(Cost_of_Desserts)

        Service_Charge = txtServiceCharged.Text

        txtSubtotal.Text = "RM" & Convert.ToString(Cost_of_Beverage + Cost_of_Desserts + Val(Service_Charge.Replace("RM", "")))
        txtTaxCharged.Text = "RM" + Convert.ToString((((Cost_of_Beverage + Cost_of_Desserts + Val(Service_Charge.Replace("RM", ""))) * tax / 100)))
        SSTax = txtTaxCharged.Text
        txtTotal.Text = "RM" & Convert.ToString(Cost_of_Beverage + Cost_of_Desserts + Val(SSTax.Replace("RM", "") + Val(Service_Charge.Replace("RM", ""))))
        txtAmountPaid.Text = "RM" & "0"
        txtChange.Text = "RM" & "0"
    End Sub

    'Cash out Function
    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        Dim tax As Double
        tax = 6
        Dim Cappucino, Americano, Espresso, Latte, Rootbeer, Green, Chocolate, Pepermint, Lemon As Double
        Dim IceCream, ChocolateCake, StrawCake, DarkChocolate, Fruit, Red, Coffee, Forest, IceCake As Double

        'Beverage
        Cappucino = 5.5
        Americano = 5.5
        Espresso = 5.5
        Latte = 6.5
        Rootbeer = 7.5
        Green = 6.5
        Chocolate = 7.5
        Pepermint = 5.5
        Lemon = 5.5

        Dim Cappucino_Bev As Double = Convert.ToDouble(txtCappucino.Text)
        Dim Americano_Bev As Double = Convert.ToDouble(txtAmericano.Text)
        Dim Espresso_Bev As Double = Convert.ToDouble(txtEspresso.Text)
        Dim Latte_Bev As Double = Convert.ToDouble(txtLatte.Text)
        Dim Rootbeer_Bev As Double = Convert.ToDouble(txtRootbeer.Text)
        Dim Green_Bev As Double = Convert.ToDouble(txtGreen.Text)
        Dim Chocolate_Bev As Double = Convert.ToDouble(txtChocolate.Text)
        Dim Pepermint_Bev As Double = Convert.ToDouble(txtPepermint.Text)
        Dim Lemon_Bev As Double = Convert.ToDouble(txtLemon.Text)

        'Dessert
        IceCream = 6
        ChocolateCake = 7
        StrawCake = 7
        DarkChocolate = 7
        Fruit = 7
        Red = 10
        Coffee = 8
        Forest = 8
        IceCake = 11

        Dim IceCream_Des = Convert.ToDouble(txtIceCream.Text)
        Dim ChocolateCake_Des = Convert.ToDouble(txtChocolateCake.Text)
        Dim StrawCake_Des = Convert.ToDouble(txtStrawCake.Text)
        Dim DarkChocolate_Des = Convert.ToDouble(txtDarkChocolate.Text)
        Dim Fruit_Des = Convert.ToDouble(txtFruit.Text)
        Dim Red_Des = Convert.ToDouble(txtRed.Text)
        Dim Coffee_Des = Convert.ToDouble(txtCoffee.Text)
        Dim Forest_Des = Convert.ToDouble(txtForest.Text)
        Dim IceCake_Des = Convert.ToDouble(txtIceCake.Text)
        '___________________________________________________________________________________________
        Dim Cost_of_Beverage, Cost_of_Desserts, Change As Double
        Dim Service_Charge, SSTax, AmountPaid As String

        Cost_of_Beverage = (Cappucino_Bev * Cappucino) + (Americano_Bev * Americano) + (Espresso_Bev * Espresso) + (Latte_Bev * Latte) _
            + (Rootbeer_Bev * Rootbeer) + (Green_Bev * Green) + (Chocolate_Bev * Chocolate) + (Pepermint_Bev * Pepermint) + (Lemon_Bev * Lemon)
        txtBeverage.Text = "RM" & Convert.ToString(Cost_of_Beverage)

        Cost_of_Desserts = (IceCream_Des * IceCream) + (ChocolateCake_Des * ChocolateCake) + (StrawCake_Des * StrawCake) + (DarkChocolate_Des * DarkChocolate) _
            + (Fruit_Des * Fruit) + (Red_Des * Red) + (Coffee_Des * Coffee) + (Forest_Des * Forest) + (IceCake_Des * IceCake)
        txtDesserts.Text = "RM" & Convert.ToString(Cost_of_Desserts)

        Service_Charge = txtServiceCharged.Text

        txtChange.Clear()
        txtSubtotal.Text = "RM" & Convert.ToString(Cost_of_Beverage + Cost_of_Desserts + Val(Service_Charge.Replace("RM", "")))
        txtTaxCharged.Text = "RM" + Convert.ToString((((Cost_of_Beverage + Cost_of_Desserts + Val(Service_Charge.Replace("RM", ""))) * tax / 100)))
        SSTax = txtTaxCharged.Text
        txtTotal.Text = "RM" & Convert.ToString(Cost_of_Beverage + Cost_of_Desserts + Val(SSTax.Replace("RM", "")) + Val(Service_Charge.Replace("RM", "")))
        AmountPaid = txtAmountPaid.Text
        txtChange.Text = "RM" & Convert.ToString(Val(AmountPaid.Replace("RM", "")) - (Cost_of_Beverage + Cost_of_Desserts + Val(SSTax.Replace("RM", "")) + Val(Service_Charge.Replace("RM", ""))))
        Change = Val(txtChange.Text.Replace("RM", ""))
        Change = Math.Round(Change, 2)


        If Val(txtTotal.Text.Replace("RM", "")) > Val(AmountPaid.Replace("RM", "")) Then
            MessageBox.Show("Amount entered is invalid!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAmountPaid.Select()
            Return
        Else
            Dim mySQL As String = String.Empty

            mySQL &= "INSERT INTO Order_Payment (Username, CustomerID, Cappucino, Americano, Espresso, Latte, Rootbeer, Green_Latte, Hot_Chocolate,
                                                 Pepermint, Lemon, Ice_Cream, Chocolate_Cake, Strawberry_Cake, DChocolate_Cake, Fruit_Cake, 
                                                 Red_Cake, Coffee_Cake, Forest_Cake, Ice_Cake, Subtotal, Total, Amount_Paid, Change)"
            mySQL &= "VALUES ('" & UserDisplayName.UsernameDisplay & "','" & txtCustomerID.Text & "','" & txtCappucino.Text & "','" & txtAmericano.Text & "',
                              '" & txtEspresso.Text & "','" & txtLatte.Text & "','" & txtRootbeer.Text & "','" & txtGreen.Text & "','" & txtChocolate.Text & "',
                              '" & txtPepermint.Text & "','" & txtLemon.Text & "','" & txtIceCream.Text & "','" & txtChocolateCake.Text & "',
                              '" & txtStrawCake.Text & "','" & txtDarkChocolate.Text & "','" & txtFruit.Text & "','" & txtRed.Text & "',
                              '" & txtCoffee.Text & "','" & txtForest.Text & "','" & txtIceCake.Text & "','" & txtSubtotal.Text & "','" & txtTotal.Text & "',
                              '" & txtAmountPaid.Text & "','" & txtChange.Text & "')"

            ExecuteSQL(mySQL)

            MessageBox.Show("Transaction has been saved successfully!", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
                tb.Text = String.Empty
            Next

            btnReceipt.PerformClick()
            TSBPrint.PerformClick()

            txtCappucino.Text = "0"
            txtAmericano.Text = "0"
            txtEspresso.Text = "0"
            txtLatte.Text = "0"
            txtRootbeer.Text = "0"
            txtGreen.Text = "0"
            txtChocolate.Text = "0"
            txtPepermint.Text = "0"
            txtLemon.Text = "0"
            txtIceCream.Text = "0"
            txtChocolateCake.Text = "0"
            txtStrawCake.Text = "0"
            txtDarkChocolate.Text = "0"
            txtFruit.Text = "0"
            txtRed.Text = "0"
            txtCoffee.Text = "0"
            txtForest.Text = "0"
            txtIceCake.Text = "0"
            txtBeverage.Text = "0"
            txtDesserts.Text = "0"
            txtServiceCharged.Text = "RM3"
            txtTaxCharged.Text = "0"
            txtTotal.Text = "0"
            txtSubtotal.Text = "0"
            txtChange.Text = "0"
            txtAmountPaid.Text = "0"

            txtCappucino.Enabled = False
            txtAmericano.Enabled = False
            txtEspresso.Enabled = False
            txtLatte.Enabled = False
            txtRootbeer.Enabled = False
            txtGreen.Enabled = False
            txtChocolate.Enabled = False
            txtPepermint.Enabled = False
            txtLemon.Enabled = False
            txtIceCream.Enabled = False
            txtChocolateCake.Enabled = False
            txtStrawCake.Enabled = False
            txtDarkChocolate.Enabled = False
            txtFruit.Enabled = False
            txtRed.Enabled = False
            txtCoffee.Enabled = False
            txtForest.Enabled = False
            txtIceCake.Enabled = False
            txtBeverage.Enabled = False
            txtDesserts.Enabled = False
            txtServiceCharged.Enabled = False
            txtSubtotal.Enabled = False
            txtTaxCharged.Enabled = False
            txtTotal.Enabled = False
            txtChange.Enabled = False
            txtAmountPaid.Enabled = False

            rtfReceipt.Clear()

            CBCappucino.Enabled = True
            CBAmericano.Enabled = True
            CBEspresso.Enabled = True
            CBLatte.Enabled = True
            CBRootbeer.Enabled = True
            CBGreen.Enabled = True
            CBChocolate.Enabled = True
            CBPepermint.Enabled = True
            CBLemon.Enabled = True
            CBIceCream.Enabled = True
            CBChocolateCake.Enabled = True
            CBStrawCake.Enabled = True
            CBDarkChocolate.Enabled = True
            CBFruit.Enabled = True
            CBRed.Enabled = True
            CBCoffee.Enabled = True
            CBForest.Enabled = True
            CBIceCake.Enabled = True

            CBCappucino.Checked = False
            CBAmericano.Checked = False
            CBEspresso.Checked = False
            CBLatte.Checked = False
            CBRootbeer.Checked = False
            CBGreen.Checked = False
            CBChocolate.Checked = False
            CBPepermint.Checked = False
            CBLemon.Checked = False
            CBIceCream.Checked = False
            CBChocolateCake.Checked = False
            CBStrawCake.Checked = False
            CBDarkChocolate.Checked = False
            CBFruit.Checked = False
            CBRed.Checked = False
            CBCoffee.Checked = False
            CBForest.Checked = False
            CBIceCake.Checked = False

            btnCash.Enabled = False
            btnConfirm.Enabled = True

        End If
    End Sub
End Class
