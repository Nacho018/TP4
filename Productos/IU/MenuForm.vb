Public Class MenuForm
    Private Sub SalirButton_Click(sender As Object, e As EventArgs) Handles SalirButton.Click
        End
    End Sub

    Private Sub RubrosButton_Click(sender As Object, e As EventArgs) Handles RubrosButton.Click

        ToolStrip2.Enabled = False

        Dim GridRubros As New RubrosGrid

        GridRubros.MdiParent = Me

        GridRubros.Show()


    End Sub


    Private Sub ArticulosButton_Click(sender As Object, e As EventArgs) Handles ArticulosButton.Click

        ToolStrip2.Enabled = False

        Dim GridArticulos As New ArticulosGrid

        GridArticulos.MdiParent = Me

        GridArticulos.Show()


    End Sub

End Class