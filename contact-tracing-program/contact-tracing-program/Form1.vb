Public Class Form1

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim studentContact As System.IO.StreamWriter
        Dim handleFile As String = boxGivenName.Text + "-" + boxLastName.Text + ".txt"


        If (boxLastName.Text = "") And (boxMiddleName.Text = "") And (boxLastName.Text = "") Then
            MessageBox.Show("Please enter your given, middle, and last name.")
        Else
            If System.IO.File.Exists(handleFile) Then
                MessageBox.Show("Student information already registered.")
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

        End If


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim studentContact As System.IO.StreamWriter
        Dim handleFile As String = boxGivenName.Text + "-" + boxLastName.Text + ".txt"
        If System.IO.File.Exists(handleFile) Then
            System.IO.File.Delete(handleFile)
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
            MessageBox.Show("Text file edit successfull.")
        Else
            MessageBox.Show("Text file not found.")
        End If
    End Sub
End Class
