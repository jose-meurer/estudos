// Funcao fabrica
function product(name, price, quantity) {
  return {
    name,
    price,
    quantity,
    total() {
      return this.price * this.quantity;
    },
  };
}

const p = product("Teclado", 130.0, 33);
console.log(p.total());
