<?php
    include_once 'UserModel.php';
     session_start();
     if(isset($_POST['confirm']))
     {
        $email=$_POST['email'];
        $password=$_POST['password'];
        $confirm_password=$_POST['confirmPassword'];
        if(empty($email) || empty($confirm_password) || empty($password))
        {
            echo "null value found";
        }
        elseif($password!=$confirm_password)
        {
            echo "Password doesn't match!";
        }
        else{
            $status= updatePassword($email,$password);
            if($status)
            {
                echo "Password update successfully";
                echo "<br><a href='signin.html'>Back</a>";
            }
            else 
            {
                echo "error!!";
            }
        }
     }
    
    else 
    {
        header('location: Admin_dash.html');
    }

?>