Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        'read the input from the user
        fullname = txtFullName.Text

        'trim the outside spaces on fullname
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'find the first space
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'extract the first name
        Dim firstName As String
        firstName = fullnameTrimmed.Substring(0, idxSpace)

        'display result to user
        txtfirstname.Text = firstName

    End Sub
End Class
