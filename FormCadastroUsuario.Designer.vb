<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastroUsuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.BtnCadastrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblUsuarioErro = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(59, 64)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsuario.TabIndex = 2
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(59, 113)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(100, 20)
        Me.TxtSenha.TabIndex = 3
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Location = New System.Drawing.Point(71, 139)
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCadastrar.TabIndex = 4
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnCadastrar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtSenha)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(289, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 204)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'LblUsuarioErro
        '
        Me.LblUsuarioErro.AutoSize = True
        Me.LblUsuarioErro.ForeColor = System.Drawing.Color.Red
        Me.LblUsuarioErro.Location = New System.Drawing.Point(171, 107)
        Me.LblUsuarioErro.Name = "LblUsuarioErro"
        Me.LblUsuarioErro.Size = New System.Drawing.Size(442, 13)
        Me.LblUsuarioErro.TabIndex = 5
        Me.LblUsuarioErro.Text = "Usuário inválido. Use apenas letras, números e hífens (sem começar ou terminar co" &
    "m hífen)."
        Me.LblUsuarioErro.Visible = False
        '
        'FormCadastroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblUsuarioErro)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCadastroUsuario"
        Me.Text = "FormCadastroUsuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents BtnCadastrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblUsuarioErro As Label
End Class
