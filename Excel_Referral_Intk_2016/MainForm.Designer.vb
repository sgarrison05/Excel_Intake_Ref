<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txbChildName = New System.Windows.Forms.TextBox()
        Me.lblChildName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateSub = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblIntakeComp = New System.Windows.Forms.Label()
        Me.lblCaseNo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txbIncidentNo = New System.Windows.Forms.TextBox()
        Me.txbOffense = New System.Windows.Forms.TextBox()
        Me.txbNotes = New System.Windows.Forms.TextBox()
        Me.cmbRefAgency = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.dteDateSub = New System.Windows.Forms.MaskedTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblFileLoc = New System.Windows.Forms.Label()
        Me.txbFileName = New System.Windows.Forms.TextBox()
        Me.cmbIntakeComp = New System.Windows.Forms.ComboBox()
        Me.dteLastStatus = New System.Windows.Forms.MaskedTextBox()
        Me.lblDateStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(44, 347)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(114, 46)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(234, 347)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(114, 46)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(431, 347)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(114, 46)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txbChildName
        '
        Me.txbChildName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbChildName.Location = New System.Drawing.Point(27, 90)
        Me.txbChildName.Name = "txbChildName"
        Me.txbChildName.Size = New System.Drawing.Size(266, 26)
        Me.txbChildName.TabIndex = 0
        '
        'lblChildName
        '
        Me.lblChildName.AutoSize = True
        Me.lblChildName.Location = New System.Drawing.Point(24, 74)
        Me.lblChildName.Name = "lblChildName"
        Me.lblChildName.Size = New System.Drawing.Size(64, 13)
        Me.lblChildName.TabIndex = 4
        Me.lblChildName.Text = "Child Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Referral Agency:"
        '
        'lblDateSub
        '
        Me.lblDateSub.AutoSize = True
        Me.lblDateSub.Location = New System.Drawing.Point(24, 191)
        Me.lblDateSub.Name = "lblDateSub"
        Me.lblDateSub.Size = New System.Drawing.Size(83, 13)
        Me.lblDateSub.TabIndex = 6
        Me.lblDateSub.Text = "Date Submitted:"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(190, 131)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Notes:"
        '
        'lblIntakeComp
        '
        Me.lblIntakeComp.AutoSize = True
        Me.lblIntakeComp.Location = New System.Drawing.Point(409, 131)
        Me.lblIntakeComp.Name = "lblIntakeComp"
        Me.lblIntakeComp.Size = New System.Drawing.Size(93, 13)
        Me.lblIntakeComp.TabIndex = 16
        Me.lblIntakeComp.Text = "Intake Completed:"
        '
        'lblCaseNo
        '
        Me.lblCaseNo.AutoSize = True
        Me.lblCaseNo.Location = New System.Drawing.Point(25, 131)
        Me.lblCaseNo.Name = "lblCaseNo"
        Me.lblCaseNo.Size = New System.Drawing.Size(64, 13)
        Me.lblCaseNo.TabIndex = 17
        Me.lblCaseNo.Text = "Case No: #:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(481, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Offense:"
        '
        'txbIncidentNo
        '
        Me.txbIncidentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbIncidentNo.Location = New System.Drawing.Point(28, 147)
        Me.txbIncidentNo.Name = "txbIncidentNo"
        Me.txbIncidentNo.Size = New System.Drawing.Size(140, 26)
        Me.txbIncidentNo.TabIndex = 3
        '
        'txbOffense
        '
        Me.txbOffense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbOffense.Location = New System.Drawing.Point(484, 90)
        Me.txbOffense.Name = "txbOffense"
        Me.txbOffense.Size = New System.Drawing.Size(266, 26)
        Me.txbOffense.TabIndex = 2
        '
        'txbNotes
        '
        Me.txbNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNotes.Location = New System.Drawing.Point(28, 266)
        Me.txbNotes.MaxLength = 100
        Me.txbNotes.Multiline = True
        Me.txbNotes.Name = "txbNotes"
        Me.txbNotes.Size = New System.Drawing.Size(361, 56)
        Me.txbNotes.TabIndex = 8
        '
        'cmbRefAgency
        '
        Me.cmbRefAgency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRefAgency.FormattingEnabled = True
        Me.cmbRefAgency.Location = New System.Drawing.Point(321, 90)
        Me.cmbRefAgency.Name = "cmbRefAgency"
        Me.cmbRefAgency.Size = New System.Drawing.Size(139, 28)
        Me.cmbRefAgency.TabIndex = 1
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(193, 147)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(181, 28)
        Me.cmbStatus.TabIndex = 4
        '
        'dteDateSub
        '
        Me.dteDateSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteDateSub.Location = New System.Drawing.Point(27, 207)
        Me.dteDateSub.Mask = "00/00/0000"
        Me.dteDateSub.Name = "dteDateSub"
        Me.dteDateSub.Size = New System.Drawing.Size(93, 26)
        Me.dteDateSub.TabIndex = 6
        Me.dteDateSub.ValidatingType = GetType(Date)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Excel Files|*.xls*|All Files|*.*"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(622, 347)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 46)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblFileLoc
        '
        Me.lblFileLoc.AutoSize = True
        Me.lblFileLoc.Location = New System.Drawing.Point(20, 19)
        Me.lblFileLoc.Name = "lblFileLoc"
        Me.lblFileLoc.Size = New System.Drawing.Size(70, 13)
        Me.lblFileLoc.TabIndex = 22
        Me.lblFileLoc.Text = "File Location:"
        '
        'txbFileName
        '
        Me.txbFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbFileName.Location = New System.Drawing.Point(91, 12)
        Me.txbFileName.Name = "txbFileName"
        Me.txbFileName.ReadOnly = True
        Me.txbFileName.Size = New System.Drawing.Size(662, 26)
        Me.txbFileName.TabIndex = 21
        '
        'cmbIntakeComp
        '
        Me.cmbIntakeComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIntakeComp.FormattingEnabled = True
        Me.cmbIntakeComp.Location = New System.Drawing.Point(412, 147)
        Me.cmbIntakeComp.Name = "cmbIntakeComp"
        Me.cmbIntakeComp.Size = New System.Drawing.Size(174, 28)
        Me.cmbIntakeComp.TabIndex = 5
        '
        'dteLastStatus
        '
        Me.dteLastStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dteLastStatus.Location = New System.Drawing.Point(200, 207)
        Me.dteLastStatus.Mask = "00/00/0000"
        Me.dteLastStatus.Name = "dteLastStatus"
        Me.dteLastStatus.Size = New System.Drawing.Size(93, 26)
        Me.dteLastStatus.TabIndex = 7
        Me.dteLastStatus.ValidatingType = GetType(Date)
        '
        'lblDateStatus
        '
        Me.lblDateStatus.AutoSize = True
        Me.lblDateStatus.Location = New System.Drawing.Point(193, 191)
        Me.lblDateStatus.Name = "lblDateStatus"
        Me.lblDateStatus.Size = New System.Drawing.Size(90, 13)
        Me.lblDateStatus.TabIndex = 25
        Me.lblDateStatus.Text = "Last Case Status:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 417)
        Me.Controls.Add(Me.dteLastStatus)
        Me.Controls.Add(Me.lblDateStatus)
        Me.Controls.Add(Me.cmbIntakeComp)
        Me.Controls.Add(Me.lblFileLoc)
        Me.Controls.Add(Me.txbFileName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.dteDateSub)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbRefAgency)
        Me.Controls.Add(Me.txbNotes)
        Me.Controls.Add(Me.txbOffense)
        Me.Controls.Add(Me.txbIncidentNo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblCaseNo)
        Me.Controls.Add(Me.lblIntakeComp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblDateSub)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblChildName)
        Me.Controls.Add(Me.txbChildName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intake Submissions Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txbChildName As System.Windows.Forms.TextBox
    Friend WithEvents lblChildName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDateSub As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblIntakeComp As System.Windows.Forms.Label
    Friend WithEvents lblCaseNo As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txbIncidentNo As System.Windows.Forms.TextBox
    Friend WithEvents txbOffense As System.Windows.Forms.TextBox
    Friend WithEvents txbNotes As System.Windows.Forms.TextBox
    Friend WithEvents cmbRefAgency As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dteDateSub As System.Windows.Forms.MaskedTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblFileLoc As Label
    Friend WithEvents txbFileName As TextBox
    Friend WithEvents cmbIntakeComp As ComboBox
    Friend WithEvents dteLastStatus As MaskedTextBox
    Friend WithEvents lblDateStatus As Label
End Class
