<?php
    
    //include_once 'UserModel.php';
    session_start();
    if(isset($_POST['account']))
    {
        header('location: Account.php');

    }
    else if(isset($_POST['payment']))
    {
            header('location: Repeat.html');
    }
    else if(isset($_POST['rewards']))
    {
        header('location: rewards.php');
    }
    else if(isset($_POST['remainder']))
    {
        header('location: ../../oishi/Email/index.php');
    }
    else
    {
        header('location: interaction.html');
    }
?>