Imports System.Data.SqlClient

Public Class manageresident

    'Enable Fields
    Sub Enable_Field()
        m1.Enabled = True
        m3.Enabled = True
        m4.Enabled = True
    End Sub

    'Disable Fields
    Sub Disable_Fields()
        m1.Enabled = False
        m3.Enabled = False
        m4.Enabled = False
        Label5.Visible = False
        residentbox.Visible = False
    End Sub

    'CLEAR FUNCTION
    Sub CLEAR()
        m0.Text = ""
        m1.Text = ""
        m2.Text = ""
        m3.Text = ""
        m4.Text = ""
        genderbox.Text = ""
        residentbox.Text = ""
        Disable_Fields()
    End Sub

    'Load ID
    Sub Load_ID()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        m1.Items.Clear()
        m1.Text = ""
        If m0.Text = "Student" Then
            cmd = New SqlCommand("Select ID from student where Room = 'NONE'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                m1.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf m0.Text = "Employee" Then
            cmd = New SqlCommand("select ID_NO from employee where Room = 'NONE'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                m1.Items.Add(dr(0))
            End While
            dr.Close()
        End If
        con.Close()
    End Sub

    'Loading Gender
    Sub LOAD_G()
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
            con.Open()
            If m0.Text = "Student" Then
                da = New SqlDataAdapter("Select Gender from Student where ID = '" & m1.Text & "'", con)
                da.Fill(dt)
                genderbox.Text = dt.Rows(0).Item(0)
            ElseIf m0.Text = "Employee" Then
                da = New SqlDataAdapter("Select Designation, Gender from Employee where ID_No = '" & m1.Text & "'", con)
                da.Fill(dt)
                residentbox.Text = dt.Rows(0).Item(0)
                genderbox.Text = dt.Rows(0).Item(1)
            End If

        Catch ex As Exception
        Finally
            con.Close()
        End Try
    End Sub

    'Select Resident Type
    Private Sub m0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles m0.SelectedIndexChanged
        If m0.Text = "Student" Or m0.Text = "Employee" Then
            Load_ID()
            m1.Enabled = True
        End If
    End Sub

    'SELECTING ID
    Private Sub m1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles m1.SelectedIndexChanged
        If m0.Text = "Employee" Then
            Label5.Visible = True
            residentbox.Visible = True
        End If
        LOAD_G()
        Enable_Field()
    End Sub

    'BACK BUTTON
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        dashboard.disall.Text = "MANAGE ROOMS"
        Me.Close()
    End Sub

    'LOADING GENDER AND HOSTEL TYPE
    Private Sub genderbox_TextChanged(sender As Object, e As EventArgs) Handles genderbox.TextChanged
        If genderbox.Text = "Male" Then
            m2.Text = "Boys"
        ElseIf genderbox.Text = "Female" Then
            m2.Text = "Girls"
        End If
    End Sub

    'CLEAR BUTTON
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        CLEAR()
    End Sub

    'Load Room No
    Private Sub m3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles m3.SelectedIndexChanged
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        m4.Items.Clear()
        m4.Text = ""
        con.Open()

        If m3.Text = "Single" And m2.Text = "Boys" Then
            cmd = New SqlCommand("select room_No from BRoom_single where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                m4.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf m3.Text = "Single" And m2.Text = "Girls" Then
            cmd = New SqlCommand("select room_No from GRoom_single where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                m4.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf m3.Text = "Double" And m2.Text = "Boys" Then
            cmd = New SqlCommand("select room_No from BRoom_double where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                m4.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf m3.Text = "Double" And m2.Text = "Girls" Then
            cmd = New SqlCommand("select room_No from GRoom_double where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                m4.Items.Add(dr(0))
            End While
            dr.Close()
        End If
        con.Close()
    End Sub

    'Update Button
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        con.Open()
        If m0.Text <> "" And m1.Text <> "" And m2.Text <> "" And m3.Text <> "" And m4.Text <> "" And genderbox.Text <> "" Then

            Dim result As DialogResult = MessageBox.Show("Do you really want to update the record?", "caption", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                MessageBox.Show("Operation Cancelled")
            ElseIf result = DialogResult.Yes Then
                'UPDATE RESIDENT ROOM DATA TO OCCUPY
                If m0.Text = "Student" Then
                    cmd = New SqlCommand("update student set ROOM = 'Occupied' where ID = '" & m1.Text & "'", con)
                    cmd.ExecuteNonQuery()
                ElseIf m0.Text = "Employee" Then
                    cmd = New SqlCommand("update employee set ROOM = 'Occupied' where ID_No = '" & m1.Text & "'", con)
                    cmd.ExecuteNonQuery()
                End If

                'UPDATE RESIDENT ROOM NO
                ''For Boys
                If m2.Text = "Boys" And m3.Text = "Single" Then
                    Try
                        If residentbox.Text <> "" Then
                            cmd = New SqlCommand("update BRoom_single set vacancy = 'Occupied', Resident_ID = '" & m1.Text & "', Resident_Type = '" & residentbox.Text & "' where Room_No = '" & m4.Text & "'", con)
                        Else
                            cmd = New SqlCommand("update BRoom_single set vacancy = 'Occupied', Resident_ID = '" & m1.Text & "', Resident_Type = 'Student' where Room_No = '" & m4.Text & "'", con)
                        End If
                        cmd.ExecuteNonQuery()
                        CLEAR()
                    Catch ex As Exception
                        MsgBox("Error in Updating")
                    End Try
                ElseIf m2.Text = "Boys" And m3.Text = "Double" Then
                    Try
                        If residentbox.Text <> "" Then
                            cmd = New SqlCommand("update BRoom_double set vacancy = 'Occupied', Resident_ID = '" & m1.Text & "', Resident_Type = '" & residentbox.Text & "' where Room_No = '" & m4.Text & "'", con)
                        Else
                            cmd = New SqlCommand("update BRoom_double set vacancy = 'Occupied', Resident_ID = '" & m1.Text & "', Resident_Type = 'Student' where Room_No = '" & m4.Text & "'", con)
                        End If
                        cmd.ExecuteNonQuery()
                        CLEAR()
                    Catch ex As Exception
                        MsgBox("ERROR in Updating")
                    End Try
                End If

                ''For Girls
                If m2.Text = "Girls" And m3.Text = "Single" Then
                    Try
                        If residentbox.Text <> "" Then
                            cmd = New SqlCommand("update GRoom_single set vacancy = 'Occupied', Resident_ID = '" & m1.Text & "', Resident_Type = '" & residentbox.Text & "' where Room_No = '" & m4.Text & "'", con)
                        Else
                            cmd = New SqlCommand("update GRoom_single set vacancy = 'Occupied', Resident_ID = '" & m1.Text & "', Resident_Type = 'Student' where Room_No = '" & m4.Text & "'", con)
                        End If
                        cmd.ExecuteNonQuery()
                        CLEAR()
                    Catch ex As Exception
                        MsgBox("Error in Updating")
                    End Try
                ElseIf m2.Text = "Girls" And m3.Text = "Double" Then
                    Try
                        If residentbox.Text <> "" Then
                            cmd = New SqlCommand("update GRoom_double set vacancy = 'Occupied', Resident_ID = '" & m1.Text & "', Resident_Type = '" & residentbox.Text & "' where Room_No = '" & m4.Text & "'", con)
                        Else
                            cmd = New SqlCommand("update GRoom_double set vacancy = 'Occupied', Resident_ID = '" & m1.Text & "', Resident_Type = 'Student' where Room_No = '" & m4.Text & "'", con)
                        End If
                        cmd.ExecuteNonQuery()
                        CLEAR()
                    Catch ex As Exception
                        MsgBox("ERROR in Updating")
                    End Try
                End If
            End If
        Else
            MsgBox("Fields are not filled properly")
        End If
        con.Close()
    End Sub

    Private Sub manageresident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Visible = False
        residentbox.Visible = False
    End Sub
End Class