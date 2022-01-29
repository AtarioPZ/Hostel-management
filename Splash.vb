Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        bar.Increment(1)
        displayp.Text = Convert.ToString(bar.Value) + "%"

        If bar.Value = 100 Then
            Me.Hide()
            Dim log = New login
            log.Show()
            Timer1.Enabled = False

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles displayp.Click

    End Sub
End Class
