USE LMD_Aeroport;

INSERT INTO AVIONS(AVMARQUE, AVTYPE, CAP, LOC) VALUES
	('AIRBUS', 'A320', 300, 'Nice'),
	('BOEING', 'B707', 250, 'Paris'),
	('AIRBUS', 'A320', 300, 'Toulouse'),
	('CARAVELLE', 'Caravelle', 200, 'Toulouse'),
	('BOEING', 'B747', 400, 'Paris'),
	('AIRBUS', 'A320', 300, 'Grenoble'),
	('ATR', 'ATR42', 50, 'Paris'),
	('BOEING', 'B727', 300, 'Lyon'),
	('BOEING', 'B727', 300, 'Nantes'),
	('AIRBUS', 'A340', 350, 'Bastia')
;

INSERT INTO PILOTES(PILNOM, ADR) VALUES
	('SERGE', 'Nice'),
	('JEAN', 'Paris'),
	('CLAUDE', 'Grenoble'),
	('ROBERT', 'Nantes'),
	('SIMON', 'Paris'),
	('LUCIEN', 'Toulouse'),
	('BERTRAND', 'Lyon'),
	('HERVE', 'Bastia'),
	('LUC', 'Paris')
;

INSERT INTO VOLS(AV, PIL, VD, VA, HD, HA) VALUES
	(100, 1, 'NICE', 'PARIS', '7:00', '9:00'),
	(100, 2, 'PARIS', 'TOULOUSE', '11:00', '12:00'),
	(101, 1, 'PARIS', 'NICE', '12:00', '14:00'),
	(105, 3, 'GRENOBLE', 'TOULOUSE', '9:00', '11:00'),
	(105, 3, 'TOULOUSE', 'GRENOBLE', '17:00', '19:00'),
	(107, 7, 'LYON', 'PARIS', '6:00','7:00'),
	(109, 8, 'BASTIA', 'PARIS', '10:00', '13:00'),
	(106, 9, 'PARIS', 'BRIVE', '7:00', '8:00'),
	(106, 9, 'BRIVE', 'PARIS', '19:00', '20:00'),
	(107, 7, 'PARIS', 'LYON', '18:00', '19:00'),
	(102, 2, 'TOULOUSE', 'PARIS', '15:00', '16:00'),
	(101, 4, 'NICE', 'NANTES', '17:00', '19:00'),
	(103, 5, 'PARIS', 'NICE', '11:00', '13:00'),
	(104, 6, 'NICE', 'PARIS', '13:00', '15:00')
;