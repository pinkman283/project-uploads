<?php
    
    include_once '../User_Authentication/UserModel.php';
    session_start();
    if(isset($_POST['save']))
    {
        $title=$_POST['title'];
        $description=$_POST['description'];
        

        if($title==null || $description==null)
        {
            echo "null value found!";
        }
        
        else
        {
            $status=addCampaign($title,$description);
            if($status)
            {
              header('location: Deadline.html');
            }
            else{
                echo "Error: Campaign creation failed!";
            }
        }

    }
    else 
    {
        header('location: Campaign_Title.html');
    }





?>