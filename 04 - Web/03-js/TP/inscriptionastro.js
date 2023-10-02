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

    let inputs = document.querySelectorAll("input");
    
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
    
    let inputs = document.querySelectorAll("input");
    inputs.forEach(element => {creerCookie(element.id, element.value)});

}

function nbJoursAnniv() {

    

}


/// TESTS



///////////////////////////////////////////////////
// EXECUTION

let inputs = document.querySelectorAll("input");

inputs.forEach(element => {
    element.addEventListener("input", () => {
        if(formOk()) {

            let dateNaissance = new Date(document.getElementById("datenaissance").value);
            let nom = document.getElementById("nom").value;
            let prenom = document.getElementById("prenom").value;

            document.getElementById("pseudo").value = calculerPseudo(dateNaissance, nom, prenom);

            document.getElementById("valider").disabled = false;
        }
        else {

            document.getElementById("valider").disabled = true;

        }
    })
});

let boutonValider = document.getElementById("valider");

boutonValider.addEventListener("click", () => {
    valider();
    window.location.href = "accueil.html";
});