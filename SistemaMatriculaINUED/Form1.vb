Imports System.Data.OleDb
Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim conexion As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=G:\1 CLASES 2024\PROGRAMACION 12C\II Parcial\SistemaMatriculaINUED\Base de Datos\matriculaINUED(2002-2003).mdb")
        Try
            conexion.Open()
            MsgBox("Conectado")

            Dim query = "Select * from maestro"
            Dim adap As New OleDbDataAdapter(query, conexion)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub
End Class
