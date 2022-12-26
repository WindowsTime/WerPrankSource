Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Form1.TextBox1.Text
        Label1.Text = Form1.TextBox1.Text & " has stopped working"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Size = New Size(375, 190)
        ProgressBar1.Visible = False
        Label2.Text = "A problem caused the program to stop working correctly." & vbCrLf & "Windows will close the program and notify you if a solution is" & vbCrLf & "available."
        Button1.Text = "Close Program"
        Button1.Size = New Size(107, 23)
        Button1.Location = New Point(245, 9)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
        MessageBox.Show("If you like this then join my Discord server: https://dsc.gg/windowstime2/" & vbCrLf & "Made by TechnologyTime", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class