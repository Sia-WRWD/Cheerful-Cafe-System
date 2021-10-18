Public Class HistoryForm

    'History Form
    Private Sub HistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowUserData()
        lblDate.Text = DateTime.Now.ToLongDateString
        Timer1.Start()
    End Sub

    'DGV
    Private Sub ShowUserData()

        Dim UserData As DataTable = ExecuteSQL("SELECT OrderID, Username, CustomerID, Cappucino, Americano, Espresso,
                                                Latte, Rootbeer, Green_Latte, Hot_Chocolate, Pepermint, Lemon, Ice_Cream,
                                                Chocolate_Cake, Strawberry_Cake, DChocolate_Cake, Fruit_Cake, Red_Cake,
                                                Coffee_Cake, Forest_Cake, Ice_Cake, Subtotal, Total, Amount_Paid, Change FROM Order_Payment")

        With DGV

            .DataSource = UserData
            .Columns(0).HeaderText = "OrderID"
            .Columns(1).HeaderText = "Staff"
            .Columns(2).HeaderText = "CustomerID"
            .Columns(3).HeaderText = "Cappucino"
            .Columns(4).HeaderText = "Americano"
            .Columns(5).HeaderText = "Espresso"
            .Columns(6).HeaderText = "Latte"
            .Columns(7).HeaderText = "Rootbeer"
            .Columns(8).HeaderText = "Green_Latte"
            .Columns(9).HeaderText = "Hot_Chocolate"
            .Columns(10).HeaderText = "Pepermint"
            .Columns(11).HeaderText = "Lemon"
            .Columns(12).HeaderText = "Ice_Cream"
            .Columns(13).HeaderText = "Chocolate_Cake"
            .Columns(14).HeaderText = "Strawberry_Cake"
            .Columns(15).HeaderText = "DChocolate_Cake"
            .Columns(16).HeaderText = "Fruit_Cake"
            .Columns(17).HeaderText = "Red_Cake"
            .Columns(18).HeaderText = "Coffee_Cake"
            .Columns(19).HeaderText = "Forest_Cake"
            .Columns(20).HeaderText = "Ice_Cake"
            .Columns(21).HeaderText = "Subtotal"
            .Columns(22).HeaderText = "Total"
            .Columns(23).HeaderText = "Amount_Paid"
            .Columns(24).HeaderText = "Change"
        End With
    End Sub

    'Button Back
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainForm.Show()
        Me.Close()
    End Sub

    'Timer1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToLongTimeString
    End Sub

End Class