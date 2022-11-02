USE master;
GO
DROP DATABASE Tuottavuus;
GO
CREATE DATABASE Tuottavuus;
GO
USE Tuottavuus;
GO

CREATE TABLE Feriado(
	Id INT NOT NULL IDENTITY,
	Ano INT NOT NULL,
	Data_Feriado DATETIME NOT NULL,
	Descricao VARCHAR(50)

CONSTRAINT PK_Id_Feriado PRIMARY KEY(Id)
);
GO
CREATE TABLE Indicador(
	Id INT NOT NULL IDENTITY,
	Descricao VARCHAR(150) NOT NULL,
	Ativo BIT NOT NULL DEFAULT 1,
	Pesquisa BIT NOT NULL DEFAULT 0,
	Chamado BIT NOT NULL DEFAULT 0,
	Assiduidade BIT NOT NULL DEFAULT 0,
	Captura BIT NOT NULL DEFAULT 0,
	Feedback BIT NOT NULL DEFAULT 0

CONSTRAINT PK_Id_Indicador PRIMARY KEY(Id)

);
GO

CREATE TABLE Atividade(
	Id INT NOT NULL IDENTITY,
	Descricao VARCHAR(150) NOT NULL,
	Ativo BIT NOT NULL DEFAULT 1

CONSTRAINT PK_Id_Atividade PRIMARY KEY(Id)
);
GO

CREATE TABLE Competencia(
	Id INT NOT NULL IDENTITY,
	Competencia DATETIME NOT NULL,
	Ativo BIT NOT NULL DEFAULT 1

CONSTRAINT PK_Id_Competencia PRIMARY KEY(Id)
);
GO

CREATE TABLE Departamento(
	Id INT NOT NULL IDENTITY,
	Descricao VARCHAR(150) NOT NULL

CONSTRAINT PK_Id_Departamento PRIMARY KEY(Id)
);
GO

CREATE TABLE Empresa(
	Id INT NOT NULL IDENTITY,
	Nome VARCHAR(150) NOT NULL,
	Ativo BIT NOT NULL DEFAULT 1

CONSTRAINT PK_Id_Empresa PRIMARY KEY(Id)
);
GO

CREATE TABLE PesquisaNota(
	Id INT NOT NULL IDENTITY,
	Nota INT NOT NULL,
	Data DATETIME NOT NULL
CONSTRAINT PK_Id_PesquisaNota PRIMARY KEY(Id)
);
GO

CREATE TABLE ProdutividadeBase(
	Id INT NOT NULL IDENTITY,
	Data_Cadastro DATETIME NOT NULL,
	Valor DECIMAL(10,2) NOT NULL

CONSTRAINT PK_Id_ProdutividadeBase PRIMARY KEY(Id)
);
GO

CREATE TABLE MetaPeso(
	Id INT NOT NULL IDENTITY,
	Id_Indicador INT NOT NULL,
	Meta DECIMAL(5,2) NOT NULL DEFAULT 0,
	Peso DECIMAL(5,2) NOT NULL DEFAULT 0
	
CONSTRAINT PK_Id_MetaPeso PRIMARY KEY(Id),
CONSTRAINT FK_Indicador_MetaPeso FOREIGN KEY (Id_Indicador)
	REFERENCES Indicador(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO

CREATE TABLE Empregado(
	Id INT NOT NULL IDENTITY,
	Id_Empresa INT NOT NULL,
	Id_Departamento INT NOT NULL,
	Codigo INT,
	Nome VARCHAR(150) NOT NULL,
	Ativo BIT NOT NULL DEFAULT 1

CONSTRAINT PK_Id_Empregado PRIMARY KEY(Id),
CONSTRAINT FK_Empresa_Empregado FOREIGN KEY(Id_Empresa)
	REFERENCES Empresa(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
CONSTRAINT FK_Depart_Empregado FOREIGN KEY(Id_Departamento)
	REFERENCES Departamento(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO

CREATE TABLE Assiduidade(
	Id INT NOT NULL IDENTITY,
	Id_Competencia INT NOT NULL,
	Id_Empresa INT NOT NULL,
	Id_Empregado INT NOT NULL,
	AtrasoFalta INT NOT NULL

CONSTRAINT PK_Id_Assiduidade PRIMARY KEY(Id),
CONSTRAINT FK_Comp_Assiduidade FOREIGN KEY(Id_Competencia)
	REFERENCES Competencia(Id),
CONSTRAINT FK_Empresa_Assiduidade FOREIGN KEY(Id_Empresa)
	REFERENCES Empresa(Id),
CONSTRAINT FK_Empregado_Assiduidade FOREIGN KEY(Id_Empregado)
	REFERENCES Empregado(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO

CREATE TABLE AtividadeAvaliacao(
	Id INT NOT NULL IDENTITY,
	Id_Competencia INT NOT NULL,
	Id_Empresa INT NOT NULL,
	Id_Empregado INT NOT NULL,
	Id_Atividade INT NOT NULL,
	Nota DECIMAL(5,2) NOT NULL DEFAULT 0,

CONSTRAINT PK_Id_AtividadeAvaliacao PRIMARY KEY(Id),
CONSTRAINT FK_Comp_AtividadeAvaliacao FOREIGN KEY(Id_Competencia)
	REFERENCES Competencia(Id),
CONSTRAINT FK_Empresa_AtividadeAvaliacao FOREIGN KEY(Id_Empresa)
	REFERENCES Empresa(Id),
CONSTRAINT FK_Empregado_AtividadeAvaliacao FOREIGN KEY(Id_Empregado)
	REFERENCES Empregado(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
CONSTRAINT FK_Atividade_AtividadeAvaliacao FOREIGN KEY(Id_Atividade)
	REFERENCES Atividade(Id)
);
GO

CREATE TABLE IndicadorAvaliacao(
	Id INT NOT NULL IDENTITY,
	Id_Competencia INT NOT NULL,
	Id_Empresa INT NOT NULL,
	Id_Empregado INT NOT NULL,
	Nota DECIMAL(5,2) NOT NULL DEFAULT 0,

CONSTRAINT PK_Id_IndicadorAvaliacao PRIMARY KEY(Id),
CONSTRAINT FK_Comp_IndicadorAvaliacao FOREIGN KEY(Id_Competencia)
	REFERENCES Competencia(Id),
CONSTRAINT FK_Empresa_IndicadorAvaliacao FOREIGN KEY(Id_Empresa)
	REFERENCES Empresa(Id),
CONSTRAINT FK_Empregado_IndicadorAvaliacao FOREIGN KEY(Id_Empregado)
	REFERENCES Empregado(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO

CREATE TABLE PossoMais(
	Id INT NOT NULL IDENTITY,
	Id_Competencia INT NOT NULL,
	Id_Empresa INT NOT NULL,
	Id_Empregado INT NOT NULL,
	Id_Meta INT NOT NULL,
	Total DECIMAL(10,2) NOT NULL DEFAULT 0,

CONSTRAINT PK_Id_PossoMais PRIMARY KEY(Id),
CONSTRAINT FK_Comp_PossoMais FOREIGN KEY(Id_Competencia)
	REFERENCES Competencia(Id),
CONSTRAINT FK_Empresa_PossoMais FOREIGN KEY(Id_Empresa)
	REFERENCES Empresa(Id),
CONSTRAINT FK_Empregado_PossoMais FOREIGN KEY(Id_Empregado)
	REFERENCES Empregado(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
CONSTRAINT FK_MetaPeso_PossoMais FOREIGN KEY(Id_Meta)
	REFERENCES MetaPeso(Id)
);
GO

CREATE TABLE Produtividade(
	Id INT NOT NULL IDENTITY,
	Id_Competencia INT NOT NULL,
	Id_Empresa INT NOT NULL,
	Id_Empregado INT NOT NULL,
	Dias_Apurados INT,
	Fer_Dom_Apurados INT,
	Media_Avaliacao INT,
	Produtividade_Valor DECIMAL(10,2),
	Produtividade_Reflexo DECIMAL(10,2),
	Data_Calculo DATETIME

CONSTRAINT PK_Id_Produtividade PRIMARY KEY(Id),
CONSTRAINT FK_Comp_Produtividade FOREIGN KEY(Id_Competencia)
	REFERENCES Competencia(Id),
CONSTRAINT FK_Empresa_Produtividade FOREIGN KEY(Id_Empresa)
	REFERENCES Empresa(Id),
CONSTRAINT FK_Empregado_Produtividade FOREIGN KEY(Id_Empregado)
	REFERENCES Empregado(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO


CREATE TABLE PesquisaAvaliacao(
	Id INT NOT NULL IDENTITY,
	Id_Competencia INT NOT NULL,
	Id_Empresa INT NOT NULL,
	Id_Empregado INT NOT NULL,
	DataAbertura DATETIME,
	CodigoAtendente INT,
	NomeAtendente VARCHAR(150),
	NotaConceito INT,
	Chamado INT,

CONSTRAINT PK_Id_PesquisaAvaliacao PRIMARY KEY(Id),
CONSTRAINT FK_Comp_PesquisaAvaliacao FOREIGN KEY(Id_Competencia)
	REFERENCES Competencia(Id),
CONSTRAINT FK_Empresa_PesquisaAvaliacao FOREIGN KEY(Id_Empresa)
	REFERENCES Empresa(Id),
CONSTRAINT FK_Empregado_PesquisaAvaliacao FOREIGN KEY(Id_Empregado)
	REFERENCES Empregado(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
CREATE TABLE Chamados(
	Id INT NOT NULL IDENTITY,
	Id_Competencia INT NOT NULL,
	Id_Empresa INT NOT NULL,
	Id_Empregado INT NOT NULL,
	DataAbertura DATETIME,
	Chamado INT,
	CodigoGrupoSolucao INT,
	DescGrupoSolucao VARCHAR(150),
	CodigoAtendente INT,
	NomeAtendente VARCHAR(150),
	CodigoNatureza INT,
	DescNatureza VARCHAR(150),
	CodigoTpAtividade INT,
	DescTpAtividade VARCHAR(150)
	
CONSTRAINT PK_Id_Chamados PRIMARY KEY(Id),
CONSTRAINT FK_Comp_Chamados FOREIGN KEY(Id_Competencia)
	REFERENCES Competencia(Id),
CONSTRAINT FK_Empresa_Chamados FOREIGN KEY(Id_Empresa)
	REFERENCES Empresa(Id),
CONSTRAINT FK_Empregado_Chamados FOREIGN KEY(Id_Empregado)
	REFERENCES Empregado(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO