class Participant {

    constructor(_participantJson) {
        this.pays = _participantJson.pays;
        this.nom = "";
        this.prenom = ""
        this.temps = _participantJson.temps;
        this.minutes = "";
        this.secondes = "";
        this.hydraterNomPrenom(_participantJson.nom);
        this.hydraterMinutesSecondes(_participantJson.temps);
    }

    hydraterNomPrenom(_nom) {
        let listeNomPrenom = _nom.split(" ");
        this.nom = listeNomPrenom[0];
        this.prenom = listeNomPrenom[1];
    }

    hydraterMinutesSecondes(_temps) {

        this.minutes = Math.floor(_temps / 60);
        this.secondes = _temps - this.minutes * 60;

        if(this.minutes < 10) {

            this.minutes = "0" + this.minutes;

        }

        if(this.secondes < 10) {

            this.secondes = "0" + this.secondes;

        }
    }



}

export { Participant };