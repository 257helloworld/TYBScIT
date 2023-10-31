<?php
    $m = new MongoClient();
    echo "Connection to database successful", "<br>";

    // Select db
    $db = $m -> tya;
    echo "Database tya selected", "<br>";
    $collection = $db -> emp;
    echo "Collection emp selected", "<br>";

    $collection -> remove(array("name"=>"Harry"));
    echo "Document deleted successfully", "<br>";

    $cursor = $collection -> find();
    echo "<br>Documents: <br>";
    foreach($cursor as $document) {
        echo $document["name"], "<br>";
    }
?>