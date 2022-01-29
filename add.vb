Imports System.Data.SqlClient

Public Class add

    'CLEAR FUNCTION FOR DELETE
    Sub CLEAR_D()
        ar1.Text = ""
        ar2.Text = ""
        ar3.Text = ""
        ar2.Enabled = False
        ar3.Items.Clear()
        ar3.Enabled = False
    End Sub

    'CLEAR FUNCTION FOR ADD
    Sub CLEAR_A()
        a1.Text = ""
        a2.Text = ""
        a3.Text = ""
        a4.Text = ""
        a2.Enabled = False
        a3.Enabled = False
        Label2.Visible = False
        a4.Visible = False
    End Sub

    'Load Room Nos for Delete
    Sub LOAD_ROOM()
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con.Open()
        ar3.Items.Clear()
        ar3.Text = ""

        If ar1.Text = "Boys" And ar2.Text = "Single" Then
            cmd = New SqlCommand("Select Room_No from BRoom_single", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ar3.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf ar1.Text = "Boys" And ar2.Text = "Double" Then
            cmd = New SqlCommand("Select Room_No from BRoom_double", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ar3.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf ar1.Text = "Girls" And ar2.Text = "Single" Then
            cmd = New SqlCommand("Select Room_No from GRoom_single", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ar3.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf ar1.Text = "Girls" And ar2.Text = "Double" Then
            cmd = New SqlCommand("Select Room_No from GRoom_double", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ar3.Items.Add(dr(0))
            End While
            dr.Close()
        Else
            ar3.Items.Clear()
        End If
        con.Close()
    End Sub

    'FORM LOAD
    Private Sub add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        a4.Visible = False
    End Sub


    'REMOVE HOSTEL_TYPE
    Private Sub ar1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ar1.SelectedIndexChanged
        If ar1.Text = "Boys" Or ar1.Text = "Girls" Then
            ar2.Enabled = True
        Else
            ar2.Enabled = False
            ar3.Enabled = False
        End If
        LOAD_ROOM()
    End Sub

    'REMOVE ROOM_TYPE
    Private Sub ar2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ar2.SelectedIndexChanged
        If ar2.Text = "Single" Or ar2.Text = "Double" Then
            ar3.Enabled = True
        Else
            ar3.Enabled = False
        End If
        LOAD_ROOM()
    End Sub

    'CLEAR BUTTON FOR DELETE SECTION
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        CLEAR_D()
    End Sub

    'ADD HOSTEL_TYPE
    Private Sub a1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles a1.SelectedIndexChanged
        If a1.Text = "Boys" Or a1.Text = "Girls" Then
            a2.Enabled = True
        Else
            a2.Enabled = False
            a3.Enabled = False
            Label2.Visible = False
            a4.Visible = False
        End If
    End Sub

    'ADD ROOM_TYPE
    Private Sub a2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles a2.SelectedIndexChanged
        If a2.Text = "Double" Then
            a3.Enabled = True
            Label2.Visible = True
            a4.Visible = True
        Else
            a3.Enabled = False
            Label2.Visible = False
            a4.Visible = False
        End If

        If a2.Text = "Single" Or a2.Text = "Double" Then
            a3.Enabled = True
        Else
            a3.Enabled = False
            Label2.Visible = False
            a4.Visible = False
        End If
    End Sub

    'ADD ROOM No accepts only numerical value
    Private Sub a3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles a3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'CLEAR BUTTON FOR ADD
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        CLEAR_A()
    End Sub

    'DELETE BUTTON
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        If ar3.Text = "" Then
            MsgBox("Please select Room number")
        Else
            Try
                con.Open()
                Dim result As DialogResult = MessageBox.Show("Do you really want to delete the room?", "caption", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Operation Cancelled")
                ElseIf result = DialogResult.Yes Then
                    If ar1.Text = "Boys" And ar2.Text = "Single" Then
                        cmd = New SqlCommand("Delete from BRoom_single where Room_No = '" & ar3.Text & "'", con)
                        cmd.ExecuteNonQuery()
                        CLEAR_D()
                    ElseIf ar1.Text = "Boys" And ar2.Text = "Double" Then
                        cmd = New SqlCommand("Delete from BRoom_double where Room_No = '" & ar3.Text & "'", con)
                        cmd.ExecuteNonQuery()
                        CLEAR_D()
                    ElseIf ar1.Text = "Girls" And ar2.Text = "Single" Then
                        cmd = New SqlCommand("Delete from GRoom_single where Room_No = '" & ar3.Text & "'", con)
                        cmd.ExecuteNonQuery()
                        CLEAR_D()
                    ElseIf ar1.Text = "Girls" And ar2.Text = "Double" Then
                        cmd = New SqlCommand("Delete from GRoom_double where Room_No = '" & ar3.Text & "'", con)
                        cmd.ExecuteNonQuery()
                        CLEAR_D()
                    Else
                        MsgBox("Please select all the fields before deleting")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Failed")
            End Try
        End If
    End Sub


    'ADD BUTTON
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim roomdouble As String
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        roomdouble = a3.Text + a4.Text
        con.Open()
        Try
            If a1.Text = "Boys" And a2.Text = "Single" Then
                If a1.Text <> "" And a2.Text <> "" And a3.Text <> "" Then
                    Try
                        cmd = New SqlCommand("Insert into BRoom_single values('" & a3.Text & "', 'empty', 'NULL', 'NULL', '" & a2.Text & "', 'BOYS')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Room added successfully")
                        CLEAR_A()
                    Catch ex As Exception
                        MsgBox("Room No already exists")
                    End Try
                Else
                    MsgBox("Please fill up all the fields")
                End If

            ElseIf a1.Text = "Girls" And a2.Text = "SIngle" Then
                If a1.Text <> "" And a2.Text <> "" And a3.Text <> "" Then
                    Try
                        cmd = New SqlCommand("Insert into GRoom_single values('" & a3.Text & "', 'empty', 'NULL', 'NULL', '" & a2.Text & "', 'GIRLS')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Room added successfully")
                        CLEAR_A()
                    Catch ex As Exception
                        MsgBox("Room No already exists")
                    End Try
                End If

            ElseIf a1.Text = "Boys" And a2.Text = "Double" Then
                If a1.Text <> "" And a2.Text <> "" And a3.Text <> "" And a4.Text <> "" Then
                    Try
                        cmd = New SqlCommand("Insert into BRoom_double values('" & roomdouble & "', 'empty', 'NULL', 'NULL', '" & a2.Text & "', 'BOYS')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Room added successfully")
                        CLEAR_A()
                    Catch ex As Exception
                        MsgBox("Room No already exists")
                    End Try
                Else
                    MsgBox("Please fill up all the fields")
                End If
            ElseIf a1.Text = "Girls" And a2.Text = "Double" Then
                If a1.Text <> "" And a2.Text <> "" And a3.Text <> "" And a4.Text <> "" Then
                    Try
                        cmd = New SqlCommand("Insert into GRoom_double values('" & roomdouble & "', 'empty', 'NULL', 'NULL', '" & a2.Text & "', 'GIRLS')", con)
                        cmd.ExecuteNonQuery()
                        MsgBox("Room added successfully")
                        CLEAR_A()
                    Catch ex As Exception
                        MsgBox("Room No already exists")
                    End Try
                Else
                    MsgBox("Please fill up all the fields")
                End If
            End If
        Catch ex As Exception
            MsgBox("Please fill up all the fields")
        End Try
        con.Close()
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        dashboard.disall.Text = "MANAGE ROOMS"
        Me.Close()
    End Sub
End Class