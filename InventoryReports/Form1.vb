' Johnathan R. Burgess CSC-289 Inventory Report Generator
' April 30th, 2019
Public Class MainFrm
    Dim ReportFrm As Report
    Private Sub InventoryReportsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventoryReportsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventoryReportsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Items' table. You can move, or remove it, as needed.
        Me.ItemsTableAdapter.Fill(Me.TailoringBusinessDataSet.Items)
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.InventoryReports' table. You can move, or remove it, as needed.
        Me.InventoryReportsTableAdapter.Fill(Me.TailoringBusinessDataSet.InventoryReports)
        Me.ItemsTableAdapter.Fill(Me.TailoringBusinessDataSet.Items)
    End Sub
    Private Sub BtnGetReport_Click(sender As Object, e As EventArgs) Handles btnGetReport.Click
        Dim strSql As String = "SELECT * FROM Items"

        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=C:\Users\ryanb\source\repos\InventoryReports\InventoryReports\TailoringBusiness.accdb"
        Dim odaItems As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decValue As Decimal = 0D

        odaItems.Fill(datValue)
        odaItems.Dispose()
        decValue = Convert.ToDecimal(datValue.Rows(Convert.ToInt32(inputID.Text) - 1)("Quantity"))

        ReportFrm = New Report
        ReportFrm.Show()
        ReportFrm.Activate()

        If (decValue < 10) Then
            ReportFrm.lblOrderMore.Text = "You need to go ahead and order " & (25 - decValue) & " more of those!"
        End If

        ReportFrm.bllTotalQuantity.Text = decValue.ToString()

    End Sub
End Class
