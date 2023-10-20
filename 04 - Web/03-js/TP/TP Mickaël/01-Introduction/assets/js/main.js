// DECLARATIONS OBJETS

let inputPrenom = document.getElementById("prenom");
let inputAge = document.getElementById("age");

let affichage = document.getElementById("affichage");
let affichageMajorite = document.getElementById("affichagemajorite");
let affichageRetraite = document.getElementById("affichageretraite");
const boutonValider = document.getElementById("valider");

// DECLARATION FONCTIONS

function valider() {

    if(formulaireValide()) {
        
        afficherAge();
        afficherMajorite();
        afficherRetraite();

    }
    else {

        afficherErreur();

    }
}

function formulaireValide() {

    return inputPrenom.value.trim().length > 0 && inputAge.value > 0

}

function afficherAge() {

    affichage.innerHTML = "Bonjour <span>" + inputPrenom.value + "</span>, votre âge est : <span>" + inputAge.value + "</span>.";

}

function afficherMajorite() {

    if(inputAge.value < 18) {

        affichageMajorite.innerHTML = "Vous êtes <span>mineur</span>.";
        
    }
    else {

        affichageMajorite.innerHTML = "Vous êtes <span>majeur</span>.";

    }

}

function afficherRetraite() {

    const ageRetraite = 64;

    if(inputAge.value < ageRetraite) {

        affichageRetraite.innerHTML = "Il vous reste <span>" + (ageRetraite - inputAge.value) + "</span> année(s) avant la retraite.";

    }
    else if(inputAge.value > ageRetraite) {

        affichageRetraite.innerHTML = "Vous êtes à la retraite depuis <span>" + (inputAge.value - ageRetraite) + "</span> année(s).";

    }
    else {

        affichageRetraite.innerHTML = "Vous prenez votre retraite cette année !";

    }

}

function afficherErreur() {

    affichage.innerHTML = "Compléter/corriger le formulaire.";
    affichageMajorite.innerHTML = "";
    affichageRetraite.innerHTML = "";

}

// APPELS


boutonValider.addEventListener(
    "click",
    valider
);