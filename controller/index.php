<!DOCTYPE html>
<html lang="en">
<head>
  <title>Simple Multi-Form</title>
  <link rel="stylesheet" type="text/css" href="../css/mystyle.css">
</head>
<body>

<?php
require_once "mydb2.php"; 
?>

  <form action="" method="POST">
    <h1>Select a Form</h1>
    <button type="submit" name="form" value="cub"class="btnregister"></td>Campaign Update</button>
    <button type="submit" name="form" value="dr"class="btnregister"></td>Deadline Reminder</button>
    <button type="submit" name="form" value="gc" class="btnregister"></td>Confirmation</button>
  </form>

  <?php
  // Check if a form is submitted
  if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $allowed_forms = ['cub', 'dr', 'gc'];

    // Check if the 'form' field exists and is valid
    if (isset($_POST['form']) && in_array($_POST['form'], $allowed_forms)) {
      
      if ($_POST['form'] === 'cub') {
        // Campaign Update Form
        ?>
        <h2>Campaign Update</h2>
        <form action="" method="POST">
          <!-- Include a hidden field to indicate this is the 'Campaign Update' form -->
          <input type="hidden" name="form" value="cub">

          <label for="update_message">Message:</label><br>
          <input type="text" name="update_message" id="update_message"><br><br>
          <button type="submit">Submit</button>
        </form>
        <?php

        // Process Campaign Update submission
        if (isset($_POST['update_message'])) {
          $update_message = trim($_POST['update_message']);

          if (empty($update_message)) {
            echo "<p>Message cannot be empty.</p>";
          } elseif (strlen($update_message) > 500) {
            echo "<p>Message is too long. Maximum 500 characters allowed.</p>";
          } else {
            echo "<p>Message submitted successfully!</p>";
            // Optionally, you could store the message in the database or perform other actions here
          }
        }

      } elseif ($_POST['form'] === 'dr') {
        // Deadline Reminder Form
        ?>
        <h2>Deadline Reminder</h2>
        <form>
          <label for="projectName">Project Name:</label><br>
          <input type="text" id="projectName" value="Web tech Project" readonly><br><br>
          <label for="deadline">Deadline:</label><br>
          <input type="text" id="deadline" value="2025-01-15" readonly><br><br>
        </form>
        <?php

      } elseif ($_POST['form'] === 'gc') {
        // Confirmation Form
        ?>
        <h2>Confirmation</h2>
        <form action="" method="POST">
          <label for="email">Enter your Email Address:</label><br>
          <input type="email" id="email" name="email" placeholder="example@example.com" required><br><br>
          <input type="hidden" name="form" value="gc"> <!-- Pass form type to process submission -->
          <button type="submit">Confirm</button>
        </form>
        <?php

        // Process Confirmation Form submission
        if (isset($_POST['email'])) {
          $email = trim($_POST['email']);

          $pattern = "/^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$/";

          if (empty($email)) {
            echo "<p>Please enter your email address.</p>";
          } elseif (!preg_match($pattern, $email)) {
            echo "<p>Invalid email format.</p>";
          } else {
            // Check if the email already exists in the database
            $query = "SELECT email FROM users WHERE email = '$email'";
            $result = mysqli_query($conn, $query);

            if (mysqli_num_rows($result) > 0) {
              echo "<p>Confirmation successful! Your email address is: $email</p>";
            } else {
              // Insert the email into the database
              $insert_query = "INSERT INTO users (email) VALUES ('$email')";
              if (mysqli_query($conn, $insert_query)) {
                echo "<p>Email address successfully stored and confirmed: $email</p>";
              } else {
                echo "<p>Error storing email: " . mysqli_error($conn) . "</p>";
              }
            }
          }
        }
      }
    } else {
      echo "<p>Invalid form selection.</p>";
    }
  }
  mysqli_close($conn);
  ?>
</body>
</html>
