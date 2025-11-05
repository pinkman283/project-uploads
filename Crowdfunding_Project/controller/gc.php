<!DOCTYPE html>
<html lang="en">
<head>
  <title>Confirmation</title>
  <link rel="stylesheet" type="text/css" href="../css/mystyle.css">
</head>
<body>
  <h1>Confirmation</h1>
  <form action="" method="POST">
    <label for="email">Enter your Email Address:</label><br>
    <input type="email" id="email" name="email" placeholder="example@example.com" required><br><br>
    <button type="submit" class="btnregister">Confirm</button>
  </form>

  <?php
  require_once "mydb2.php";

  if ($_SERVER['REQUEST_METHOD'] === 'POST' && isset($_POST['email'])) {
    $email = trim($_POST['email']);
    $pattern = "/^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$/";

    if (empty($email)) {
      echo "<p>Please enter your email address.</p>";
    } elseif (!preg_match($pattern, $email)) {
      echo "<p>Invalid email format.</p>";
    } else {
      $email = mysqli_real_escape_string($conn, $email);

      $query = "SELECT email FROM users WHERE email = '$email'";
      $result = mysqli_query($conn, $query);

      if (!$result) {
        echo "<p>Database error: " . mysqli_error($conn) . "</p>";
      } elseif (mysqli_num_rows($result) > 0) {
        echo "<p>Confirmation successful!</p>";
      } else {
        $insert_query = "INSERT INTO users (email) VALUES ('$email')";
        if (mysqli_query($conn, $insert_query)) {
          echo "<p>Confirmation successful!</p>";
        } else {
          echo "<p>Error storing email: " . mysqli_error($conn) . "</p>";
        }
      }
    }
  }

  mysqli_close($conn);
  ?>
</body>
</html>
