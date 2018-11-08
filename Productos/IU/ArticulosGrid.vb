Public Class ArticulosGrid



    Private Sub Agregar_Click(sender As Object, e As EventArgs)

        ArticuloForm.operacion = "Agregar"
        ArticuloForm.Text = "Agregar"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index

        'ArticuloForm.TituloLabel.Text = "Agregar"

        RubroForm.Show()

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs)

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        ArticuloForm.operacion = "Eliminar"
        ArticuloForm.Text = "Eliminar "
        ArticuloForm.indice = DataGridView1.CurrentRow.Index

        'ArticuloForm.TituloLabel.Text = "Eliminar "

        'Número de fila seleccionado en el datagridview
        RubroForm.indice = DataGridView1.CurrentRow.Index

        LlenarForm()
        ArticuloForm.Show()

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs)

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        ArticuloForm.operacion = "Modificar"
        ArticuloForm.Text = "Modificar"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index


        'ArticuloForm.TituloLabel.Text = "Modificar "

        LlenarForm()
        ArticuloForm.Show()

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = False
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip2.Enabled = True


        Me.Close()

    End Sub

    Private Sub ArticulosGrid_Load(sender As Object, e As EventArgs) Handles Me.Load



        MenuForm.Label1.Text = "Productos"
        'ArticulosCollectionBindingSource.DataSource = ArticulosList.TraerArticulos
        ArticulosCombo.ComboBox.DataSource = RubrosList.TraerRubros

        'Lleno el datagrid con turnosList.
        ' DataGridView1.DataSource = turnosList.TraerTurnos

        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

    End Sub

    Private Sub LlenarForm()

        'Número de fila seleccionado en el datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        ArticuloForm.TextBox1.Text = ArticulosList.Item(fila).Id
        ArticuloForm.TextBox2.Text = ArticulosList.Item(fila).Descripcion
        ArticuloForm.TextBox3.Text = ArticulosList.Item(fila).IdRubro

    End Sub

    Private Sub ArticulosGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.Label1.Text = " Articulos"
        MenuForm.ToolStrip2.Enabled = True

        Me.Dispose()

    End Sub

End Class