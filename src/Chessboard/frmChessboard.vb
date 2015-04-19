Public Class frmChessboard
    Public d As New Checkers



    ''' <summary>Inzializza le caselle dell'interfaccia nelle caselle della classe</summary>
#Region "Inizializzazione delle proprietà iniziali"
    Public Sub Inizializza()

        With d
            With .c(1, 2)
                .c = b8
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(1, 4)
                .c = d8
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(1, 6)
                .c = f8
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(1, 8)
                .c = lblNeri
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(2, 1)
                .c = a7
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(2, 3)
                .c = c7
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(2, 5)
                .c = e7
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(2, 7)
                .c = g7
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(3, 2)
                .c = b6
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(3, 4)
                .c = d6
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(3, 6)
                .c = f6
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(3, 8)
                .c = h6
                .Color = PawnColor.White
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(4, 1)
                .c = a5
                .Color = PawnColor.Blank
                .PawnType = PawnTypeEnum.Checkers
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(4, 3)
                .c = c5
                .Color = PawnColor.Blank
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(4, 5)
                .c = e5
                .Color = PawnColor.Blank
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(4, 7)
                .c = g5
                .Color = PawnColor.Blank
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(5, 2)
                .c = b4
                .Color = PawnColor.Blank
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(5, 4)
                .c = d4
                .Color = PawnColor.Blank
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(5, 6)
                .c = f4
                .Color = PawnColor.Blank
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(5, 8)
                .c = h4
                .Color = PawnColor.Blank
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(6, 1)
                .c = a3
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(6, 3)
                .c = c3
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(6, 5)
                .c = e3
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(6, 7)
                .c = g3
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(7, 2)
                .c = b2
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(7, 4)
                .c = d2
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(7, 6)
                .c = f2
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(7, 8)
                .c = h2
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(8, 1)
                .c = a1
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(8, 3)
                .c = c1
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(8, 5)
                .c = e1
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            With .c(8, 7)
                .c = g1
                .Color = PawnColor.Black
                .PawnType = PawnTypeEnum.Normal
                .Selectioned = False
                .CanStillEat = False
            End With

            .HistoryMessages = rtfMessaggi
        End With
    End Sub
#End Region

    Private Sub frmDama_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Si è sicuri di voler terminare la partita?", MsgBoxStyle.YesNo, "Attenzione") = MsgBoxResult.Yes Then
            frmStart.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frmDama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inizializza()
    End Sub
#Region "GestioneClickCaselle"
    Private Sub b8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b8.Click
        d.SelectPawn(1, 2)
    End Sub

    'In questa regione sono contenute le procedure che gestiscono l'evento click su una casella

    Private Sub d8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d8.Click
        d.SelectPawn(1, 4)
    End Sub

    Private Sub f8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f8.Click
        d.SelectPawn(1, 6)
    End Sub

    Private Sub h8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNeri.Click
        d.SelectPawn(1, 8)
    End Sub

    Private Sub a7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a7.Click
        d.SelectPawn(2, 1)
    End Sub

    Private Sub c7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c7.Click
        d.SelectPawn(2, 3)
    End Sub

    Private Sub e7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e7.Click
        d.SelectPawn(2, 5)
    End Sub

    Private Sub g7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g7.Click
        d.SelectPawn(2, 7)
    End Sub

    Private Sub b6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b6.Click
        d.SelectPawn(3, 2)
    End Sub

    Private Sub d6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d6.Click
        d.SelectPawn(3, 4)
    End Sub

    Private Sub f6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f6.Click
        d.SelectPawn(3, 6)
    End Sub

    Private Sub h6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h6.Click
        d.SelectPawn(3, 8)
    End Sub

    Private Sub a5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a5.Click
        d.SelectPawn(4, 1)
    End Sub

    Private Sub c5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c5.Click
        d.SelectPawn(4, 3)
    End Sub

    Private Sub e5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e5.Click
        d.SelectPawn(4, 5)
    End Sub

    Private Sub g5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g5.Click
        d.SelectPawn(4, 7)
    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        d.SelectPawn(5, 2)
    End Sub

    Private Sub d4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d4.Click
        d.SelectPawn(5, 4)
    End Sub

    Private Sub f4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f4.Click
        d.SelectPawn(5, 6)
    End Sub

    Private Sub h4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h4.Click
        d.SelectPawn(5, 8)
    End Sub

    Private Sub a3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a3.Click
        d.SelectPawn(6, 1)
    End Sub

    Private Sub c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3.Click
        d.SelectPawn(6, 3)
    End Sub

    Private Sub e3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e3.Click
        d.SelectPawn(6, 5)
    End Sub

    Private Sub g3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g3.Click
        d.SelectPawn(6, 7)
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        d.SelectPawn(7, 2)
    End Sub

    Private Sub d2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d2.Click
        d.SelectPawn(7, 4)
    End Sub

    Private Sub f2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f2.Click
        d.SelectPawn(7, 6)
    End Sub

    Private Sub h2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h2.Click
        d.SelectPawn(7, 8)
    End Sub

    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.Click
        d.SelectPawn(8, 1)
    End Sub

    Private Sub c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.Click
        d.SelectPawn(8, 3)
    End Sub

    Private Sub e1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e1.Click
        d.SelectPawn(8, 5)
    End Sub

    Private Sub g1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g1.Click
        d.SelectPawn(8, 7)
    End Sub
#End Region

End Class