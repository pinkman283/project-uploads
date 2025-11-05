<?php
// Database connection details
$host = "localhost";
$username = "root";
$password = ""; // Replace with your database password
$database = "db2"; // Ensure the database exists

// Create a connection
$conn = new mysqli($host, $username, $password, $database);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
?>
