<?php
header('Content-Type: application/json');

try {
    $rawData = file_get_contents('php://input');
    $data = json_decode($rawData, true);

    if (!isset($data['update_message']) || empty($data['update_message'])) {
        http_response_code(400);
        echo json_encode(['error' => 'Update message is required.']);
        exit;
    }

    $updateMessage = htmlspecialchars($data['update_message']);
    $success = true;

    if ($success) {
        echo json_encode(['message' => 'Campaign update submitted successfully!']);
    } else {
        http_response_code(500);
        echo json_encode(['error' => 'Failed to process the update.']);
    }
} catch (Exception $e) {
    http_response_code(500);
    echo json_encode(['error' => 'An unexpected error occurred.', 'details' => $e->getMessage()]);
}
?>
