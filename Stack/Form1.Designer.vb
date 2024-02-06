<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        Button3 = New Button()
        Label6 = New Label()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Label7 = New Label()
        Button7 = New Button()
        Button8 = New Button()
        PictureBox1 = New PictureBox()
        Button9 = New Button()
        Button10 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Chocolate
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Image = My.Resources.Resources.jairo
        Label1.Location = New Point(73, 313)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 39)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.Visible = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Chocolate
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Image = My.Resources.Resources.jairo
        Label2.Location = New Point(73, 274)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 39)
        Label2.TabIndex = 2
        Label2.TextAlign = ContentAlignment.MiddleCenter
        Label2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Chocolate
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Image = My.Resources.Resources.jairo
        Label3.Location = New Point(73, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 39)
        Label3.TabIndex = 3
        Label3.TextAlign = ContentAlignment.MiddleCenter
        Label3.Visible = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Chocolate
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Image = My.Resources.Resources.jairo
        Label4.Location = New Point(73, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(153, 39)
        Label4.TabIndex = 4
        Label4.TextAlign = ContentAlignment.MiddleCenter
        Label4.Visible = False
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Chocolate
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Image = My.Resources.Resources.jairo
        Label5.Location = New Point(73, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(153, 39)
        Label5.TabIndex = 5
        Label5.TextAlign = ContentAlignment.MiddleCenter
        Label5.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Sitka Banner", 9F)
        Button1.Location = New Point(309, 196)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 39)
        Button1.TabIndex = 6
        Button1.Text = "Push"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Sitka Banner", 9F)
        Button2.Location = New Point(309, 236)
        Button2.Name = "Button2"
        Button2.Size = New Size(84, 39)
        Button2.TabIndex = 7
        Button2.Text = "Pop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.BackgroundImage = My.Resources.Resources._106811484_1608045351058_gettyimages_1126750618_dsc_1540
        PictureBox2.Image = My.Resources.Resources.Screenshot_2024_02_05_093306_removebg_preview
        PictureBox2.Location = New Point(-475, -56)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1248, 611)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Sitka Banner", 9F)
        Button3.Location = New Point(348, 407)
        Button3.Name = "Button3"
        Button3.Size = New Size(84, 39)
        Button3.TabIndex = 9
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Banner", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(-27, -10)
        Label6.Name = "Label6"
        Label6.Size = New Size(476, 137)
        Label6.TabIndex = 10
        Label6.Text = "STACK"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkGray
        Button4.BackgroundImage = My.Resources.Resources.jairo
        Button4.Cursor = Cursors.Hand
        Button4.Font = New Font("Sitka Banner", 20.2499981F)
        Button4.ForeColor = Color.Yellow
        Button4.Location = New Point(140, 170)
        Button4.Name = "Button4"
        Button4.Size = New Size(144, 92)
        Button4.TabIndex = 11
        Button4.Text = "Start"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkGray
        Button5.BackgroundImage = My.Resources.Resources.jairo
        Button5.Cursor = Cursors.Hand
        Button5.Font = New Font("Sitka Banner", 20.2499981F)
        Button5.ForeColor = Color.Yellow
        Button5.Location = New Point(140, 268)
        Button5.Name = "Button5"
        Button5.Size = New Size(144, 92)
        Button5.TabIndex = 12
        Button5.Text = "Exit"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.Cursor = Cursors.Hand
        Button6.Font = New Font("Sitka Banner", 9F)
        Button6.Location = New Point(309, 274)
        Button6.Name = "Button6"
        Button6.Size = New Size(84, 39)
        Button6.TabIndex = 13
        Button6.Text = "Clear"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Location = New Point(2, 443)
        Label7.Name = "Label7"
        Label7.Size = New Size(200, 15)
        Label7.TabIndex = 14
        Label7.Text = "Jairo Devon A. Daquioag -  BSCPE2--"
        ' 
        ' Button7
        ' 
        Button7.Cursor = Cursors.Hand
        Button7.Font = New Font("Sitka Banner", 9F)
        Button7.Location = New Point(348, 375)
        Button7.Name = "Button7"
        Button7.Size = New Size(84, 39)
        Button7.TabIndex = 15
        Button7.Text = "Menu"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.DarkGray
        Button8.BackgroundImage = My.Resources.Resources.jairo
        Button8.Cursor = Cursors.Hand
        Button8.Font = New Font("Sitka Banner", 20.2499981F)
        Button8.ForeColor = Color.Yellow
        Button8.Location = New Point(140, 115)
        Button8.Name = "Button8"
        Button8.Size = New Size(144, 49)
        Button8.TabIndex = 16
        Button8.Text = "Continue"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(51, 115)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(233, 265)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Button9
        ' 
        Button9.Cursor = Cursors.Hand
        Button9.Font = New Font("Sitka Banner", 9F)
        Button9.Location = New Point(309, 313)
        Button9.Name = "Button9"
        Button9.Size = New Size(84, 39)
        Button9.TabIndex = 18
        Button9.Text = "Build"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Cursor = Cursors.Hand
        Button10.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button10.Location = New Point(127, 383)
        Button10.Name = "Button10"
        Button10.Size = New Size(75, 38)
        Button10.TabIndex = 19
        Button10.Text = "Demolish"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Yellow
        BackgroundImage = My.Resources.Resources._106811484_1608045351058_gettyimages_1126750618_dsc_1540
        ClientSize = New Size(435, 458)
        ControlBox = False
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Name = "Form1"
        Text = "STACK"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button

End Class
