<?php
include_once 'UserModel.php';
session_start();

$json = file_get_contents('php://input');
$data = json_decode($_POST['data'], true);


$email = $data['email'];
$password = $data['password'];

$response = [];

if (empty($email) || empty($password)) {
    $response = ['status' => 'error', 'message' => 'Null value found!'];
} else {
    $status = login($email,$password);

    if ($status) {
        $user = getUser($email);
        $_SESSION['name'] = $user['name'];
        $check = checkUserType($email);

        if ($check === "Admin" || $check === "admin") {
            $response = ['status' => 'success', 'redirectUrl' => '../Dashboard/Admin_dash.html'];
        } else {
            $response = ['status' => 'success', 'redirectUrl' => '../Dashboard/User_dash.html'];
        }
    } else {
        $response = ['status' => 'error', 'message' => "email or password doesn't match!"];
    }
}

echo json_encode($response);
?>
