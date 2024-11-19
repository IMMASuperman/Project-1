<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditDataForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditDataForm))
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtTASComment = New System.Windows.Forms.TextBox()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.txtTASNo = New System.Windows.Forms.TextBox()
        Me.txtPartNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTASComment = New System.Windows.Forms.Label()
        Me.lblTAS = New System.Windows.Forms.Label()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.lblPN = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtEditComment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'calendar
        '
        Me.calendar.BackColor = System.Drawing.Color.Gray
        Me.calendar.Cursor = System.Windows.Forms.Cursors.No
        Me.calendar.Location = New System.Drawing.Point(231, 63)
        Me.calendar.Name = "calendar"
        Me.calendar.TabIndex = 26
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(231, 460)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(170, 38)
        Me.cmbStatus.TabIndex = 25
        '
        'txtTASComment
        '
        Me.txtTASComment.BackColor = System.Drawing.Color.DimGray
        Me.txtTASComment.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTASComment.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTASComment.Location = New System.Drawing.Point(231, 360)
        Me.txtTASComment.Name = "txtTASComment"
        Me.txtTASComment.ReadOnly = True
        Me.txtTASComment.Size = New System.Drawing.Size(245, 35)
        Me.txtTASComment.TabIndex = 24
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.BackColor = System.Drawing.Color.DimGray
        Me.txtSerialNumber.Cursor = System.Windows.Forms.Cursors.No
        Me.txtSerialNumber.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSerialNumber.Location = New System.Drawing.Point(231, 278)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.ReadOnly = True
        Me.txtSerialNumber.Size = New System.Drawing.Size(170, 35)
        Me.txtSerialNumber.TabIndex = 23
        '
        'txtTASNo
        '
        Me.txtTASNo.BackColor = System.Drawing.Color.DimGray
        Me.txtTASNo.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTASNo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtTASNo.Location = New System.Drawing.Point(231, 319)
        Me.txtTASNo.Name = "txtTASNo"
        Me.txtTASNo.ReadOnly = True
        Me.txtTASNo.Size = New System.Drawing.Size(170, 35)
        Me.txtTASNo.TabIndex = 22
        '
        'txtPartNumber
        '
        Me.txtPartNumber.BackColor = System.Drawing.Color.DimGray
        Me.txtPartNumber.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPartNumber.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtPartNumber.Location = New System.Drawing.Point(231, 237)
        Me.txtPartNumber.Name = "txtPartNumber"
        Me.txtPartNumber.ReadOnly = True
        Me.txtPartNumber.Size = New System.Drawing.Size(170, 35)
        Me.txtPartNumber.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(121, 461)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Status : "
        '
        'lblTASComment
        '
        Me.lblTASComment.AutoSize = True
        Me.lblTASComment.BackColor = System.Drawing.Color.Transparent
        Me.lblTASComment.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTASComment.Location = New System.Drawing.Point(30, 360)
        Me.lblTASComment.Name = "lblTASComment"
        Me.lblTASComment.Size = New System.Drawing.Size(195, 32)
        Me.lblTASComment.TabIndex = 19
        Me.lblTASComment.Text = "TAS Comment : "
        '
        'lblTAS
        '
        Me.lblTAS.AutoSize = True
        Me.lblTAS.BackColor = System.Drawing.Color.Transparent
        Me.lblTAS.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTAS.Location = New System.Drawing.Point(47, 319)
        Me.lblTAS.Name = "lblTAS"
        Me.lblTAS.Size = New System.Drawing.Size(178, 32)
        Me.lblTAS.TabIndex = 18
        Me.lblTAS.Text = "TAS Number : "
        '
        'lblSN
        '
        Me.lblSN.AutoSize = True
        Me.lblSN.BackColor = System.Drawing.Color.Transparent
        Me.lblSN.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblSN.Location = New System.Drawing.Point(26, 278)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Size = New System.Drawing.Size(199, 32)
        Me.lblSN.TabIndex = 17
        Me.lblSN.Text = "Serial Number : "
        '
        'lblPN
        '
        Me.lblPN.AutoSize = True
        Me.lblPN.BackColor = System.Drawing.Color.Transparent
        Me.lblPN.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblPN.Location = New System.Drawing.Point(42, 237)
        Me.lblPN.Name = "lblPN"
        Me.lblPN.Size = New System.Drawing.Size(183, 32)
        Me.lblPN.TabIndex = 16
        Me.lblPN.Text = "Part Number : "
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblDate.Location = New System.Drawing.Point(137, 193)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(88, 32)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "Date : "
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle2.Font = New System.Drawing.Font("Segoe UI", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblTitle2.Location = New System.Drawing.Point(12, -2)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(247, 65)
        Me.lblTitle2.TabIndex = 27
        Me.lblTitle2.Text = "Edit Form"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(501, 63)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(192, 474)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.BackColor = System.Drawing.Color.Transparent
        Me.lblComment.Font = New System.Drawing.Font("Segoe UI", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblComment.Location = New System.Drawing.Point(79, 501)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(146, 32)
        Me.lblComment.TabIndex = 29
        Me.lblComment.Text = "Comment : "
        '
        'txtEditComment
        '
        Me.txtEditComment.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtEditComment.Location = New System.Drawing.Point(231, 502)
        Me.txtEditComment.Name = "txtEditComment"
        Me.txtEditComment.Size = New System.Drawing.Size(245, 35)
        Me.txtEditComment.TabIndex = 30
        '
        'EditDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 626)
        Me.Controls.Add(Me.txtEditComment)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.calendar)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtTASComment)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.txtTASNo)
        Me.Controls.Add(Me.txtPartNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTASComment)
        Me.Controls.Add(Me.lblTAS)
        Me.Controls.Add(Me.lblSN)
        Me.Controls.Add(Me.lblPN)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "EditDataForm"
        Me.Text = "EditDataForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calendar As MonthCalendar
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtTASComment As TextBox
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents txtTASNo As TextBox
    Friend WithEvents txtPartNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTASComment As Label
    Friend WithEvents lblTAS As Label
    Friend WithEvents lblSN As Label
    Friend WithEvents lblPN As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblComment As Label
    Friend WithEvents txtEditComment As TextBox
End Class
