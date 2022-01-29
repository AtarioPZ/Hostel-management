<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.settingsbtn = New FontAwesome.Sharp.IconButton()
        Me.manageempbtn = New FontAwesome.Sharp.IconButton()
        Me.managebtn = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.homebtn = New System.Windows.Forms.PictureBox()
        Me.managerR = New FontAwesome.Sharp.IconButton()
        Me.empBtn = New FontAwesome.Sharp.IconButton()
        Me.payBtn = New FontAwesome.Sharp.IconButton()
        Me.exitbtn = New FontAwesome.Sharp.IconButton()
        Me.STDbutton = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.disall = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.homebtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.settingsbtn)
        Me.Panel1.Controls.Add(Me.manageempbtn)
        Me.Panel1.Controls.Add(Me.managebtn)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.managerR)
        Me.Panel1.Controls.Add(Me.empBtn)
        Me.Panel1.Controls.Add(Me.payBtn)
        Me.Panel1.Controls.Add(Me.exitbtn)
        Me.Panel1.Controls.Add(Me.STDbutton)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 725)
        Me.Panel1.TabIndex = 0
        '
        'settingsbtn
        '
        Me.settingsbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsbtn.FlatAppearance.BorderSize = 0
        Me.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsbtn.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.settingsbtn.IconChar = FontAwesome.Sharp.IconChar.Sun
        Me.settingsbtn.IconColor = System.Drawing.Color.Yellow
        Me.settingsbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.settingsbtn.IconSize = 30
        Me.settingsbtn.Location = New System.Drawing.Point(3, 479)
        Me.settingsbtn.Name = "settingsbtn"
        Me.settingsbtn.Size = New System.Drawing.Size(182, 41)
        Me.settingsbtn.TabIndex = 9
        Me.settingsbtn.Text = "SETTINGS"
        Me.settingsbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.settingsbtn.UseVisualStyleBackColor = True
        '
        'manageempbtn
        '
        Me.manageempbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.manageempbtn.FlatAppearance.BorderSize = 0
        Me.manageempbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manageempbtn.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manageempbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.manageempbtn.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.manageempbtn.IconColor = System.Drawing.Color.Yellow
        Me.manageempbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.manageempbtn.IconSize = 35
        Me.manageempbtn.Location = New System.Drawing.Point(-2, 337)
        Me.manageempbtn.Name = "manageempbtn"
        Me.manageempbtn.Size = New System.Drawing.Size(182, 41)
        Me.manageempbtn.TabIndex = 8
        Me.manageempbtn.Text = "Manage Employee"
        Me.manageempbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.manageempbtn.UseVisualStyleBackColor = True
        '
        'managebtn
        '
        Me.managebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.managebtn.FlatAppearance.BorderSize = 0
        Me.managebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.managebtn.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managebtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.managebtn.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.managebtn.IconColor = System.Drawing.Color.Yellow
        Me.managebtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.managebtn.IconSize = 35
        Me.managebtn.Location = New System.Drawing.Point(-2, 290)
        Me.managebtn.Name = "managebtn"
        Me.managebtn.Size = New System.Drawing.Size(182, 41)
        Me.managebtn.TabIndex = 7
        Me.managebtn.Text = "Manage Student"
        Me.managebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.managebtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel3.Controls.Add(Me.homebtn)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(185, 93)
        Me.Panel3.TabIndex = 3
        '
        'homebtn
        '
        Me.homebtn.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.homebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homebtn.Image = CType(resources.GetObject("homebtn.Image"), System.Drawing.Image)
        Me.homebtn.Location = New System.Drawing.Point(41, 16)
        Me.homebtn.Name = "homebtn"
        Me.homebtn.Size = New System.Drawing.Size(83, 66)
        Me.homebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.homebtn.TabIndex = 6
        Me.homebtn.TabStop = False
        '
        'managerR
        '
        Me.managerR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.managerR.FlatAppearance.BorderSize = 0
        Me.managerR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.managerR.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.managerR.ForeColor = System.Drawing.Color.Gainsboro
        Me.managerR.IconChar = FontAwesome.Sharp.IconChar.Procedures
        Me.managerR.IconColor = System.Drawing.Color.Yellow
        Me.managerR.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.managerR.IconSize = 30
        Me.managerR.Location = New System.Drawing.Point(-2, 384)
        Me.managerR.Name = "managerR"
        Me.managerR.Size = New System.Drawing.Size(182, 42)
        Me.managerR.TabIndex = 4
        Me.managerR.Text = "Manage Rooms"
        Me.managerR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.managerR.UseVisualStyleBackColor = True
        '
        'empBtn
        '
        Me.empBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.empBtn.FlatAppearance.BorderSize = 0
        Me.empBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.empBtn.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.empBtn.IconChar = FontAwesome.Sharp.IconChar.Pause
        Me.empBtn.IconColor = System.Drawing.Color.Yellow
        Me.empBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.empBtn.IconSize = 30
        Me.empBtn.Location = New System.Drawing.Point(0, 243)
        Me.empBtn.Name = "empBtn"
        Me.empBtn.Size = New System.Drawing.Size(182, 41)
        Me.empBtn.TabIndex = 3
        Me.empBtn.Text = "Employee"
        Me.empBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.empBtn.UseVisualStyleBackColor = True
        '
        'payBtn
        '
        Me.payBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.payBtn.FlatAppearance.BorderSize = 0
        Me.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.payBtn.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.payBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck
        Me.payBtn.IconColor = System.Drawing.Color.Yellow
        Me.payBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.payBtn.IconSize = 30
        Me.payBtn.Location = New System.Drawing.Point(-2, 432)
        Me.payBtn.Name = "payBtn"
        Me.payBtn.Size = New System.Drawing.Size(182, 41)
        Me.payBtn.TabIndex = 2
        Me.payBtn.Text = "PAYMENT"
        Me.payBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.payBtn.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitbtn.FlatAppearance.BorderSize = 0
        Me.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbtn.Font = New System.Drawing.Font("Georgia", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.exitbtn.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt
        Me.exitbtn.IconColor = System.Drawing.Color.White
        Me.exitbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.exitbtn.IconSize = 20
        Me.exitbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.exitbtn.Location = New System.Drawing.Point(44, 583)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Rotation = 180.0R
        Me.exitbtn.Size = New System.Drawing.Size(76, 56)
        Me.exitbtn.TabIndex = 1
        Me.exitbtn.Text = "EXIT"
        Me.exitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'STDbutton
        '
        Me.STDbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.STDbutton.FlatAppearance.BorderSize = 0
        Me.STDbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.STDbutton.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STDbutton.ForeColor = System.Drawing.Color.Gainsboro
        Me.STDbutton.IconChar = FontAwesome.Sharp.IconChar.Portrait
        Me.STDbutton.IconColor = System.Drawing.Color.Yellow
        Me.STDbutton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.STDbutton.IconSize = 30
        Me.STDbutton.Location = New System.Drawing.Point(-2, 186)
        Me.STDbutton.Name = "STDbutton"
        Me.STDbutton.Size = New System.Drawing.Size(190, 41)
        Me.STDbutton.TabIndex = 0
        Me.STDbutton.Text = "New Student"
        Me.STDbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.STDbutton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.disall)
        Me.Panel2.Location = New System.Drawing.Point(187, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(952, 93)
        Me.Panel2.TabIndex = 2
        '
        'disall
        '
        Me.disall.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.disall.Font = New System.Drawing.Font("Franklin Gothic Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disall.ForeColor = System.Drawing.Color.White
        Me.disall.Location = New System.Drawing.Point(133, 16)
        Me.disall.Name = "disall"
        Me.disall.Size = New System.Drawing.Size(706, 61)
        Me.disall.TabIndex = 0
        Me.disall.Text = "HOSTEL MANAGEMENT SYSTEM"
        Me.disall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.PictureBox1.BackgroundImage = Global.Hostel_management.My.Resources.Resources.WhatsApp_Image_2021_09_17_at_8_38_20_PM
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(952, 641)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(187, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(952, 629)
        Me.Panel4.TabIndex = 8
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1141, 725)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.CadetBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hostel Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.homebtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents STDbutton As FontAwesome.Sharp.IconButton
    Friend WithEvents managerR As FontAwesome.Sharp.IconButton
    Friend WithEvents empBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents payBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents exitbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents disall As Label
    Friend WithEvents homebtn As PictureBox
    Friend WithEvents managebtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents manageempbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents settingsbtn As FontAwesome.Sharp.IconButton
End Class
