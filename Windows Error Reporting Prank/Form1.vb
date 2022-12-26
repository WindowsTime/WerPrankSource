Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Text box is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Form2.Show()
            Me.Hide()
        End If
        If RadioButton1.Checked = True Then
            Form2.MinimizeBox = True
        ElseIf RadioButton2.Checked = True Then
            Form2.MinimizeBox = False

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class
