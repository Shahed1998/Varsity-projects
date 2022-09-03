'use strict';

function search() {
  var facName = document.getElementById('fac_name');
  var resInt = document.getElementById('res_int');
  var desg = document.getElementById('desg');
  var dept = document.getElementById('dept');

  var http = new XMLHttpRequest();
  http.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
      document.querySelector('.info').innerHTML = this.responseText;
    }
  };
  http.open('POST', 'searchFaculty.php', true);
  http.setRequestHeader('Content-type', 'application/x-www-form-urlencoded');
  http.send(`fName=${facName.value}&resInt=${resInt.value}&desg=${desg.value}`);
}

// `facName=${facName.value}&resInt=${resInt.value}&desg=${desg.value}`;
