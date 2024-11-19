Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.Cursors
Public Class EditDataForm
    Private connectionString As String = "Server=localhost;Database=BarcodeDB;Uid=root;Pwd=;"
    Public Property ID As Integer
    Private Sub EditDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.AddRange(New String() {"Reflow to Line", "Pending EPP", "Pending Claim", "Sent to MI/SMT", "Scrap", "Rework"})
        SetReadOnlyFields()
    End Sub

    ' Method to set fields as read-only
    Private Sub SetReadOnlyFields()
        txtSerialNumber.ReadOnly = True
        txtPartNumber.ReadOnly = True
        txtTASNo.ReadOnly = True
        txtTASComment.ReadOnly = True
        calendar.Enabled = False

    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim status As String = cmbStatus.SelectedItem.ToString()
        Dim Comment As String = txtEditComment.Text

        ' Validate the status (prevent other status being keyin)
        If Not cmbStatus.Items.Contains(status) Then
            MessageBox.Show("Please select a proper Status.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE Barcodes SET Status = @Status, Comment = @Comment WHERE ID = @ID"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@Comment", Comment)
                command.Parameters.AddWithValue("@ID", ID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Data updated successfully.")
        Me.Close()
    End Sub


End Class