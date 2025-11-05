<?php
session_start();

if (isset($_POST['mydata'])) {
    
    $json = $_POST['mydata'];
    $user = json_decode($json, true);

    $accountNo = trim($user['accNo']);
    $password = trim($user['password']);

    if (empty($accountNo) || empty($password)) {
       
        echo json_encode(['success' => false, 'message' => 'Account number or password cannot be empty.']);
        exit;
    }

    $con = mysqli_connect('127.0.0.1', 'root', '', 'fundflock');
    if (!$con) {
       
        echo json_encode(['success' => false, 'message' => 'Database connection failed.']);
        exit;
    }

   
    $sql = "SELECT * FROM user WHERE Account_No='{$accountNo}' AND Password='{$password}'";
    $result = mysqli_query($con, $sql);
    $count = mysqli_num_rows($result);

   
    if ($count == 1) {
        $_SESSION['account'] = $accountNo;
        
        echo json_encode(['success' => true]);
    } else {
      
        echo json_encode(['success' => false, 'message' => 'Invalid account number or password.']);
    }

    
    mysqli_close($con);
} else {

    echo json_encode(['success' => false, 'message' => 'No data received.']);
}
?>
