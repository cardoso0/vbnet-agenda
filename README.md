
# 📅 Agenda de Compromissos - VB.NET WinForms

Projeto de agenda de compromissos desenvolvido com **VB.NET** utilizando **Windows Forms** e **SQL Server**.  
Permite cadastro, edição, exclusão e visualização de compromissos com autenticação de usuários.

---

## 🛠 Funcionalidades

- Cadastro e login de usuários
- CRUD de compromissos
- Validação de campos (sem caracteres especiais em nome de usuário)
- Filtro por data: Hoje, Semana, Mês
- Logout e troca de usuários

---

## 🚀 Tecnologias utilizadas

- VB.NET (.NET Framework)
- Windows Forms
- SQL Server (LocalDB ou outro)
- ADO.NET (SqlConnection, SqlCommand)

---

## 📦 Como executar o projeto

### Pré-requisitos:

* Visual Studio com suporte a VB.NET
* SQL Server (ou SQL Server Express)
* SQL Server Management Studio (SSMS)
- Git (opcional)

### Clonando o repositório

```bash
git clone https://github.com/cardoso0/vbnet-agenda.git
```

### Criando o banco de dados

Abra o SQL Server Management Studio e execute o script abaixo para criar o banco de dados e tabelas:

```sql
-- Criação do banco de dados (você pode trocar o nome se quiser)
CREATE DATABASE AgendaDB;
GO

-- Seleciona o banco de dados criado
USE AgendaDB;
GO

-- Criação da tabela de usuários
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Usuario NVARCHAR(50) NOT NULL UNIQUE,
    Senha NVARCHAR(50) NOT NULL,
    Nome NVARCHAR(100) NOT NULL
);
GO

-- Criação da tabela de compromissos
CREATE TABLE Compromissos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(MAX),
    DataHora DATETIME NOT NULL,
    UsuarioId INT NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);
GO

-- Inserção de um usuário inicial para testes
INSERT INTO Usuarios (Usuario, Senha, Nome)
VALUES ('admin', '1234', 'Administrador');
GO
```

### Ajuste de conexão

Edite o arquivo `DbConnection.vb` para colocar a **string de conexão** com seu banco local:

```vb.net
"Data Source=SEU_SERVIDOR;Initial Catalog=AgendaDB;Integrated Security=True"
```

### Executando o projeto

Abra o `.sln` no Visual Studio e pressione `F5` para rodar.

---

## 👨‍💻 Autor

Desenvolvido por **Felipe Cardoso**  
[LinkedIn](https://www.linkedin.com/in/felipe-pontes-cardoso-9b93401a0/) | [GitHub](https://github.com/cardoso0)

---

## 📌 Licença

Este projeto está sob a licença MIT. Sinta-se à vontade para usar e modificar.
