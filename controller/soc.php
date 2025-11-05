<?php
require_once "mydb1.php";  

$error = "";
$campaign_url = "";
$success_message = "";

$table_check_query = "CREATE TABLE IF NOT EXISTS campaign (
    id INT AUTO_INCREMENT PRIMARY KEY,
    campaign_url VARCHAR(255) NOT NULL
)";
mysqli_query($conn, $table_check_query);  

if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $campaign_url = trim($_POST['campaign_url']);

    if (empty($campaign_url)) {
        $error = "Please enter a campaign URL.";
    } elseif (!preg_match('/^https?:\/\/[^\s]+$/', $campaign_url)) {
        $error = "Invalid URL format. Make sure it starts with http:// or https://";
    } else {
        // Escape the URL to prevent SQL injection
        $campaign_url = mysqli_real_escape_string($conn, $campaign_url);

       
        $query = "INSERT INTO campaign (campaign_url) VALUES ('$campaign_url')";
        if (mysqli_query($conn, $query)) {
            $success_message = "URL is valid and has been saved to the database!";
        } else {
            $error = "Error saving the URL: " . mysqli_error($conn);
        }
    }
}

// Close the database connection
if (isset($conn) && $conn instanceof mysqli) {
    mysqli_close($conn);
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <title>Share This Campaign</title>
    <link rel="stylesheet" type="text/css" href="../css/mystyle.css">
    <script>
        function validateForm() {
            var urlField = document.getElementById('campaign_url').value;
            if (!urlField.startsWith('http://') && !urlField.startsWith('https://')) {
                alert('Please enter a valid URL starting with http:// or https://');
                return false;
            }
            return true;
        }
    </script>
</head>
<body>
    <form action="" method="POST" onsubmit="return validateForm()">
        <h1>Share This Campaign</h1>
        <label for="campaign_url">Campaign URL:</label><br>
        <input type="text" name="campaign_url" id="campaign_url" value="<?= htmlspecialchars($campaign_url) ?>"><br><br>
        <button type="submit" class="btnregister">Generate Link</button >
        <br><br>
        <?php if (!empty($error)): ?>
            <p style="color: red;"><?= $error; ?></p>
        <?php elseif (!empty($success_message)): ?>
            <p style="color: green;"><?= $success_message; ?></p>
            <p>Your Campaign URL: <?= htmlspecialchars($campaign_url); ?></p>
        <?php endif; ?>
    </form>
</body>
</html>
