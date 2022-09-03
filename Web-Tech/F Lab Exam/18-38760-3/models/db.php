<?php

    class db{

        // ------------------------------------ Open Connection
        function openConn(){

            $serverName = "localhost";
            $userName = "newUser";
            $password = "shahed1998";
            $dbName = "mydb";

            $conn = new mysqli($serverName,$userName,$password,$dbName);

            if($conn->connect_error){

                die("Failed to connect");

            }

            echo "Connected successfully";

        }

        function searchLec($connObj,$table,$name,$inter,$desg){
            $sql = "SELECT * FROM $table WHERE Name LIKE '$name%' OR Interest LIKE '$inter%' OR Designation LIKE '$desg%'";
            $ret = $connObj->query($sql);

            $result = "
            <table>
                <tr>
                    <th>Name</th>
                    <th>Interest</th>
                    <th>Designation</th>
                    <th>Department</th>
                </tr>
            ";

            
            if($ret->num_rows>0){

                while($rows = $ret->fetch_assoc()){

                    
                    $result .= "<tr>".
                    "<td>".$rows['Name']."</td>".
                    "<td>".$rows['Interest']."</td>".
                    "<td>".$rows['Designation']."</td>".
                    "<td>".$rows['Department']."</td>".
                    "</tr>";

                }

                $result .= "</table>";


            }else{
                $result = FALSE;
            }
            return $result;
        }

        // ------------------------------------ Close Connection
        function closeConn($connObj){

            $connObj->close();

        }


    }

?>