Imports Microsoft.Office.Interop

Public Class frmMain

    Public Sub ClearLables()

        'Cleans form
        Me.txbChildName.Text = ""
        Me.cmbRefAgency.ResetText()
        Me.txbOffense.Text = ""
        Me.txbIncidentNo.Text = ""
        Me.cmbStatus.ResetText()
        Me.cmbIntakeComp.ResetText()
        Me.dteDateSub.Text = ""
        Me.dteLastStatus.Text = ""
        Me.txbNotes.Text = ""

        Me.txbChildName.Focus()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Add LE Agencies
        Me.cmbRefAgency.Items.Add("OPD")
        Me.cmbRefAgency.Items.Add("WOPD")
        Me.cmbRefAgency.Items.Add("OCSO")
        Me.cmbRefAgency.Items.Add("PHPD")
        Me.cmbRefAgency.Items.Add("DPS")
        Me.cmbRefAgency.Items.Add("BCPD")
        Me.cmbRefAgency.Items.Add("BCISDPD")
        Me.cmbRefAgency.Items.Add("VPD")
        Me.cmbRefAgency.Items.Add("VISDPD")
        Me.cmbRefAgency.Items.Add("RCMARSHAL")

        'Add Status?
        Me.cmbStatus.Items.Add("Pending")
        Me.cmbStatus.Items.Add("Under ADA Review")
        Me.cmbStatus.Items.Add("Temp Reject")
        Me.cmbStatus.Items.Add("Offer DP")
        Me.cmbStatus.Items.Add("Refused")

        'Add Intake Completed?
        Me.cmbIntakeComp.Items.Add("Yes")
        Me.cmbIntakeComp.Items.Add("Set")
        Me.cmbIntakeComp.Items.Add("Needs Setting")
        Me.cmbIntakeComp.Items.Add("Needs Resetting")
        Me.cmbIntakeComp.Items.Add("Unable to Locate")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'close application
        Me.Close()

    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Me.OpenFileDialog1.FileName = Nothing

        If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            Me.txbFileName.Text = Me.OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Call ClearLables()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'open workbook and make is visible
        Dim MyExcel As New Excel.Application
        Dim wb As Excel.Workbook = MyExcel.Workbooks.Open(Me.txbFileName.Text, False, False)
        Dim ws As Excel.Worksheet = wb.Sheets("sheet1")
        MyExcel.Visible = True

        'write in cell
        ws.Cells(6, 1).Value = txbChildName.Text
        ws.Cells(6, 2).Value = cmbRefAgency.Text
        ws.Cells(6, 3).Value = txbOffense.Text
        ws.Cells(6, 4).Value = txbIncidentNo.Text
        ws.Cells(6, 5).Value = cmbStatus.Text
        ws.Cells(6, 6).Value = cmbIntakeComp.Text
        ws.Cells(6, 7).Value = dteDateSub.Text
        ws.Cells(6, 9).Value = dteLastStatus.Text
        ws.Cells(6, 12).Value = txbNotes.Text

        'This will automatically overwrite and save without interaction
        wb.Save()

        'close workbook
        MyExcel.Quit()

        'Release objects so the application closes down and behaves correctly
        ReleaseObject(ws)
        ReleaseObject(wb)
        ReleaseObject(MyExcel)


    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)

        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try

    End Sub

End Class
