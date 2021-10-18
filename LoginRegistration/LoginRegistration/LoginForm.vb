Public Class LoginForm

    'Exit Function
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'Show Password Function
    Private Sub CBShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CBShowPassword.CheckedChanged

        If CBShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    'Login Form Codes
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()
        txtUsername.Select()
    End Sub

    'Login Button Code
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not String.IsNullOrEmpty(txtUsername.Text) And Not String.IsNullOrEmpty(txtPassword.Text) Then

            UserDisplayName.UsernameDisplay = txtUsername.Text

            Dim SQL As String = String.Empty
            SQL &= "SELECT * FROM UserLogin "
            SQL &= "WHERE Username = '" & txtUsername.Text & "'"
            SQL &= "AND Password = '" & txtPassword.Text & "'"


            Dim UserData As DataTable = ExecuteSQL(SQL)

            If UserData.Rows.Count > 0 Then
                txtUsername.Clear()
                txtPassword.Clear()
                CBShowPassword.Checked = False

                MessageBox.Show("Welcome back" & " " & UserDisplayName.UsernameDisplay & "!!!", "Login is Successful!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Dim MainForm As New MainForm()
                MainForm.Show()
                Me.Close()

            Else
                MsgBox("The Username or Password is incorrect. Try again.", MsgBoxStyle.Critical, "Login is Unsuccessful!")
                txtUsername.Focus()
                txtUsername.SelectAll()
                txtPassword.Clear()
            End If


        Else
            MsgBox("Please enter the Username and Password!", MsgBoxStyle.Critical, "Login Form: Cheerful Cafe")
            txtUsername.Select()
        End If

    End Sub

    'Timer1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = DateTime.Now.ToLongTimeString
    End Sub
End Class

Public Class UserDisplayName
    Public Shared UsernameDisplay As String
End Class
