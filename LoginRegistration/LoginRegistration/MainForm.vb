Imports System.Data.SqlClient

Public Class MainForm

    'Main Form Codes
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()
        btnMenu.Enabled = False
        txtCustomerName.Enabled = False

        'Welcome User
        lblWelcome.Text = "Welcome Back " & UserDisplayName.UsernameDisplay & "!"

        'Music
        Dim MyValue
        Randomize()

        MyValue = Int((5 * Rnd()) + 1)

        If MyValue = 1 Then

            lblMessage.Text = "Roses are red,
                               My Name is Dave, 
                               This poem makes no sense, 
                               Microwave."

        ElseIf MyValue = 2 Then

            lblMessage.Text = "What does a dog say when it sees a human?
                               Woof! Woof!
                               Cause they can't talk. :D"


        ElseIf MyValue = 3 Then

            lblMessage.Text = "Why did the chicken cross the road?
                               To get to your house. 
                               Knock Knock, Who’s there? 
                               THE CHICKEN!"

        ElseIf MyValue = 4 Then

            lblMessage.Text = "Knock Knock, Who's there?
                               Daisy,
                               Daisy Who?
                               Daisy me rollin', they hatin'"

        ElseIf MyValue = 5 Then

            lblMessage.Text = "Knock Knock, Who's there?
                               Arch
                               Arch Who?
                               Bless you. :D"


        End If

    End Sub

    'Timer1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = DateTime.Now.ToLongTimeString
    End Sub

    'Direct to Staff Registration Page Button
    Private Sub btnStaffRegistration_Click(sender As Object, e As EventArgs) Handles btnStaffRegistration.Click
        StaffRegistrationForm.Show()
        Me.Close()
    End Sub

    'Direct to Customer Registration Page Button
    Private Sub btnCustomerRegistration_Click(sender As Object, e As EventArgs) Handles btnCustomerRegistration.Click
        CustomerRegistrationForm.Show()
        Me.Close()
    End Sub

    'Direct to MenuPayment Page Button
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        MenuPaymentSystem.Show()
        Me.Close()
    End Sub

    'Log Off
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        LoginForm.Show()
        LoginForm.txtUsername.Clear()
        LoginForm.txtPassword.Clear()
        Me.Close()
    End Sub

    'Search Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim connection As New SqlConnection("Data Source =DESKTOP-2VS00LB;Initial Catalog=UserData;Integrated Security=True")

        Dim command As New SqlCommand("Select * FROM CustomerDetails WHERE CustomerID ='" & txtCustomerID.Text & "'", connection)

        command.Parameters.Add("CustomerID", SqlDbType.NVarChar).Value = txtCustomerID.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim Table As New DataTable()

        adapter.Fill(Table)

        txtCustomerName.Text = ""

        If Table.Rows.Count() > 0 Then

            txtCustomerName.Text = Table.Rows(0)(1).ToString() & " " & Table.Rows(0)(2).ToString()
            btnMenu.Enabled = True
        Else

            MessageBox.Show("CustomerID input is either missing or cannot be found!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnMenu.Enabled = False
        End If

        CustomerDisplayID.CustomerDisplay = txtCustomerID.Text

    End Sub

    'Play Music Function
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        My.Computer.Audio.Play(My.Resources.Your_Name__Sparkle__Instrumental_Only_, AudioPlayMode.BackgroundLoop)

    End Sub

    'Stop Music Function
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        My.Computer.Audio.Stop()

    End Sub

    'History Form
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        HistoryForm.Show()
        Me.Close()
    End Sub

    Private Sub txtCustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerID.TextChanged

    End Sub
End Class

Public Class CustomerDisplayID
    Public Shared CustomerDisplay As String
End Class