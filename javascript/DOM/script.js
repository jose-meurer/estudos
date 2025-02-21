const getCards = document.getElementsByClassName("card");
const queryCards = document.querySelectorAll(".card");

console.log(getCards);
console.log(queryCards);

const card = document.querySelector(".card");
card.innerHTML = "teste do DOM";
card.classList.add("super-border");

const p = document.createElement("p");
p.innerHTML = "Descrição do card";
card.appendChild(p);

const div = document.createElement("div");
div.innerHTML = "Cartao 3";
div.classList.add("card");
const cardParent = document.querySelector("body");
console.log(cardParent);
cardParent.appendChild(div);

console.log(getCards);
console.log(queryCards);
console.log(card);
