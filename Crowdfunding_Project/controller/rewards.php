<html>
<body>
 <head>    
  <style>
      body {
        font-size: 16px;
        margin: 0;
        padding: 20px;
        background-color: #f4f4f4;
      }

      h2 {
        text-align: center;
        color: #333;
      }

      form {
        background-color: #fff;
        padding: 20px;
        border-radius: 8px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        width: 300px;
        margin: 0 auto;
      }

      label {
     
        display: flex;
        margin-bottom: 8px;
      }

      input[type="text"] {
        width: 100%;
        padding: 10px;
        margin-bottom: 15px;
        border-radius: 4px;
        border: 1px solid #ccc;
      }

      button {
        width: 20%;
        padding: 10px;
        background-color: #e6a234;
        color: white;
        border: none;
        border-radius: 4px;
      }

      button:hover {
        background-color: #e43c3c;
      }

      a {
        display: block;
        text-align: center;
        margin-top: 20px;
      }
    </style> </head> 
 
<?php
            session_start();
 
           
            $account=  $_SESSION['account'];
 
            $con = mysqli_connect('127.0.0.1', 'root', '', 'fundflock');
            $sql = "SELECT * FROM user WHERE Account_No='{$account}'";
            $result = mysqli_query($con, $sql);
            $row = mysqli_fetch_assoc($result);
           
            $name = $row['Name'];
            $Donation = $row['Donation'];
            $badge = $row['Badge'];
           // $result = mysqli_query($con, $sql);
           // $count =  mysqli_num_rows($result);
 
?>
 
<form>
  <label for="name">Name:</label>
  <input type="text" id="name" value="<?php echo $name ?>"><br><br>
 
   <label for="Donation"> Dontaion :</label>
   <input type ="text" id="donation" name="donation" value="<?php echo $Donation ?>"><br><br>
   
   <label for="reward">Reward Badge:</label>
  <input type="text" id="reward" value="<?php echo $badge ?>"><br><br>
   
</form>
<a href = 'Accdash.html'> <button> Back </button> </a>
 
</body>
</html>