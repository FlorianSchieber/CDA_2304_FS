/* créer 3 messages 
	récupérer 3 membres
	récupérer un sujet
*/
USE forum;

INSERT INTO messages
(message_id, message_contenu, message_date_depot, message_date_publication, sujet_id, membre_id)
VALUES
	(1, 'Bonjoure !', '1955-01-01 00:00:00', '1955-01-01 00:00:01', 3, 3),
	(4, 'Sava ?', '1956-01-02 02:45:12', '1956-01-02 02:45:13', 3, 3),
	(6, 'Orevouare !' , '2023-07-31 15:09:00', '2023-07-31 15:12:00', 3, 3)
;
	