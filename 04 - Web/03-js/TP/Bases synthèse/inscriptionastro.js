///////////////////////////////////////////////////
// DECLARATION OBJETS

const inputs = document.querySelectorAll("input");
const inputNom = document.getElementById("nom");
const inputPrenom = document.getElementById("prenom");
const inputDateNaissance = document.getElementById("datenaissance");
const inputPseudo = document.getElementById("pseudo");
const boutonValider = document.getElementById("valider");

///////////////////////////////////////////////////
// DECLARATION FONCTIONS

function valNum(_chaine) {

    const asciiEnCode = 64;

    let chaineMajuscule = _chaine.toUpperCase();
    let somme = 0;

    for (let i = 0; i < chaineMajuscule.length; i++) {
        somme += chaineMajuscule.charCodeAt(i) - asciiEnCode;
    }

    return somme;

}

function signeAstro(_mois) {
    
    let signe = ["Capricorne","Verseau","Poisson","Belier","Taureau","Gémeaux","Cancer","Lion","Vierge","Balance","Scorpion","Sagittaire"];

    return signe[_mois];

}

function formOk() {
    
    let renseignes = true;

    inputs.forEach(element => {
        if (element.getAttribute("readonly") != "true") {
            if (element.value == "") {
                renseignes = false; 
            } 
        }
    })

    return renseignes;

}

function calculerPseudo(_dateNaissance, _nom, _prenom) {

    let mois = _dateNaissance.getMonth();

    return signeAstro(mois) + (valNum(_nom) + valNum(_prenom));

}

function creerCookie(_cle, _valeur) {

    const jourEnMs = (24 * 60 * 60 * 1000);
    let joursValidite = 1;

    let dateJour = new Date();
    let dateExpiration = new Date(dateJour.getTime() + joursValidite * jourEnMs);
    dateExpiration = dateExpiration.toUTCString();

    document.cookie = _cle + " = " + _valeur + "; expires = " + dateExpiration + "; secure; SameSite = lax";
    
}

function valider() {

    inputs.forEach(element => {creerCookie(element.id, element.value)});

}

function nbJoursAnniv() {

    let dateNaissance = new Date(inputDateNaissance.value);
    let dateAujourdhui = new Date();
    
    let differenceMs = dateNaissance.getTime() - dateAujourdhui.getTime();

}

///////////////////////////////////////////////////
// EXECUTION

inputs.forEach(element => {
    element.addEventListener("input", () => {

        if(formOk()) {

            let dateNaissance = new Date(inputDateNaissance.value);
            let nom = inputNom.value;
            let prenom = inputPrenom.value;

            inputPseudo.value = calculerPseudo(dateNaissance, nom, prenom);

            boutonValider.disabled = false;

        }
        else {

            boutonValider.disabled = true;

        }

    })
});

boutonValider.addEventListener("click", () => {
    valider();
    window.location.href = "accueil.html";
});