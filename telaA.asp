<!DOCTYPE html
    PUBLIC "-//W3C//DTD XHTML 1.0 Transitional// EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">

</html>

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Método FORM</title>
</head>

<body>
    <form id="form1" name="form1" method="post" action="teste_resposta_metodo_form.asp">
        <table width="100%" border="0">
            <tr>
                <td width="11%" align="right">
                    <label><strong>Nome</strong>:</label>
                </td>
                <td width="89%">
                    <input required type="text" name="txt_Nome" id="txt_Nome" />
                </td>
            </tr>
            <tr>
                <td align="right">
                    <label><strong>CPF</strong>:</label>
                </td>
                <td>
                    <input required type="text" name="txt_Cpf" id="txt_Cpf" />
                </td>
            </tr>
            <tr>
                <td align="right">
                    <label><strong>Data de Nascimento</strong>:</label>
                </td>
                <td>
                    <input required type="text" name="txt_Nasc" id="txt_Nasc" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="left">
                    <input type="submit" name="button" id="button" value="Salvar" />
                </td>
            </tr>
        </table>
        <p></p>
    </form>
</body>