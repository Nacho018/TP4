Public Class ArticuloClass

    Dim Id_, IdRubro_ As Integer
    Dim Descripcion_, rubrodesc_ As String


    Public Property Id() As Integer
        Get
            Return Id_
        End Get
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

    Public Property IdRubro() As Integer
        Get
            Return IdRubro_
        End Get
        Set(value As Integer)
            IdRubro_ = value
        End Set
    End Property

    'Public ReadOnly Property() rubrodesc As String
    '    Get
    '        For Each rubro In RubrosList
    '            If rubro.Id = IdRubro_ Then
    '                rubrodesc_ = rubro.Descripcion
    '                Exit For
    '            End If
    '        Next

    '        Return rubrodesc_
    '    End Get
    'End Property

End Class


