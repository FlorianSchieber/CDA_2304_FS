USE LMD_Aeroport;

/* Question 1 : vols au départ de Paris entre 12h et 14h */
SELECT *
FROM vols
WHERE HD >= '12:00'
	AND HA <= '14:00'
	AND VD ='PARIS';
	
/* Question 2 : pilotes commençant par 's' */
SELECT *
FROM pilotes
WHERE PILNOM LIKE 'S%';

/* Question 3 : pour chaque ville, le nombre, et les capacites minimum et maximum des avions */
SELECT LOC AS 'Ville', min(CAP) AS 'capacite minimum', max(CAP) AS 'capacite maximum', count(AV) AS 'Nombre'
FROM avions
GROUP BY Ville;

/* Question 4 : pour chaque ville, la capacité moyenne des avions par type */
SELECT LOC AS 'Ville', AVTYPE AS 'Type', AVG(CAP) AS 'capacite moyenne'
FROM avions
GROUP BY LOC, AVTYPE;

/* Question 5 : capacité moyenne des avions pour chaque ville de plus d'un avion */
SELECT LOC AS 'Ville', AVG(CAP) AS 'capacite moyenne'
FROM avions
GROUP BY LOC
HAVING COUNT(AV) > 1;

/* Question 6 : noms des pilotes habitant dans la ville de localisation d'un Airbus */
SELECT pilotes.PILNOM
FROM avions, pilotes
WHERE avions.LOC = pilotes.ADR AND avions.AVMARQUE = 'Airbus';

/* Question 7 : noms des pilotes conduisant un Airbus ET habitant dans la ville de localisation d'un Airbus */
SELECT DISTINCT pilotes.PILNOM
FROM avions JOIN vols ON avions.AV = vols.AV
	JOIN pilotes ON vols.PIL = pilotes.PIL
WHERE avions.AVMARQUE = 'Airbus' AND avions.LOC = pilotes.ADR;

/* Question 8 : noms des pilotes conduisant un Airbus OU habitant dans la ville de localisation d'un Airbus */
SELECT DISTINCT pilotes.PILNOM
FROM avions JOIN vols ON avions.AV = vols.AV
	JOIN pilotes ON vols.PIL = pilotes.PIL
WHERE avions.AVMARQUE = 'Airbus' OR avions.LOC = pilotes.ADR;

/* Question 9 : noms des pilotes conduisant un Airbus SAUF ceux habitant dans la ville de localisation d'un Airbus */
SELECT DISTINCT pilotes.PILNOM
FROM avions JOIN vols ON avions.AV = vols.AV
	JOIN pilotes ON vols.PIL = pilotes.PIL
WHERE avions.AVMARQUE = 'Airbus' AND NOT (avions.LOC = pilotes.ADR);

/* Question 10 : vols ayant un trajet identique à ceux assurés par Serge*/
SELECT volsNonSerge.*
FROM (
	SELECT vols.*
	FROM pilotes JOIN vols ON pilotes.PIL = vols.PIL
	WHERE pilotes.PILNOM <> 'Serge'	
) volsNonSerge JOIN (
	SELECT vols.*
	FROM pilotes JOIN vols ON pilotes.PIL = vols.PIL
	WHERE pilotes.PILNOM = 'Serge'
) volsSerge ON volsNonSerge.VD = volsSerge.VD AND volsNonSerge.VA = volsSerge.VA;

/* Question 11 : paires de pilotes habitant la même ville (sans doublon) */
SELECT *
FROM pilotes JOIN pilotes AS pilotes2
	ON pilotes.PIL < pilotes2.PIL AND pilotes.ADR = pilotes2.ADR;

/* Question 12 : noms des pilotes condisant un avion conduit par le pilote n°1 */
SELECT pilotes.PILNOM
FROM (
	SELECT vols.AV
	FROM vols
	WHERE vols.PIL = 1
) avionsPilote1 JOIN (
	SELECT vols.AV, vols.PIL
	FROM vols
	WHERE vols.PIL <> 1 
) avionsPilotesNon1 ON avionsPilote1.AV = avionsPilotesNon1.AV
	JOIN pilotes ON avionsPilotesNon1.PIL = pilotes.PIL;
	
/* Question 13 : paires de villes telles qu'un avion localisé dans la ville de départ
	soit conduit par un pilote résidant dans la ville d'arrivée */
SELECT vols.VD, vols.VA
FROM avions JOIN vols ON avions.AV = vols.AV
	JOIN pilotes ON vols.PIL = pilotes.PIL
WHERE avions.LOC = vols.VD AND vols.VA = pilotes.ADR;
