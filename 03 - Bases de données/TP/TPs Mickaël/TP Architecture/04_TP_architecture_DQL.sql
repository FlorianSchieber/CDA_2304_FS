USE db_architecte;

CALL architectes_parmi_employes();

CALL employes_selon_fonction('Administratif');

CALL nombre_effectif_selon_fonction('Dessinateur', @nombre_effectif_dessinateur);
SELECT @nombre_effectif_dessinateur;

CALL projets_selon_employe('neymar');

CALL anciennete_employe('roussotte', @anciennete_roussotte);
SELECT @anciennete_roussotte;

SET @cumul_prix := 0;
CALL ajouter_prix_selon_projet(1, @cumul_prix);
CALL ajouter_prix_selon_projet(2, @cumul_prix);
SELECT @cumul_prix;