'use strict';
function validator() {
  var fName = document.getElementById('fName');
  var email = document.getElementById('email');
  var pass = document.getElementById('pass');
  var comment = document.getElementById('comment');
  var male = document.getElementById('male');
  var female = document.getElementById('female');
  var others = document.getElementById('others');
  var hobby1 = document.getElementById('Singing');
  var hobby2 = document.getElementById('Dancing');
  var hobby3 = document.getElementById('Reading');
  var img = document.getElementById('img');

  var nameErr = document.getElementById('name-err');
  var emailErr = document.getElementById('email-err');
  var passErr = document.getElementById('pass-err');
  var commentErr = document.getElementById('cmnt-err');
  var genderErr = document.getElementById('gender-err');
  var hobbyErr = document.getElementById('hobby-err');
  var imgErr = document.getElementById('img-err');

  var nameErrMsg = '';
  var emailErrMsg = '';
  var passErrMsg = '';
  var cmntErrMsg = '';
  var genderErrMsg = '';
  var hobbyErrMsg = '';
  var imgErrMsg = '';

  var regex =
    /^([a-z0-9\+_\-]+)(\.[a-z0-9\+_\-]+)*@([a-z0-9\-]+\.)+[a-z]{2,6}$/;
  var flag = 0;

  //   ---------------------------------Name validation
  if (fName.value.length < 1) {
    nameErrMsg = '* Name is required.';
    flag = 1;
  } else if (fName.value.length < 5) {
    nameErrMsg = '* Name must be more than 5 characters long.';
    flag = 1;
  }
  //   -----------------------------Email validation
  if (email.value.length < 1) {
    emailErrMsg = '* Email is required';
    flag = 1;
  } else if (regex.test(email.value) == false) {
    emailErrMsg = '* Invalid email';
    flag = 1;
  }
  //   --------------------------------Password validation
  if (pass.value.length < 1) {
    passErrMsg = '* Password is required';
    flag = 1;
  } else if (pass.value.length < 5) {
    passErrMsg = '* Weak password';
    flag = 1;
  }

  // -----------------------------------Comment validation
  if (comment.value.length < 1) {
    cmntErrMsg = '* Comment is required.';
    flag = 1;
  }
  // --------------------------------------Gender validation
  if (
    male.checked === false &&
    female.checked === false &&
    others.checked === false
  ) {
    genderErrMsg = '* Must select a gender';
    flag = 1;
  }
  // ---------------------------------------Hobby validation
  if (
    hobby1.checked === false &&
    hobby2.checked === false &&
    hobby3.checked === false
  ) {
    hobbyErrMsg = '* Must select a hobby';
    flag = 1;
  }
  // ------------------------------------Image validation

  if (img.value.length < 1) {
    imgErrMsg = '* Must select an image';
    flag = 1;
  }

  // --------------------------------Return values

  if (flag == 1) {
    nameErr.innerHTML = nameErrMsg;
    emailErr.innerHTML = emailErrMsg;
    passErr.innerHTML = passErrMsg;
    commentErr.innerHTML = cmntErrMsg;
    genderErr.innerHTML = genderErrMsg;
    hobbyErr.innerHTML = hobbyErrMsg;
    imgErr.innerHTML = imgErrMsg;
    return false;
  }
}
