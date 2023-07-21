CREATE DATABASE LDD_Ex2;

USE LDD_Ex2;

CREATE TABLE Etudiant(
	id_etudiant INTEGER NOT NULL AUTO_INCREMENT,
	Nom VARCHAR(50) NOT NULL,
	Prenom VARCHAR(50) NOT NULL,
	Date_entree DATETIME NOT NULL,
	
	CONSTRAINT PK_id_etudiant PRIMARY KEY (id_etudiant)
);

CREATE TABLE Matiere(
	id_matiere INTEGER NOT NULL AUTO_INCREMENT,
	lib_matiere VARCHAR(50) NOT NULL,
	coefficient INTEGER NOT NULL,

	CONSTRAINT PK_id_matiere PRIMARY KEY (id_matiere)
);

CREATE TABLE Note(
	id_etudiant INTEGER NOT NULL,
	id_matiere INTEGER NOT NULL,
	moyenne DECIMAL(4,2) NOT NULL,
	
	CONSTRAINT PK_id_etudiant_id_matiere PRIMARY KEY (id_etudiant, id_matiere),
	CONSTRAINT FK_Etudiant FOREIGN KEY (id_etudiant) REFERENCES Etudiant(id_etudiant),
	CONSTRAINT FK_Matiere FOREIGN KEY (id_matiere) REFERENCES Matiere(id_matiere)
);
