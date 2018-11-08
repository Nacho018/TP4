Imports System.ComponentModel
Imports System.Text

Public Class ArticulosCollection

    Inherits BindingList(Of ArticuloClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)
        e.NewObject = New ArticuloClass
    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(ByVal prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each carrera In Me
            If prop.GetValue(carrera).Equals(key) Then
                Return Me.IndexOf(carrera)
            End If
        Next

        Return -1
    End Function

    ''' <summary>
    ''' Trae todos las Articulos.
    ''' </summary>
    ''' <returns></returns>
    Public Function TraerArticulos() As ArticulosCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiArticulo As ArticuloClass

        ObjBaseDatos.objTabla = "Articulos"
        MiDataTable = ObjBaseDatos.TraerTodo

        For Each dr As DataRow In MiDataTable.Rows
            MiArticulo = New ArticuloClass

            MiArticulo.Id = CInt(dr("Id"))
            MiArticulo.Descripcion = dr("Descripcion")
            MiArticulo.IdRubro = CInt("IdRubro")

            Me.Add(MiArticulo)
        Next

        Return Me

    End Function

    ''' <summary>
    ''' Trae las Articulos filtrado por IdTurno.
    ''' </summary>
    ''' <param name="IdRubro"></param>
    ''' <returns></returns>
    Public Function TraerArticulos(ByVal IdRubro As Integer) As ArticulosCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiArticulo As ArticuloClass
        Dim filtro As String = "IdRubro = " & IdRubro

        ObjBaseDatos.objTabla = "Articulos"
        MiDataTable = ObjBaseDatos.TraerFiltrado(filtro)

        For Each dr As DataRow In MiDataTable.Rows
            MiArticulo = New ArticuloClass

            MiArticulo.Id = CInt(dr("Id"))
            MiArticulo.Descripcion = dr("Descripcion")
            MiArticulo.IdRubro = CInt(dr("IdRubro"))

            Me.Add(MiArticulo)
        Next

        Return Me

    End Function

    Public Sub InsertarArticulo(ByVal MiArticulo As ArticuloClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'busca la tabla personas 
        ObjBasedeDato.objTabla = "Articulos"

        Dim vsql As New StringBuilder

        vsql.Append("(Descripcion")
        vsql.Append(", IdRubro)")

        vsql.Append(" VALUES ")

        vsql.Append("('" & MiArticulo.Descripcion & "'")
        vsql.Append(", '" & MiArticulo.IdRubro & "')")

        MiArticulo.Id = ObjBasedeDato.Insertar(vsql.ToString)

        'Evalúa el resultado del comando SQL.
        If MiArticulo.Id = 0 Then
            MsgBox("No fue posible agregar el Articulo ")
            Exit Sub
        End If

        Me.Add(MiArticulo)

    End Sub

    Public Sub EliminarArticulos(ByVal MiArticulo As ArticuloClass)


        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Articulo"

        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiArticulo.Id)

        If resultado Then

            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiArticulo)

            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiArticulo.Id))

        Else
            MessageBox.Show("No fue posible eliminar el registro.")
        End If

    End Sub

    Public Sub EliminarArticulo(ByVal MiArticulo As ArticuloClass)

        'Llena articulosList con articulos del IdRubro
        'ArticulosList.TraerArticulos(IdRubro)

        'Instancio el el Objeto BaseDatosClass para acceder al la base productos.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Articulo"

        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiArticulo.Id)

        If resultado Then
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiArticulo)

            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiArticulo.Id))



        Else
            MessageBox.Show("No fue posible eliminar el registro.")



        End If



        Me.ClearItems()

    End Sub

    Public Sub ActualizarArticulo(ByVal MiArticulo As ArticuloClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base productos.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Articulos"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        vSQL.Append("Descripcion='" & MiArticulo.Descripcion & "'")
        vSQL.Append(",IdRubro='" & MiArticulo.IdRubro.ToString & "'")

        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiArticulo.Id)

        If Not resultado Then
            MessageBox.Show("No fue posible modificar el registro.")
            Exit Sub
        End If

        'El código a continuación sirve para localizar el ítem en la lista
        'en este caso un persona.
        ' Creates a new collection and assign it the properties for modulo.
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiArticulo)

        'Sets an PropertyDescriptor to the specific property Id.
        Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
        Me.Items.Item(Me.FindCore(myProperty, MiArticulo.Id)) = MiArticulo

    End Sub

End Class


