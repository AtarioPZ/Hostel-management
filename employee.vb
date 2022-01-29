Imports System.Data.SqlClient

Public Class employee

    'Load Room no in ComboBox s11 and s12
    Sub LOAD_ROOM()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd, cmdd As New SqlCommand
        Dim dr As SqlDataReader
        e10.Items.Clear()

        If e8.Text = "Male" And e9.Text = "Single" Then
            cmd = New SqlCommand("Select room_no from BRoom_single where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                e10.Items.Add(dr(0))
            End While
        ElseIf e8.Text = "Male" And e9.Text = "Double" Then
            cmd = New SqlCommand("Select room_no from BRoom_double where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                e10.Items.Add(dr(0))
            End While
        ElseIf e8.Text = "Female" And e9.Text = "Single" Then
            cmd = New SqlCommand("Select room_no from GRoom_single where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                e10.Items.Add(dr(0))
            End While
        ElseIf e8.Text = "Female" And e9.Text = "Double" Then
            cmd = New SqlCommand("Select room_no from GRoom_double where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                e10.Items.Add(dr(0))
            End While
        End If
        dr.Close()
        con.Close()
    End Sub


    'Clear function
    Sub Clear()
        e0.Text = ""
        e1.Text = ""
        e2.Text = ""
        e3.Text = ""
        e4.Text = ""
        e5.Text = ""
        e6.Text = ""
        e7.Text = ""
    End Sub


    'Close Button
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'Clear Button
    Private Sub CLbutton_Click(sender As Object, e As EventArgs) Handles CLbutton.Click
        Clear()
    End Sub


    'Add Employee Details Button
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Dim cmds, cmdr As New SqlCommand
        Dim empid As String
        Try
            If e0.Text <> "" And e1.Text <> "" And e2.Text <> "" And e3.Text <> "" And e4.Text <> "" And e5.Text <> "" And e6.Text <> "" And e7.Text <> "" And e8.Text <> "" And e9.Text <> "" And e10.Text <> "" Then
                empid = "E" + e0.Text
                cmds = New SqlCommand("Insert into employee values('" & empid & "', '" & e1.Text & "', '" & e2.Text & "','" & e3.Text & "', '" & e4.Text & "','" & e5.Text & "','" & e6.Text & "','" & e7.Text & "','" & e8.Text & "', 'Occupied')", con)

                If e9.Text = "Single" Then
                    Try
                        If e8.Text = "Male" Then
                            cmdr = New SqlCommand("update BRoom_single set Resident_ID = '" & empid & "', Vacancy = 'Occupied', Resident_Type = '" & e6.Text & "' where Room_No = '" & e10.Text & "'", con)
                            cmdr.ExecuteNonQuery()
                            cmds.ExecuteNonQuery()
                            MsgBox("Data inserted successfully", MsgBoxStyle.Information, "SUCCESS")
                            Clear()
                        ElseIf e8.Text = "Female" Then
                            cmdr = New SqlCommand("update GRoom_single set Resident_ID = '" & empid & "', Vacancy = 'Occupied', Resident_Type = '" & e6.Text & "' where Room_No = '" & e10.Text & "'", con)
                            cmdr.ExecuteNonQuery()
                            cmds.ExecuteNonQuery()
                            MsgBox("Data inserted successfully", MsgBoxStyle.Information, "SUCCESS")
                            Clear()
                        End If
                    Catch ex As Exception
                        MsgBox("Student ID already exists in Database")
                    End Try


                ElseIf e9.Text = "Double" Then
                    Try
                        If e8.Text = "Male" Then
                            cmdr = New SqlCommand("update BRoom_double set Vacancy = 'Occupied', Resident_ID = '" & empid & "', Resident_Type = '" & e6.Text & "' where Room_No = '" & e10.Text & "'", con)
                            cmdr.ExecuteNonQuery()
                            cmds.ExecuteNonQuery()
                            MsgBox("Data inserted successfully", MsgBoxStyle.Information, "SUCCESS")
                            Clear()
                        ElseIf e8.Text = "Female" Then
                            cmdr = New SqlCommand("update GRoom_double set Vacancy = 'Occupied', Resident_ID = '" & empid & "', Resident_Type = '" & e6.Text & "' where Room_No = '" & e10.Text & "'", con)
                            cmdr.ExecuteNonQuery()
                            cmds.ExecuteNonQuery()
                            MsgBox("Data inserted successfully", MsgBoxStyle.Information, "SUCCESS")
                            Clear()
                        End If
                    Catch ex As Exception
                        MsgBox("Student ID already exists or Bed taken, choose the other bed!!!")
                    End Try
                End If

                con.Close()
            Else
                MsgBox("Please fill up all the fields", MsgBoxStyle.Critical, "ERROR")
            End If
        Catch ex As Exception
            MsgBox("Student ID already exists", MsgBoxStyle.Critical, "ERROR")
        End Try

    End Sub

    'Mobile Field accepts only numeric value
    Private Sub e7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles e7.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Enable/Disable Room type based on Gender Selection
    Private Sub e8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles e8.SelectedIndexChanged
        If e8.Text = "Male" Or e8.Text = "Female" Then
            e9.Enabled = True
        Else
            e9.Enabled = False
        End If
    End Sub

    'Load Room nos upon selecting room type
    Private Sub e9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles e9.SelectedIndexChanged
        If e9.Text = "Single" Then
            e10.Enabled = True
            e10.Text = ""
            LOAD_ROOM()
        ElseIf e9.Text = "Double" Then
            e10.Enabled = True
            e10.Text = ""
            LOAD_ROOM()
        Else
            e10.Text = ""
            e10.Enabled = False
        End If
    End Sub
End Class