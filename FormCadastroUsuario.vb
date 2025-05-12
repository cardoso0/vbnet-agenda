Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class FormCadastroUsuario
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Dim usuario As String = TxtUsuario.Text.Trim()
        Dim senha As String = TxtSenha.Text.Trim()

        If usuario = "" OrElse senha = "" Then
            MessageBox.Show("Por favor, preencha todos os campos.")
            Exit Sub
        End If

        If Not Regex.IsMatch(usuario, "^[a-zA-Z0-9]+(?:-[a-zA-Z0-9]+)*$") Then
            MessageBox.Show("Nome de usuário inválido. Use apenas letras, números e hífens (sem iniciar ou terminar com hífen).")
            Exit Sub
        End If

        Using conn As SqlConnection = DbConnection.GetConnection()
            Dim query As String = "INSERT INTO Usuarios (Nome, Usuario, Senha) VALUES (@nome, @usuario, @senha)"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@senha", senha)
                cmd.Parameters.AddWithValue("nome", "Comum")

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuário cadastrado com sucesso!")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Erro ao cadastrar: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub FormCadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = BtnCadastrar
        TxtSenha.PasswordChar = "*"c
    End Sub
    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        Dim input As String = TxtUsuario.Text
        Dim regex As New Regex("^[a-zA-Z0-9]+(?:-[a-zA-Z0-9]+)*$")

        If Not regex.IsMatch(input) AndAlso input <> "" Then
            LblUsuarioErro.Visible = True
            TxtUsuario.BackColor = Color.MistyRose
        Else
            LblUsuarioErro.Visible = False
            TxtUsuario.BackColor = Color.White
        End If
    End Sub
End Class