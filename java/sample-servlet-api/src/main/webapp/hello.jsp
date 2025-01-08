<%@ page contentType="text/html; charset=UTF-8" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Hello</title>
  </head>
  <body>
    <h1>Bem-vindo à página, <%= request.getParameter("nomeUsuario") %></h1>
    <h2>Nome do servlet <%= request.getAttribute("nomeServlet") %></h2>
    <p>Essa pagina foi processada pelo servidor, utilizando um servlet</p>
  </body>
</html>
