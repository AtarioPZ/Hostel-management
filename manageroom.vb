Public Class manageroom

    'ADD ROOM
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        With add
            .TopLevel = False
            dashboard.Panel4.Controls.Add(add)
            .BringToFront()
            .Show()
        End With
        dashboard.disall.Text = "ADD ROOMS"
    End Sub


    'MANAGE ROOM
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        With room
            .TopLevel = False
            dashboard.Panel4.Controls.Add(room)
            .BringToFront()
            .Show()
        End With
        dashboard.disall.Text = "MANAGE ROOMS"
    End Sub

    'RESIDENT ROOM
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        With manageresident
            .TopLevel = False
            dashboard.Panel4.Controls.Add(manageresident)
            .BringToFront()
            .Show()
        End With
        dashboard.disall.Text = "MANAGE RESIDENT"
    End Sub

    Private Sub manageroom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class