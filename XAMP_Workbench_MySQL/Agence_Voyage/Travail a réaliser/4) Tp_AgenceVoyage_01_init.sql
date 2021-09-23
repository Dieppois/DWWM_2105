CREATE DATABASE Agence_Voyage_2;
USE Agence_Voyage_2;

CREATE TABLE THEMATIQUES(
   theme_code INT AUTO_INCREMENT PRIMARY KEY,
   theme_name VARCHAR(32) NOT NULL,
   theme_description TEXT
);

CREATE TABLE SERVICES(
   service_code INT AUTO_INCREMENT PRIMARY KEY,
   service_name VARCHAR(32) NOT NULL,
   service_description TEXT
);

CREATE TABLE PAYS(
   country_code CHAR(2) PRIMARY KEY,
   country_name VARCHAR(128) NOT NULL
);

CREATE TABLE COMMERCIAUX(
   com_code CHAR(5) PRIMARY KEY,
   com_name VARCHAR(64) NOT NULL,
   com_password CHAR(60) NOT NULL,
   com_code__1 VARCHAR(5), FOREIGN KEY(com_code__1) REFERENCES COMMERCIAUX(com_code)
);

CREATE TABLE VILLES(
   city_code INT AUTO_INCREMENT PRIMARY KEY,
   city_name VARCHAR(128) NOT NULL,
   country_code VARCHAR(2) NOT NULL, FOREIGN KEY(country_code) REFERENCES PAYS(country_code)
);

CREATE TABLE CLIENTS(
   client_id SMALLINT AUTO_INCREMENT PRIMARY KEY,
   client_lastname VARCHAR(32) NOT NULL,
   client_firstname VARCHAR(32) NOT NULL,
   client_email VARCHAR(128) UNIQUE NOT NULL, CONSTRAINT CHK_Email CHECK(client_email LIKE '%___@___%'), 
   client_phone CHAR(16) UNIQUE NOT NULL, CONSTRAINT CHK_Phone CHECK (client_phone NOT LIKE '%[^0-9]%'),
   client_added DATE NOT NULL, CONSTRAINT CHK_Date CHECK (client_added LIKE '[Y-M-D]'),
   client_password CHAR(60) NOT NULL, CONSTRAINT CHK_Password CHECK (client_password LIKE '[Y-M-D]'),
   com_code VARCHAR(5) NOT NULL, FOREIGN KEY(com_code) REFERENCES COMMERCIAUX(com_code)
);

CREATE TABLE VOYAGES(
   trip_code INT AUTO_INCREMENT PRIMARY KEY,
   trip_title VARCHAR(128) NOT NULL,
   trip_available INT NOT NULL,
   trip_start DATETIME NOT NULL,
   trip_end DATETIME NOT NULL,
   trip_price DECIMAL(7,2) NOT NULL,
   trip_overview TEXT NOT NULL,
   trip_description TEXT ,
   city_code INT NOT NULL, FOREIGN KEY(city_code) REFERENCES VILLES(city_code)
);

CREATE TABLE NOTES(
   client_id SMALLINT, FOREIGN KEY(client_id) REFERENCES CLIENTS(client_id),
   trip_code INT, FOREIGN KEY(trip_code) REFERENCES VOYAGES(trip_code),
   service_code INT, FOREIGN KEY(service_code) REFERENCES Services(service_code),
   service_score BIGINT NOT NULL,
   PRIMARY KEY(client_id, trip_code, service_code)
);

CREATE TABLE RESERVATIONS(
   client_id SMALLINT, FOREIGN KEY(client_id) REFERENCES CLIENTS(client_id),
   trip_code INT, FOREIGN KEY(trip_code) REFERENCES VOYAGES(trip_code),
   PRIMARY KEY(client_id, trip_code),
   order_quantity BIGINT NOT NULL,
   order_paid BOOLEAN NOT NULL
);

CREATE TABLE PROPOSITIONS(
   trip_code INT, FOREIGN KEY(trip_code) REFERENCES VOYAGES(trip_code),
   theme_code INT, FOREIGN KEY(theme_code) REFERENCES THEMATIQUES(theme_code),
   PRIMARY KEY(trip_code, theme_code)
);

CREATE TABLE ESCALES(
   step_start DATETIME, step_end DATETIME, PRIMARY KEY(step_start, step_end),
   city_code INT NOT NULL, FOREIGN KEY(city_code) REFERENCES VILLES(city_code),
   trip_code INT NOT NULL, FOREIGN KEY(trip_code) REFERENCES VOYAGES(trip_code)
);