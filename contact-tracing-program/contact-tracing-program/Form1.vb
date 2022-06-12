Public Class Form1
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim studentContact As System.IO.StreamWriter
        Dim handleFile As String = boxGivenName.Text + boxLastName.Text + ".txt"


        If (boxLastName.Text = "") And (boxMiddleName.Text = "") And (boxLastName.Text = "") Then
            MessageBox.Show("Please enter your given, middle, and last name.")
        Else
            studentContact = My.Computer.FileSystem.OpenTextFileWriter(handleFile, True)
            studentContact.WriteLine(boxLastName.Text + ", " + boxGivenName.Text + " " + boxMiddleName.Text + ".")
            studentContact.WriteLine(boxStudentNo.Text)
            studentContact.WriteLine(boxCourse.Text)
            studentContact.WriteLine(boxEmail.Text)
            studentContact.WriteLine(boxContactNo.Text)
            studentContact.WriteLine(boxGender.Text)
            studentContact.WriteLine(boxBirthdate.Text)
            studentContact.WriteLine(boxHomeAdd.Text)
            studentContact.Close()

            MessageBox.Show("Text file create successfull")
        End If


    End Sub
End Class
