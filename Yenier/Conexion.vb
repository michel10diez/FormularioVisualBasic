Imports System.Data.Sql
Imports System.Data.SqlClient

Module Conexion
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Public adaptador As SqlDataAdapter

    '*************Funcion de Conexion a la base de datos**************'
    Sub abrir()
        Try
            conexiones = New SqlConnection("Data Source=DESKTOP-R12OLQS;Initial Catalog=yenier;Integrated Security=True")
            conexiones.Open()
            MsgBox("Conexion Exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente")
        Catch ex As Exception
            MsgBox("Error al conectarse" & ex.Message, MsgBoxStyle.Critical, "Error")
            conexiones.Close()
        End Try
    End Sub

    '**********************Inserción a la base de datos***********************'
    Function insercionYener(ByVal identificacion As String, ByVal nombre As String, ByVal fecha As Date, ByVal edad As Integer) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("insert into persona(identificacion, nombre, fecha, edad)values('" & identificacion & "', '" & nombre & "', '" & fecha & "'," & edad & ")", conexiones)
            enunciado.ExecuteNonQuery()
            resultado = "Se ha registrado correctamente"
            'conexiones.Close()'
        Catch ex As Exception
            resultado = "no se ha resgistrado" + ex.ToString
            'conexiones.Close()'
        End Try
        Return resultado
    End Function
    '*******************************************************************************************'

    '***********************Eliminar Datos**************************************'



End Module
