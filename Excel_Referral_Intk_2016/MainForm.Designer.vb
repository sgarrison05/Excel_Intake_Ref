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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtChildName = New System.Windows.Forms.TextBox()
        Me.lblChildName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSupervision = New System.Windows.Forms.TextBox()
        Me.txtIncidentNo = New System.Windows.Forms.TextBox()
        Me.txtOffense = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.cboxTypeRef = New System.Windows.Forms.ComboBox()
        Me.cboxRefAgency = New System.Windows.Forms.ComboBox()
        Me.cboxSubmit = New System.Windows.Forms.ComboBox()
        Me.cboxAccepted = New System.Windows.Forms.ComboBox()
        Me.cboxTempRej = New System.Windows.Forms.ComboBox()
        Me.cboxRefused = New System.Windows.Forms.ComboBox()
        Me.cboxSupCaution = New System.Windows.Forms.ComboBox()
        Me.cboxResub = New System.Windows.Forms.ComboBox()
        Me.cboxRANA = New System.Windows.Forms.ComboBox()
        Me.mtxtDateSub = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtReSubDate = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 429)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 46)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(414, 429)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 46)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtChildName
        '
        Me.txtChildName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildName.Location = New System.Drawing.Point(27, 52)
        Me.txtChildName.Name = "txtChildName"
        Me.txtChildName.Size = New System.Drawing.Size(266, 26)
        Me.txtChildName.TabIndex = 0
        '
        'lblChildName
        '
        Me.lblChildName.AutoSize = True
        Me.lblChildName.Location = New System.Drawing.Point(24, 36)
        Me.lblChildName.Name = "lblChildName"
        Me.lblChildName.Size = New System.Drawing.Size(64, 13)
        Me.lblChildName.TabIndex = 4
        Me.lblChildName.Text = "Child Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Referral Agency:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(533, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date Submitted:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(429, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Submit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Accepted:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Temp Reject:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Refused:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Sup Cautioned:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(428, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ReSub:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(533, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "ReSub Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Notes:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(650, 179)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "RANA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Supervision:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(165, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Incident #:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(650, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Type:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(350, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Offense:"
        '
        'txtSupervision
        '
        Me.txtSupervision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupervision.Location = New System.Drawing.Point(27, 276)
        Me.txtSupervision.Name = "txtSupervision"
        Me.txtSupervision.Size = New System.Drawing.Size(266, 26)
        Me.txtSupervision.TabIndex = 11
        '
        'txtIncidentNo
        '
        Me.txtIncidentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncidentNo.Location = New System.Drawing.Point(168, 121)
        Me.txtIncidentNo.Name = "txtIncidentNo"
        Me.txtIncidentNo.Size = New System.Drawing.Size(140, 26)
        Me.txtIncidentNo.TabIndex = 4
        '
        'txtOffense
        '
        Me.txtOffense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffense.Location = New System.Drawing.Point(353, 52)
        Me.txtOffense.Name = "txtOffense"
        Me.txtOffense.Size = New System.Drawing.Size(266, 26)
        Me.txtOffense.TabIndex = 1
        '
        'txtNotes
        '
        Me.txtNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(27, 338)
        Me.txtNotes.MaxLength = 100
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(361, 56)
        Me.txtNotes.TabIndex = 12
        '
        'cboxTypeRef
        '
        Me.cboxTypeRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTypeRef.FormattingEnabled = True
        Me.cboxTypeRef.Location = New System.Drawing.Point(653, 52)
        Me.cboxTypeRef.Name = "cboxTypeRef"
        Me.cboxTypeRef.Size = New System.Drawing.Size(66, 28)
        Me.cboxTypeRef.TabIndex = 2
        '
        'cboxRefAgency
        '
        Me.cboxRefAgency.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxRefAgency.FormattingEnabled = True
        Me.cboxRefAgency.Location = New System.Drawing.Point(27, 121)
        Me.cboxRefAgency.Name = "cboxRefAgency"
        Me.cboxRefAgency.Size = New System.Drawing.Size(104, 28)
        Me.cboxRefAgency.TabIndex = 3
        '
        'cboxSubmit
        '
        Me.cboxSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxSubmit.FormattingEnabled = True
        Me.cboxSubmit.Location = New System.Drawing.Point(432, 121)
        Me.cboxSubmit.Name = "cboxSubmit"
        Me.cboxSubmit.Size = New System.Drawing.Size(66, 28)
        Me.cboxSubmit.TabIndex = 5
        '
        'cboxAccepted
        '
        Me.cboxAccepted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxAccepted.FormattingEnabled = True
        Me.cboxAccepted.Location = New System.Drawing.Point(9, 33)
        Me.cboxAccepted.Name = "cboxAccepted"
        Me.cboxAccepted.Size = New System.Drawing.Size(66, 28)
        Me.cboxAccepted.TabIndex = 0
        '
        'cboxTempRej
        '
        Me.cboxTempRej.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxTempRej.FormattingEnabled = True
        Me.cboxTempRej.Location = New System.Drawing.Point(98, 33)
        Me.cboxTempRej.Name = "cboxTempRej"
        Me.cboxTempRej.Size = New System.Drawing.Size(66, 28)
        Me.cboxTempRej.TabIndex = 1
        '
        'cboxRefused
        '
        Me.cboxRefused.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxRefused.FormattingEnabled = True
        Me.cboxRefused.Location = New System.Drawing.Point(190, 33)
        Me.cboxRefused.Name = "cboxRefused"
        Me.cboxRefused.Size = New System.Drawing.Size(66, 28)
        Me.cboxRefused.TabIndex = 2
        '
        'cboxSupCaution
        '
        Me.cboxSupCaution.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxSupCaution.FormattingEnabled = True
        Me.cboxSupCaution.Location = New System.Drawing.Point(279, 33)
        Me.cboxSupCaution.Name = "cboxSupCaution"
        Me.cboxSupCaution.Size = New System.Drawing.Size(66, 28)
        Me.cboxSupCaution.TabIndex = 3
        '
        'cboxResub
        '
        Me.cboxResub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxResub.FormattingEnabled = True
        Me.cboxResub.Location = New System.Drawing.Point(431, 197)
        Me.cboxResub.Name = "cboxResub"
        Me.cboxResub.Size = New System.Drawing.Size(66, 28)
        Me.cboxResub.TabIndex = 8
        '
        'cboxRANA
        '
        Me.cboxRANA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxRANA.FormattingEnabled = True
        Me.cboxRANA.Location = New System.Drawing.Point(653, 195)
        Me.cboxRANA.Name = "cboxRANA"
        Me.cboxRANA.Size = New System.Drawing.Size(66, 28)
        Me.cboxRANA.TabIndex = 10
        '
        'mtxtDateSub
        '
        Me.mtxtDateSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtDateSub.Location = New System.Drawing.Point(536, 121)
        Me.mtxtDateSub.Mask = "00/00/0000"
        Me.mtxtDateSub.Name = "mtxtDateSub"
        Me.mtxtDateSub.Size = New System.Drawing.Size(93, 26)
        Me.mtxtDateSub.TabIndex = 6
        Me.mtxtDateSub.ValidatingType = GetType(Date)
        '
        'mtxtReSubDate
        '
        Me.mtxtReSubDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtReSubDate.Location = New System.Drawing.Point(536, 197)
        Me.mtxtReSubDate.Mask = "00/00/0000"
        Me.mtxtReSubDate.Name = "mtxtReSubDate"
        Me.mtxtReSubDate.Size = New System.Drawing.Size(93, 26)
        Me.mtxtReSubDate.TabIndex = 9
        Me.mtxtReSubDate.ValidatingType = GetType(Date)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboxSupCaution)
        Me.GroupBox1.Controls.Add(Me.cboxRefused)
        Me.GroupBox1.Controls.Add(Me.cboxTempRej)
        Me.GroupBox1.Controls.Add(Me.cboxAccepted)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 80)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Case Status:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Excel Files|*.xls*|All Files|*.*"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(605, 429)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 46)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 500)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mtxtReSubDate)
        Me.Controls.Add(Me.mtxtDateSub)
        Me.Controls.Add(Me.cboxRANA)
        Me.Controls.Add(Me.cboxResub)
        Me.Controls.Add(Me.cboxSubmit)
        Me.Controls.Add(Me.cboxRefAgency)
        Me.Controls.Add(Me.cboxTypeRef)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtOffense)
        Me.Controls.Add(Me.txtIncidentNo)
        Me.Controls.Add(Me.txtSupervision)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblChildName)
        Me.Controls.Add(Me.txtChildName)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intake Submissions Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtChildName As System.Windows.Forms.TextBox
    Friend WithEvents lblChildName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSupervision As System.Windows.Forms.TextBox
    Friend WithEvents txtIncidentNo As System.Windows.Forms.TextBox
    Friend WithEvents txtOffense As System.Windows.Forms.TextBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents cboxTypeRef As System.Windows.Forms.ComboBox
    Friend WithEvents cboxRefAgency As System.Windows.Forms.ComboBox
    Friend WithEvents cboxSubmit As System.Windows.Forms.ComboBox
    Friend WithEvents cboxAccepted As System.Windows.Forms.ComboBox
    Friend WithEvents cboxTempRej As System.Windows.Forms.ComboBox
    Friend WithEvents cboxRefused As System.Windows.Forms.ComboBox
    Friend WithEvents cboxSupCaution As System.Windows.Forms.ComboBox
    Friend WithEvents cboxResub As System.Windows.Forms.ComboBox
    Friend WithEvents cboxRANA As System.Windows.Forms.ComboBox
    Friend WithEvents mtxtDateSub As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtxtReSubDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
