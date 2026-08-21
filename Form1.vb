Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblname.Click

    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        'creating variables to store the values entered by the user
        Dim studentName As String
        Dim Age As Integer
        Dim Course As String
        'intializing the variables with the values entered by the user
        studentName = txtname.Text
        Age = txtage.Text
        Course = txtcourse.Text
        'writing the message box to display the values entered by the user
        MessageBox.Show("Name: " & studentName & vbCrLf & "Age: " & Age & vbCrLf & "Course: " & Course)
    End Sub
End Class
