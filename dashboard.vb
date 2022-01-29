Public Class dashboard

    Sub Close_All_Window()
        student.Close()
        room.Close()
        manage.Close()
        payment.Close()
        records.Close()
        employee.Close()
        add.Close()
        admin.Close()
        manageemp.Close()
        manageroom.Close()
        manageresident.Close()
    End Sub

    'This Sub is used for making round edges to the software
    Sub rounding(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.Cyan


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Height - 40)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub

    'EXIT BUTTON
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Dim result As DialogResult = MessageBox.Show("EXIT APPLICATION?", "EXIT", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        ElseIf result = DialogResult.No Then
        End If
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles payBtn.Click
        Close_All_Window()
        With payment
            .TopLevel = False
            Panel4.Controls.Add(payment)
            .BringToFront()
            .Show()
        End With
        disall.Text = "FEES PAYMENT"
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles STDbutton.Click
        Close_All_Window()
        With student
            .TopLevel = False
            Panel4.Controls.Add(student)
            .BringToFront()
            .Show()
        End With
        disall.Text = "ADD NEW STUDENT"
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles managerR.Click
        Close_All_Window()
        With manageroom
            .TopLevel = False
            Panel4.Controls.Add(manageroom)
            .BringToFront()
            .Show()
        End With
        disall.Text = "MANAGE ROOMS"
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles empBtn.Click
        Close_All_Window()
        With employee
            .TopLevel = False
            Panel4.Controls.Add(employee)
            .BringToFront()
            .Show()
        End With
        disall.Text = "ADD NEW EMPLOYEE"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles homebtn.Click
        Close_All_Window()
        disall.Text = "HOSTEL MANAGEMENT SYSYTEM"
    End Sub

    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles managebtn.Click
        Close_All_Window()
        With manage
            .TopLevel = False
            Panel4.Controls.Add(manage)
            .BringToFront()
            .Show()
        End With
        disall.Text = "MANAGE STUDENT RECORDS"
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rounding(Me)
    End Sub

    Private Sub IconButton1_Click_2(sender As Object, e As EventArgs) Handles manageempbtn.Click
        Close_All_Window()
        With manageemp
            .TopLevel = False
            Panel4.Controls.Add(manageemp)
            .BringToFront()
            .Show()
        End With
        disall.Text = "MANAGE EMPLOYEE RECORDS"
    End Sub

    Private Sub IconButton2_Click_1(sender As Object, e As EventArgs)
        Close_All_Window()
        With add
            .TopLevel = False
            Panel4.Controls.Add(add)
            .BringToFront()
            .Show()
        End With
        disall.Text = "ADD ROOMS"
    End Sub

    Private Sub IconButton2_Click_2(sender As Object, e As EventArgs) Handles settingsbtn.Click
        Close_All_Window()
        With admin
            .TopLevel = False
            Panel4.Controls.Add(admin)
            .BringToFront()
            .Show()
        End With
        disall.Text = "ADMIN PANEL"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub
End Class