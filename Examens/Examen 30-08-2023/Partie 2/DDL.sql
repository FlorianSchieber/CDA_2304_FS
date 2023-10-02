DROP DATABASE if EXISTS db_garage;

CREATE DATABASE db_garage;

USE db_garage;

CREATE TABLE realisations (
	id_rea INT(10) UNSIGNED NOT NULL,
	titre_rea VARCHAR(255) NOT NULL,
	date_rea DATE NOT NULL,
	texte_rea TEXT NOT NULL
);

ALTER TABLE realisations
	ADD PRIMARY KEY (id_rea);

ALTER TABLE realisations
	AUTO_INCREMENT = 10;
	
CREATE TABLE images (
	id_img INT(10) UNSIGNED NOT NULL,
	url_img VARCHAR(250) NOT NULL,
	nom_img VARCHAR(100) NOT NULL,
	text_img VARCHAR(300) NOT NULL,
	ext_img VARCHAR(5) NOT NULL
);

ALTER TABLE images
	ADD PRIMARY KEY (id_img);

ALTER TABLE images
	AUTO_INCREMENT = 1;
	
ALTER TABLE realisations
	ADD COLUMN id_img INT(10) UNSIGNED NOT NULL,
	ADD CONSTRAINT fk_rea_img FOREIGN KEY (id_img) REFERENCES images(id_img);
	
ALTER TABLE realisations
	DROP FOREIGN KEY fk_rea_img,
	DROP COLUMN id_img;
	
CREATE TABLE associations (
	id_rea INT(10) UNSIGNED NOT NULL,
	id_img INT(10) UNSIGNED NOT NULL,
	
	PRIMARY KEY (id_rea, id_img)
);

ALTER TABLE associations
	ADD CONSTRAINT fk_asso_rea FOREIGN KEY (id_rea) REFERENCES realisations(id_rea),
	ADD CONSTRAINT fk_asso_img FOREIGN KEY (id_img) REFERENCES images(id_img)
;