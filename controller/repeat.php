<?php

session_start();

if ($_SERVER["REQUEST_METHOD"] == "POST") 
{
    $amount = $_REQUEST['amount'];
    if($amount=="")
    {
        echo "Please Enter a valid emount";
    }
    else if (!isset($_POST['payment_method']) || empty($_POST['payment_method'])) 
    {
        $payment_method_error = "Please select a payment method."; 
        
        
    } 
    else 
    {
        $payment_method = $_POST['payment_method'];
        //echo $payment_method;
       // echo $amount;
        $account =  $_SESSION['account'];
       // echo $account;

        $con = mysqli_connect('127.0.0.1', 'root', '', 'fundflock');
        $sql = "INSERT INTO Donation (Account_No,Amount,Method) VALUES ('{$account}', '{$amount}', '{$payment_method}');";
        $result = mysqli_query($con, $sql);

        $sql = "SELECT Donation FROM user WHERE Account_No='{$account}'";
        $result = mysqli_query($con, $sql);
        $row = mysqli_fetch_assoc($result);

        $donation =  $row['Donation'];

        $total = $donation + $amount;
        //echo $total;
        

        if($result)
        {
            $badge ="";
            if($total>20000)
            {
                $badge="No Badge";
            }
           if($total>=20000 && $total<=49999)
                $badge = "Silver";
            else if($total>= 50000 && $total<=199999)
                $badge = "Gold";
            else 
            $badge = "Platinum";

            $sql = "UPDATE user SET Donation = {$total}, Badge = '{$badge}' WHERE Account_No = '{$account}'";
            $result = mysqli_query($con, $sql);

            header('location: repeat.html');
        }
        else
        {
            header('location: repeat.html');
        }
    }
}
?>

