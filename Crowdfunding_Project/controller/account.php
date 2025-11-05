<html>
<body>

<h1> Account Information</h1>

<head>

<style>
      body {
        
        margin: 0;
        padding: 20px;
        background-color: #d0f1bb;
      }

     
      h1 {
        text-align: center;
        color: #333;
      }

      form {
        background-color: #e3e3e3;
        padding: 20px;
        border-radius: 8px;
        width: 300px;
        margin: 0 auto;
      }

      table {
      width: 100%;
      margin-bottom: 10px;
    }
      input[type="text"] {
        width: 100%;
        padding: 10px;
        margin-bottom: 15px;
        border-radius: 4px;
        border: 1px solid #ccc;
      }

      input[type="submit"] {
        width: 100%;
        padding: 10px;
        background-color: #d6813b;
        color: white;
        border: none;
        border-radius: 4px;
      }

      input[type="submit"]:hover {
        background-color: #c12929;
      }
    </style>
</head>

<?php

    session_start();
    $id = $_SESSION['account'];

    $con = mysqli_connect('127.0.0.1', 'root', '', 'fundflock');
    $sql = "SELECT * FROM user WHERE Account_No ='{$id}'";
    $result = mysqli_query($con,$sql);

    $row = mysqli_fetch_assoc($result);

    
    $name=$row['Name'];
    $email=$row['Email'];
    $password=$row['Password']



?>

<form>
  <label for="useracc">Account ID:</label>
  <input type="text" id="useracc" name="useracc" value="<?php echo $id ?>" ><br><br>
  Password: <input type="text" id="password" name="password" value="<?php echo $password ?>" ><br><br>
   <label for="updatename">  Name:</label>
  <input type="text" id="updatename" name="updatename" value="<?php echo $name ?>" ><br><br>
    <label for="useremail"> Email:</label>
  <input type="text" id="useremail" name="useremail" value="<?php echo $email ?>"><br><br>
  
  
  <input type="submit" value="Submit">
</form>

</body>
</html>

