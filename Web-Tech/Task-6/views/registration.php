<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registration</title>
</head>
<body>
    <h1>Registration form</h1>
    <hr>
    <form action="" onsubmit="return validator()">
        <table>
            <tr>
                <td>Full name:</td>
                <td><input type="text" id="fName"></td>
                <td><div id="name-err"></div></td>
            </tr>
            <tr>
                <td>Email:</td>
                <td><input type="text" id="email"></td>
                <td><div id="email-err"></div></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td><input type="password" id="pass"></td>
                <td><div id="pass-err"></div></td>
            </tr>
            <tr>
                <td>Comments:</td>
                <td><textarea  cols="30" rows="5" id="comment"></textarea></td>
                <td><div id="cmnt-err"></div></td>
            </tr>
            <tr>
                <td>Gender:</td>
                <td>
                    <div id="gender">
                    <input type="radio" id="male" name="selection" class="gender" value="Male">
                    <label for="male">Male</label>
                    <input type="radio" id="female" name="selection" class="gender" value="Female">
                    <label for="female">Female</label>
                    <input type="radio" id="others" name="selection" class="gender" value="Others">
                    <label for="Others">Others</label>
                    </div>
                </td>
                <td><div id="gender-err"></div></td>
            </tr>
            <tr>
                <td>Please choose a hobby:</td>
                <td>
                    <input type="checkbox" id="Singing">
                    <label for="Singing">Singing</label>
                    <input type="checkbox" id="Dancing">
                    <label for="Dancing">Dancing</label>
                    <input type="checkbox" id="Reading">
                    <label for="Reading">Reading</label>
                </td>
                <td><div id="hobby-err"></div></td>
            </tr>
            <tr>
                <td> <label for="img">Please choose an image:</label></td>
               <td><input type="file" id="img"></td>
               <td><div id="img-err"></div></td>
            </tr>
            <tr>
                <td>
                    <input type="submit" value="Submit">
                    <input type="reset" value="Reset">
                </td>
            </tr>
        </table>
    </form>
    <script src="../public/scripts/script.js?v=<?= time(); ?>"></script>
</body>
</html>