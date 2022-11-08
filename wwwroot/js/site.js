/* eslint-disable quotes */
/* eslint-disable semi */
/* eslint-disable eqeqeq */
ValidarNome()
ValidarSenha()
ValidarSenha2()
ValidarEmail()
function ValidarNome ()
// eslint-disable-next-line brace-style
{
  var ValorNome = document.getElementById("txtNome").value

  if (ValorNome.lenght == 0)
  // eslint-disable-next-line brace-style
  {
    alert("Preencha esse campo");
    document.getElementById("txtNome").style.background = "red";
    return false;
  // eslint-disable-next-line brace-style
  }
  else
  // eslint-disable-next-line brace-style
  {
    document.getElementById("txtNome").style.color = "black";
    document.getElementById("txtNome").style.background = "white";
    return true;
  }
}

function ValidarSenha ()
// eslint-disable-next-line brace-style
{
  var ValorSenha = document.getElementById("txtSenha").value

  if (ValorSenha.lenght == 0)
  // eslint-disable-next-line brace-style
  {
    alert("Preencha esse campo");
    document.getElementById("txtSenha").style.background = "red";
    return false;
  // eslint-disable-next-line brace-style
  }
  else if (ValorSenha.lenght < 3)
  // eslint-disable-next-line brace-style
  {
    alert("Senha precisa ter ao menos 3 caracteres");
    document.getElementById("txtSenha").style.color = "red";
    return false;
  // eslint-disable-next-line brace-style
  }
  else
  // eslint-disable-next-line brace-style
  {
    document.getElementById("txtSenha").style.color = "black";
    return true;
  }
}

function ValidarSenha2 ()
// eslint-disable-next-line brace-style
{
  var ValorSenha2 = document.getElementById("txtSenha2").value

  if (ValorSenha2.lenght == 0)
  // eslint-disable-next-line brace-style
  {
    alert("Preencha esse campo");
    document.getElementById("txtSenha2").style.background = "red";
    return false;
  // eslint-disable-next-line brace-style
  }
  else if (ValorSenha2.lenght < 3)
  // eslint-disable-next-line brace-style
  {
    alert('Senha precisa ter ao menos 3 caracteres');
    document.getElementById("txtSenha2").style.color = "red";
    return false;
  // eslint-disable-next-line brace-style
  }
  else
  // eslint-disable-next-line brace-style
  {
    document.getElementById("txtSenha2").style.color = "black";
    return true;
  }
}

function ValidarEmail ()
// eslint-disable-next-line brace-style
{
  var ValorEmail = document.getElementById("txtEmail").value

  if (ValorEmail == "")
  // eslint-disable-next-line brace-style
  {
    alert("Campo está vazio");
    return false;
  // eslint-disable-next-line brace-style
  }
  else if (ValorEmail.indexOf('@'))
  // eslint-disable-next-line brace-style
  {
    alert("Insira um email válido");
    return false;
  // eslint-disable-next-line brace-style
  }
  else if (ValorEmail.indexOf('.'))
  // eslint-disable-next-line brace-style
  {
    alert("Insira um email válido");
    return false;
  // eslint-disable-next-line brace-style
  }
  else
  // eslint-disable-next-line brace-style
  {
    return true;
  }
}
