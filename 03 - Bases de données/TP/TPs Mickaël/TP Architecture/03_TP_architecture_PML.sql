USE db_architecte;

DROP PROCEDURE if EXISTS architectes_parmi_employes;

DROP PROCEDURE if EXISTS employes_selon_fonction;

DROP PROCEDURE if EXISTS nombre_effectif_selon_fonction;

DROP PROCEDURE if EXISTS projets_selon_employe;

DROP PROCEDURE if EXISTS anciennete_employe;

DROP PROCEDURE if EXISTS ajouter_prix_selon_projet;

DELIMITER |

-- 1) matricule, nom et prénom des architectes

CREATE PROCEDURE architectes_parmi_employes()
BEGIN
	SELECT emp_matricule, emp_nom, emp_prenom
	FROM employes JOIN fonctions ON employes.fonction_id = fonctions.fonction_id
	WHERE fonction_nom = 'Architecte';
END|

-- 2) listes des employés d'une fonction donnée

CREATE PROCEDURE employes_selon_fonction(IN in_fonction_nom VARCHAR(50))
BEGIN
	SELECT emp_matricule, emp_nom, emp_prenom, emp_date_embauche
	FROM employes JOIN fonctions ON employes.fonction_id = fonctions.fonction_id
	WHERE fonction_nom = in_fonction_nom;
END|

-- 3) nombre effectif en sortie pour une fonction donnee

CREATE PROCEDURE nombre_effectif_selon_fonction(IN in_fonction_nom VARCHAR(50), OUT out_nombre_effectif INT)
BEGIN
	SELECT COUNT(emp_matricule)
	INTO out_nombre_effectif
	FROM employes JOIN fonctions ON employes.fonction_id = fonctions.fonction_id
	WHERE fonction_nom = in_fonction_nom;
END|

-- 4) afficher la liste des projets (projet_ref, date de fin prevue, projet_prix) pour un nom d'employé donné
/* 
CREATE PROCEDURE projets_selon_employe(IN in_emp_nom VARCHAR(50))
BEGIN
	SELECT projet_ref, projet_date_fin_prevue, projet_prix
	FROM (
			(
				SELECT employes.emp_matricule, emp_nom, projets.projet_ref, projet_date_fin_prevue, projet_prix
				FROM employes JOIN projets ON employes.emp_matricule = projets.emp_matricule
			)
			UNION
			(
				SELECT employes.emp_matricule, emp_nom, projets.projet_ref, projet_date_fin_prevue, projet_prix
				FROM employes JOIN participer ON employes.emp_matricule = participer.emp_matricule
					JOIN projets ON participer.projet_ref = projets.projet_ref
			)
		) AS projets_unis
	WHERE emp_nom = in_emp_nom;
END|
*/


CREATE PROCEDURE projets_selon_employe(IN in_emp_nom VARCHAR(50))
BEGIN
	DECLARE metier VARCHAR(50) DEFAULT '';
	
	SELECT fonction_nom
	INTO metier
	FROM employes JOIN fonctions ON employes.fonction_id = fonctions.fonction_id
	WHERE emp_nom = in_emp_nom;
	
	IF(metier = 'Architecte')
	THEN
		SELECT projets.projet_ref, projet_date_fin_prevue, projet_prix
		FROM employes JOIN projets ON employes.emp_matricule = projets.emp_matricule
		WHERE emp_nom = in_emp_nom;
	ELSE
		SELECT projets.projet_ref, projet_date_fin_prevue, projet_prix
		FROM employes JOIN participer ON employes.emp_matricule = participer.emp_matricule
			JOIN projets ON participer.projet_ref = projets.projet_ref
		WHERE emp_nom = in_emp_nom;
	END IF;
END|

-- 5) ancienneté d'un salarié en années en sortie pour un nom d'employé donné

CREATE PROCEDURE anciennete_employe(IN in_emp_nom VARCHAR(50), OUT out_anciennete INT)
BEGIN
	SELECT TIMESTAMPDIFF(YEAR, emp_date_embauche, CURRENT_DATE)
	INTO out_anciennete
	FROM employes
	WHERE emp_nom = in_emp_nom;
END|

-- 6) pour un id de projet donné, ajouter son prix à la sortie

CREATE PROCEDURE ajouter_prix_selon_projet(IN in_projet_ref INT, INOUT inout_cumul_prix DECIMAL(10,2))
BEGIN 
	SELECT inout_cumul_prix + projet_prix
	INTO inout_cumul_prix	
	FROM projets
	WHERE projet_ref = in_projet_ref;
END|

DELIMITER ;