<?php
include_once 'UserModel.php';
session_start();

$json = file_get_contents('php://input');

$data = json_decode($json, true);

if (!$data) {
    echo json_encode(['status' => 'error', 'message' => 'Invalid input data!']);
    exit();
}

$name = trim($data['name']);
$email = trim($data['email']);
$password = trim($data['password']);
$confirm_password = trim($data['confirm_password']);
$user_type = $data['user_type'];

if (empty($name) || empty($email) || empty($password) || empty($user_type)) {
    echo json_encode(['status' => 'error', 'message' => 'All fields are required!']);
    exit();
}

if ($password !== $confirm_password) {
    echo json_encode(['status' => 'error', 'message' => 'Passwords do not match!']);
    exit();
}

$status = addUser($name, $email, $password, $user_type);

if ($status) {
    echo json_encode(['status' => 'success', 'message' => 'Signup successful!', 'redirectUrl' => 'signin.html']);
} else {
    echo json_encode(['status' => 'error', 'message' => 'Signup failed. Please try again!']);
}
exit();
?>
