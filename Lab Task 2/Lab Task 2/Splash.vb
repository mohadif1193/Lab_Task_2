Imports System.Reflection.Emit
Imports System.Windows

Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub timerload_Tick(sender As Object, e As EventArgs) Handles timerload.Tick

        pbloading.Value += 1
        If pbloading.Value <= 10 Then
            lblpro.Text = "Initializing System"
        ElseIf pbloading.Value <= 30 Then
            lblpro.Text = "Loading All Components"
        ElseIf pbloading.Value <= 50 Then
            lblpro.Text = "Integrating Database"
        ElseIf pbloading.Value <= 70 Then
            lblpro.Text = "PLease Wait"
        ElseIf pbloading.Value <= 100 Then
            lblpro.Text = "Welcome"

            If pbloading.Value = 100 Then
                timerload.Dispose()
                Me.Hide()
                frmlogin.ShowDialog()

            End If

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class