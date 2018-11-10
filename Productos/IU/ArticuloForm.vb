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

    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set

    End Property

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click

        Me.Close()

    End Sub


    Private Sub Aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Aceptar.Click

        If operacion_ <> "Agregar" Then


            MiArticulo.Id = CInt(ArticuloTextBox1.Text)

        End If

        MiArticulo.Descripcion = ArticuloTextBox2.Text

        MiArticulo.IdRubro = ComboBox1.SelectedValue


        Select Case operacion_

            Case "Agregar"
                If ComboBox1.SelectedIndex = -1 Then Exit Sub

                ArticulosList.InsertarArticulo(MiArticulo)


            Case "Eliminar"
                ArticulosList.EliminarArticulo(MiArticulo)

            Case "Modificar"

                ArticulosList.ActualizarArticulo(MiArticulo)

        End Select

        Me.Close()

    End Sub

    Private Sub ArticuloForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.DataSource = RubrosList.TraerRubros()
        ComboBox1.DisplayMember = "Descripcion"
        ComboBox1.ValueMember = "Id"
        ComboBox1.SelectedValue = IdRubro_

    End Sub

End Class