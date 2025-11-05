<?php
include_once 'UserModel.php';
session_start();

if (isset($_POST['signin'])) {
   header('location: signin.html');
} 
elseif(isset($_POST['signup']))
{
    header('location: signup.html');
    
}
else{
    header('location: homePage.html');
}
?>
