<?php
// Database configuration
$dbHost = "sql207.byethost11.com";
$dbUsername = "b11_18165880";
$dbPassword = "midps4ios9";
$dbName = "b11_18165880_codex";

// Create database connection
$db = new mysqli($dbHost, $dbUsername, $dbPassword, $dbName);

// Check connection
if ($db->connect_error) {
    die("Connection failed: " . $db->connect_error);
}
?>