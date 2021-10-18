Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class CustomerRegistrationForm

    Private FirstNameValid As Boolean
    Private LastNameValid As Boolean
    Private EmailValid As Boolean
    Private ContactNumberValid As Boolean
    Private GenderValid As Boolean
    Private AddressValid As Boolean

    'Button Close
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MainForm.Show()
        Me.Close()
    End Sub

    'Button Clear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            tb.Text = String.Empty
        Next
        txtCustomerID.Select()
        txtCustomerID.Enabled = True
    End Sub

    'DataGridView
    Private Sub ShowUserData()

        Dim UserData As DataTable = ExecuteSQL("SELECT (FirstName + ' ' + LastName) As Fullname, CustomerID, Gender FROM CustomerDetails")

        With DGV

            .DataSource = UserData
            .Columns(0).HeaderText = "Full Name"
            .Columns(1).HeaderText = "CustomerID"
            .Columns(2).HeaderText = "Gender"
            .Columns(0).Width = 263
            .Columns(1).Width = 263
            .Columns(2).Width = 263

        End With

    End Sub

    'Button Delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            If MessageBox.Show("Do you want to permanently delete the selected record?",
                               "Delete Data: Cheerful Cafe", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) =
                                Windows.Forms.DialogResult.Yes Then

                ExecuteSQL("DELETE FROM CustomerDetails Where CustomerID = '" & DGV.CurrentRow.Cells(1).Value & "'")

                ShowUserData()

                MessageBox.Show("The record has been deleted.", "Delete Data: Cheerful Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Return
            End If

        Catch ex As Exception
            MsgBox("An Error occured: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    'Button Insert
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

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
        Dim Emaill As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})",
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled
        )

        Dim blnPossibleMatch As Boolean = Emaill.IsMatch(txtEmail.Text)

        If blnPossibleMatch Then
            If Not txtEmail.Text.Equals(Emaill.Match(txtEmail.Text).ToString) Then
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

        'Phone Input Validation

        Dim strContactNumPattern As String = "^(\+?6?01)[0-46-9]-*[0-9]{7,8}$"

        Dim ContactNumber As New Regex(strContactNumPattern)

        If Not ContactNumber.IsMatch(txtContactNumber.Text) Then

            MessageBox.Show("Please enter your Contact Number in the correct format!")
            txtContactNumber.Clear()
            txtContactNumber.Focus()
            ContactNumberValid = False
        Else
            ContactNumberValid = True
        End If

        'Gender Input Validation
        Dim Genderr As String = "^(?:m|M|male|Male|f|F|female|Female)$"
        Dim Gender As New Regex(Genderr)

        If Not Gender.IsMatch(txtGender.Text) Then
            MessageBox.Show("Please enter either Male or Female!")
            txtGender.Clear()
            txtGender.Focus()
            GenderValid = False
        Else
            GenderValid = True
        End If

        'Empty Input Validation for all textboxes
        Dim btn As MessageBoxButtons = MessageBoxButtons.OK
        Dim ico As MessageBoxIcon = MessageBoxIcon.Information
        Dim caption As String = "Save Data: Cheerful Cafe"

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

        If String.IsNullOrEmpty(txtAddress.Text) Then
            MessageBox.Show("Please enter your Address!", caption, btn, ico)
            txtAddress.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtEmail.Text) Then
            MessageBox.Show("Please enter your email!", caption, btn, ico)
            txtEmail.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtCustomerID.Text) Then
            MessageBox.Show("Please enter your CustomerID!", caption, btn, ico)
            txtCustomerID.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtContactNumber.Text) Then
            MessageBox.Show("Please enter your Contact Number!", caption, btn, ico)
            txtContactNumber.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtGender.Text) Then
            MessageBox.Show("Please enter your Gender!", caption, btn, ico)
            txtGender.Select()
            Return
        End If

        Dim CheckDuplicates As DataTable = ExecuteSQL("SELECT CustomerID FROM CustomerDetails WHERE CustomerID = '" & txtCustomerID.Text & "'")

        If CheckDuplicates.Rows.Count > 0 Then
            MessageBox.Show("The CustomerID that you input already exists! Please try again.", caption, btn, ico)
            txtCustomerID.Focus()
            Return
        End If

        Dim result As DialogResult

        result = MessageBox.Show("Do you want to insert the selected records?", "Save Data: Cheerful Cafe",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim mySQL As String = String.Empty

            mySQL &= "INSERT INTO CustomerDetails (CustomerID, FirstName, LastName, Email, Address, Contact_Number, Gender)"
            mySQL &= "VALUES ('" & txtCustomerID.Text & "','" & txtFirstName.Text & "','" & txtLastName.Text & "','" & txtEmail.Text & "','" & txtAddress.Text & "','" & txtContactNumber.Text & "','" & txtGender.Text & "')"

            ExecuteSQL(mySQL)

            MessageBox.Show("The record has been inserted successfully!", "Save Data: Cheerful Cafe", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ShowUserData()

            For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
                tb.Text = String.Empty
            Next
        Else
            Return
        End If
    End Sub

    'Form
    Private Sub CustomerRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        txtCustomerID.Select()
        ShowUserData()
        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()

    End Sub

    'Timer1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = DateTime.Now.ToLongTimeString
    End Sub

    'Textbox Contact Number
    Private Sub txtNumbersOnly(sender As Object, e As KeyPressEventArgs) Handles txtContactNumber.KeyPress
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MessageBox.Show("Numbers Only!!!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    'Search Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim connection As New SqlConnection("Data Source =DESKTOP-2VS00LB;Initial Catalog=UserData;Integrated Security=True")

        Dim command As New SqlCommand("Select * FROM CustomerDetails WHERE CustomerID ='" & txtCustomerID.Text & "'", connection)

        command.Parameters.Add("CustomerID", SqlDbType.NVarChar).Value = txtCustomerID.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim Table As New DataTable()

        adapter.Fill(Table)

        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtGender.Text = ""

        If Table.Rows.Count() > 0 Then
            txtFirstName.Text = Table.Rows(0)(1).ToString()
            txtLastName.Text = Table.Rows(0)(2).ToString()
            txtEmail.Text = Table.Rows(0)(3).ToString()
            txtAddress.Text = Table.Rows(0)(4).ToString()
            txtContactNumber.Text = Table.Rows(0)(5).ToString()
            txtGender.Text = Table.Rows(0)(6).ToString()
            txtCustomerID.Enabled = False
        Else

            MessageBox.Show("CustomerID input cannot be found!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCustomerID.Enabled = True
        End If
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
        Dim Emaill As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})",
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled
        )

        Dim blnPossibleMatch As Boolean = Emaill.IsMatch(txtEmail.Text)

        If blnPossibleMatch Then
            If Not txtEmail.Text.Equals(Emaill.Match(txtEmail.Text).ToString) Then
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

        'Phone Input Validation

        Dim strContactNumPattern As String = "^(\+?6?01)[0-46-9]-*[0-9]{7,8}$"

        Dim ContactNumber As New Regex(strContactNumPattern)

        If Not ContactNumber.IsMatch(txtContactNumber.Text) Then

            MessageBox.Show("Please enter your Contact Number in the correct format!")
            txtContactNumber.Clear()
            txtContactNumber.Focus()
            ContactNumberValid = False
        Else
            ContactNumberValid = True
        End If

        'Gender Input Validation
        Dim Genderr As String = "^(?:m|M|male|Male|f|F|female|Female)$"
        Dim Gender As New Regex(Genderr)

        If Not Gender.IsMatch(txtGender.Text) Then
            MessageBox.Show("Please enter either Male or Female!")
            txtGender.Clear()
            txtGender.Focus()
            GenderValid = False
        Else
            GenderValid = True
        End If

        Dim btn As MessageBoxButtons = MessageBoxButtons.OK
        Dim ico As MessageBoxIcon = MessageBoxIcon.Information
        Dim caption As String = "Save Data: Cheerful Cafe"

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

        If String.IsNullOrEmpty(txtAddress.Text) Then
            MessageBox.Show("Please enter your Address!", caption, btn, ico)
            txtAddress.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtEmail.Text) Then
            MessageBox.Show("Please enter your email!", caption, btn, ico)
            txtEmail.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtContactNumber.Text) Then
            MessageBox.Show("Please enter your Contact Number!", caption, btn, ico)
            txtContactNumber.Select()
            Return
        End If

        If String.IsNullOrEmpty(txtGender.Text) Then
            MessageBox.Show("Please enter your Gender!", caption, btn, ico)
            txtGender.Select()
            Return
        End If

        If txtCustomerID.Text = "" Then

            MessageBox.Show("Please input Customer ID!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            Dim connection As New SqlConnection("Data Source =DESKTOP-2VS00LB;Initial Catalog=UserData;Integrated Security=True")
            Dim command As New SqlCommand("UPDATE CustomerDetails SET FirstName ='" & txtFirstName.Text & "', LastName = '" & txtLastName.Text & "', Email = '" & txtEmail.Text & "', Address = '" & txtAddress.Text & "', Contact_Number ='" & txtContactNumber.Text & "', Gender = '" & txtGender.Text & "' WHERE CustomerID = '" & txtCustomerID.Text & "'", connection)

            command.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = txtFirstName.Text
            command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = txtLastName.Text
            command.Parameters.Add("Email", SqlDbType.NVarChar).Value = txtEmail.Text
            command.Parameters.Add("Address", SqlDbType.NVarChar).Value = txtAddress.Text
            command.Parameters.Add("ContactNUmber", SqlDbType.NVarChar).Value = txtContactNumber.Text
            command.Parameters.Add("Gender", SqlDbType.NVarChar).Value = txtGender.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Updated!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtFirstName.Clear()
                txtLastName.Clear()
                txtAddress.Clear()
                txtEmail.Clear()
                txtCustomerID.Clear()
                txtGender.Clear()
                txtContactNumber.Clear()
                txtCustomerID.Enabled = True
            Else
                MessageBox.Show("Data Not Updated", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            connection.Close()
        End If

        ShowUserData()
    End Sub
End Class