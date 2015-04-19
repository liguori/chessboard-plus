''' <summary>All program enumerations</summary>
Public Module Enumerations

    ''' <summary>The pawn content color</summary>
    Public Enum PawnColor
        ''' <summary>Black color</summary>
        Black = 1
        ''' <summary>White color</summary>
        White
        ''' <summary>No pawn, no color: blank</summary>
        Blank
    End Enum

    ''' <summary>Pawn type</summary>
    Public Enum PawnTypeEnum
        Normal
        Checkers
    End Enum

    '''<summary>Letter representetion for axys </summary>
    Public AxysLetter() As String = {"A", "B", "C", "D", "E", "F", "G", "H"}

End Module
