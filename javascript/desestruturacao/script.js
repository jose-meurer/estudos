const obj = {
  id: 53,
  date: "2021-10-20",
  items: [
    {
      description: "Celular",
      price: 1499.99,
      quantity: 1,
    },
    {
      description: "Mouse",
      price: 100.0,
      quantity: 2,
    },
    {
      description: "Teclado",
      price: 150.0,
      quantity: 1,
    },
    {
      description: "Monitor",
      price: 900.0,
      quantity: 2,
    },
  ],
  client: {
    name: "Maria Red",
    email: "maria@gmail.com",
    active: true,
  },
};

const { id, date } = obj;

console.log(id);
console.log(date);

function subTotal({ price, quantity }) {
  return price * quantity;
}

console.log(subTotal(obj.items[0]));
console.log(subTotal(obj.items[1]));

// function total({ items }) {
//   let soma = 0;
//   for (let i = 0; i < items.length; i++) {
//     soma = soma + subTotal(items[i]);
//   }
//   return soma;
// }

function total({ items }) {
  return items.reduce((total, item) => (total += subTotal(item)), 0);
}

console.log("Total: " + total(obj));

const [item1, item2, ...resto] = obj.items;

console.log(item1);
console.log(item2);
console.log(resto); // recebe o resto do array
