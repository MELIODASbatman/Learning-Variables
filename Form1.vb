Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblname.Click

    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim studentName As String
        Dim Age As Integer
        Dim Course As String
        studentName = txtname.Text
        Age = txtage.Text
        Course = txtcourse.Text
        MessageBox.Show("Name: " & studentName & vbCrLf & "Age: " & Age & vbCrLf & "Course: " & Course)
    End Sub
End Class
