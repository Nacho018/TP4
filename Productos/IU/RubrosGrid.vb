Public Class RubrosGrid



    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        RubroForm.operacion = "Agregar"
        RubroForm.Text = "Agregar"
        'RubroForm.TituloLabel.Text = "Agregar"

        RubroForm.Show()

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        RubroForm.operacion = "Eliminar"
        RubroForm.Text = "Eliminar Rubro"
        'RubroForm.TituloLabel.Text = "Eliminar Turno"

        'Número de fila seleccionado en el datagridview
        RubroForm.indice = DataGridView1.CurrentRow.Index

        LlenarForm()
        RubroForm.Show()

    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        RubroForm.operacion = "Modificar"
        RubroForm.Text = "Modificar Rubro"
        ' RubroForm.TituloLabel.Text = "Modificar Turno"

        LlenarForm()
        RubroForm.Show()

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = False
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip2.Enabled = True

        Me.Close()

    End Sub

    Private Sub RubrosGrid_Load(sender As Object, e As EventArgs) Handles Me.Load



        MenuForm.Label1.Text = "Productos"
        RubrosCollectionBindingSource.DataSource = RubrosList.TraerRubros

        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

    End Sub

    Private Sub LlenarForm()

        'Número de fila seleccionado en el datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        RubroForm.IdTextBox1.Text = RubrosList.Item(fila).Id
        RubroForm.DescripcionTextBox2.Text = RubrosList.Item(fila).Descripcion


    End Sub

    Private Sub RubrosGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.Label1.Text = " Productos "
        MenuForm.ToolStrip2.Enabled = True

        Me.Dispose()

    End Sub



End Class


