// IMPORTATIONS

import { Database } from "./Database.js";

// DECLARATIONS

const tbody = document.querySelector("tbody");
const apiUrl = "https://arfp.github.io/tp/web/html-css-js/02-cardgame/cardgame.json";
const keyList = ["id", "name", "level", "description", "power", "attack", "armor", "damage", "mitigation", "played", "victory", "defeat", "draw"];

let cardList = await Database.fetchJson(apiUrl);

// FONCTIONS

function display(_cardList) {

    tbody.innerHtml = "";

    for(let card of _cardList) {

        let tr = document.createElement("tr");
        
        for(let key of keyList) {

            let td = document.createElement("td");

            if(card[key] !== undefined) {

                td.innerText = card[key];

            } else {
                
                td.innerText = "-";

            }
            
            tr.appendChild(td);

        }

        tbody.appendChild(tr);
    }
}

// APPELS

display(cardList);