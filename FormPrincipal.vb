Imports System.Data.SqlClient
Imports System.Threading

Public Class FormPrincipal
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub
    Private _userId As Integer

    Private Sub LimparCampos()
        TxtTitulo.Text = ""
        TxtDescricao.Text = ""
        DtpDataHora.Value = DateTime.Now
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        If String.IsNullOrWhiteSpace(TxtTitulo.Text) OrElse
            String.IsNullOrWhiteSpace(TxtDescricao.Text) OrElse
            String.IsNullOrWhiteSpace(_userId) Then
            MessageBox.Show("Preencha todos os campos.")
            Exit Sub
        End If

        Using conn As SqlConnection = DbConnection.GetConnection()
            Dim query As String = "INSERT INTO Compromissos (Titulo, Descricao, DataHora, UsuarioId) VALUES (@Titulo, @Descricao, @DataHora, @UsuarioId)"
            Dim cmd As New SqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@Titulo", TxtTitulo.Text)
            cmd.Parameters.AddWithValue("@Descricao", TxtDescricao.Text)
            cmd.Parameters.AddWithValue("@DataHora", DtpDataHora.Value)
            cmd.Parameters.AddWithValue("@UsuarioId", Convert.ToInt32(_userId))

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Compromisso adicionado com sucesso!")

                ' Atualiza a Lista
                CarregarCompromissos()

                LimparCampos()
            Catch ex As Exception
                MessageBox.Show("UsuarioId _userId enviado: " & _userId)
                MessageBox.Show("Erro ao adicionar compromisso: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If DgvCompromissos.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione um compromisso para editar.")
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(DgvCompromissos.SelectedRows(0).Cells("Id").Value)
        Dim titulo As String = TxtTitulo.Text.Trim()
        Dim descricao As String = TxtDescricao.Text.Trim()
        Dim dataHora As DateTime = DtpDataHora.Value

        If titulo = "" Then
            MessageBox.Show("Informe o título.")
            Exit Sub
        End If

        Dim query As String = "UPDATE Compromissos SET Titulo=@Titulo, Descricao=@Descricao, DataHora=@DataHora WHERE Id=@Id"

        Using conn As SqlConnection = DbConnection.GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Titulo", titulo)
                cmd.Parameters.AddWithValue("@Descricao", descricao)
                cmd.Parameters.AddWithValue("@DataHora", dataHora)
                cmd.Parameters.AddWithValue("@Id", id)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Compromisso atualizado com sucesso.")
        CarregarCompromissos()
        LimparCampos()
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If DgvCompromissos.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione um compromisso para excluir.")
            Exit Sub
        End If

        Dim confirm As DialogResult = MessageBox.Show("Tem certeza que deseja excluir este compromisso?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then
            Exit Sub
        End If

        Dim id As Integer = Convert.ToInt32(DgvCompromissos.SelectedRows(0).Cells("id").Value)

        Dim query As String = "DELETE FROM Compromissos WHERE Id=@Id"

        Try
            Using conn As SqlConnection = DbConnection.GetConnection()
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Compromisso excluído com sucesso.")
            CarregarCompromissos()
            LimparCampos()
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir compromisso: " & ex.Message)
        End Try
    End Sub
    Private Sub DgvCompromissos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCompromissos.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvCompromissos.Rows(e.RowIndex)
            TxtTitulo.Text = row.Cells("Titulo").Value.ToString()
            TxtDescricao.Text = row.Cells("Descricao").Value.ToString()
            DtpDataHora.Value = Convert.ToDateTime(row.Cells("DataHora").Value)
        End If
    End Sub
    Private Sub CarregarCompromissos()
        Using conn As SqlConnection = DbConnection.GetConnection()
            Dim query As String = "SELECT id, Titulo, Descricao, DataHora FROM Compromissos WHERE UsuarioId = @UsuarioId ORDER BY DataHora"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@UsuarioId", _userId)

            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()

            Try
                adapter.Fill(dt)
                DgvCompromissos.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Erro ao carregar compromissos: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub FormAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarCompromissos()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        ' Fecha a tela principal
        Me.Close()

        ' Mostra novamente a tela de login
        Dim formLogin As New FormLogin()
        formLogin.Show()
    End Sub
End Class