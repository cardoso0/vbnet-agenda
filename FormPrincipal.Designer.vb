<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTitulo = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.DtpDataHora = New System.Windows.Forms.DateTimePicker()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.DgvCompromissos = New System.Windows.Forms.DataGridView()
        Me.BtnLogout = New System.Windows.Forms.Button()
        CType(Me.DgvCompromissos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Título:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data e Hora:"
        '
        'TxtTitulo
        '
        Me.TxtTitulo.Location = New System.Drawing.Point(12, 25)
        Me.TxtTitulo.Name = "TxtTitulo"
        Me.TxtTitulo.Size = New System.Drawing.Size(206, 20)
        Me.TxtTitulo.TabIndex = 3
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(12, 74)
        Me.TxtDescricao.Multiline = True
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(259, 63)
        Me.TxtDescricao.TabIndex = 4
        '
        'DtpDataHora
        '
        Me.DtpDataHora.Location = New System.Drawing.Point(12, 166)
        Me.DtpDataHora.Name = "DtpDataHora"
        Me.DtpDataHora.Size = New System.Drawing.Size(200, 20)
        Me.DtpDataHora.TabIndex = 5
        '
        'BtnNovo
        '
        Me.BtnNovo.Location = New System.Drawing.Point(11, 202)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNovo.TabIndex = 6
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(92, 202)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 7
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Location = New System.Drawing.Point(173, 202)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.BtnExcluir.TabIndex = 8
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'DgvCompromissos
        '
        Me.DgvCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCompromissos.Location = New System.Drawing.Point(11, 231)
        Me.DgvCompromissos.Name = "DgvCompromissos"
        Me.DgvCompromissos.ReadOnly = True
        Me.DgvCompromissos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCompromissos.Size = New System.Drawing.Size(621, 207)
        Me.DgvCompromissos.TabIndex = 9
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(713, 9)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(75, 23)
        Me.BtnLogout.TabIndex = 10
        Me.BtnLogout.Text = "Sair"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.DgvCompromissos)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.DtpDataHora)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.TxtTitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPrincipal"
        Me.Text = "FormPrincipal"
        CType(Me.DgvCompromissos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTitulo As TextBox
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents DtpDataHora As DateTimePicker
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents DgvCompromissos As DataGridView
    Friend WithEvents BtnLogout As Button
End Class
