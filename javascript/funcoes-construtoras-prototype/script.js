const p1 = {
  name: "Computador",
  price: 3000.0,
  quantity: 2,
};

const Product = function (id, name, price, quantity) {
  const _id = id;

  this.name = name;
  this.price = price;
  this.quantity = quantity;
};

Product.prototype.total = function () {
  return this.price * this.quantity;
};

Product.prototype.add = function (amount) {
  this.quantity += amount;
};

Product.prototype.remove = function (amount) {
  if (this.quantity >= amount) {
    this.quantity -= amount;
  }
};

Product.prototype.label = function () {
  return "Dados: " + this.name + ", " + this.price.toFixed(2);
};

const p2 = new Product(55, "Monitor", 800.0, 10);

const p3 = new Product(35, "Mouse", 50.0, 4);
