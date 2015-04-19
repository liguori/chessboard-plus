''' <summary>Box informations</summary>
Public Class Box

    Dim casell As New PictureBox
    ''' <summary>Chessboard matrix</summary>
    Public Property c() As PictureBox
        Get
            Return casell
        End Get
        Set(ByVal value As PictureBox)
            casell = value
        End Set
    End Property

    Dim col As PawnColor
    ''' <summary>Pawn color 1-Black,2-White,3-Blank</summary>
    Public Property Color() As PawnColor
        Get
            Return col
        End Get
        Set(ByVal value As PawnColor)
            col = value
        End Set
    End Property

    Dim Dam As PawnTypeEnum
    ''' <summary>Contain the pawn type</summary>
    Public Property PawnType() As PawnTypeEnum
        Get
            Return Dam
        End Get
        Set(ByVal value As PawnTypeEnum)
            Dam = value
        End Set
    End Property

    Dim State As Boolean
    ''' <summary>Contain a value that indicate if a pawn is currently actived by user</summary>
    Public Property Selectioned() As Boolean
        Get
            Return State
        End Get
        Set(ByVal value As Boolean)
            State = value
        End Set
    End Property

    Dim cEat As Boolean
    ''' <summary>Contain a value that indicate wheter pawn can still eat</summary>
    Public Property CanStillEat() As Boolean
        Get
            Return cEat
        End Get
        Set(ByVal value As Boolean)
            cEat = value
        End Set
    End Property

End Class
