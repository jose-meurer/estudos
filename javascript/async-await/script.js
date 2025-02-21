const cep = "01001000";
const url = `https://viacep.com.br/ws/${cep}/json/`;

async function getJsonResponse(url) {
  const response = await fetch(url);
  const jsonBody = await response.json();
  return jsonBody;
}

console.log(getJsonResponse(url)); //Retorna a promise Promise { <pending> }

//Uma maneira de resolver a promise
getJsonResponse(url).then((obj) => {
  console.log(obj);
});

//Melhor maneira de resolver a promise, chamando por outra function async
async function showCepData(cep) {
  const url = `https://viacep.com.br/ws/${cep}/json/`;
  const json = await getJsonResponse(url);
  console.log(json);
}

showCepData("01011000");
