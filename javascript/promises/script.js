function f(accept, rejected) {
  setTimeout(() => {
    if (10 > 0) {
      accept("P");
    } else {
      rejected("Q");
    }
  }, 3000);
}

const minhaPromise = new Promise(f);

minhaPromise
  .then((result) => {
    console.log("Resolveu com o valor " + result);
  })
  .catch((result) => {
    console.log("Rejeitada com o valor " + result);
  });

console.log(minhaPromise);
