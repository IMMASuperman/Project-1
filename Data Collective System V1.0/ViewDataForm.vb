Imports MySql.Data.MySqlClient
Public Class ViewDataForm
    Private connectionString As String = "Server=localhost;Database=BarcodeDB;Uid=root;Pwd=;"
    Private Sub ViewDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData(Optional ByVal filter As String = "")
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM Barcodes"
            If Not String.IsNullOrEmpty(filter) Then
                query &= " WHERE SerialNumber LIKE @Filter OR PartNumber LIKE @Filter"
            End If
            Using command As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(filter) Then
                    command.Parameters.AddWithValue("@Filter", "%" & filter & "%")
                End If
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView.DataSource = table
            End Using
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData(txtSearch.Text)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dataGridView.SelectedRows.Count > 0 Then
            Dim editForm As New EditDataForm()
            editForm.txtSerialNumber.Text = dataGridView.SelectedRows(0).Cells("SerialNumber").Value.ToString()
            editForm.txtPartNumber.Text = dataGridView.SelectedRows(0).Cells("PartNumber").Value.ToString()
            editForm.calendar.SelectionStart = Convert.ToDateTime(dataGridView.SelectedRows(0).Cells("ScanDate").Value)
            editForm.txtTASNo.Text = dataGridView.SelectedRows(0).Cells("TASNo").Value.ToString()
            editForm.txtTASComment.Text = dataGridView.SelectedRows(0).Cells("TASComment").Value.ToString()
            editForm.cmbStatus.SelectedItem = dataGridView.SelectedRows(0).Cells("Status").Value.ToString()
            editForm.txtEditComment.Text = dataGridView.SelectedRows(0).Cells("Comment").Value.ToString()
            editForm.ID = Convert.ToInt32(dataGridView.SelectedRows(0).Cells("ID").Value)
            editForm.ShowDialog()
            LoadData()
        Else
            MessageBox.Show("Please select a record to edit.")
        End If
    End Sub

End Class