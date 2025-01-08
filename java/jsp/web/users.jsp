<%-- 
    Document   : users
    Created on : 7 de jan. de 2025, 11:46:36
    Author     : josem
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Usuários</title>
        <%@include file="WEB-INF/jspf/html-head-libs.jspf" %>
    </head>
    <body>
        <%@include file="WEB-INF/jspf/navbar.jspf" %>
        <div class="m-2"> 

            <% if (userName != null) {%>
                <h2>Usuários</h2>
                <div class="m-2">
                    <% for (String user : users) {%>
                    <p> <%= user%> </p>
                    <% }%>
                    Conteúdo da página
                </div>
            <% }%>
        </div>
        <%@include file="WEB-INF/jspf/html-body-libs.jspf" %>
    </body>
</html>
