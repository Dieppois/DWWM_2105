/*1) Afficher les informations de toutes les villes (informations du pays incluses). */

select city_code, city_name, country_code from villes;

/*2) Sélectionner tous les clients (code et nom de son commercial inclus). */

select client_id,client_lastname,client_firstname,client_email,client_phone,client_added,client_password,com_code from clients;

/* 3) Sélectionner le client n°3 (code et nom du commercial associé inclus). */

select client_id,client_lastname,client_firstname,client_email,client_phone,client_added,client_password,com_code from clients where client_id = 3;

/*4) Sélectionner tous les clients ayant réservé au moins un voyage (le nombre de voyages réservés inclus). */
select client_lastname,client_firstname, order_quantity 
from clients inner join reservations on clients.client_id =  reservations_ibfk_1 where order_quantity > 0;

select * from reservations

