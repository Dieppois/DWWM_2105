CREATE DATABASE Creation_Restaurant;
USE Creation_Restaurant;

CREATE TABLE RESTAURANTS (
 id INT AUTO_INCREMENT PRIMARY KEY,
   nom TEXT NOT NULL,
   adresse TEXT NOT NULL,
   prix DECIMAL (5,2) NOT NULL,
   Commentaire TEXT,
   Note DOUBLE,
   visite Date("%D %b %Y") ;
   
   INSERT INTO RESTAURANTS
   values
   (id, "JY'SC", "17 Rue de la Poissonneries 68000 Colmar", 50, 
   "Le JY'S est un restaurant différent des autres avec un décor cosy et résolument contemporain qui attire une 
très belle clientèle cosmopolite. Jean-Yves Schillinger est un chef doublement étoilé créatif qui vous entraînera 
dans une ronde dépaysante à souhait où la cuisine du monde est à l'honneurLe chef décline la cuisine fusion à 
sa façon. Une carte régulièrement renouvelée s'égaye de créations audacieuses et de plats revisités avec 
modernité et pertinence",
 9/10, "2019-12-05"),

(id, "L'Adriatico", "6 route de Neuf Brisach, 68000, Colmar, France", 25, 
"Une des meilleurs pizzéria de la région Service très agréable, efficace et souriant Salle principale un peu 
bruyante mais cela donne un côté italien je recommande",
 8/10, "2020-02-04");
 
 
update restaurants
SET SELECT DATE_FORMAT(visite, "%D %b %Y");
 
 
 ("UPDATE " . $this->table . " set adresse=:adresse, prix=:prix, commentaire=:commentaire, 
        note=:note, visite=:visite WHERE id =" . $_id);
 
SELECT * FROM RESTAURANTS;
 
BEGIN
INSERT INTO restaurants 
VALUES
(id, 
$_POST["nom"],$_POST["adresse"],$_POST["prix"],
$_POST["commentaire"],$_POST["note"],$_POST["visite"]);
END