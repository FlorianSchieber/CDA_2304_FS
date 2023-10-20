const schluck = 1;

const app = {
    
    data() {

        return {

            prixAuLitre: 0,

            litrage: 0,

        }

    },

    computed: {
        
        prix() {

            let result = (this.litrage * this.prixAuLitre);

            if(!isNaN(result) && this.prixAuLitrePositif()) {

                return result.toFixed(2);
            
            } else {

                alert('Le prix au litre est invalide');
                
            }

        }

    },

    methods: {

        ajouterSchluck() {

            this.litrage += schluck;

        },

        prixAuLitrePositif() {

            return this.prixAuLitre >= 0;

        }

    }

}

Vue.createApp(app).mount("#app");