Imports Dama
''' <summary>This class is used to manage the computer in a game of chess</summary>
Public Class Computer

    Private ChessBoardBox(8, 8) As Box

    ''' <summary> To use the class computer to play with the computer must pass the scacchier on which svolgfe the game</summary>
    ''' <param name="Chessboard">The board on which the game is played</param>
    Public Sub New(ByVal Chessboard(,) As Box)
        MyBase.New()
        For i As Short = 0 To 8
            For j As Integer = 0 To 8
                ChessBoardBox(i, j) = New Box()
                ChessBoardBox(i, j) = Chessboard(i, j)
            Next
        Next
    End Sub


    ''' <summary>The board on which the game is played</summary>
    ''' <param name="x">Row number</param>
    ''' <param name="y">Column number</param>
    Private Property s(ByVal x As Short, ByVal y As Short) As Box
        Get
            If x > 8 Or x < 1 Then
                x = 0
            End If
            If y > 8 Or y < 1 Then
                y = 0
            End If
            Return ChessBoardBox(x, y)
        End Get
        Set(ByVal value As Box)
            ChessBoardBox(x, y) = value
        End Set
    End Property

#Region "Declaration data structures for the moves"
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '              Declaration of data structures to hold the moves to be made
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'In order to store a coordinate system is declared a structure capable of storing the coordinates (x, y), then you can move to 
    ' declare a structure to contain the moves, the fields of this structure are three: StartPosition () and FinalPosition () that are parallel arrays 
    'that contain respectively the initial and final position to make a move, the initial position indicates the position from where should the pawn while 
    'the final one the direction in which you must move the pawn, these moves are calculated to certain functions which prevederranno increase as the third number 
    'field that indicates the number of moves stored in the array of type coordinated, this field will be incremented by the procedure "Resize" that also resize arrays preserving data

    ''' <summary>Contains the coordinates of the Cartesian plane</summary>
    Public Structure Coordinates
        Dim x As Integer
        Dim y As Integer
    End Structure

    ''' <summary>Serves to contain the token to move</summary>
    Public Structure MoveMark
        Dim Position() As Coordinates
        ''' <summary>Indicates the number of moves that can be performed consecutively</summary>
        Private Numb As Integer
        Public Property Number() As Integer
            Get
                Return Numb
            End Get
            Set(ByVal value As Integer)
                Numb = value
                Try
                    ReDim Preserve Position(Numb)
                Catch ex As Exception
                    Exit Property
                End Try
            End Set
        End Property
    End Structure


    ''''''''''''''''''''''''''''''''''End of statement data structures to hold the moves''''''''''''''''''''''
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
#End Region

    ''' <summary>Contains moves to do to eat an opposing checker</summary>
    Dim Eat() As MoveMark
    Dim numereeat As Integer
    Public Property NumberMoveToEat() As Integer
        Get
            Return numereeat
        End Get
        Set(ByVal value As Integer)
            numereeat = value
            ReDim Preserve Eat(numereeat)
            Eat(numereeat).Number = 0
        End Set
    End Property

    ''' <summary>Contains moves to do to Move without being eaten</summary>
    Dim MoveWithoutEat() As MoveMark
    Dim numberwithouteat As Integer
    Public Property NumberShiftMoveWIthoutEat() As Integer
        Get
            Return numberwithouteat
        End Get
        Set(ByVal value As Integer)
            numberwithouteat = value
            ReDim Preserve MoveWithoutEat(numberwithouteat)
            MoveWithoutEat(numberwithouteat).Number = 0
        End Set
    End Property

    ''' <summary>Contains moves to do to Navigate</summary>
    Dim Move() As MoveMark
    Dim numbermove As Integer
    Public Property NumberShiftMove() As Integer
        Get
            Return numbermove
        End Get
        Set(ByVal value As Integer)
            numbermove = value
            ReDim Preserve Move(numbermove)
            Move(numbermove).Number = 0
        End Set
    End Property

    ''' <summary>Recursively calculates all the moves with which a pawn whose coordinates are passed as parameters</summary>
    ''' <param name="x">Row number</param>
    ''' <param name="y">Column number</param>
    Public Sub RecursiveCalculate(ByVal x As Short, ByVal y As Short, ByVal MossePrecedenti As MoveMark)
        Dim index As Integer = NumberMoveToEat
        Eat(index) = MossePrecedenti
        Dim MarkMoveIncrement As Boolean
        Dim ax As Boolean
        Dim nFirtToEat = 0
        Do
            MarkMoveIncrement = False
            If s(x, y).PawnType = PawnTypeEnum.Normal Or s(x, y).PawnType = PawnTypeEnum.Checkers Then
                If s(x + 1, y - 1).Color = PawnColor.Black And s(x + 2, y - 2).Color = PawnColor.Blank And (s(x, y).PawnType = PawnTypeEnum.Normal And s(x + 1, y - 1).PawnType = PawnTypeEnum.Normal Or s(x, y).PawnType = PawnTypeEnum.Checkers) Then
                    With Eat(index)
                        .Number += 1
                        .Position(.Number).x = x
                        .Position(.Number).y = y
                        .Number += 1
                        .Position(.Number).x = x + 2
                        .Position(.Number).y = y - 2
                    End With
                    If nFirtToEat = 0 Then
                        nFirtToEat = 1
                    End If

                    MarkMoveIncrement = True
                    ax = True
                End If

                If s(x + 1, y + 1).Color = PawnColor.Black And s(x + 2, y + 2).Color = PawnColor.Blank And (s(x, y).PawnType = PawnTypeEnum.Normal And s(x + 1, y + 1).PawnType = PawnTypeEnum.Normal Or s(x, y).PawnType = PawnTypeEnum.Checkers) Then
                    With Eat(index)
                        If MarkMoveIncrement = False Then
                            .Number += 1
                            .Position(.Number).x = x
                            .Position(.Number).y = y
                            .Number += 1
                            .Position(.Number).x = x + 2
                            .Position(.Number).y = y + 2
                            If nFirtToEat = 0 Then
                                nFirtToEat = 2
                            End If

                            MarkMoveIncrement = True
                            ax = True
                        Else
                            Dim temp As MoveMark = Eat(index)
                            With temp
                                .Number -= 2
                                .Number += 1
                                .Position(.Number).x = x
                                .Position(.Number).y = y
                                .Number += 1
                                .Position(.Number).x = x + 2
                                .Position(.Number).y = y + 2
                                NumberMoveToEat += 1
                                RecursiveCalculate(.Position(.Number).x, .Position(.Number).y, temp)
                            End With

                        End If
                    End With
                End If

            End If
            If s(x, y).PawnType = PawnTypeEnum.Checkers Then
                If s(x - 1, y - 1).Color = PawnColor.Black And s(x - 2, y - 2).Color = PawnColor.Blank Then
                    With Eat(index)
                        If MarkMoveIncrement = False Then
                            .Number += 1
                            .Position(.Number).x = x
                            .Position(.Number).y = y
                            .Number += 1
                            .Position(.Number).x = x - 2
                            .Position(.Number).y = y - 2
                            If nFirtToEat = 0 Then
                                nFirtToEat = 3
                            End If
                            MarkMoveIncrement = True
                            ax = True
                        Else
                            Dim temp As MoveMark = Eat(index)
                            With temp
                                .Number -= 2
                                .Number += 1
                                .Position(.Number).x = x
                                .Position(.Number).y = y
                                .Number += 1
                                .Position(.Number).x = x - 2
                                .Position(.Number).y = y - 2
                                NumberMoveToEat += 1
                                RecursiveCalculate(.Position(.Number).x, .Position(.Number).y, temp)
                            End With
                        End If
                    End With
                End If

                If s(x - 1, y + 1).Color = PawnColor.Black And s(x - 2, y + 2).Color = PawnColor.Blank Then
                    With Eat(index)
                        If MarkMoveIncrement = False Then
                            .Number += 1
                            .Position(.Number).x = x
                            .Position(.Number).y = y
                            .Number += 1
                            .Position(.Number).x = x - 2
                            .Position(.Number).y = y + 2
                            If nFirtToEat = 0 Then
                                nFirtToEat = 4
                            End If
                            MarkMoveIncrement = True
                            ax = True
                        Else
                            Dim temp As MoveMark = Eat(index)
                            With temp
                                .Number -= 2
                                .Number += 1
                                .Position(.Number).x = x
                                .Position(.Number).y = y
                                .Number += 1
                                .Position(.Number).x = x - 2
                                .Position(.Number).y = y + 2
                                NumberMoveToEat += 1
                                RecursiveCalculate(.Position(.Number).x, .Position(.Number).y, temp)
                            End With
                        End If

                    End With
                End If
            End If
            'The choice will eat first is the one that will continue with this procedure in the calculation of the moves
            Select Case nFirtToEat
                Case 1
                    x = x + 2
                    y = y - 2
                Case 2
                    x = x + 2
                    y = y + 2
                Case 3
                    x = x - 2
                    y = y - 2
                Case 4
                    x = x - 2
                    y = y + 2

            End Select
        Loop Until MarkMoveIncrement = False
        If ax = True Then NumberMoveToEat += 1
    End Sub


    Public Function CalculateMoveForEat() As Boolean
        ReDim Preserve Eat(NumberMoveToEat + 1)
        ReDim Preserve Eat(0).Position(0)
        For i As Short = 1 To 8
            For j As Short = 1 To 8
                Dim continua As Boolean = False
                If s(i, j).Color = PawnColor.White Then
                    RecursiveCalculate(i, j, Eat(NumberMoveToEat))
                End If
            Next
        Next
        If NumberMoveToEat = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function MoveCalculateWithoutBeEated() As Boolean
        ReDim Preserve MoveWithoutEat(0)
        ReDim Preserve MoveWithoutEat(0).Position(0)
        For i As Short = 1 To 8
            For j As Short = 1 To 8
                With s(i, j)
                    If .Color = PawnColor.White Then
                        If .PawnType = PawnTypeEnum.Normal Or .PawnType = PawnTypeEnum.Checkers Then
                            If s(i + 1, j - 1).Color = PawnColor.Blank And (s(i + 2, j - 2).Color <> PawnColor.Black And s(i + 2, j).Color <> PawnColor.Black) Then
                                With MoveWithoutEat(NumberShiftMoveWIthoutEat)
                                    .Position(.Number).x = i
                                    .Position(.Number).y = j
                                    .Number += 1
                                    .Position(.Number).x = i + 1
                                    .Position(.Number).y = j - 1
                                    .Number += 1
                                End With
                                NumberShiftMoveWIthoutEat += 1
                            End If
                            If s(i + 1, j + 1).Color = PawnColor.Blank And (s(i + 2, j + 2).Color <> PawnColor.Black And s(i + 2, j).Color <> PawnColor.Black) Then
                                With MoveWithoutEat(NumberShiftMoveWIthoutEat)
                                    .Position(.Number).x = i
                                    .Position(.Number).y = j
                                    .Number += 1
                                    .Position(.Number).x = i + 1
                                    .Position(.Number).y = j + 1
                                    .Number += 1
                                End With
                                NumberShiftMoveWIthoutEat += 1
                            End If
                        End If

                        If .PawnType = PawnTypeEnum.Checkers Then
                            If s(i - 1, j - 1).Color = PawnColor.Blank And (s(i - 2, j - 2).Color <> PawnColor.Black And s(i - 2, j).Color <> PawnColor.Black) Then
                                With MoveWithoutEat(NumberShiftMoveWIthoutEat)
                                    .Position(.Number).x = i
                                    .Position(.Number).y = j
                                    .Number += 1
                                    .Position(.Number).x = i - 1
                                    .Position(.Number).y = j - 1
                                    .Number += 1
                                End With
                                NumberShiftMoveWIthoutEat += 1
                            End If
                            If s(i - 1, j + 1).Color = PawnColor.Blank And (s(i - 2, j + 2).Color <> PawnColor.Black And s(i - 2, j).Color <> PawnColor.Black) Then
                                With MoveWithoutEat(NumberShiftMoveWIthoutEat)
                                    .Position(.Number).x = i
                                    .Position(.Number).y = j
                                    .Number += 1
                                    .Position(.Number).x = i - 1
                                    .Position(.Number).y = j + 1
                                    .Number += 1
                                End With
                                NumberShiftMoveWIthoutEat += 1
                            End If
                        End If

                    End If
                End With
            Next
        Next

        If NumberShiftMoveWIthoutEat = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>Calculates all possible combinations with which the computer can move and puts them in the data structure Move, returns a Boolean value that indicates whether moves were found with which to move</summary>
    Private Function MovesCalculate() As Boolean
        ReDim Preserve Move(0)
        ReDim Preserve Move(0).Position(0)
        For i As Short = 1 To 8
            For j As Short = 1 To 8
                With s(i, j)
                    If .Color = PawnColor.White Then
                        If .PawnType = PawnTypeEnum.Normal Or .PawnType = PawnTypeEnum.Checkers Then
                            If s(i + 1, j - 1).Color = PawnColor.Blank Then
                                With Move(NumberShiftMove)
                                    .Position(.Number).x = i
                                    .Position(.Number).y = j
                                    .Number += 1
                                    .Position(.Number).x = i + 1
                                    .Position(.Number).y = j - 1
                                    .Number += 1
                                End With
                                NumberShiftMove += 1
                            End If
                            If s(i + 1, j + 1).Color = PawnColor.Blank Then
                                With Move(NumberShiftMove)
                                    .Position(.Number).x = i
                                    .Position(.Number).y = j
                                    .Number += 1
                                    .Position(.Number).x = i + 1
                                    .Position(.Number).y = j + 1
                                    .Number += 1
                                End With
                                NumberShiftMove += 1
                            End If
                        End If

                        If .PawnType = PawnTypeEnum.Checkers Then
                            If s(i - 1, j - 1).Color = PawnColor.Blank Then
                                With Move(NumberShiftMove)
                                    .Position(.Number).x = i
                                    .Position(.Number).y = j
                                    .Number += 1
                                    .Position(.Number).x = i - 1
                                    .Position(.Number).y = j - 1
                                    .Number += 1
                                End With
                                NumberShiftMove += 1
                            End If
                            If s(i - 1, j + 1).Color = PawnColor.Blank Then
                                With Move(NumberShiftMove)
                                    .Position(.Number).x = i
                                    .Position(.Number).y = j
                                    .Number += 1
                                    .Position(.Number).x = i - 1
                                    .Position(.Number).y = j + 1
                                    .Number += 1
                                End With
                                NumberShiftMove += 1
                            End If
                        End If

                    End If
                End With
            Next
        Next
        If NumberShiftMove = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>Check if Player 1 has eaten otherwise if he did not, and could do it eliminates the tokens which could eat</summary>
    Private Sub BlowPieces()
        If frmChessboard.d.PlayerHasEated = False Then
            For i As Integer = 0 To 8
                For j As Integer = 0 To 8
                    If i <> frmChessboard.d.LastMovePawn.X And j <> frmChessboard.d.LastMovePawn.Y Then
                        With s(i, j)
                            Dim EliminaPedina As Boolean = False
                            If .Color = PawnColor.Black Then
                                If .PawnType = PawnTypeEnum.Normal Or .PawnType = PawnTypeEnum.Checkers Then
                                    If s(i - 1, j - 1).Color = PawnColor.White And s(i - 2, j - 2).Color = PawnColor.Blank And (s(i, j).PawnType = PawnTypeEnum.Checkers Or s(i - 1, j - 1).PawnType = PawnTypeEnum.Normal) Then
                                        frmChessboard.d.DeletePawn(i, j)
                                        EliminaPedina = True
                                    End If
                                    If s(i - 1, j + 1).Color = PawnColor.White And s(i - 2, j + 2).Color = PawnColor.Blank And (s(i, j).PawnType = PawnTypeEnum.Checkers Or s(i - 1, j + 1).PawnType = PawnTypeEnum.Normal) Then
                                        frmChessboard.d.DeletePawn(i, j)
                                        EliminaPedina = True
                                    End If
                                End If
                                If .PawnType = PawnTypeEnum.Checkers Then
                                    If s(i + 1, j - 1).Color = PawnColor.White And s(i - 2, j - 2).Color = PawnColor.Blank Then
                                        frmChessboard.d.DeletePawn(i, j)
                                        EliminaPedina = True
                                    End If
                                    If s(i + 1, j + 1).Color = PawnColor.White And s(i - 2, j + 2).Color = PawnColor.Blank Then
                                        frmChessboard.d.DeletePawn(i, j)
                                        EliminaPedina = True
                                    End If
                                End If
                            End If
                            If EliminaPedina = True Then
                                Dim Messaggio As String = "It was eliminated in the pawn " & AxysLetter(j - 1) & (8 - i + 1).ToString() & vbNewLine
                                With frmChessboard.rtfMessaggi
                                    .AppendText(Messaggio)
                                    .Select(.TextLength - Messaggio.Length, Messaggio.Length)
                                    .SelectionColor = Color.Orange
                                    .Select(.TextLength, 1)
                                End With
                            End If
                        End With
                    End If
                Next
            Next
        End If
    End Sub

    '''<summary>The computer runs the turn according to the situation of the chessboard</summary>
    Public Sub PlayRound()
        BlowPieces()
        Dim x1, y1, x2, y2 As Integer
        Dim r As New Random
        If CalculateMoveForEat() = True Then
            'Order the collection moves to eat in descending order: the key is the order num consecutive moves that you can do to eat (as many consecutive pawns can eat)
            For i As Short = 0 To NumberMoveToEat - 1
                For j As Short = i To NumberMoveToEat
                    Dim a As MoveMark
                    If Eat(i).Number < Eat(j).Number Then
                        a = Eat(i)
                        Eat(i) = Eat(j)
                        Eat(j) = a
                    End If
                Next
            Next
            Dim counter As Integer = 1
            'Count how many are the items with the highest number of moves: it compares the number of moves of each element of the structure with the number of moves of the first element (the one with index 0) of the structure that due to sorting descending will be the one with more number of moves.
            While Eat(counter).Number = Eat(0).Number
                counter += 1
            End While
            Dim nCase As Integer
            Randomize()
            nCase = r.Next(0, counter)
            For i As Integer = 1 To Eat(nCase).Number
                If i Mod 2 = 1 Then
                    x1 = Eat(nCase).Position(i).x
                    y1 = Eat(nCase).Position(i).y
                    x2 = Eat(nCase).Position(i + 1).x
                    y2 = Eat(nCase).Position(i + 1).y
                    frmChessboard.d.SelectPawn(x1, y1, PawnColor.White)
                    frmChessboard.d.SelectPawn(x2, y2, PawnColor.White)
                End If
            Next

        ElseIf MoveCalculateWithoutBeEated() = True Then
            Dim ncaso, counter As Integer
            counter = 0
            Do
                Randomize()
                ncaso = r.Next(0, NumberShiftMoveWIthoutEat)
                counter += 1
            Loop Until counter = 5 Or MoveWithoutEat(ncaso).Position(0).x <> 1

            x1 = MoveWithoutEat(ncaso).Position(0).x
            y1 = MoveWithoutEat(ncaso).Position(0).y
            x2 = MoveWithoutEat(ncaso).Position(1).x
            y2 = MoveWithoutEat(ncaso).Position(1).y
            frmChessboard.d.SelectPawn(x1, y1, PawnColor.White)
            frmChessboard.d.SelectPawn(x2, y2, PawnColor.White)
        ElseIf MovesCalculate() = True Then
            Dim nCase, counter As Integer
            counter = 0
            Do
                Randomize()
                nCase = r.Next(0, NumberShiftMove)
                counter += 1
            Loop Until counter = 5 Or Move(nCase).Position(0).x <> 1

            x1 = Move(nCase).Position(0).x
            y1 = Move(nCase).Position(0).y
            x2 = Move(nCase).Position(1).x
            y2 = Move(nCase).Position(1).y
            frmChessboard.d.SelectPawn(x1, y1, PawnColor.White)
            frmChessboard.d.SelectPawn(x2, y2, PawnColor.White)
        End If

    End Sub

End Class
