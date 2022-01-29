Imports System.Data.SqlClient

Public Class student

    'Load Room no in ComboBox s11 and s12
    Sub LOAD_ROOM()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd, cmdd As New SqlCommand
        Dim dr As SqlDataReader
        s11.Items.Clear()

        If s6.Text = "Male" And s10.Text = "Single" Then
            cmd = New SqlCommand("Select room_no from BRoom_single where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                s11.Items.Add(dr(0))
            End While
        ElseIf s6.Text = "Male" And s10.Text = "Double" Then
            cmd = New SqlCommand("Select room_no from BRoom_double where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                s11.Items.Add(dr(0))
            End While
        ElseIf s6.Text = "Female" And s10.Text = "Single" Then
            cmd = New SqlCommand("Select room_no from GRoom_single where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                s11.Items.Add(dr(0))
            End While
        ElseIf s6.Text = "Female" And s10.Text = "Double" Then
            cmd = New SqlCommand("Select room_no from GRoom_double where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                s11.Items.Add(dr(0))
            End While
        End If
        dr.Close()
        con.Close()
    End Sub

    'Sub CLEAR
    Sub CLEAR()
        s0.Text = ""
        s1.Text = ""
        s2.Text = ""
        s3.Text = ""
        s4.Text = ""
        s5.Text = ""
        s6.Text = ""
        s7.Text = ""
        s8.Text = ""
        s9.Text = ""
        s9.Text = ""
        s10.Text = ""
        s11.Text = ""
    End Sub

    'The 'X' Button
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        dashboard.disall.Text = "    HOSTEL MANAGEMENT SYSYTEM    "
        Me.Close()
    End Sub

    'Clear Button
    Private Sub CLSbutton_Click(sender As Object, e As EventArgs) Handles CLSbutton.Click
        CLEAR()
    End Sub

    'Add Student Details Button
    Private Sub S_Add_Click(sender As Object, e As EventArgs) Handles S_Add.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmds, cmdr As New SqlCommand
        Dim studentid, roomno As String
        Try
            If s0.Text <> "" And s1.Text <> "" And s2.Text <> "" And s3.Text <> "" And s4.Text <> "" And s5.Text <> "" And s6.Text <> "" And s7.Text <> "" And s8.Text <> "" And s9.Text <> "" And s10.Text <> "" And s11.Text <> "" Then
                studentid = "S" + s0.Text
                roomno = s11.Text
                cmds = New SqlCommand("Insert into student values('" & studentid & "', '" & s1.Text & "', '" & s2.Text & "','" & s3.Text & "', '" & s4.Text & "','" & s5.Text & "','" & s6.Text & "','" & s7.Text & "','" & s8.Text & "','" & s9.Text & "', 'Occupied')", con)

                If s10.Text = "Single" Then
                    Try
                        If s6.Text = "Male" Then
                            cmdr = New SqlCommand("update BRoom_single set Resident_ID = '" & studentid & "', Vacancy = 'Occupied', Resident_Type = 'Student' where Room_No = '" & s11.Text & "'", con)
                            cmdr.ExecuteNonQuery()
                            cmds.ExecuteNonQuery()
                            MsgBox("Data inserted successfully", MsgBoxStyle.Information, "SUCCESS")
                            CLEAR()
                        ElseIf s6.Text = "Female" Then
                            cmdr = New SqlCommand("update GRoom_single set Resident_ID = '" & studentid & "', Vacancy = 'Occupied', Resident_Type = 'Student' where Room_No = '" & s11.Text & "'", con)
                            cmdr.ExecuteNonQuery()
                            cmds.ExecuteNonQuery()
                            MsgBox("Data inserted successfully", MsgBoxStyle.Information, "SUCCESS")
                            CLEAR()
                        End If
                    Catch ex As Exception
                        MsgBox("Student ID already exists in Database")
                    End Try
                ElseIf s10.Text = "Double" Then
                    Try
                        If s6.Text = "Male" Then
                            cmdr = New SqlCommand("update BRoom_double set Vacancy = 'Occupied', Resident_ID = '" & studentid & "', Resident_Type = 'Student' where Room_No = '" & roomno & "'", con)
                            cmdr.ExecuteNonQuery()
                            cmds.ExecuteNonQuery()
                            MsgBox("Data inserted successfully", MsgBoxStyle.Information, "SUCCESS")
                            CLEAR()
                        ElseIf s6.Text = "Female" Then
                            cmdr = New SqlCommand("update GRoom_double set Vacancy = 'Occupied', Resident_ID = '" & studentid & "', Resident_Type = 'Student' where Room_No = '" & roomno & "'", con)
                            cmdr.ExecuteNonQuery()
                            cmds.ExecuteNonQuery()
                            MsgBox("Data inserted successfully", MsgBoxStyle.Information, "SUCCESS")
                            CLEAR()
                        End If
                    Catch ex As Exception
                        MsgBox("Student ID already exists!!!")
                    End Try
                Else
                    MsgBox("Please fill up all the fields", MsgBoxStyle.Critical, "ERROR")
                End If
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Student ID already exists", MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    'Mobile Number accepts only numeric value
    Private Sub s8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles s8.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'Room Type Selection
    Private Sub s10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles s10.SelectedIndexChanged
        If s10.Text = "Single" Then
            s11.Enabled = True
            s11.Text = ""
            LOAD_ROOM()
        ElseIf s10.Text = "Double" Then
            s11.Enabled = True
            s11.Text = ""
            LOAD_ROOM()
        Else
            s11.Text = ""
            s11.Enabled = False
        End If
    End Sub

    Private Sub s6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles s6.SelectedIndexChanged
        If s6.Text = "Male" Or s6.Text = "Female" Then
            s10.Enabled = True
        Else
            s10.Enabled = False
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub s11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles s11.SelectedIndexChanged

    End Sub
End Class