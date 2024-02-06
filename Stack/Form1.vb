Imports System.Runtime.ConstrainedExecution
Public Class Form1

    Dim isPictureBox1Visible As Boolean = False
    Public Sub New()
        InitializeComponent()
        DoubleBuffered = True
    End Sub

    Dim ctr As Integer = -1
    Dim fallingSpeed As Integer = 15
    Dim originalTopPositions() As Integer
    Dim fallingDistances() As Integer
    Dim fadeTimer As New Timer()
    Dim fadeStep As Single = 0.05F

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False

        Timer1.Interval = 20
        Timer1.Start()

        ReDim originalTopPositions(L.Length - 1)
        ReDim fallingDistances(L.Length - 1)
        For i = 0 To L.Length - 1
            originalTopPositions(i) = L(i).Top
            fallingDistances(i) = -L(i).Height ' Set initial falling distance above the visible area
        Next
    End Sub



    '                                Push
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ctr = ctr + 1
        If ctr < L.Length Then
            L(ctr).Visible = True
            fallingDistances(ctr) = -L(ctr).Height

            ' Check if 5 stacks are visible to show Button9
            If ctr = 4 Then
                Button9.Visible = True
            End If
        Else
            ctr = L.Length - 1
            MsgBox("Stack at maximum capacity", vbOKOnly, "Maximum Limit")
        End If
    End Sub


    '                                Pop
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ctr >= 0 Then
            L(ctr).Visible = False
            ctr = ctr - 1

            ' Check if fewer than 5 stacks are visible to hide Button9
            If ctr < 4 Then
                Button9.Visible = False
            End If
        Else
            MsgBox("Stack can't be lower than 0", vbOKOnly, "Minimum")
        End If
    End Sub



    '                               Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Move the visible items up
        For i = 0 To ctr
            If L(i).Visible Then
                fallingDistances(i) += fallingSpeed

                ' Check if the item has reached its original position
                If fallingDistances(i) < originalTopPositions(i) Then
                    L(i).Top = fallingDistances(i)
                Else
                    L(i).Top = originalTopPositions(i) ' Set to original position
                    fallingDistances(i) = originalTopPositions(i) ' Set falling distance to original position
                End If
            End If
        Next
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Dim ex As Integer

    '                           Exit(Small)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        ex = MsgBox("Are you sure you want to exit?", vbYesNo, "Exit")

        If ex = vbYes Then
            End
        End If
    End Sub

    '                           Start
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Reset the visibility of stack items

        ctr = -1
        For i As Integer = 0 To L.Length - 1
            L(i).Visible = False
        Next

        ' Show necessary menu buttons and hide unnecessary ones
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        PictureBox2.Visible = True
        Label6.Visible = False
    End Sub

    '                               Exit
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ex = MsgBox("Are you sure you want to exit?", vbYesNo, "Exit")

        If ex = vbYes Then
            End
        End If
    End Sub

    '                                Clear
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim clr As Integer
        If ctr >= 0 Then
            clr = MsgBox("Are you sure you want to clear the stack?", vbYesNo, "Clear")
            If clr = vbYes Then
                If ctr >= 0 Then
                    For i As Integer = 0 To ctr
                        L(i).Visible = False
                    Next
                    ctr = -1 ' Reset the counter
                    Button9.Visible = False
                Else
                    MsgBox("Stack already cleared", vbOKOnly, "Empty")
                End If
            End If
        Else
            MsgBox("Stack already cleared", vbOKOnly, "Empty")
        End If

    End Sub

    Dim stackVisibility() As Boolean


    '                              Menu
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Store the visibility state of stack items
        ReDim stackVisibility(L.Length - 1)
        For i As Integer = 0 To L.Length - 1
            stackVisibility(i) = L(i).Visible
        Next

        ' Hide menu buttons and show continue button
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = True
        Button9.Visible = False
        Button10.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = False

        If ctr <= -1 Then Button8.Visible = False

    End Sub

    '                           Continue
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' Restore visibility state of stack items
        For i As Integer = 0 To L.Length - 1
            L(i).Visible = stackVisibility(i)
        Next

        ' Show menu buttons and hide continue button
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = False
        Label6.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        Button9.Visible = False
        Button10.Visible = False

        If ctr = 4 Then
            Button9.Visible = True
        End If

    End Sub

    '                                 Build
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button1.Visible = False
        Button2.Visible = False
        Button6.Visible = False
        Button9.Visible = False
        Button10.Visible = True
        PictureBox1.Visible = True

    End Sub


    '                               Demolish
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' Reset the visibility of stack items

        ctr = -1
        For i As Integer = 0 To L.Length - 1
            L(i).Visible = False
        Next

        ' Show necessary menu buttons and hide unnecessary ones
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        Label6.Visible = False
    End Sub
End Class