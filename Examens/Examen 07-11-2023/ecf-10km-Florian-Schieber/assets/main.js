/* App 10000 mètres */

import { Database } from "./Database.js";
import { Participant } from "./Participant.js";
import { Pays } from "./Pays.js";


const app = {


    data() {
        return {
            participants: [],
            participantsFiltres : [],
            listePays: [],
            listePaysMike: []
        }
    },

    async mounted() {
        let participantsJson = await Database.fetchJson("./data/resultats.json");
        console.log(participantsJson); // Debug

        this.hydraterParticipants(participantsJson);

        this.trierParticipants();

        this.participantsFiltres = this.participants;

        this.hydraterListePays(participantsJson);

        this.trierListePays();

        
    },

    computed: {

        nombreParticipants() {

            return this.participants.length;

        },
        
        /*

        nomCompletGagnant() {

            let indiceTempsMinimum = 0;

            for(let i = 1; i < this.participants.length; i++) {

                if(this.participants[i].temps < this.participants[indiceTempsMinimum].temps) {
                    
                    indiceTempsMinimum = i;

                }

            }

            let participantGagnant = this.participants[indiceTempsMinimum];

            console.log(participantGagnant);
            
            for (let key in participantGagnant) {

                console.log(participantGagnant["nom"]);

            }

            console.log(participantGagnant["nom"]);

            return this.nomComplet(participantGagnant);
        }

        */

        // LA METHODE SUIVANTE NE FONCTIONNE PAS !?

        nomCompletGagnant() {

            return this.nomComplet(this.participants[0]); 

        }


        /*
        nomCompletGagnant() {

            for (let participant of this.participants) { // ?!!!
                return this.nomComplet(this.participants[0]); // Magie !
            }

        }

        */
        
    },

    methods: {

        hydraterParticipants(_participantsJson) {

            for(let participantJson of _participantsJson) {
                this.participants.push(new Participant(participantJson));
            };

        },

        trierParticipants() {

            this.participants.sort(
                (a, b) => a.temps - b.temps
            )

        },

        nomComplet(_participant) {

            return _participant.prenom + " " + _participant.nom;

        },

        hydraterListePays(_participantsJson) {

            let listeNomPays = [];

            for(let participant of this.participants) {

                if(!listeNomPays.includes(participant.pays)) {
                    listeNomPays.push(participant.pays);
                }

            }

            for(let nomPays of listeNomPays) {

                this.listePays.push(new Pays(nomPays));

            }

        },

        trierListePays() {

            this.listePays.sort(
                (a, b) => {

                    if(a.nom <= b.nom) {
                        return -1;
                    }
                    else {
                        return 1;
                    }
                }
            )

        },

        paysCoche(_nomPays) {

            let resultat = false;

            for(let pays of this.listePays) {

                if(pays.nom == _nomPays && pays.coche) {
                    resultat = true;
                }

            }

            return resultat;

        },

        tousPaysDecoches() {

            let resultat = true;

            for(let pays of this.listePays) {

                if(pays.coche) {
                    resultat = false;
                }

            }

            return resultat;

        },

        filtrer() {

            if(this.tousPaysDecoches()) {

                this.participantsFiltres = this.participants;

            }
            else {

                this.participantsFiltres = this.participants.filter(
                    (participant) => this.paysCoche(participant.pays)
                );

            }

        }

    }

}

Vue.createApp(app).mount("#app");