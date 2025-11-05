<?php
    include_once '../User_Authentication/UserModel.php';
    session_start();

    // Read the raw JSON input
    $json = file_get_contents('php://input');
    $data = json_decode($json, true); // Decode the incoming JSON data
    $response = [];
    $response2 = [];

    if (isset($_POST['showUser'])) {
        $users = getAllUser();
        if (!empty($users)) {
            echo "<table border='1'>";
            echo "<tr>
                    <th>Username</th>
                    <th>Password</th>
                    <th>Email</th>
                    <th>User Type</th>
                  </tr>";
            foreach ($users as $user) {
                echo "<tr>
                        <td>{$user['name']}</td>
                        <td>{$user['password']}</td>
                        <td>{$user['email']}</td>
                        <td>{$user['user_type']}</td>
                      </tr>";
            }
            echo "</table>";
            echo '<a href="Admin_dash.html">Back</a>';
        } else {
            echo "No users found!";
        }
    } elseif (isset($_POST['showCampaign'])) {
        $campaign = getAllCampaign();
        if (!empty($campaign)) {
            echo "<table border='1'>";
            echo "<tr>
                    <th>Title</th>
                    <th>Description</th>
                  </tr>";
            foreach ($campaign as $campaigns) {
                echo "<tr>
                        <td>{$campaigns['title']}</td>
                        <td>{$campaigns['description']}</td>
                      </tr>";
            }
            echo "</table>";
            echo '<a href="Admin_dash.html">Back</a>';
        } else {
            echo "No campaigns found!";
        }
    } elseif (isset($data['email'])) {  // For update user
        $email = $data['email'];  // Get email from JSON data
        $status = updateUser($email);
        if ($status) {
            $response = ['status' => 'success'];
        } else {
            $response = ['status' => 'error'];
        }
        echo json_encode($response);  // Return JSON response
    } elseif (isset($data['email2'])) {  // For delete user
        $email = $data['email2'];  // Get email from JSON data
        $status = deleteUser($email);
        if ($status) {
            $response2 = ['status' => 'success'];
        } else {
            $response2 = ['status' => 'error'];
        }
        echo json_encode($response2);  // Return JSON response
    } else {
        header('location: Admin_dash.html');
    }
?>
