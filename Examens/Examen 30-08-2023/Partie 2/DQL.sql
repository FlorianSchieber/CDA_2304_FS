USE db_garage;

/*
1) Donner dans ce cas la requête qui pour une réalisation données (« id_rea »=51)
permet de trouver tous les noms des images associées et leur extensions…
*/

SELECT nom_img, ext_img
FROM realisations INNER JOIN associations ON realisations.id_rea = associations.id_rea
	INNER JOIN images ON associations.id_img = images.id_img
WHERE realisations.id_rea = 1
;

/*
2) Construire et tester la procédure stockées en MySQL qui permet de savoir combien 
de fois une image est utilisée toutes réalisations confondues en fonction du nom de 
l’image passé en paramètre (@nom_img ='camion Marconi2').
*/

CALL nombre_utilisation_image('Mercedes 710 SS Saoutchik avant', @compte);
SELECT @compte;

/*
3) Donner dans le cas où l’information « quel est l’image principale pour une réalisation 
donnée est renseignée dans la base », la requête qui pour une réalisation donnée
(«exemple id_rea » =43) permet de trouver l’identifiant et le nom de l’image 
« principale »

SELECT images.id_img, nom_img
FROM realisations INNER JOIN images ON realisations.id_img = images.id_img
WHERE id_rea = 43
;

*/