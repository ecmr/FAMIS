function limpa_string(S){
 // Deixa so' os digitos no numero
 var Digitos = "0123456789";
 var temp = "";
 var digito = "";
    for (var i=0; i<S.length; i++){
      digito = S.charAt(i);
      if (Digitos.indexOf(digito)>=0){temp=temp+digito}
    }
   return temp
}


