Imports System.Data.SqlClient

Public Class payment

    'The 'X' Button
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        dashboard.disall.Text = "    HOSTEL MANAGEMENT SYSYTEM    "
        Me.Close()
    End Sub

    'Clear Button
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles CLbutton.Click
        ComboID.Text = ""
        p0.Items.Clear()
        p0.Text = ""
        p1.Text = ""
        p2.Text = ""
        p3.Text = ""
        p5.Text = ""
    End Sub

    'SEARCH Button
    Private Sub STDbutton_Click(sender As Object, e As EventArgs) Handles STDbutton.Click
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable
        Dim cmd As New SqlCommand
        Dim ID As String
        Try
            If ComboID.Text = "S" Then
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
                con.Open()
                ID = p0.Text
                da = New SqlDataAdapter("Select Name, Email, Mobile_No from student where id = '" & ID & "'", con)
                da.Fill(dt)
                p1.Text = dt.Rows(0).Item(0)
                p2.Text = dt.Rows(0).Item(1)
                p3.Text = dt.Rows(0).Item(2)
            ElseIf ComboID.Text = "E" Then
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
                con.Open()
                ID = p0.Text
                da = New SqlDataAdapter("Select Name, Email, Mobile_No from employee where id_no = '" & ID & "'", con)
                da.Fill(dt)
                p1.Text = dt.Rows(0).Item(0)
                p2.Text = dt.Rows(0).Item(1)
                p3.Text = dt.Rows(0).Item(2)
            End If
            p5.Text = "6840"
        Catch ex As Exception
            MsgBox("Invalid ID")
        Finally
            con.Close()
        End Try
    End Sub

    'Pay button
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da, darowcount As New SqlDataAdapter
        Dim dt, dtrowcount As New DataTable
        Dim countflag As Integer = 0
        Dim yeartext As String
        Dim timetext As String
        Dim pid As String
        Dim rowcount As Integer
        Dim i As Integer = 0
        Dim m As Integer 'take month value as integer
        Dim mtext As String 'convert integer month to string



        'Payment starts
        Try
            If p0.Text <> "" And p1.Text <> "" And p2.Text <> "" And p3.Text <> "" And p5.Text <> "" Then
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
                con.Open()
                pid = p0.Text

                'Row Count
                darowcount = New SqlDataAdapter("SELECT COUNT(Time) FROM payment where id = '" & pid & "' ", con)
                darowcount.Fill(dtrowcount)
                rowcount = dtrowcount.Rows(0).Item(0)

                'Convert number to month string text
                m = p6.Value.Month
                mtext = MonthName(m)
                'Convert year to string
                yeartext = p6.Value.Year.ToString()
                timetext = mtext + " " + yeartext


                da = New SqlDataAdapter("Select time from payment where id = '" & pid & "'", con)
                da.Fill(dt)

                'Counter for payment duplication
                For i = 0 To rowcount - 1
                    If (dt.Rows(i).Item(0).ToString.Trim = timetext) Then
                        countflag += 1
                        Exit For
                    End If
                Next

                'Payment Success based on payment counter
                If countflag = 1 Then
                    MsgBox("Already paid for " + timetext)
                ElseIf countflag = 0 Then
                    cmd = New SqlCommand("Insert into Payment values(@pid, @name, @email, @mobile, @amount, @time)", con)
                    cmd.Parameters.AddWithValue("pid", pid)
                    cmd.Parameters.AddWithValue("name", p1.Text)
                    cmd.Parameters.AddWithValue("email", p2.Text)
                    cmd.Parameters.AddWithValue("mobile", p3.Text)
                    cmd.Parameters.AddWithValue("amount", p5.Text)
                    cmd.Parameters.AddWithValue("time", timetext)
                    cmd.ExecuteNonQuery()
                    MsgBox("Payment entry for " + timetext + "success")
                End If
            Else
                MsgBox("Please fill up all the fields", MsgBoxStyle.Critical, "ERROR")
            End If
        Catch ex As Exception
            MsgBox("Error in Payment")
        Finally
            con.Close()
        End Try
    End Sub

    'Load IDs Upon Selecting S or E
    Private Sub ComboID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboID.SelectedIndexChanged
        Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        con.Open()
        p0.Items.Clear()
        p0.Text = ""

        If ComboID.Text = "S" Then
            cmd = New SqlCommand("Select ID from student", con)
            dr = cmd.ExecuteReader
            While dr.Read
                p0.Items.Add(dr(0))
            End While
            dr.Close()
        ElseIf ComboID.Text = "E" Then
            cmd = New SqlCommand("Select ID_No from employee", con)
            dr = cmd.ExecuteReader
            While dr.Read
                p0.Items.Add(dr(0))
            End While
            dr.Close()
        Else
            p0.Items.Clear()
        End If
        con.Close()
    End Sub
End Class