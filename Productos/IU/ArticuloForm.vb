Public Class ArticuloForm

    Dim IdRubro_ As Integer
    Dim operacion_ As String
    Dim MiArticulo As New ArticuloClass
    Public Property IdRubro() As Integer

        Get
            Return IdRubro_

        End Get
        Set(value As Integer)

            IdRubro_ = value
        End Set
    End Property



    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set

    End Property

    Dim indice_ As Byte

    Public Property indice() As String
        Get
            Return indice_
        End Get
        Set(ByVal value As String)
            indice_ = value
        End Set

    End Property

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub


    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        If operacion_ <> "Agregar" Then


            MiArticulo.Id = CInt(TextBox1.Text)

        End If

        MiArticulo.Descripcion = TextBox2.Text

        MiArticulo.IdRubro = CInt(ComboBox1.Text)

        Select Case operacion_

            Case "Agregar"
                ArticulosList.InsertarArticulo(MiArticulo)

            Case "Eliminar"
                ArticulosList.EliminarArticulo(MiArticulo)

            Case "Modificar"

                ArticulosList.ActualizarArticulo(MiArticulo)

        End Select

        Me.Close()

    End Sub

    Private Sub RubroForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        TextBox2.Focus()
    End Sub

End Class