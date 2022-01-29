Imports System.Data.SqlClient

Public Class records
    'Form Load
    Private Sub records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGProp()
    End Sub

    'Properties of Data Grid View
    Sub DGProp()
        DataGridView1.DefaultCellStyle.Font = New Font("Tahoma", 15)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Me.Close()
    End Sub
End Class