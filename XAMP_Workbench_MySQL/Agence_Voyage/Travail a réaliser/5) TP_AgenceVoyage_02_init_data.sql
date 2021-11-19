INSERT INTO PAYS (country_code, country_name)
VALUES 
('FR', 'France'),
('DE', 'Allemagne'),
('BE', 'Belgique'),
('IT', 'Italie'),
('MA', 'Maroc'),
('UA', 'Ukraine'),
('GB', 'Ecosse');

INSERT INTO VILLES 
VALUES 
(city_code, 'Paris', 'FR'),
(city_code, 'Mulhouse', 'FR'),
(city_code, 'Rust', 'DE'),
(city_code, 'Bruxelles', 'BE'),
(city_code, 'Milan', 'IT'),
(city_code, 'Rome', 'IT'),
(city_code, 'Chernobyl', 'UA'),
(city_code, 'Edimbourg', 'GB');

INSERT INTO VILLES 
VALUES
(city_code, 'Marrakech', 'MA');

DELETE FROM VILLES
WHERE city_code = 9;

INSERT INTO THEMATIQUES 
VALUES 
(theme_code, 'Montagne', NULL),
(theme_code, 'Plage', NULL),
(theme_code, 'Soleil', NULL),
(theme_code, 'Sports d\'hiver',NULL),
(theme_code, 'Sports nautiques',NULL),
(theme_code, 'Culture',NULL),
(theme_code, 'Gastronomique',NULL),
(theme_code, 'Aventure',NULL);

ALTER TABLE THEMATIQUES AUTO_INCREMENT = 1;

DELETE FROM THEMATIQUES;

INSERT INTO SERVICES (service_name, service_description)
VALUES
(service_code, 'All inclusive'),
(service_code, 'Service d’étage'),
(service_code, 'Piscine'),
(service_code, 'Piscine chauffée'),
(service_code, 'Coach sportif'),
(service_code, 'Pratique du golf');

INSERT INTO COMMERCIAUX (com_code, com_name, com_password, com_code_1)
VALUES
('00001', 'Guillaume', '1234'),
('00002', 'Damien', '1234'),
('00003', 'Bruno', '1234'),
('00004', 'Chems', '1234'),
('00005', 'Stephane', '1234');

UPDATE COMMERCIAUX
SET com_code_1 = '00002'
WHERE com_code = '00001';

INSERT INTO CLIENTS
VALUES
(client_id, 'Dieppois', 'Jimmy', 'jimmy.dieppois@outlook.fr', '0649994155', '2015-09-21', '0000', '00001'),
(client_id, 'Benitez', 'Jean', 'jean.benitez@outlook.fr', '0614257896', '1932-09-21', 'azerty', '00001'),
(client_id, 'Roca', 'George', 'george.roca@outlook.fr', '0698753625', '2002-09-21', '1234','00005'),
(client_id, 'Chatelot', 'Franck', 'franck.chatelot@outlook.fr', '0612963548', '2000-09-21', '94hn8AaF','00001'),
(client_id, 'Humbert', 'Arnaud', 'arnaud.humbert@outlook.fr', '0699887755', '2021-08-21', 'PlofkE*98é"(-fàf_f(f','00001');

ALTER TABLE CLIENTS AUTO_INCREMENT = 1;
SET SQL_SAFE_UPDATES = 0;
DELETE FROM CLIENTS;

UPDATE CLIENTS
SET client_password = '0000',
    com_code = '00001'
WHERE client_id = 16;

INSERT INTO VOYAGES
VALUES
(trip_code, 'Sejour touristique', 'TRUE', '2021-09-21', '2022-16-21', 899, 'cool', NULL, 10),
(trip_code, 'Sejour Gastronomique', 'TRUE', '2022-08-20', '2022-08-25', 399, 'cool', NULL, 1),
(trip_code, 'Voyage Aventure', 'TRUE', '2022-09-21', '2022-09-24', 1299, 'cool', NULL, 7),
(trip_code, 'Destination Vert-Bouteille', 'TRUE', '2022-09-21', '2022-09-27', 849, 'cool', NULL, 8),
(trip_code, 'Europa Park', 'TRUE', '2022-09-21', '2022-09-23', 99, 'cool', NULL, 3);

DELETE FROM VOYAGES;
ALTER TABLE VOYAGES AUTO_INCREMENT = 1;

INSERT INTO PROPOSITIONS (trip_code, theme_code)
VALUES
(1, 3),
(2, 7),
(3, 8),
(4, 1),
(5, 6);

INSERT INTO NOTES (client_id, trip_code, service_code, service_score)
VALUES 
(1, 1, 1, 99),
(2, 2, 2, 99),
(3, 3, 3, 99),
(4, 4, 4, 99),
(5, 5, 5, 99);

INSERT INTO RESERVATIONS (client_id, trip_code, order_quantity, order_paid)
Values
(2, 1, 2, true),
(3, 1, 5, true),
(3, 2, 3, true),
(4, 5, 5, false);

SELECT * FROM RESERVATIONS;
DELETE FROM RESERVATIONS;

select * from reservations;
select * from clients;
select * from voyages;
select * from propositions



