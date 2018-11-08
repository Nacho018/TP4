



Public Class RubroClass

    Private Id_ As Integer
    Private Descripcion_ As String


    Public Property Id() As Integer
        'obtentien
        Get
            Return Id_
        End Get
        'devuelve
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property Descripcion() As String

        Get
            Return Descripcion_
        End Get

        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property


End Class


