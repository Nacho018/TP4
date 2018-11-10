Public Class RubroForm

    Dim operacion_ As String
    Dim MiRubro As New RubroClass

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


            MiRubro.Id = CInt(IdTextBox1.Text)

        End If

        MiRubro.Descripcion = DescripcionTextBox2.Text


        Select Case operacion_

            Case "Agregar"
                RubrosList.InsertarRubro(MiRubro)

            Case "Eliminar"
                'RubrosList.TraerRubros(MiRubro)
                RubrosList.EliminarRubro(MiRubro)

            Case "Modificar"

                RubrosList.ActualizarRubro(MiRubro)

        End Select

        Me.Close()

    End Sub

    Private Sub RubroForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        DescripcionTextBox2.Focus()
    End Sub

End Class


