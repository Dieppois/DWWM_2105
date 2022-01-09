// Too complex for what it is dynamic array generator

function addCell(tr, text) {
  var td = tr.insertCell();
  td.textContent = text;
  return td;
}

function titleCell(row, text) {
  var cell = document.createElement("th");
  cell.textContent = text;
  row.appendChild(cell);
}

function createCells(row, obj) {
  for (var key in obj) {
    addCell(row, obj[key]);
  }
}

function fillTable(result) {
  var table = document.getElementById("Table");
  // create header
  var thead = table.createTHead();
  var headerRow = thead.insertRow();
  for (var key in result[0]) {
    titleCell(headerRow, key);
  }
  var Body = table.createTBody();
  for (let i = 0; i < result.length; i++) {
    var BodyRow = Body.insertRow();
    createCells(BodyRow, result[i]);
  }
}

// Better next time

// Max stuff

function maxPower(_data) {
  let id = 0;
  let max = _data[0].power;
  for (i = 1; i < _data.length; i++) {
    if (_data[i].power > max) {
      max = _data[i].power;
      j = i;
    }
  }
  return id + 1;
}
function maxArmor(_data) {
  let j = 0;
  let max = _data[0].armor;
  for (let i = 1; i < _data.length; i++) {
    if (_data[i].armor > max) {
      max = _data[i].armor;
      j = i;
    }
  }
  return j + 1;
}
function maxPlayed(_data) {
  let j = 0;
  let max = _data[0].played;
  for (let i = 1; i < _data.length; i++) {
    if (_data[i].played > max) {
      max = _data[i].played;
      j = i;
    }
  }
  return j + 1;
}
function maxVictory(_data) {
  let j = 0;
  let max = _data[0].victory;
  for (let i = 1; i < _data.length; i++) {
    if (_data[i].victory > max) {
      max = _data[i].victory;
      j = i;
    }
  }
  return j + 1;
}


// 


// Outdated _ XHR

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
  //Si le statut HTTP n'est pas 200...
  if (xhr.status != 200) {
    //...On affiche le statut et le message correspondant
    alert("Erreur " + xhr.status + " : " + xhr.statusText);
    //Si le statut HTTP est 200, on affiche le nombre d'octets téléchargés et la réponse
  } else {
    //alert(xhr.response.length + " octets  téléchargés\n" + JSON.stringify(xhr.response));
    let monTab = xhr.response;
    console.log(monTab);
    fillTable(monTab);
    Select(monTab);
  }
};

//Si la requête n'a pas pu aboutir...
xhr.onerror = function () {
  alert("La requête a échoué");
};
}

jsonThingy();

// It works though


/*
Select strongest Char = id_value
Select mostPowerful Char = id_value
Select mostArmored Char = id_value
Select id_value = result[]
Put id_value's value into Character sheet 
*/



