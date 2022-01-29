Imports System.Data.SqlClient

Public Class login

    'CLOSE BUTTON
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    'RESET BUTTON
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        uname.Text = ""
        password.Text = ""
    End Sub

    'LOGIN BUTTON
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim con As New SqlConnection
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hostel_DB.mdf;Integrated Security=True")
        con.Open()
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter("Select * from UserData", con)
        da.Fill(dt)
        If uname.Text = dt.Rows(0).Item(0) And password.Text = dt.Rows(0).Item(1) Then
            dashboard.Show()
            con.Close()
            Me.Close()
        Else
            MsgBox("Wrong Username/Password")
        End If
    End Sub

    'Pressing enter on username field
    Private Sub uname_KeyDown(sender As Object, e As KeyEventArgs) Handles uname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2GradientButton1_Click(Me, EventArgs.Empty)
        End If
    End Sub


    'Pressing enter on Password Field
    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Guna2GradientButton1_Click(Me, EventArgs.Empty)
        End If
    End Sub

    'FORM LOAD
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        uname.Select()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class