Public Class progressbar
    Private Sub progressbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgressBar.Increment(5)
        percentageLbl.Text = MyProgressBar.Value()
        If MyProgressbar.Value = 100 Then
            Me.Hide()
            Dim log = New loginform
            log.Show()
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub MyProgressBar_ValueChanged(sender As Object, e As EventArgs) Handles MyProgressBar.ValueChanged

    End Sub
End Class