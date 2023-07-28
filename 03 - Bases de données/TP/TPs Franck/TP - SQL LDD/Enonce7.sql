DROP DATABASE if EXISTS LDD_Ex7;

CREATE DATABASE LDD_Ex7;

USE LDD_Ex7;

CREATE TABLE VIGNERONS(
	Num_Vig INTEGER NOT NULL AUTO_INCREMENT,
	Nom_Vig VARCHAR(50) NOT NULL,
	
	CONSTRAINT PK_Num_Vig PRIMARY KEY (Num_Vig)
);

CREATE TABLE VINS(
	Num_Vin INTEGER NOT NULL AUTO_INCREMENT,
	Cru VARCHAR(50) NOT NULL,
	Millesime INTEGER NOT NULL,
	Num_Vig INTEGER NOT NULL,
	
	CONSTRAINT PK_Num_Vin PRIMARY KEY (Num_Vin),
	CONSTRAINT FK_VIGNERON FOREIGN KEY (Num_Vig) REFERENCES VIGNERONS(Num_Vig)
);

CREATE TABLE BUVEURS(
	Num_Buv INTEGER NOT NULL AUTO_INCREMENT,
	Nom_Buv VARCHAR(50) NOT NULL,
	Prenom_Buv VARCHAR(50) NOT NULL,
	Ville_Buv VARCHAR(50) NOT NULL,
	
	CONSTRAINT PK_Num_Buv PRIMARY KEY (Num_Buv)
);

CREATE TABLE COMMANDES(
	Num_Com INTEGER NOT NULL AUTO_INCREMENT,
	Date_Com DATE NOT NULL,
	Num_Buv INTEGER NOT NULL,
	
	CONSTRAINT PK_Num_Com PRIMARY KEY (Num_Com),
	CONSTRAINT FK_BUVEURS FOREIGN KEY (Num_Buv) REFERENCES BUVEURS(Num_Buv)
);

CREATE TABLE ACHATS(
	Num_Vin INTEGER NOT NULL,
	Num_Com INTEGER NOT NULL,
	Quantite INTEGER NOT NULL,
	
	CONSTRAINT PK_Num_Vin_Num_Com PRIMARY KEY (Num_Vin, Num_Com),
	CONSTRAINT FK_VIN FOREIGN KEY (Num_Vin) REFERENCES VINS(Num_Vin),
	CONSTRAINT FK_COMMANDES FOREIGN KEY (Num_Com) REFERENCES COMMANDES(Num_Com)
);