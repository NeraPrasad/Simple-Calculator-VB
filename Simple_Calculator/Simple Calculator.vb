Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            Dim num1 As Integer = CInt(txtAddition1.Text) 'Convert Integer
            Dim num2 As Integer = CInt(txtAddition2.Text)
            Dim sum = num1 + num2

            txtAdditionAnswer.Text = CStr(sum) 'Convert String

        Catch ex As InvalidCastException

            MessageBox.Show("Enter Only Number",
                            "Error")  'Title in the Message Box

        Catch ex As Exception

            MessageBox.Show("Error",
                            "Error")

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim num1 As Integer = CInt(txtSub1.Text) 'Convert Integer
            Dim num2 As Integer = CInt(txtSub2.Text)

            If num1 > num2 Then
                Dim sum = num1 - num2
                txtSubAnswer.Text = CStr(sum) 'Convert String
            Else
                Dim sum = num2 - num1
                txtSubAnswer.Text = CStr(sum) 'Convert String
            End If


        Catch ex As InvalidCastException

            MessageBox.Show("Enter Only Number",
                            "Error")  'Title in the Message Box

        Catch ex As Exception

            MessageBox.Show("Error",
                            "Error")

        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Try
            Dim num1 As Integer = CInt(txtMulti1.Text) 'Convert Integer
            Dim num2 As Integer = CInt(txtMulti2.Text)
            Dim sum = num1 * num2

            txtMultiAnswer.Text = CStr(sum) 'Convert String

        Catch ex As InvalidCastException

            MessageBox.Show("Enter Only Number",
                            "Error")  'Title in the Message Box

        Catch ex As Exception

            MessageBox.Show("Error",
                            "Error")

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            Dim num1 As Integer = CInt(txtDivi1.Text) 'Convert Integer
            Dim num2 As Integer = CInt(txtDivi2.Text)
            Dim sum = num1 / num2

            txtDiviAnswer.Text = CStr(sum) 'Convert String

        Catch ex As InvalidCastException

            MessageBox.Show("Enter Only Number",
                            "Error")  'Title in the Message Box

        Catch ex As Exception

            MessageBox.Show("Error",
                            "Error")

        End Try

    End Sub
End Class
