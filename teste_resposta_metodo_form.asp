<% option explicit %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional// EN" "http://www.w3.org/TR/xhtm11/DTD/xhtml11-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <%
        Dim strNome, strCpf, strNasc
        strNome = Request.Form("txt_Nome")
        strCpf = Request.Form("txt_Cpf")
        strNasc = Request.Form("txt_Nasc")
        %>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>Método FORM</title>
    </head>
    <body>
        <h3>As informações enviada pelo método Form, foram as seguintes:</h3>
        <p><strong>Nome:</strong><% =strNome %></p>
        <p><strong>CPF:</strong><% =strCpf %></p>
        <p><strong>Data de Nascimento</strong><% =strNasc %></p>
    </body>
</html>