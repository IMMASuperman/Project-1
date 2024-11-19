Imports MySql.Data.MySqlClient


Public Class frmDCS

    Private connectionString As String = "Server=localhost;Database=BarcodeDB;Uid=root;Pwd=;"

    Private Sub frmDCS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.AddRange(New String() {"Reflow to Line", "Pending EPP", "Pending Claim", "Sent to MI/SMT", "Scrap", "Rework"})
        LoadData()
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        Dim barcode As String = InputBox("Scan the 2D barcode")
        If barcode.Length = 17 Then
            txtSerialNumber.Text = barcode.Substring(0, 7)
            txtPartNumber.Text = barcode.Substring(7, 10)
        Else
            MessageBox.Show("Invalid barcode length. Please scan again.")
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim serialNumber As String = txtSerialNumber.Text
        Dim partNumber As String = txtPartNumber.Text
        Dim scanDate As DateTime = calendar.SelectionStart
        Dim tasNo As String = txtTASNo.Text
        Dim tasComment As String = txtTASComment.Text
        Dim status As String = cmbStatus.SelectedItem.ToString()

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO Barcodes (SerialNumber, PartNumber, ScanDate, TASNo, TASComment, Status) VALUES (@SerialNumber, @PartNumber, @ScanDate, @TASNo, @TASComment, @Status)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@SerialNumber", serialNumber)
                command.Parameters.AddWithValue("@PartNumber", partNumber)
                command.Parameters.AddWithValue("@ScanDate", scanDate)
                command.Parameters.AddWithValue("@TASNo", tasNo)
                command.Parameters.AddWithValue("@TASComment", tasComment)
                command.Parameters.AddWithValue("@Status", status)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Data saved successfully.")
        LoadData()
    End Sub


    Private Sub LoadData()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Barcodes"
            Using command As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                dataGridView.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnViewData_Click(sender As Object, e As EventArgs) Handles btnViewData.Click
        Dim viewDataForm As New ViewDataForm()
        viewDataForm.Show()
    End Sub


End Class


