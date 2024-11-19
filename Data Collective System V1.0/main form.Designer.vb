<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDCS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDCS))
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPN = New System.Windows.Forms.Label()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.lblTAS = New System.Windows.Forms.Label()
        Me.lblTASComment = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.btnViewData = New System.Windows.Forms.Button()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.txtTASNo = New System.Windows.Forms.TextBox()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.txtTASComment = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblDate.Location = New System.Drawing.Point(132, 246)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(88, 32)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date : "
        '
        'lblPN
        '
        Me.lblPN.AutoSize = True
        Me.lblPN.BackColor = System.Drawing.Color.Transparent
        Me.lblPN.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblPN.Location = New System.Drawing.Point(37, 290)
        Me.lblPN.Name = "lblPN"
        Me.lblPN.Size = New System.Drawing.Size(183, 32)
        Me.lblPN.TabIndex = 1
        Me.lblPN.Text = "Part Number : "
        '
        'lblSN
        '
        Me.lblSN.AutoSize = True
        Me.lblSN.BackColor = System.Drawing.Color.Transparent
        Me.lblSN.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblSN.Location = New System.Drawing.Point(21, 331)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Size = New System.Drawing.Size(199, 32)
        Me.lblSN.TabIndex = 2
        Me.lblSN.Text = "Serial Number : "
        '
        'lblTAS
        '
        Me.lblTAS.AutoSize = True
        Me.lblTAS.BackColor = System.Drawing.Color.Transparent
        Me.lblTAS.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTAS.Location = New System.Drawing.Point(42, 372)
        Me.lblTAS.Name = "lblTAS"
        Me.lblTAS.Size = New System.Drawing.Size(178, 32)
        Me.lblTAS.TabIndex = 3
        Me.lblTAS.Text = "TAS Number : "
        '
        'lblTASComment
        '
        Me.lblTASComment.AutoSize = True
        Me.lblTASComment.BackColor = System.Drawing.Color.Transparent
        Me.lblTASComment.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTASComment.Location = New System.Drawing.Point(25, 413)
        Me.lblTASComment.Name = "lblTASComment"
        Me.lblTASComment.Size = New System.Drawing.Size(195, 32)
        Me.lblTASComment.TabIndex = 4
        Me.lblTASComment.Text = "TAS Comment : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(116, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status : "
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Fuchsia
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(795, 405)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(163, 87)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnScan
        '
        Me.btnScan.BackColor = System.Drawing.Color.Red
        Me.btnScan.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnScan.Location = New System.Drawing.Point(795, 305)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(163, 87)
        Me.btnScan.TabIndex = 7
        Me.btnScan.Text = "Scan New Barcode"
        Me.btnScan.UseVisualStyleBackColor = False
        '
        'btnViewData
        '
        Me.btnViewData.BackColor = System.Drawing.Color.Blue
        Me.btnViewData.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnViewData.Location = New System.Drawing.Point(795, 116)
        Me.btnViewData.Name = "btnViewData"
        Me.btnViewData.Size = New System.Drawing.Size(163, 87)
        Me.btnViewData.TabIndex = 8
        Me.btnViewData.Text = "View Data"
        Me.btnViewData.UseVisualStyleBackColor = False
        '
        'txtPartNumber
        '
        Me.txtPartNumber.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPartNumber.Location = New System.Drawing.Point(226, 290)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.Size = New System.Drawing.Size(170, 35)
        Me.txtPartNumber.TabIndex = 9
        '
        'txtTASNo
        '
        Me.txtTASNo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTASNo.Location = New System.Drawing.Point(226, 372)
        Me.txtTASNo.Name = "txtTASNo"
        Me.txtTASNo.Size = New System.Drawing.Size(175, 35)
        Me.txtTASNo.TabIndex = 10
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSerialNumber.Location = New System.Drawing.Point(226, 331)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(170, 35)
        Me.txtSerialNumber.TabIndex = 11
        '
        'txtTASComment
        '
        Me.txtTASComment.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTASComment.Location = New System.Drawing.Point(226, 413)
        Me.txtTASComment.Name = "txtTASComment"
        Me.txtTASComment.Size = New System.Drawing.Size(245, 35)
        Me.txtTASComment.TabIndex = 12
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(226, 454)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(217, 38)
        Me.cmbStatus.TabIndex = 13
        '
        'calendar
        '
        Me.calendar.Location = New System.Drawing.Point(226, 116)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 14
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(21, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(657, 65)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Data Collective System V1.0"
        '
        'dataGridView
        '
        Me.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView.Location = New System.Drawing.Point(12, 498)
        Me.dataGridView.Name = "dataGridView"
        Me.dataGridView.RowTemplate.Height = 25
        Me.dataGridView.Size = New System.Drawing.Size(946, 133)
        Me.dataGridView.TabIndex = 16
        '
        'frmDCS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(970, 654)
        Me.Controls.Add(Me.dataGridView)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtTASComment)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.txtTASNo)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.btnViewData)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTASComment)
        Me.Controls.Add(Me.lblTAS)
        Me.Controls.Add(Me.lblSN)
        Me.Controls.Add(Me.lblPN)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "frmDCS"
        Me.Text = "Data Collective System V1.0"
        CType(Me.dataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblPN As Label
    Friend WithEvents lblSN As Label
    Friend WithEvents lblTAS As Label
    Friend WithEvents lblTASComment As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnScan As Button
    Friend WithEvents btnViewData As Button
    Friend WithEvents txtPartNumber As TextBox
    Friend WithEvents txtTASNo As TextBox
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents txtTASComment As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents lblTitle As Label
    Friend WithEvents dataGridView As DataGridView
End Class
