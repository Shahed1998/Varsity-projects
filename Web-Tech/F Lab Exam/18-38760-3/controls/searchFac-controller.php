<?php
    include("../models/db.php");
    $connection = new db();
    $connObj = $connection->openConn();
    $userQuery = $connection->searchLec($connObj,'faculty',$_POST['fName'],$_POST['resInt'],$_POST['desg']); 
    $connection->closeConn($connObj);

?>