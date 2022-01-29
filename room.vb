Imports System.Data.SqlClient

Public Class room

    'Enable TextFields
    Sub Enable_TEXTFIELDS()
        r1.Enabled = True
        r2.Enabled = True
        r3.Enabled = True
        r8.Enabled = True
        r0.Enabled = True
    End Sub

    'Disable TextFields
    Sub Disable_TEXTFIELDS()
        CLEAR()
        r1.Enabled = False
        r2.Enabled = False
        r3.Enabled = False
        r8.Enabled = False
        r0.Enabled = False
    End Sub

    'Clear Function
    Sub CLEAR()
        r0.Text = ""
        r1.Text = ""
        r2.Text = ""
        r3.Text = ""
        allroom1.Text = ""
        allroom2.Text = ""
        allroom3.Text = ""
        r5.Text = ""
        r6.Text = ""
        r7.Text = ""
        r8.Text = ""
        RoomGrid.Columns.Clear()
    End Sub

    'The 'X' Button
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        dashboard.disall.Text = "    HOSTEL MANAGEMENT SYSYTEM    "
        Me.Close()
    End Sub

    'Clear Button
    Private Sub CLbutton_Click(sender As Object, e As EventArgs) Handles CLbutton.Click
        CLEAR()
    End Sub

    'Load Room Records
    Sub ShowDB_R()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        'Dim adapter As New SqlDataAdapter
        Dim table As New DataTable

        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        'AAA
        If allroom1.Text = "All" And allroom2.Text = "All" And allroom3.Text = "All" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single UNION SELECT * FROM BRoom_double UNION Select * from GRoom_single UNION Select * from GRoom_double", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'AAE
        ElseIf allroom1.Text = "All" And allroom2.Text = "All" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single where vacancy = 'empty' UNION SELECT * FROM BRoom_double where vacancy = 'empty' UNION Select * from GRoom_single where vacancy = 'empty' UNION Select * from GRoom_double where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'AAO
        ElseIf allroom1.Text = "All" And allroom2.Text = "All" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single where vacancy = 'Occupied' UNION SELECT * FROM BRoom_double where vacancy = 'Occupied' UNION Select * from GRoom_single where vacancy = 'Occupied' UNION Select * from GRoom_double where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'ASA
        ElseIf allroom1.Text = "All" And allroom2.Text = "Single" And allroom3.Text = "All" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single UNION Select * from GRoom_single", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'ADA
        ElseIf allroom1.Text = "All" And allroom2.Text = "Double" And allroom3.Text = "All" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_double UNION Select * from GRoom_double", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'ASE
        ElseIf allroom1.Text = "All" And allroom2.Text = "Single" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single where vacancy = 'Empty' UNION Select * from GRoom_single where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'ASO
        ElseIf allroom1.Text = "All" And allroom2.Text = "Single" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single where vacancy = 'Occupied' UNION Select * from GRoom_single where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'ADE
        ElseIf allroom1.Text = "All" And allroom2.Text = "Double" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_double where vacancy = 'Empty' UNION Select * from GRoom_double where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'ADO
        ElseIf allroom1.Text = "All" And allroom2.Text = "Double" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_double where vacancy = 'Occupied' UNION Select * from GRoom_double where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()

            'BAA
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "All" And allroom3.Text = "All" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single UNION SELECT * FROM BRoom_double", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'BAE
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "All" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single where vacancy = 'empty' UNION SELECT * FROM BRoom_double where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'BAO
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "All" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single where vacancy = 'Occupied' UNION SELECT * FROM BRoom_double where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'BSA
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "Single" And allroom3.Text = "All" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'BDA
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "Double" And allroom3.Text = "All" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_double", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'BSE
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "Single" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'BSO
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "Single" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_single where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'BDE
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "Double" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_double where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'BDO
        ElseIf allroom1.Text = "Boys" And allroom2.Text = "Double" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM BRoom_double where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()

            'GAA
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "All" And allroom3.Text = "All" Then
            cmd = New SqlCommand("SELECT * FROM GRoom_single UNION SELECT * FROM GRoom_double", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'GAE
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "All" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM GRoom_single where vacancy = 'empty' UNION SELECT * FROM GRoom_double where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'GAO
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "All" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM GRoom_single where vacancy = 'Occupied' UNION SELECT * FROM GRoom_double where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'GSA
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "Single" And allroom3.Text = "All" Then
            cmd = New SqlCommand("SELECT * FROM GRoom_single", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'GDA
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "Double" And allroom3.Text = "All" Then
            cmd = New SqlCommand(" SELECT * FROM GRoom_double", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'GSE
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "Single" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM GRoom_single where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'GSO
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "Single" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM GRoom_single where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'GDE
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "Double" And allroom3.Text = "Empty" Then
            cmd = New SqlCommand("SELECT * FROM GRoom_single where vacancy = 'empty'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
            'GDO
        ElseIf allroom1.Text = "Girls" And allroom2.Text = "Double" And allroom3.Text = "Occupied" Then
            cmd = New SqlCommand("SELECT * FROM GRoom_single where vacancy = 'Occupied'", con)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(table)
            RoomGrid.DataSource = table
            con.Close()
        End If
    End Sub

    'GridView Property
    Sub DGProp()
        RoomGrid.DefaultCellStyle.Font = New Font("Tahoma", 15)
    End Sub

    'Form Load
    Private Sub room_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGProp()
    End Sub

    'SEARCH Button
    Private Sub STDbutton_Click(sender As Object, e As EventArgs) Handles STDbutton.Click
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
            con.Open()
            If r5.Text = "Boys" And r6.Text = "Single" Then
                da = New SqlDataAdapter("Select * from BRoom_single where Resident_ID = '" & r7.Text & "'", con)
                da.Fill(dt)
                Enable_TEXTFIELDS()
                r1.Text = dt.Rows(0).Item(0)
                r2.Text = dt.Rows(0).Item(1)
                r0.Text = dt.Rows(0).Item(2)
                r8.Text = dt.Rows(0).Item(3)
                r3.Text = dt.Rows(0).Item(4)
                MsgBox("Please enter: " + dt.Rows(0).Item(0) + " as room number if you wish you remove resident")
            ElseIf r5.Text = "Boys" And r6.Text = "Double" Then
                da = New SqlDataAdapter("Select * from BRoom_double where Resident_ID = '" & r7.Text & "'", con)
                da.Fill(dt)
                r0.Text = dt.Rows(0).Item(2)
                r1.Text = dt.Rows(0).Item(0)
                r2.Text = dt.Rows(0).Item(1)
                r3.Text = dt.Rows(0).Item(4)
                r8.Text = dt.Rows(0).Item(3)
                MsgBox("Please enter: " + dt.Rows(0).Item(0) + " as room number if you wish you remove resident")
                Enable_TEXTFIELDS()
            ElseIf r5.Text = "Girls" And r6.Text = "Single" Then
                da = New SqlDataAdapter("Select * from GRoom_single where Resident_ID = '" & r7.Text & "'", con)
                da.Fill(dt)
                r0.Text = dt.Rows(0).Item(2)
                r1.Text = dt.Rows(0).Item(0)
                r2.Text = dt.Rows(0).Item(1)
                r3.Text = dt.Rows(0).Item(4)
                r8.Text = dt.Rows(0).Item(3)
                MsgBox("Please enter: " + dt.Rows(0).Item(0) + " as room number if you wish you remove resident")
                Enable_TEXTFIELDS()
            ElseIf r5.Text = "Girls" And r6.Text = "Double" Then
                da = New SqlDataAdapter("Select * from GRoom_double where Resident_ID = '" & r7.Text & "'", con)
                da.Fill(dt)
                r0.Text = dt.Rows(0).Item(2)
                r1.Text = dt.Rows(0).Item(0)
                r2.Text = dt.Rows(0).Item(1)
                r3.Text = dt.Rows(0).Item(4)
                r8.Text = dt.Rows(0).Item(3)
                MsgBox("Please enter: " + dt.Rows(0).Item(0) + " as room number if you wish you remove resident")
                Enable_TEXTFIELDS()
            End If
        Catch ex As Exception
            MsgBox("Please enter valid ID", MsgBoxStyle.Critical, "ERROR")
        End Try
        RoomGrid.DataSource = dt
        con.Close()
    End Sub

    'Display Button
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ShowDB_R()
    End Sub

    Private Sub r5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r5.SelectedIndexChanged
        If r5.Text = "Boys" Or r5.Text = "Girls" Then
            r6.Enabled = True
        End If
    End Sub

    'Room Type Selection
    Private Sub r6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r6.SelectedIndexChanged
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        r7.Items.Clear()
        r7.Text = ""

        If r6.Text = "Single" And r5.Text = "Boys" Then
            r7.Enabled = True
            cmd = New SqlCommand("select Resident_ID from BRoom_single where vacancy = 'occupied'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                r7.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf r6.Text = "Single" And r5.Text = "Girls" Then
            r7.Enabled = True
            cmd = New SqlCommand("select Resident_ID from GRoom_single where vacancy = 'occupied'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                r7.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf r6.Text = "Double" And r5.Text = "Boys" Then
            r7.Enabled = True
            cmd = New SqlCommand("select Resident_ID from BRoom_double where vacancy = 'occupied'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                r7.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf r6.Text = "Double" And r5.Text = "Girls" Then
            r7.Enabled = True
            cmd = New SqlCommand("select Resident_ID from GRoom_double where vacancy = 'occupied'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                r7.Items.Add(dr(0))
            End While
            dr.Close()
        End If
        con.Close()
    End Sub

    'UPDATE BUTTON
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Try
            con.Open()
            If r1.Text <> "" And r2.Text <> "" And r3.Text <> "" Then
                Dim result As DialogResult = MessageBox.Show("Do you really want to update the record?", "caption", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Operation Cancelled")
                ElseIf result = DialogResult.Yes Then
                    If r2.Text = "Empty" Then
                        If r8.Text = "Student" Then
                            cmd = New SqlCommand("update student set ROOM = 'NONE' where ID = '" & r0.Text & "'", con)
                            cmd.ExecuteNonQuery()
                        ElseIf r8.Text <> "" Then
                            cmd = New SqlCommand("update employee set ROOM = 'NONE' where ID_No = '" & r0.Text & "'", con)
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    'Update to Old Database to make records "NULL"
                    If r6.Text = "Single" Then
                        If r5.Text = "Boys" Then
                            cmd = New SqlCommand("update BRoom_single set Vacancy = 'empty', Resident_ID = 'NULL', Resident_Type = 'NULL' where Resident_ID = '" & r0.Text & "'", con)
                            cmd.ExecuteNonQuery()
                        ElseIf r5.Text = "Girls" Then
                            cmd = New SqlCommand("update GRoom_single set Vacancy = 'empty', Resident_ID = 'NULL', Resident_Type = 'NULL' where Resident_ID = '" & r0.Text & "'", con)
                            cmd.ExecuteNonQuery()
                        End If
                    ElseIf r6.Text = "Double" Then
                        If r5.Text = "Boys" Then
                            cmd = New SqlCommand("update BRoom_double set Vacancy = 'empty', Resident_ID = 'NULL', Resident_Type = 'NULL' where Resident_ID = '" & r0.Text & "'", con)
                            cmd.ExecuteNonQuery()
                        ElseIf r5.Text = "Girls" Then
                            cmd = New SqlCommand("update GRoom_double set Vacancy = 'empty', Resident_ID = 'NULL', Resident_Type = 'NULL' where Resident_ID = '" & r0.Text & "'", con)
                            cmd.ExecuteNonQuery()
                        End If
                    End If

                    If r2.Text = "Occupied" Then
                        'Update to New Database
                        ''For BOYS HOSTEL
                        If r5.Text = "Boys" And r3.Text = "Single" Then
                            Try
                                cmd = New SqlCommand("update BRoom_single set vacancy = 'Occupied', Resident_ID = '" & r0.Text & "', Resident_Type = '" & r8.Text & "' where Room_No = '" & r1.Text & "'", con)
                                cmd.ExecuteNonQuery()
                                CLEAR()
                                ShowDB_R()
                            Catch ex As Exception
                                MsgBox("ERROR in Updating")
                            End Try
                        ElseIf r5.Text = "Boys" And r3.Text = "Double" Then
                            Try
                                cmd = New SqlCommand("update BRoom_double set vacancy = 'Occupied', Resident_ID = '" & r0.Text & "', Resident_Type = '" & r8.Text & "' where Room_No = '" & r1.Text & "'", con)
                                cmd.ExecuteNonQuery()
                                CLEAR()
                                ShowDB_R()
                            Catch ex As Exception
                                MsgBox("ERROR in Updating")
                            End Try
                        End If

                        ''FOR GIRLS HOSTEL
                        If r5.Text = "Girls" And r3.Text = "Single" Then
                            Try
                                cmd = New SqlCommand("update GRoom_single set vacancy = 'Occupied', Resident_ID = '" & r0.Text & "', Resident_Type = '" & r8.Text & "' where Room_No = '" & r1.Text & "'", con)
                                cmd.ExecuteNonQuery()
                                CLEAR()
                                ShowDB_R()
                            Catch ex As Exception
                                MsgBox("ERROR in Updating")
                            End Try
                        ElseIf r5.Text = "Girls" And r3.Text = "Double" Then
                            Try
                                cmd = New SqlCommand("update GRoom_double set vacancy = 'Occupied', Resident_ID = '" & r0.Text & "', Resident_Type = '" & r8.Text & "' where Room_No = '" & r1.Text & "'", con)
                                cmd.ExecuteNonQuery()
                                CLEAR()
                                ShowDB_R()
                            Catch ex As Exception
                                MsgBox("ERROR in Updating")
                            End Try
                        End If
                    End If
                    Disable_TEXTFIELDS()
                End If
            Else
                MsgBox("Enter Room No")
                Disable_TEXTFIELDS()
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub


    'Room No Load in Edit Mode
    Private Sub r3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles r3.SelectedIndexChanged
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        r1.Items.Clear()
        r1.Text = ""
        con.Open()

        If r3.Text = "Single" And r5.Text = "Boys" Then
            cmd = New SqlCommand("select room_No from BRoom_single where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                r1.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf r3.Text = "Single" And r5.Text = "Girls" Then
            cmd = New SqlCommand("select room_No from GRoom_single where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                r1.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf r3.Text = "Double" And r5.Text = "Boys" Then
            cmd = New SqlCommand("select room_No from BRoom_double where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                r1.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf r3.Text = "Double" And r5.Text = "Girls" Then
            cmd = New SqlCommand("select room_No from GRoom_double where vacancy = 'empty'", con)
            dr = cmd.ExecuteReader
            While dr.Read
                r1.Items.Add(dr(0))
            End While
            dr.Close()
        End If
        con.Close()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        dashboard.disall.Text = "MANAGE ROOMS"
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
