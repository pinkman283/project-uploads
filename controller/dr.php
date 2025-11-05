<?php
$today = date('Y-m-d');
$deadline = "2025-01-15";
$deadline_timestamp = strtotime($deadline);
$today_timestamp = strtotime($today);
$remaining_days = ceil(($deadline_timestamp - $today_timestamp) / 86400);
?>
