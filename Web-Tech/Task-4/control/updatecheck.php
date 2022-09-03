<?php
include('../model/db.php');


 $error="";

if (isset($_POST['update'])) {
if (empty($_POST['firstname']) || empty($_POST['email']) || empty($_POST['password']) ) {
$error = "input given is invalid";
}
else
{
$connection = new db();
$conobj=$connection->OpenCon();

$userQuery=$connection->UpdateUser(
    $conobj,
    "student",
    $_SESSION["username"],
    $_POST['firstname'],
    $_POST['email'],
    $_POST['password']
);


if($userQuery==TRUE)
{
    echo "update successful"; 
    $_SESSION["password"] = $_POST["password"];
}
else
{
    echo "could not update";    
}
$connection->CloseCon($conobj);

}
}


?>
