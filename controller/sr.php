<?php

$servername = "localhost";
$username = "root"; 
$password = ""; 
$dbname = "reviews_db";

// Connect to the database
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$message = "";

if ($_SERVER["REQUEST_METHOD"] === "POST") {
    $review = trim($_POST['review']);

    if (empty($review)) {
        $message = "<p style='color:red;'>Review cannot be empty!</p>";
    } else {
        // Insert review into database
        $stmt = $conn->prepare("INSERT INTO reviews (review) VALUES (?)");
        $stmt->bind_param("s", $review);

        if ($stmt->execute()) {
            $message = "<p style='color:green;'>Thank you for your review!</p>";
        } else {
            $message = "<p style='color:red;'>Error submitting your review. Please try again later.</p>";
        }

        $stmt->close();
    }
}

$conn->close();
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <title>Submit Review</title>
    <link rel="stylesheet" type="text/css" href="../css/mystyle.css">
</head>
<body>
    <h2>Submit Your Review</h2>

    <div>
        <?php
        echo $message;
        ?>
    </div>

    <form action="sr.php" method="POST">
        <label for="review">Review:</label>
        <textarea id="review" name="review" required></textarea><br><br>
        <input type="submit" value="Submit Review">
    </form>
</body>
</html>
