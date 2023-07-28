DROP DATABASE if EXISTS LDD_Ex5;

CREATE DATABASE LDD_Ex5;

USE LDD_Ex5;

CREATE TABLE Magasins(
	CodeM INTEGER NOT NULL,
	NomM VARCHAR(50) NOT NULL,
	
	PRIMARY KEY (CodeM)	
);

CREATE TABLE Rayons(
	NomR VARCHAR(50) NOT NULL,
	
	PRIMARY KEY (NomR)
);

CREATE TABLE Articles(
	CodeA INTEGER NOT NULL,
	NomA VARCHAR(50) NOT NULL,
	TypeA CHAR(1) NOT NULL CHECK (TypeA IN ('P', 'L', 'D')),
	
	CONSTRAINT PK_CodeA PRIMARY KEY (CodeA)
);

CREATE TABLE Ventes(
	CodeM INTEGER NOT NULL,
	NomR VARCHAR(50) NOT NULL,
	CodeA INTEGER NOT NULL,
	QuantiteS INTEGER NOT NULL,
	
	CONSTRAINT PK_CodeM_NomR_CodeA PRIMARY KEY (CodeM, NomR, CodeA),
	CONSTRAINT FK_Magasins FOREIGN KEY (CodeM) REFERENCES Magasins(CodeM),
	CONSTRAINT FK_Rayons FOREIGN KEY (NomR) REFERENCES Rayons(NomR),
	CONSTRAINT FK_Articles FOREIGN KEY (CodeA) REFERENCES Articles(CodeA)
);