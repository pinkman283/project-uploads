<?php

function getConnection() {
    $con = mysqli_connect('127.0.0.1', 'root', '', 'fundflock');
    if (!$con) {
        die("Database connection failed: " . mysqli_connect_error());
    }
    return $con;
}


function login($email, $password) {
    $con = getConnection();
    $sql = "select * from user_info where email='{$email}' and password='{$password}'";
    $result = mysqli_query($con, $sql);
    $count = mysqli_num_rows($result);

    if ($count == 1) {
        return true;
    } else {
        return false;
    }
}
function checkUserType($email) {
    $con = getConnection();
    $sql = "SELECT user_type FROM user_info WHERE email = '{$email}'";
    $result = mysqli_query($con, $sql);

    if ($result && mysqli_num_rows($result) == 1) {
        $row = mysqli_fetch_assoc($result);
        return $row['user_type'];
    }
    return null;
}


function addUser($name, $email, $password, $user_type) {
    $con = getConnection();
    $sql = "INSERT INTO user_info (name, email, password, user_type) VALUES ('{$name}', '{$email}', '{$password}', '{$user_type}')";
    return mysqli_query($con, $sql);
}


function getUser($email) {
    $con = getConnection();
    $sql = "SELECT name FROM user_info WHERE email='{$email}'";
    $result = mysqli_query($con, $sql);

    if (!$result) {
        die("Database query failed: " . mysqli_error($con)); // Show SQL error
    }

    $user = mysqli_fetch_assoc($result);

    if (!$user) {
        die("No user found with the given email."); // Ensure data exists
    }

    return $user;
}


function getAllUser() {
    $con = getConnection();
    $sql = "select * from user_info";
    $result = mysqli_query($con, $sql);
    $users = [];

    while ($row = mysqli_fetch_assoc($result)) {
        $users[] = $row;
    }

    return $users;
}

function updateUser($email) {
    $con = getConnection();
    $sql = "UPDATE user_info SET user_type='Admin' WHERE email='{$email}'"; 
    $result = mysqli_query($con, $sql);
    
    if ($result) {
        return true;
    } else {
        echo "Error: " . mysqli_error($con); 
        return false;
    }
}

function deleteUser($email) {
    $con = getConnection();
    $sql = "delete from user_info where email='{$email}'";

    if (mysqli_query($con, $sql)) {
        return true;
    } else {
        return false;
    }
}
function updatePassword($email, $newPassword) {
    $con = getConnection();
    $sql = "UPDATE user_info SET password='{$newPassword}' WHERE email='{$email}'";
    
    $result = mysqli_query($con, $sql);
    
    if ($result) {
        return true;
    } else {
        echo "Error: " . mysqli_error($con); // Display error if the query fails
        return false;
    }
}
function getAllCampaign() {
    $con = getConnection();
    $sql = "select * from campaign";
    $result = mysqli_query($con, $sql);
    $campaigns = [];

    while ($row = mysqli_fetch_assoc($result)) {
        $campaigns[] = $row;
    }

    return $campaigns;
}
function addCampaign($title,$description) {
    $con = getConnection();
    $sql = "INSERT INTO campaign (title, description) VALUES ('{$title}', '{$description}')";
    return mysqli_query($con, $sql);
}



?>
