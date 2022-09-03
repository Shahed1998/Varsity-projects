<?php

    include('../controls/homeC.php');
    include("./partials/header.php");
   
?>

<h1>Search Faculty</h1><br><br>

<label for="fac_name">Faculty name</label><br>
<input type="text" name="fac_name" id="fac_name"><br><br>

<label for="res_int">Research Interest</label><br>
<input type="text" name="res_int" id="res_int"><br><br>

<label for="desg">Search by Designation:</label><br>
<select name="desg" id="desg">
  <option value="">Select Designation</option>
  <option value="lecturer">lecturer</option>
  <option value="assistant-professor">assistant professor</option>
  <option value="professor">professor</option>
</select><br><br>

<label for="depart">Search by department</label><br>
<input type="radio" name="dept" id="cs" value="cs">
<label for="cs">CS</label>
<input type="radio" name="dept" id="phy" value="physics">
<label for="phy">Physics</label>
<input type="radio" name="dept" id="eee" value="eee">
<label for="eee">EEE</label><br><br>

<input type="submit" value="Submit" name="submit" onclick="search()">

<div class="info"></div>


<?php include("./partials/footer.php"); ?>