Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim usuario As String = TxtUsuario.Text.Trim()
        Dim senha As String = TxtSenha.Text.Trim()

        If usuario = "" OrElse senha = "" Then
            MessageBox.Show("Por favor, preencha usuário e senha.")
            Exit Sub
        End If

        If Not Regex.IsMatch(usuario, "^[a-zA-Z0-9]+(?:-[a-zA-Z0-9]+)*$") Then
            MessageBox.Show("Nome de usuário inválido. Use apenas letras, números e hífens (sem iniciar ou terminar com hífen).")
            Exit Sub
        End If

        Using conn As SqlConnection = DbConnection.GetConnection()

            Dim query As String = "SELECT Id FROM Usuarios WHERE Usuario=@usuario AND Senha=@senha"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@senha", senha)

            Using reader As SqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim userId As Integer = reader.GetInt32(0)
                    MessageBox.Show("Login realizado com sucesso!")

                    ' Abre tela principal passando o ID do usuário logado
                    Dim formPrincipal As New FormPrincipal(userId)
                    Me.Hide()
                    formPrincipal.Show()
                Else
                    MessageBox.Show("Usuário ou senha inválidos!")
                End If
            End Using
        End Using
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = BtnLogin
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
    Private Sub BtnCriarConta_Click(sender As Object, e As EventArgs) Handles BtnCriarConta.Click
        Dim cadastroForm As New FormCadastroUsuario()
        cadastroForm.ShowDialog()
    End Sub
End Class