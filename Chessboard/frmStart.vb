Public Class frmStart

    Private Sub btnNuova_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuova.Click
        Me.AvviaDama()
    End Sub

    ''' <summary>Avvia il gioco della dama</summary>
    Public Sub AvviaDama()
        Me.Hide()
        frmChessboard.Show()
    End Sub
End Class
