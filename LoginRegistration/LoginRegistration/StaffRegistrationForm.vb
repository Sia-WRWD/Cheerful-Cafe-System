
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class StaffRegistrationForm

    Private FirstNameValid As Boolean
    Private LastNameValid As Boolean
    Private EmailValid As Boolean
    Private UsernameValid As Boolean

    'Close Function
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MainForm.Show()
        Me.Close()
    End Sub

    'Clear Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            tb.Text = String.Empty
        Next
        txtFirstName.Select()
        txtUsername.Enabled = True
        lblConfirm.Visible = True
        txtConfirm.Visible = True
    End Sub

    'Form Code
    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowUserData()
        txtFirstName.Select()
        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()
    End Sub

    'DGV
    Private Sub ShowUserData()

        Dim UserData As DataTable = ExecuteSQL("SELECT (FirstName + ' ' + LastName) As Fullname, Username, Email FROM UserLogin")

        With DGV

            .DataSource = UserData
            .Columns(0).HeaderText = "Full Name"
            .Columns(1).HeaderText = "Username"
            .Columns(2).HeaderText = "Email"
            .Columns(0).Width = 217
            .Columns(1).Width = 217
            .Columns(2).Width = 217

        End With

    End Sub

    'Delete Function
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            If MessageBox.Show("Do you want to permanently delete the selected record?",
                               "Delete Data: Cheerful Cafe", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
                                Windows.Forms.DialogResult.Yes Then

                ExecuteSQL("DELETE FROM UserLogin Where Username = '" & DGV.CurrentRow.Cells(1).Value & "'")

                ShowUserData()

                MessageBox.Show("The record has been deleted.", "Delete Data: Cheerful Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Return
            End If

        Catch ex As Exception
            MsgBox("An Error occured: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Save Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Input Validation for First Name
        Dim FirstN As String = "^[a-zA-Z\s]+$"
        Dim FirstName As New Regex(FirstN)
        If Not FirstName.IsMatch(txtFirstName.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFirstName.Focus()
            txtFirstName.Clear()
            FirstNameValid = False
        Else
            FirstNameValid = True
        End If

        'Input Validation for Last Name
        Dim LastN As String = "^[a-zA-Z\s]+$"
        Dim LastName As New Regex(LastN)
        If Not LastName.IsMatch(txtLastName.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLastName.Focus()
            txtLastName.Clear()
            LastNameValid = False
        Else
            LastNameValid = True
        End If

        'Input Validation for Username
        Dim UserN As String = "^[a-z]*$"
        Dim UserName As New Regex(UserN)
        If Not UserName.IsMatch(txtUsername.Text) Then
            MessageBox.Show("Your Username should be within 30 characters!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Focus()
            txtUsername.Clear()
            UsernameValid = False
        Else
            UsernameValid = True
        End If

        'Email Input Validation.
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})",
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled
        )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txtEmail.Text)

        If blnPossibleMatch Then
            If Not txtEmail.Text.Equals(reEmail.Match(txtEmail.Text).ToString) Then
                MessageBox.Show("Invalid Email Address!")

            Else
                EmailValid = True
            End If
        Else
            EmailValid = False
            MessageBox.Show("Invalid Email Address!")
            txtEmail.Clear()
            txtEmail.Focus()
        End If

        Dim btn As MessageBoxButtons = MessageBoxButtons.OK
        Dim ico As MessageBoxIcon = MessageBoxIcon.Information
        Dim caption As String = "Save Data: Cheerful Cafe"

        'Empty Input Validation for all textboxes.
        If String.IsNullOrEmpty(txtFirstName.Text) Then
            MessageBox.Show("Please enter your First Name!", caption, btn, ico)
            txtFirstName.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtLastName.Text) Then
            MessageBox.Show("Please enter your Last Name!", caption, btn, ico)
            txtLastName.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtUsername.Text) Then
            MessageBox.Show("Please enter your Username!", caption, btn, ico)
            txtUsername.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please enter your Password!", caption, btn, ico)
            txtPassword.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtConfirm.Text) Then
            MessageBox.Show("Please enter your Confirm Password!", caption, btn, ico)
            txtConfirm.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtEmail.Text) Then
            MessageBox.Show("Please enter your email!", caption, btn, ico)
            txtEmail.Select()
            Return
        End If

        If txtPassword.Text <> txtConfirm.Text Then

            MessageBox.Show("Your Password and Confirmation password do not match!", caption, btn, ico)
            txtConfirm.Select()
            Return
        End If

        Dim CheckDuplicates As DataTable = ExecuteSQL("SELECT Username FROM UserLogin WHERE Username = '" & txtUsername.Text & "'")

        If CheckDuplicates.Rows.Count > 0 Then
            MessageBox.Show("The Username that you input already exists! Please try again.", caption, btn, ico)
            txtUsername.Focus()
            Return
        End If

        Dim result As DialogResult

        result = MessageBox.Show("Do you want to save the selected records?", "Save Data: Cheerful Cafe",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim mySQL As String = String.Empty

            mySQL &= "INSERT INTO UserLogin (FirstName, LastName, Email, Username, Password)"
            mySQL &= "VALUES ('" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtEmail.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "')"

            ExecuteSQL(mySQL)

            MessageBox.Show("The record has been saved successfully!", "Save Data: Cheerful Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ShowUserData()

            For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
                tb.Text = String.Empty
            Next
        Else
            Return
        End If
    End Sub

    'Timer1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub

    'Password Character Setting = Password
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        txtPassword.UseSystemPasswordChar = True
    End Sub

    'Password Character Setting = Confirm
    Private Sub txtConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtConfirm.TextChanged
        txtConfirm.UseSystemPasswordChar = True
    End Sub

    'Update Function
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Input Validation for First Name
        Dim FirstN As String = "^[a-zA-Z\s]+$"
        Dim FirstName As New Regex(FirstN)
        If Not FirstName.IsMatch(txtFirstName.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFirstName.Focus()
            txtFirstName.Clear()
            FirstNameValid = False
        Else
            FirstNameValid = True
        End If

        'Input Validation for Last Name
        Dim LastN As String = "^[a-zA-Z\s]+$"
        Dim LastName As New Regex(LastN)
        If Not LastName.IsMatch(txtLastName.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtLastName.Focus()
            txtLastName.Clear()
            LastNameValid = False
        Else
            LastNameValid = True
        End If

        'Email Input Validation.
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})",
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled
        )

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txtEmail.Text)

        If blnPossibleMatch Then
            If Not txtEmail.Text.Equals(reEmail.Match(txtEmail.Text).ToString) Then
                MessageBox.Show("Invalid Email Address!")

            Else
                EmailValid = True
            End If
        Else
            EmailValid = False
            MessageBox.Show("Invalid Email Address!")
            txtEmail.Clear()
            txtEmail.Focus()
        End If

        Dim btn As MessageBoxButtons = MessageBoxButtons.OK
        Dim ico As MessageBoxIcon = MessageBoxIcon.Information
        Dim caption As String = "Save Data: Cheerful Cafe"

        'Empty Input Validation for all textboxes.
        If String.IsNullOrEmpty(txtFirstName.Text) Then
            MessageBox.Show("Please enter your First Name!", caption, btn, ico)
            txtFirstName.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtLastName.Text) Then
            MessageBox.Show("Please enter your Last Name!", caption, btn, ico)
            txtLastName.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please enter your Password!", caption, btn, ico)
            txtPassword.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtConfirm.Text) Then
            MessageBox.Show("Please enter your Confirm Password!", caption, btn, ico)
            txtConfirm.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtEmail.Text) Then
            MessageBox.Show("Please enter your email!", caption, btn, ico)
            txtEmail.Select()
            Return
        End If

        If txtPassword.Text <> txtConfirm.Text Then

            MessageBox.Show("Your Password and Confirmation password do not match!", caption, btn, ico)
            txtConfirm.Select()
            Return
        End If

        If txtUsername.Text = "" Then

            MessageBox.Show("Please input Username!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Dim connection As New SqlConnection("Data Source =DESKTOP-2VS00LB;Initial Catalog=UserData;Integrated Security=True")
            Dim command As New SqlCommand("UPDATE UserLogin SET FirstName ='" & txtFirstName.Text & "', LastName = '" & txtLastName.Text & "', Email = '" & txtEmail.Text & "', Password = '" & txtPassword.Text & "' WHERE Username = '" & txtUsername.Text & "'", connection)

            command.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = txtFirstName.Text
            command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = txtLastName.Text
            command.Parameters.Add("Email", SqlDbType.NVarChar).Value = txtEmail.Text
            command.Parameters.Add("Password", SqlDbType.NVarChar).Value = txtPassword.Text
            connection.Open()

            If txtPassword.Text <> txtConfirm.Text Then
                MessageBox.Show("Your Password and Confirmation password do not match!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtConfirm.Select()
                Return
            End If

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Updated!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsername.Clear()
                txtPassword.Clear()
                txtEmail.Clear()
                txtFirstName.Clear()
                txtLastName.Clear()
                txtConfirm.Clear()
                txtUsername.Enabled = True
            Else
                MessageBox.Show("Data Not Updated", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            connection.Close()
        End If

        ShowUserData()

    End Sub

    'Search Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim connection As New SqlConnection("Data Source =DESKTOP-2VS00LB;Initial Catalog=UserData;Integrated Security=True")

        Dim command As New SqlCommand("Select * FROM UserLogin WHERE Username ='" & txtUsername.Text & "'", connection)

        command.Parameters.Add("Username", SqlDbType.NVarChar).Value = txtUsername.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim Table As New DataTable()

        adapter.Fill(Table)

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""

        If Table.Rows.Count() > 0 Then
            txtFirstName.Text = Table.Rows(0)(0).ToString()
            txtEmail.Text = Table.Rows(0)(2).ToString()
            txtLastName.Text = Table.Rows(0)(1).ToString()
            txtPassword.Text = Table.Rows(0)(4).ToString()

        Else
            MessageBox.Show("Username input cannot be found!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        txtUsername.Enabled = False
    End Sub
End Class