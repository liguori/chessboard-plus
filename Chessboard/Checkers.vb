''' <summary>Manage a virtual chessboard</summary>
''' <remarks>Le caselle della dama sono rappresentate da delle PictureBox</remarks>
Public Class Checkers

    Dim Player2 As Computer
    Dim casell(8, 8) As Box
    ''' <summary>Referrs by coordinates to a chessboard box</summary>
    ''' <param name="riga">Number of row</param>
    ''' <param name="colonna">Number of column</param>
    Public Property c(ByVal riga As Short, ByVal colonna As Short) As Box
        Get
            If riga < 0 Or riga > 8 Then
                riga = 0
            End If
            If colonna < 0 Or colonna > 8 Then
                colonna = 0
            End If
            Return casell(riga, colonna)
        End Get
        Set(ByVal value As Box)
            casell(riga, colonna) = value
        End Set
    End Property

    ''' <summary>Initialize all chessboard box</summary>
    Public Sub New()
        MyBase.New()
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                c(i, j) = New Box
            Next
        Next
    End Sub

    Dim Messag As RichTextBox
    ''' <summary>RTF Block that show shows all game messages</summary>
    Public Property HistoryMessages() As RichTextBox
        Get
            Return Messag
        End Get
        Set(ByVal value As RichTextBox)
            Messag = value
        End Set
    End Property

    Dim mRoundColor As PawnColor
    ''' <summary>Current player color</summary>
    Public Property RoundColor() As PawnColor
        Get
            Return mRoundColor
        End Get
        Set(ByVal value As PawnColor)
            mRoundColor = value
        End Set
    End Property

    Dim Player1HasEated As Boolean
    ''' <summary>Determine wheter in the last movement, current player has eaten adversary pawn</summary>
    Public Property PlayerHasEated() As Boolean
        Get
            Return Player1HasEated
        End Get
        Set(ByVal value As Boolean)
            Player1HasEated = value
        End Set
    End Property

    Dim PawnMoved As Point
    ''' <summary>Corrdinates of last moved pawn</summary>
    Public Property LastMovePawn() As Point
        Get
            Return PawnMoved
        End Get
        Set(ByVal value As Point)
            PawnMoved = value
        End Set
    End Property

#Region "New Game"
    ''' <summary>Initialize and clear the chessboard</summary>
    Private Sub NewGame()
        With c(1, 2)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(1, 4)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(1, 6)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(1, 8)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(2, 1)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(2, 3)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(2, 5)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(2, 7)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(3, 2)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(3, 4)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(3, 6)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(3, 8)
            .c.Image = My.Resources.PedinaB
            .Color = PawnColor.White
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(4, 1)
            .c.Image = Nothing
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Checkers
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(4, 3)
            .c.Image = Nothing
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(4, 5)
            .c.Image = Nothing
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(4, 7)
            .c.Image = Nothing
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(5, 2)
            .c.Image = Nothing
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(5, 4)
            .c.Image = Nothing
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(5, 6)
            .c.Image = Nothing
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(5, 8)
            .c.Image = Nothing
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(6, 1)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(6, 3)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(6, 5)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(6, 7)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(7, 2)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(7, 4)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(7, 6)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(7, 8)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(8, 1)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(8, 3)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(8, 5)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        With c(8, 7)
            .c.Image = My.Resources.PedinaN
            .Color = PawnColor.Black
            .PawnType = PawnTypeEnum.Normal
            .Selectioned = False
            .CanStillEat = False
        End With

        Me.HistoryMessages.Clear()
        frmChessboard.lblPunteggioBianchi.Text = "0"
        frmChessboard.lblPunteggioNeri.Text = "0"
    End Sub
#End Region

    ''' <summary>Check the winner</summary>
    Private Sub CheckWinning()
        Dim winn As String
        Dim ContaNeri As Short
        Dim Contabianchi As Short
        For i As Integer = 0 To 8
            For j As Integer = 0 To 8
                If c(i, j).Color = PawnColor.White Then
                    Contabianchi += 1
                ElseIf c(i, j).Color = PawnColor.Black Then
                    ContaNeri += 1
                End If
            Next
        Next
        If Contabianchi = 0 Then
            winn = "Black"
        ElseIf ContaNeri = 0 Then
            winn = "White"
        Else
            winn = ""
        End If

        If winn <> "" Then
            If MsgBox("The winners are " & winn + vbNewLine & "Start new game?", 4) = MsgBoxResult.Yes Then
                NewGame()
            Else
                frmChessboard.Close()
            End If
        End If
    End Sub

    ''' <summary>Move a pawn from the start to the end coordinates</summary>
    ''' <param name="xStart">Start row number</param>
    ''' <param name="xEnd">Start column number</param>
    ''' <param name="x">End row number</param>
    ''' <param name="y">End row number</param>
    Private Sub MovePawn(ByVal xStart As Short, ByVal xEnd As Short, ByVal x As Short, ByVal y As Short)
        With Me.c(x, y) 'Copy all start's box properties to the destination
            .Color = c(xStart, xEnd).Color
            .CanStillEat = c(xStart, xEnd).CanStillEat
            .PawnType = c(xStart, xEnd).PawnType
            .Selectioned = c(xStart, xEnd).Selectioned
            .c.Image = c(xStart, xEnd).c.Image
        End With

        With c(xStart, xEnd) 'Clear start box
            .Color = PawnColor.Blank
            .Selectioned = False
            .CanStillEat = False
            .PawnType = PawnTypeEnum.Normal
            .c.Image = Nothing
        End With
        CheckForNewCheckers()
        If Math.Abs(xStart - x) = 1 Then
            With Me.HistoryMessages
                .AppendText(c(x, y).Color.ToString & " move from " & AxysLetter(xEnd - 1) & (8 - xStart + 1).ToString & " to " & AxysLetter(y - 1) & (8 - x + 1).ToString + vbNewLine)
                .ScrollToCaret()
            End With
        Else
            With Me.HistoryMessages
                Dim Messaggio As String = c(x, y).Color.ToString & " move from " & AxysLetter(xEnd - 1) & (8 - xStart + 1).ToString & " to " & AxysLetter(y - 1) & (8 - x + 1).ToString + vbNewLine
                .AppendText(Messaggio)
                .Select(.TextLength - Messaggio.Length, Messaggio.Length)
                .SelectionColor = Color.DarkBlue
                .Select(.TextLength, 0)
                .ScrollToCaret()
            End With
        End If

    End Sub

    ''' <summary>Delete a pawn from a box</summary>
    ''' <param name="x">Row number</param>
    ''' <param name="y">Column number</param>
    Public Sub DeletePawn(ByVal x As Short, ByVal y As Short)
        With Me.c(x, y)
            .Color = PawnColor.Blank
            .PawnType = PawnTypeEnum.Checkers
            .Selectioned = False
            .c.Image = Nothing
        End With
    End Sub

    ''' <summary>Check for nuw checkers </summary>
    Private Sub CheckForNewCheckers()
        Dim i As Short
        For i = 0 To 8
            If i <> 8 Then
                With c(1, i + 1)
                    If .Color = PawnColor.Black And .PawnType = PawnTypeEnum.Normal Then
                        .PawnType = PawnTypeEnum.Checkers
                        .c.Image = My.Resources.PedinaNDamaGrande
                        frmChessboard.lblPunteggioBianchi.Text = CStr(Val(frmChessboard.lblPunteggioBianchi.Text) + 70)
                    End If
                End With
            End If

            With c(8, i)
                If .Color = PawnColor.White And .PawnType = PawnTypeEnum.Normal Then
                    .PawnType = PawnTypeEnum.Checkers
                    .c.Image = My.Resources.PedinaBDamaGrande
                    frmChessboard.lblPunteggioNeri.Text = CStr(Val(frmChessboard.lblPunteggioNeri.Text) + 70)
                End If
            End With
        Next
    End Sub

    ''' <summary>Eat a pawn</summary>
    ''' <param name="xStart">Start row for the pawn that must eat</param>
    ''' <param name="yStart">Start column for the pawn that must eat</param>
    ''' <param name="xEnd">End row for the pawn that must eat</param>
    ''' <param name="yEnd">End column for the pawn that must eat</param>
    Private Sub DoEat(ByVal xStart As Short, ByVal yStart As Short, ByVal xEnd As Short, ByVal yEnd As Short)
        DeletePawn((xStart + xEnd) / 2, (yStart + yEnd) / 2)
        MovePawn(xStart, yStart, xEnd, yEnd)
        CheckForNewCheckers()
        'Increases score for the color that has eaten
        If RoundColor = PawnColor.White Then 'White has eaten
            frmChessboard.lblPunteggioBianchi.Text = CStr(Val(frmChessboard.lblPunteggioBianchi.Text) + 100)
        ElseIf RoundColor = PawnColor.Black Then 'Black has eaten
            frmChessboard.lblPunteggioNeri.Text = CStr(Val(frmChessboard.lblPunteggioNeri.Text) + 100)
        End If
    End Sub

    ''' <summary>Check if the pawn positioned at coordinates can eat</summary>
    ''' <param name="X">Row number</param>
    ''' <param name="Y">Column number</param>
    Private Function CanStillEat(ByVal X As Short, ByVal Y As Short) As Boolean
        Dim ris As Boolean = False
        If Me.c(X, Y).PawnType = PawnTypeEnum.Normal Or Me.c(X, Y).PawnType = PawnTypeEnum.Checkers Then
            If Me.c(X - 1, Y - 1).Color = PawnColor.White And Me.c(X - 2, Y - 2).Color = PawnColor.Blank Then
                c(X, Y).CanStillEat = True
                ris = True
            ElseIf Me.c(X - 1, Y + 1).Color = PawnColor.White And Me.c(X - 2, Y + 2).Color = PawnColor.Blank Then
                c(X, Y).CanStillEat = True
                ris = True
            Else
                c(X, Y).CanStillEat = False
            End If
        End If
        If Me.c(X, Y).PawnType = PawnTypeEnum.Checkers Then
            If Me.c(X + 1, Y - 1).Color = PawnColor.White And Me.c(X + 2, Y - 2).Color = PawnColor.Blank Then
                c(X, Y).CanStillEat = True
                ris = True
            ElseIf Me.c(X + 1, Y + 1).Color = PawnColor.White And Me.c(X + 2, Y + 2).Color = PawnColor.Blank Then
                c(X, Y).CanStillEat = True
                ris = True
            Else
                c(X, Y).CanStillEat = False
            End If
        End If
        If ris = True Then
            Me.MoveSuggest(X, Y)
            Dim mess As String = "You can still eat"
            With Me.HistoryMessages
                .AppendText(mess & vbNewLine)
                .Select(Me.HistoryMessages.TextLength - mess.Length - 1, mess.Length)
                .SelectionColor = Color.Green
                .Select(Me.HistoryMessages.TextLength, 0)
                .ScrollToCaret()
            End With
        End If
        Return ris
    End Function

    ''' <summary>Proposes a move for the pawn indicated</summary>
    ''' <param name="x">Row number</param>
    ''' <param name="y">Column number</param>
    Private Sub MoveSuggest(ByVal x As Short, ByVal y As Short)
        'Clear all the previous movements suggested
        For i As Short = 0 To 8
            For j As Short = 0 To 8
                If c(i, j).c.BackColor = Color.CornflowerBlue Then
                    c(i, j).c.BackColor = Color.DarkGray
                End If
            Next
        Next
        'Calculate possible movements for the pawn and colors destination box
        If c(x, y).Color = PawnColor.Black Then
            If c(x, y).Color = PawnColor.Black Then
                If c(x, y).PawnType = PawnTypeEnum.Normal Or c(x, y).PawnType = PawnTypeEnum.Checkers Then
                    If c(x - 1, y - 1).Color = PawnColor.Blank Then
                        c(x - 1, y - 1).c.BackColor = Color.CornflowerBlue
                    End If
                    If c(x - 1, y + 1).Color = PawnColor.Blank Then
                        c(x - 1, y + 1).c.BackColor = Color.CornflowerBlue
                    End If
                    If c(x - 1, y - 1).Color = PawnColor.White And c(x - 2, y - 2).Color = PawnColor.Blank And (c(x, y).PawnType = PawnTypeEnum.Checkers Or c(x - 1, y - 1).PawnType = PawnTypeEnum.Normal) Then
                        c(x - 2, y - 2).c.BackColor = Color.CornflowerBlue
                    End If
                    If c(x - 1, y + 1).Color = PawnColor.White And c(x - 2, y + 2).Color = PawnColor.Blank And (c(x, y).PawnType = PawnTypeEnum.Checkers Or c(x - 1, y + 1).PawnType = PawnTypeEnum.Normal) Then
                        c(x - 2, y + 2).c.BackColor = Color.CornflowerBlue
                    End If
                End If
                If c(x, y).PawnType = PawnTypeEnum.Checkers Then
                    If c(x + 1, y - 1).Color = PawnColor.Blank Then
                        c(x + 1, y - 1).c.BackColor = Color.CornflowerBlue
                    End If
                    If c(x + 1, y + 1).Color = PawnColor.Blank Then
                        c(x + 1, y + 1).c.BackColor = Color.CornflowerBlue
                    End If
                    If c(x + 1, y - 1).Color = PawnColor.White And c(x + 2, y - 2).Color = PawnColor.Blank Then
                        c(x + 2, y - 2).c.BackColor = Color.CornflowerBlue
                    End If
                    If c(x + 1, y + 1).Color = PawnColor.White And c(x + 2, y + 2).Color = PawnColor.Blank Then
                        c(x + 2, y + 2).c.BackColor = Color.CornflowerBlue
                    End If
                End If
            End If
        End If
    End Sub

    ''' <summary>Highlight selected pawn</summary>
    ''' <param name="x">Row number</param>
    ''' <param name="y">Column number</param>
    ''' <param name="round">Color for current round, if not provided uses black</param>
    Public Sub SelectPawn(ByVal x As Short, ByVal y As Short, Optional ByVal round As PawnColor = PawnColor.Black)
        Player2 = New Computer(casell)
        mRoundColor = round
        'Check all the boxes if there is any selected page of which is not the turn and provides clear it
        For i As Short = 1 To 8
            For j As Short = 1 To 8
                With c(i, j)
                    If .Color <> RoundColor And .Selectioned = True Then
                        .Selectioned = False
                        If .Color = PawnColor.White Then
                            If .PawnType = PawnTypeEnum.Checkers Then
                                .c.Image = My.Resources.PedinaBDama
                            ElseIf .PawnType = PawnTypeEnum.Normal Then
                                .c.Image = My.Resources.PedinaB
                            End If
                        ElseIf .Color = PawnColor.Black Then
                            If .PawnType = PawnTypeEnum.Checkers Then
                                .c.Image = My.Resources.PedinaNDama
                            ElseIf .PawnType = PawnTypeEnum.Normal Then
                                .c.Image = My.Resources.PedinaN
                            End If
                        End If
                    End If
                End With

            Next
        Next

        'Check if there is a pawn on the chessboard that can still eat retrieving the coordinates of pawn
        Dim verifyWetherCanEat As Boolean = False
        Dim xPawnCanStillEat, yPawnCanStillEat As Short
        For i As Short = 1 To 8
            For j As Short = 1 To 8
                If Me.c(i, j).CanStillEat = True Then
                    verifyWetherCanEat = True
                    xPawnCanStillEat = i
                    yPawnCanStillEat = j
                End If
            Next
        Next


        If verifyWetherCanEat = False Or x = xPawnCanStillEat And y = yPawnCanStillEat Then

            With Me.c(x, y)
                'If you click on a box in which there is a pawn of the color of the turn goes to the select
                If .Color = RoundColor Then
                    Me.MoveSuggest(x, y) 'Proposes the moves for the pawn
                    .Selectioned = True
                    If .PawnType = PawnTypeEnum.Checkers Then
                        If RoundColor = PawnColor.Black Then
                            .c.Image = My.Resources.PedinaNDamaGrande
                        ElseIf RoundColor = PawnColor.White Then
                            .c.Image = My.Resources.PedinaBDamaGrande
                        End If
                    ElseIf .PawnType = PawnTypeEnum.Normal Then
                        If RoundColor = PawnColor.Black Then
                            .c.Image = My.Resources.PedinaNGrande
                        ElseIf RoundColor = PawnColor.White Then
                            .c.Image = My.Resources.PedinaBGrande
                        End If
                    End If

                    'You go to look for if another pawn present in a box other than the one where you clicked and goes to deselect
                    For i As Integer = 1 To 8
                        For j As Integer = 0 To 8
                            With Me.c(i, j)
                                If i <> x Or j <> y And .Color = round Then
                                    If .Selectioned = True Then
                                        .Selectioned = False
                                        If .PawnType = PawnTypeEnum.Checkers Then
                                            If round = PawnColor.Black Then
                                                .c.Image = My.Resources.PedinaNDama
                                            ElseIf round = PawnColor.White Then
                                                .c.Image = My.Resources.PedinaBDama
                                            End If

                                        ElseIf .PawnType = PawnTypeEnum.Normal Then
                                            If round = PawnColor.Black Then
                                                .c.Image = My.Resources.PedinaN
                                            ElseIf round = PawnColor.White Then
                                                .c.Image = My.Resources.PedinaB
                                            End If
                                        End If
                                    End If
                                End If
                            End With
                        Next
                    Next
                End If

            End With
        End If

        'Upon clicking on a box if the color and different from that of the turn or and empty performs an action
        If c(x, y).Color <> RoundColor Then Me.ExecuteAction(x, y)
    End Sub

    ''' <summary>Esegue un'azione in base alle coordinate della casella indicate nei parametri</summary>
    ''' <param name="X">Row number</param>
    ''' <param name="Y">Columns number</param>
    Private Sub ExecuteAction(ByVal X As Short, ByVal Y As Short)
        Dim Cx, Cy As Short
        Dim EndOfSearch As Boolean = False

        For i As Short = 1 To 8
            For j As Short = 1 To 8
                'Search in the checkerboard box selected and retrieves the coordinates
                If c(i, j).Selectioned = True Then
                    Cx = i
                    Cy = j
                    EndOfSearch = True
                    Exit For
                    If EndOfSearch = True Then
                        Exit For
                    End If
                End If
            Next
        Next

        'Check the color of the round
        If Me.RoundColor = PawnColor.Black Then

            'If the pawn is normal or checkers are considered only the moves that can make a pawn normal and checkers
            If c(Cx, Cy).PawnType = PawnTypeEnum.Normal Or c(Cx, Cy).PawnType = PawnTypeEnum.Checkers Then

                If X = Cx - 1 And Y = Cy - 1 And c(X, Y).Color = PawnColor.Blank Then
                    MovePawn(Cx, Cy, X, Y)
                    Me.Player1HasEated = False
                    Me.PawnMoved.X = X
                    Me.PawnMoved.Y = Y
                    CheckWinning()
                    Player2.PlayRound()
                    CheckWinning()
                ElseIf X = Cx - 1 And Y = Cy + 1 And c(X, Y).Color = PawnColor.Blank Then
                    MovePawn(Cx, Cy, X, Y)
                    Me.PawnMoved.X = X
                    Me.PawnMoved.Y = Y
                    Me.Player1HasEated = False
                    CheckWinning()
                    Player2.PlayRound()
                    CheckWinning()
                ElseIf X = Cx - 2 And Y = Cy - 2 And c(X, Y).Color <> PawnColor.White And c(Cx - 1, Cy - 1).Color = PawnColor.White And (c(Cx, Cy).PawnType = PawnTypeEnum.Normal And c(Cx - 1, Cy - 1).PawnType = PawnTypeEnum.Normal Or c(Cx, Cy).PawnType = PawnTypeEnum.Checkers) Then
                    DoEat(Cx, Cy, Cx - 2, Cy - 2)
                    Me.Player1HasEated = True
                    If CanStillEat(Cx - 2, Cy - 2) = False Then
                        CheckWinning()
                        Player2.PlayRound()
                        CheckWinning()
                    End If
                ElseIf X = Cx - 2 And Y = Cy + 2 And c(X, Y).Color <> PawnColor.White And c(Cx - 1, Cy + 1).Color = PawnColor.White And (c(Cx, Cy).PawnType = PawnTypeEnum.Normal And c(Cx - 1, Cy + 1).PawnType = PawnTypeEnum.Normal Or c(Cx, Cy).PawnType = PawnTypeEnum.Checkers) Then
                    DoEat(Cx, Cy, Cx - 2, Cy + 2)
                    Me.Player1HasEated = True
                    If CanStillEat(Cx - 2, Cy + 2) = False Then
                        CheckWinning()
                        Player2.PlayRound()
                        CheckWinning()
                    End If
                End If
            End If

            If c(Cx, Cy).PawnType = PawnTypeEnum.Checkers Then
                'If the token is a Lady are also considered other moves that can not fulfill the normal pawn 
                If X = Cx + 1 And Y = Cy - 1 And c(X, Y).Color = PawnColor.Blank Then
                    MovePawn(Cx, Cy, X, Y)
                    Me.PawnMoved.X = X
                    Me.PawnMoved.Y = Y
                    Me.Player1HasEated = False
                    CheckWinning()
                    Player2.PlayRound()
                    CheckWinning()
                ElseIf X = Cx + 1 And Y = Cy + 1 And c(X, Y).Color = PawnColor.Blank Then
                    MovePawn(Cx, Cy, X, Y)
                    Me.PawnMoved.X = X
                    Me.PawnMoved.Y = Y
                    Me.Player1HasEated = False
                    CheckWinning()
                    Player2.PlayRound()
                    CheckWinning()
                ElseIf X = Cx + 2 And Y = Cy - 2 And c(X, Y).Color <> PawnColor.White And c(Cx + 1, Cy - 1).Color = PawnColor.White Then
                    DoEat(Cx, Cy, Cx + 2, Cy - 2)
                    Me.Player1HasEated = True
                    If CanStillEat(Cx + 2, Cy - 2) = False Then
                        CheckWinning()
                        Player2.PlayRound()
                        CheckWinning()
                    End If
                ElseIf X = Cx + 2 And Y = Cy + 2 And c(X, Y).Color <> PawnColor.White And c(Cx + 1, Cy + 1).Color = PawnColor.White Then
                    DoEat(Cx, Cy, Cx + 2, Cy + 2)
                    Me.Player1HasEated = True
                    If CanStillEat(Cx + 2, Cy + 2) = False Then
                        CheckWinning()
                        Player2.PlayRound()
                        CheckWinning()
                    End If
                End If

            End If

        ElseIf Me.RoundColor = PawnColor.White Then
            'We repeat the same process as before just changing the coordinates of x
            If c(Cx, Cy).PawnType = PawnTypeEnum.Normal Or c(Cx, Cy).PawnType = PawnTypeEnum.Checkers Then

                If X = Cx + 1 And Y = Cy - 1 Then
                    MovePawn(Cx, Cy, X, Y)
                ElseIf X = Cx + 1 And Y = Cy + 1 Then
                    MovePawn(Cx, Cy, X, Y)
                ElseIf X = Cx + 2 And Y = Cy - 2 Then
                    DoEat(Cx, Cy, Cx + 2, Cy - 2)
                ElseIf X = Cx + 2 And Y = Cy + 2 Then
                    DoEat(Cx, Cy, Cx + 2, Cy + 2)
                End If

            End If

            If c(Cx, Cy).PawnType = PawnTypeEnum.Checkers Then
                If X = Cx - 1 And Y = Cy - 1 Then
                    MovePawn(Cx, Cy, X, Y)
                ElseIf X = Cx - 1 And Y = Cy + 1 Then
                    MovePawn(Cx, Cy, X, Y)
                ElseIf X = Cx - 2 And Y = Cy - 2 Then
                    DoEat(Cx, Cy, Cx - 2, Cy - 2)
                ElseIf X = Cx - 2 And Y = Cy + 2 Then
                    DoEat(Cx, Cy, Cx - 2, Cy + 2)
                End If
            End If

        End If

    End Sub

End Class
