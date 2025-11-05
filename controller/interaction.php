<?php
if(isset($_POST['mydata'])) {
    
    $json = $_POST['mydata'];
    $data = json_decode($json, true); 

    $feedback = trim($data['feedback']);
    $userques = trim($data['userques']);

    
    if (empty($feedback) || empty($userques)) {
       
        echo json_encode(['success' => false, 'message' => 'Null data found']);
        exit;
    }

    
    $con = mysqli_connect('127.0.0.1', 'root', '', 'fundflock');
    if (!$con) {
      
        echo json_encode(['success' => false, 'message' => 'Database connection failed']);
        exit;
    }

    $sql = "INSERT INTO feedback (Review, Question) VALUES ('{$feedback}', '{$userques}')";
    $result = mysqli_query($con, $sql);

    if ($result) {
        echo json_encode(['success' => true, 'message' => 'Submitted Successfully']);
    } else {
        echo json_encode(['success' => false, 'message' => 'Something went wrong']);
    }

    mysqli_close($con);
} else {
   
    echo json_encode(['success' => false, 'message' => 'No data received']);
}
?>
