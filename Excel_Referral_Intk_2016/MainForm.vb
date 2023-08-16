Imports Microsoft.Office.Interop

Public Class frmMain

    Public Sub ClearLables()

        'Cleans form
        Me.txtChildName.Text = ""
        Me.txtIncidentNo.Text = ""
        Me.txtOffense.Text = ""
        Me.txtSupervision.Text = ""
        Me.txtNotes.Text = ""
        Me.cboxTypeRef.ResetText()
        Me.cboxRefAgency.ResetText()
        Me.cboxSubmit.ResetText()
        Me.cboxAccepted.ResetText()
        Me.cboxTempRej.ResetText()
        Me.cboxRefused.ResetText()
        Me.cboxSupCaution.ResetText()
        Me.cboxResub.ResetText()
        Me.cboxRANA.ResetText()
        Me.mtxtDateSub.Text = ""
        Me.mtxtReSubDate.Text = ""


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Dim wb = EXL.Application.ActiveWorkbook
        'Dim ws = EXL.Application.ActiveSheet

        'add Type of Referral
        Me.cboxTypeRef.Items.Add("Yes")
        Me.cboxTypeRef.Items.Add("No")

        'Add LE Agencies
        Me.cboxRefAgency.Items.Add("OPD")
        Me.cboxRefAgency.Items.Add("WOPD")
        Me.cboxRefAgency.Items.Add("OCSO")
        Me.cboxRefAgency.Items.Add("PHPD")
        Me.cboxRefAgency.Items.Add("DPS")
        Me.cboxRefAgency.Items.Add("BCPD")
        Me.cboxRefAgency.Items.Add("BCISDPD")
        Me.cboxRefAgency.Items.Add("VPD")
        Me.cboxRefAgency.Items.Add("VISDPD")
        Me.cboxRefAgency.Items.Add("RCMARSHAL")

        'Add Submitted?
        Me.cboxSubmit.Items.Add("Yes")
        Me.cboxSubmit.Items.Add("No")

        'Add Accepted?
        Me.cboxAccepted.Items.Add("Yes")
        Me.cboxAccepted.Items.Add("No")

        'Add Temp Rejected?
        Me.cboxTempRej.Items.Add("Yes")
        Me.cboxTempRej.Items.Add("No")

        'Add Refused?
        Me.cboxRefused.Items.Add("Yes")
        Me.cboxRefused.Items.Add("No")

        'Add Supervisory Cautioned?
        Me.cboxSupCaution.Items.Add("Yes")
        Me.cboxSupCaution.Items.Add("No")

        'Add Resub?
        Me.cboxResub.Items.Add("Yes")
        Me.cboxResub.Items.Add("No")

        'Add RANA
        Me.cboxRANA.Items.Add("Yes")
        Me.cboxRANA.Items.Add("No")




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
        ws.Cells(1, 1).Value = "Test 3"


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
