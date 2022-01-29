Imports System.Data.SqlClient

Public Class admin

    'Load USERNAME
    Sub LOAD_USER()
        Dim con As New SqlConnection
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd = New SqlCommand("select U_NAME from UserData", con)
        dr = cmd.ExecuteReader
        While dr.Read
            set0.Items.Add(dr(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Sub cap_on()
        If (Control.IsKeyLocked(Keys.CapsLock)) Then
            MsgBox("CAPSLOCK ON")
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles set1.TextChanged
        cap_on()
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LOAD_USER()
    End Sub

    'Change Password Button
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim con As New SqlConnection
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        Dim pass, input_pass As String
        da = New SqlDataAdapter("Select U_PASS from UserData", con)
        da.Fill(dt)
        pass = dt.Rows(0).Item(0)
        If set0.Text <> "" And set1.Text <> "" And set2.Text <> "" Then
            If set1.Text = set2.Text Then
                Dim result As DialogResult = MessageBox.Show("Do you really want to change the password?", "caption", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Operation Cancelled")
                ElseIf result = DialogResult.Yes Then
                    input_pass = InputBox("Confirm your old password:")
                    If pass = input_pass Then
                        Try
                            cmd = New SqlCommand("update UserData set U_PASS = '" & set1.Text & "' where U_NAME = '" & set0.Text & "'", con)
                            cmd.ExecuteNonQuery()
                            MsgBox("Password changed!")
                            set0.Text = ""
                            set1.Text = "abcdefgh"
                            set2.Text = "xyz12345"
                        Catch ex As Exception
                            MsgBox("Error")
                        End Try
                    Else
                        MsgBox("Password incorrect!!!")
                    End If
                End If
            Else
                MsgBox("Password do not match")
            End If
        Else
            MsgBox("Please fix up the fields properly")
        End If
        con.Close()
    End Sub

    'Student Button
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        With records
            .TopLevel = False
            dashboard.Panel4.Controls.Add(records)
            .BringToFront()
            .Show()
        End With
        records.Label2.Text = records.Label2.Text + " [STUDENT]"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select * from student", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        records.DataGridView1.DataSource = table
        con.Close()
    End Sub

    'Employee Button
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        With records
            .TopLevel = False
            dashboard.Panel4.Controls.Add(records)
            .BringToFront()
            .Show()
        End With
        records.Label2.Text = records.Label2.Text + " [EMPLOYEE]"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select * from employee", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        records.DataGridView1.DataSource = table
        con.Close()
    End Sub

    'Payment Button
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        With records
            .TopLevel = False
            dashboard.Panel4.Controls.Add(records)
            .BringToFront()
            .Show()
        End With
        records.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        records.Label2.Text = records.Label2.Text + " [PAYMENT]"
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand("Select * from Payment", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        records.DataGridView1.DataSource = table
        con.Close()
    End Sub
End Class