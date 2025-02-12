// import * as nb from "./numbers.js"; //Importa tudo e coloca apelido
//import Prod from './product.js'; //Posso renomear os imports default
import { sum, round } from "./numbers.js"; //Posso usar desestruturacao e usar o nome direto
import Product from "./product.js"; //Import default

// console.log(nb.sum(3, 4));
// console.log(nb.round(2.3456, 3));

//const p1 = new Prod("Computador", 3000.0, 10);

console.log(sum(3, 4));
console.log(round(2.3456, 3));

const p1 = new Product("Computador", 3000.0, 10);

console.log(p1);
