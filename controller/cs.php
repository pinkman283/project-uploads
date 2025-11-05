<?php
// Database connection details
$host = "localhost";
$username = "root";
$password = "";
$database = "db";

// Create a connection
$conn = new mysqli($host, $username, $password, $database);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

$nameErr = $emailErr = $commentErr = "";
$name = $email = $comment = "";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $isValid = true;

    if (empty($_POST["name"])) {
        $nameErr = "Name is required.";
        $isValid = false;
    } else {
        $name = htmlspecialchars(trim($_POST["name"]));
    }

    if (empty($_POST["email"])) {
        $emailErr = "Email is required.";
        $isValid = false;
    } elseif (!filter_var($_POST["email"], FILTER_VALIDATE_EMAIL)) {
        $emailErr = "Invalid email format.";
        $isValid = false;
    } else {
        $email = htmlspecialchars(trim($_POST["email"]));
    }

    if (empty($_POST["comment"])) {
        $commentErr = "Comment is required.";
        $isValid = false;
    } else {
        $comment = htmlspecialchars(trim($_POST["comment"]));
    }

    if ($isValid) {
        $stmt = $conn->prepare("INSERT INTO comments (name, email, comment) VALUES (?, ?, ?)");
        $stmt->bind_param("sss", $name, $email, $comment);

        if ($stmt->execute()) {
            echo "<p style='color: green;'>Comment submitted successfully!</p>";
        } else {
            echo "<p style='color: red;'>Error: " . $stmt->error . "</p>";
        }

        $stmt->close();
    }
}

$conn->close();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Submit Comment</title>
    <link rel="stylesheet" type="text/css" href="../css/mystyle.css">
</head>
<body>
    <h2>Submit Your Comment</h2>
    <form action="cs.php" method="POST">
        <label for="name">Name:</label>
        <input type="text" id="name" name="name" value="<?php echo htmlspecialchars($name); ?>" required>
        <span class="error"><?php echo $nameErr; ?></span>
        <br><br>
        <label for="email">Email:</label>
        <input type="email" id="email" name="email" value="<?php echo htmlspecialchars($email); ?>" required>
        <span class="error"><?php echo $emailErr; ?></span>
        <br><br>
        <label for="comment">Comment:</label>
        <textarea id="comment" name="comment" required><?php echo htmlspecialchars($comment); ?></textarea>
        <span class="error"><?php echo $commentErr; ?></span>
        <br><br>
        <input type="submit" value="Submit Comment">
    </form>
</body>
</html>
