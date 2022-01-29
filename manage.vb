Imports System.Data.SqlClient

Public Class manage

    'Enable the Text Fields
    Sub Enable_TEXTFIELDS()
        m1.Enabled = True
        m2.Enabled = True
        m3.Enabled = True
        m4.Enabled = True
        m5.Enabled = True
        m6.Enabled = True
        m7.Enabled = True
        m8.Enabled = True
        m9.Enabled = True
    End Sub

    'Disable the Text Fields
    Sub Disable_TEXTFIELDS()
        m1.Enabled = False
        m2.Enabled = False
        m3.Enabled = False
        m4.Enabled = False
        m5.Enabled = False
        m6.Enabled = False
        m7.Enabled = False
        m8.Enabled = False
        m9.Enabled = False
    End Sub

    'CLEAR FUNCTION
    Sub Clear()
        m00.Text = ""
        m1.Text = ""
        m2.Text = ""
        m3.Text = ""
        m4.Text = ""
        m5.Text = ""
        m6.Text = ""
        m7.Text = ""
        m8.Text = ""
        m9.Text = ""
    End Sub

    'Load Student ID in ComboBox
    Sub LOAD_SID()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        m00.Items.Clear()
        m00.Text = ""
        cmd = New SqlCommand("select substring(ID, PATINDEX('%[0-9]%', ID), LEN(ID)) from student;", con)
        dr = cmd.ExecuteReader
        While dr.Read
            m00.Items.Add(dr(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    'CLEAR BUTTON
    Private Sub CLSbutton_Click(sender As Object, e As EventArgs) Handles CLSbutton.Click
        Clear()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        dashboard.disall.Text = "    HOSTEL MANAGEMENT SYSYTEM    "
        Me.Close()
    End Sub


    'Search Button
    Private Sub STDbutton_Click(sender As Object, e As EventArgs) Handles STDbutton.Click
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim studentid As String
        Try
            studentid = "S" + m00.Text
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
            con.Open()
            da = New SqlDataAdapter("Select * from student where id = '" & studentid & "'", con)
            da.Fill(dt)
            m1.Text = dt.Rows(0).Item(1)
            m2.Text = dt.Rows(0).Item(2)
            m3.Text = dt.Rows(0).Item(3)
            m4.Text = dt.Rows(0).Item(4)
            m5.Text = dt.Rows(0).Item(5)
            m6.Text = dt.Rows(0).Item(6)
            m7.Text = dt.Rows(0).Item(7)
            m8.Text = dt.Rows(0).Item(8)
            m9.Text = dt.Rows(0).Item(9)
        Catch ex As Exception
            MsgBox("Please enter valid student ID", MsgBoxStyle.Critical, "ERROR")
        End Try
        con.Close()
        Enable_TEXTFIELDS()
    End Sub


    'DELETE BUTTON
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim studentid As String
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        If m00.Text = "" Then
            MsgBox("Please enter a valid Student ID")
        Else
            Try
                con.Open()
                studentid = "S" + m00.Text
                Dim result As DialogResult = MessageBox.Show("Do you really want to delete the record?", "caption", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Operation Cancelled")
                ElseIf result = DialogResult.Yes Then
                    Try
                        cmd = New SqlCommand("Delete from student where ID = '" & studentid & "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Deleted Successfully")
                        Clear()
                        Disable_TEXTFIELDS()
                        LOAD_SID()
                    Catch ex As Exception
                        MsgBox("Record not found, could not delete!")
                    End Try
                End If
            Catch ex As Exception
                MsgBox("Please enter valid ID", MsgBoxStyle.Critical, "ERROR")
            End Try
            con.Close()
        End If
    End Sub


    'UPDATE Button
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim studentid As String
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Try
            con.Open()
            If m00.Text <> "" And m1.Text <> "" And m2.Text <> "" And m3.Text <> "" And m4.Text <> "" And m5.Text <> "" And m6.Text <> "" And m7.Text <> "" And m8.Text <> "" And m9.Text <> "" Then
                Dim result As DialogResult = MessageBox.Show("Do you really want to update the record?", "caption", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Operation Cancelled")
                ElseIf result = DialogResult.Yes Then
                    studentid = "S" + m00.Text
                    cmd = New SqlCommand("update student set id = '" & studentid & "', name = '" & m1.Text & "', Email = '" & m2.Text & "', Mother_name = '" & m3.Text & "', Father_name = '" & m4.Text & "', Address = '" & m5.Text & "', Gender = '" & m6.Text & "', Department = '" & m7.Text & "', Mobile_No = '" & m8.Text & "', College_Name = '" & m9.Text & "' where id = '" & studentid & "' ", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Sucessfully Updated")
                    Clear()
                    Disable_TEXTFIELDS()
                    LOAD_SID()
                End If
            Else
                MsgBox("Please fill up the fields")
            End If
        Catch ex As Exception
            MsgBox("Failed")
        Finally
            con.Close()
        End Try
    End Sub


    'Mobile_Number Textbox accepts number input only
    Private Sub m0_KeyPress(sender As Object, e As KeyPressEventArgs) Handles m8.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
             AndAlso (Not Char.IsDigit(e.KeyChar) _
             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    'FORM LOAD
    Private Sub manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_SID()
    End Sub
End Class