DROP DATABASE if EXISTS LDD_Ex2;

CREATE DATABASE LDD_Ex2;

USE LDD_Ex2;

CREATE TABLE Etudiants(
	id_etudiant INTEGER NOT NULL AUTO_INCREMENT,
	Nom VARCHAR(50) NOT NULL,
	Prenom VARCHAR(50) NOT NULL,
	Date_entree DATE NOT NULL,
	
	PRIMARY KEY (id_etudiant)
);

CREATE TABLE Matieres(
	id_matiere INTEGER NOT NULL AUTO_INCREMENT,
	lib_matiere VARCHAR(50) NOT NULL UNIQUE,
	coefficient INTEGER NOT NULL,

	PRIMARY KEY (id_matiere)
);

CREATE TABLE Notes(
	id_etudiant INTEGER NOT NULL,
	id_matiere INTEGER NOT NULL,
	Moyenne DECIMAL(4,2) NOT NULL,
	
	PRIMARY KEY (id_etudiant, id_matiere)
);

ALTER TABLE Notes
	ADD CONSTRAINT FK_Notes_Etudiants FOREIGN KEY (id_etudiant) REFERENCES Etudiants(id_etudiant),
	ADD CONSTRAINT FK_Notes_Matieres FOREIGN KEY (id_matiere) REFERENCES Matieres(id_matiere)
;