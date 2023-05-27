Public Class frmInfo
    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        Form3.Show()

        Form3.lbModel.Text = tbCM.Text
        Form3.lbParts.Text = cbCP.Text
        If checkboxCheck.Checked Then
            Form3.lbCheck.Text = "Check"
        Else
            Form3.lbCheck.Text = ""
        End If
        If checkboxClean.Checked Then
            Form3.lbClean.Text = "Clean"
        Else
            Form3.lbClean.Text = ""
        End If
        If rbYes.Checked Then
            Form3.lbYN.Text = "Yes"
        Else
            Form3.lbYN.Text = "No"
        End If
    End Sub
End Class