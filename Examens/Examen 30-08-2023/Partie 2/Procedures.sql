USE db_garage;

/*
2) Construire et tester la procédure stockées en MySQL qui permet de savoir combien 
de fois une image est utilisée toutes réalisations confondues en fonction du nom de 
l’image passé en paramètre (@nom_img ='camion Marconi2').
*/

DROP PROCEDURE if EXISTS nombre_utilisation_image;

DELIMITER |

CREATE PROCEDURE nombre_utilisation_image(IN in_nom_img VARCHAR(100), OUT out_compte INTEGER)
BEGIN
	SELECT COUNT(realisations.id_rea)
	INTO out_compte
	FROM realisations INNER JOIN associations ON realisations.id_rea = associations.id_rea
		INNER JOIN images ON associations.id_img = images.id_img
	WHERE nom_img = in_nom_img;
END|

DELIMITER ;