function genererTableau(data) {
  var ligne = 0;
  for (let i = 0; i < data.length; i++) {
    var cePerso = data[i];
    var afficherPerso = document.createElement("tr");
    afficherPerso.innerHTML =
      "<td>" +
      cePerso.id +
      "</td><td>" +
      cePerso.name +
      "</td><td>" +
      cePerso.level +
      "</td><td>" +
      cePerso.description +
      "</td><td>" +
      cePerso.power +
      "</td><td>" +
      cePerso.attack +
      "</td><td>" +
      cePerso.armor +
      "</td><td>" +
      cePerso.damage +
      "</td><td>" +
      cePerso.mitigation +
      "</td><td>" +
      cePerso.played +
      "</td><td>" +
      cePerso.victory +
      "</td><td>" +
      cePerso.defeat +
      "</td><td>" +
      cePerso.draw +
      "</td>";
    document.getElementById("Table").appendChild(afficherPerso);
  }
}

function genererPersonnage(data, max) {
  
  if (max >= 1 && max < data.length) {
    
    var personnage = data[max];
    var afficherPersonnage = document.createElement("div");
    afficherPersonnage.setAttribute("class", "personnage");
    afficherPersonnage.innerHTML =

      '<div class="haut">' +
      '<table><tr><td width=33% rowspan=2 class="levelPerso">' + personnage.level + '</td>' +
      '<td class="nomPerso">' +personnage.name + '</td></tr>' +
      '<tr><td>played: ' +personnage.played + ' | Victoires: ' + personnage.victory + '</td></table>' +
      '</div>' +

      '<div class="gauche">' +
      '<img src="../exo_ajax_jeux/armure.png" alt="armure">' +
      '</div>' +

      '<div class="droite">' +
      '<table width= 100% height= 100% ><tr><td class="power"> Power<br>' + personnage.power + '</td></tr>' +
      '<tr><td class="attack"> Attack<br>' + personnage.attack + '</td></tr>' +
      '<tr><td class="armor">Defence<br>' + personnage.armor + '</td></tr></table>' +
      '</div>' +

      '<div class="bas" >' +
      '<br>ID joueur : ' + personnage.id + '</div>';
      
    document.getElementById("Personnage").appendChild(afficherPersonnage);

   
  }
}

/* All fonction calculer maximum*/
function maxPower(_data) {
  let id = 0;
  let max = _data[0].power;
  for (i = 1; i < _data.length; i++) {
    if (_data[i].power > max) {
      max = _data[i].power;
      id = i;
    }
  }
  return id + 1;
}
function maxArmor(_data) {
  let id = 0;
  let max = _data[0].armor;
  for (let i = 1; i < _data.length; i++) {
    if (_data[i].armor > max) {
      max = _data[i].armor;
      id = i;
    }
  }
  return id + 1;
}
function maxPlayed(_data) {
  let id = 0;
  let max = _data[0].played;
  for (let i = 1; i < _data.length; i++) {
    if (_data[i].played > max) {
      max = _data[i].played;
      id = i;
    }
  }
  return id + 1;
}
function maxVictory(_data) {

  let id = 0;
  let max = _data[0].victory;
  for (let i = 1; i < _data.length; i++) {
    if (_data[i].victory > max) {
      max = _data[i].victory;
      id = i;
    }
  }
  return id + 1;
}

/* Lancer json */
function jsonThingy() {
  //On crée un objet XMLHttpRequest
  let xhr = new XMLHttpRequest();

  //On initialise notre requête avec open()
  xhr.open("GET", "../exo_ajax_jeux/jeux_de_roles.json");

  //On veut une réponse au format JSON
  xhr.responseType = "json";

  //On envoie la requête
  xhr.send();

  //Dès que la réponse est reçue...
  xhr.onload = function () {
    //Si le statut HTTP est 200, on affiche le nombre d'octets téléchargés et la réponse
    if (this.status == 200) {
      data = xhr.response;
      genererTableau(data);
      
      document.getElementById("power").addEventListener('click', function() {
      genererPersonnage(data, maxPower(data));
      }) ;
      document.getElementById("armor").addEventListener('click', function() {
      genererPersonnage(data, maxArmor(data));
    }) ;
      document.getElementById("played").addEventListener('click', function() {
      genererPersonnage(data, maxPlayed(data));
    }) ;
      document.getElementById("victory").addEventListener('click', function() {
      genererPersonnage(data, maxVictory(data));
    }) ;
    }
  };
}
jsonThingy();
