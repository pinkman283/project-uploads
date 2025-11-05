<?php
    
    //include_once 'UserModel.php';
    session_start();
    if(isset($_POST['create']))
    {
        $catagories=$_POST['catagories'];
        $new_catagory=$_POST['catagory'];

        if(!empty($catagories) && $new_catagory!=null)
        {
            echo "please choose a catagory or create a new catagory";
        }
        
        else{
           header('location: ../Campaign_Creation_and_Management/Campaign_Title.html');
        }

    }
    else 
    {
        header('location: User_dash.html');
    }





?>




