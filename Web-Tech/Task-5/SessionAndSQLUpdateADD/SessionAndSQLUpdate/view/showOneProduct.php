<?php
    session_start(); 
    if(empty($_SESSION["username"])) {
        header("Location: ./login.php"); // Redirecting To Home Page
    }

    include("../control/showProduct.php");
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Products</title>
</head>
<body>
    <h5>Do you want to see all products ? <a href="./seeAllProduct.php">See all products</a></h5>

    <form action="" method="post">
        <input type="text" name="p_name" placeholder="Enter product name">
        <input type="submit" name="search-product" value="Search">
    </form>
</body>
</html>