<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Introdução ao Servlet</title>
  </head>
  <body>
    <h1>Bem-vindo à página JSP!</h1>
    <p style="color: blue">Esta página foi gerada dinamicamente pelo servidor java.</p>

    <% java.util.Date dataAtual = new java.util.Date(); %>
    <p>Data e hora atual: <strong><%= dataAtual %></strong></p>

    <form method="post" action="/hello">
      <label for="nome">Digite seu nome:</label>
      <input type="text" name="nomeUsuario" required />
      <button type="submit">Enviar</button>
    </form>
  </body>
</html>
