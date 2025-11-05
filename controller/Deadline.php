<?php
//include_once 'UserModel.php';
session_start();

if (isset($_POST['Save'])) {
    $duration = $_POST['duration'];
    $start_date = $_POST['start_date'];
    $end_date = $_POST['end_date'];

    if ($duration == null || $start_date == null || $end_date == null) {
        echo "Null value found!";
    } 
    else 
    {
        $datetime1 = new DateTime($start_date);
        $datetime2 = new DateTime($end_date);
        $interval = $datetime2->diff($datetime1);
        $daysDifference = $interval->days; 
        if ($duration > 60 || $duration < 1 || $daysDifference != $duration || $daysDifference > 60) 
        {
            echo "Duration entered: $duration<br>";
            echo "Actual days between dates: $daysDifference<br>";
            echo "Doesn't match with the requirement";
        } 
        else 
        {
            header('location: Goal_Setting.html');
            exit(); 
        }
    }
} else {
    header('location: Deadline.html');
    exit();
}
?>
