<?php
    
    include_once 'UserModel.php';
    session_start();
    if(isset($_POST['Set']))
    {
        $goal=$_POST['goal'];
       

        if($goal<10)
        {
            echo "minimum goal ammount doesnt match!";
        }
        
        else{
           header('location: ../Dashboard/User_dash.html');
        }

    }
    else 
    {
        header('location: Goal_Setting.html');
    }





?>