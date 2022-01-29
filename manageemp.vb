Imports System.Data.SqlClient

Public Class manageemp

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
    End Sub

    'Load Employee ID in ComboBox
    Sub LOAD_EID()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        m00.Items.Clear()
        m00.Text = ""
        cmd = New SqlCommand("select substring(ID_No, PATINDEX('%[0-9]%', ID_No), LEN(ID_No)) from employee;", con)
        dr = cmd.ExecuteReader
        While dr.Read
            m00.Items.Add(dr(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    'The 'X' Button
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) 
        dashboard.disall.Text = "    HOSTEL MANAGEMENT SYSYTEM    "
        Me.Close()
    End Sub

    'Form Load
    Private Sub manageemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_EID()
    End Sub

    'Clear Button
    Private Sub CLSbutton_Click(sender As Object, e As EventArgs)
        Clear()
    End Sub

    'Search Button
    Private Sub STDbutton_Click(sender As Object, e As EventArgs) Handles STDbutton.Click
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim empid As String
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
            con.Open()
            empid = "E" + m00.Text
            da = New SqlDataAdapter("Select * from employee where id_no = '" & empid & "'", con)
            da.Fill(dt)
            m1.Text = dt.Rows(0).Item(1)
            m2.Text = dt.Rows(0).Item(2)
            m3.Text = dt.Rows(0).Item(3)
            m4.Text = dt.Rows(0).Item(4)
            m5.Text = dt.Rows(0).Item(5)
            m6.Text = dt.Rows(0).Item(6)
            m7.Text = dt.Rows(0).Item(7)
            m8.Text = dt.Rows(0).Item(8)
        Catch ex As Exception
            MsgBox("Please enter valid employee ID", MsgBoxStyle.Critical, "ERROR")
        End Try
        con.Close()
        Enable_TEXTFIELDS()
    End Sub

    'Update Button
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim empid As String
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Try
            con.Open()
            If m00.Text <> "" And m1.Text <> "" And m2.Text <> "" And m3.Text <> "" And m4.Text <> "" And m5.Text <> "" And m6.Text <> "" And m7.Text <> "" And m8.Text <> "" Then

                Dim result As DialogResult = MessageBox.Show("Do you really want to update the record?", "caption", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Operation Cancelled")
                ElseIf result = DialogResult.Yes Then
                    empid = "E" + m00.Text
                    cmd = New SqlCommand("update employee set id_no = '" & empid & "', name = '" & m1.Text & "', Email = '" & m2.Text & "', Mother_name = '" & m3.Text & "', Father_name = '" & m4.Text & "', Address = '" & m5.Text & "', Designation = '" & m6.Text & "', mobile_no = '" & m7.Text & "', Gender = '" & m8.Text & "' where id_no = '" & empid & "' ", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Sucessfully Updated")
                    Clear()
                    Disable_TEXTFIELDS()
                    LOAD_EID()
                End If
            Else
                MsgBox("Please fill up the fields")
            End If
        Catch ex As Exception
            MsgBox("Failed to update")
        Finally
            con.Close()
        End Try
    End Sub

    'Delete Button
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim empid As String
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        If m00.Text = "" Then
            MsgBox("Please enter a valid Employee ID")
        Else
            Try
                con.Open()
                empid = "E" + m00.Text
                Dim result As DialogResult = MessageBox.Show("Do you really want to delete the record?", "caption", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Operation Cancelled")
                ElseIf result = DialogResult.Yes Then
                    Try
                        cmd = New SqlCommand("delete from employee where ID_No = '" & empid & "'", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Record Deleted Successfully")
                        Clear()
                        Disable_TEXTFIELDS()
                        LOAD_EID()
                    Catch ex As Exception
                        MsgBox("Record not found, could not delete!")
                    End Try
                End If
            Catch ex As Exception
                MsgBox("Please enter valid ID", MsgBoxStyle.Critical, "ERROR")
            Finally
                con.Close()
            End Try
        End If
    End Sub

    'Mobile number field accepts only numeric value
    Private Sub m7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles m7.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'CLEAR BUTTON
    Private Sub CLSbutton_Click_1(sender As Object, e As EventArgs) Handles CLSbutton.Click
        Clear()
        Disable_TEXTFIELDS()
    End Sub
End Class