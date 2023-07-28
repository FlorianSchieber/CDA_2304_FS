USE LMD_Avions;

/* Question 1 */

SELECT *
FROM vols
WHERE HD >= '12:00'
	AND HA <= '14:00'
	AND VD ='PARIS';
	
/* Question 2 */

SELECT *
FROM pilotes
WHERE PILNOM LIKE 'S%';

/* Question 3 */

SELECT 