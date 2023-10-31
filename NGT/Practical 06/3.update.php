<?php
    $m = new MongoClient();
    echo "Connection to database successful", "<br>";

    // Select db
    $db = $m -> tya;
    echo "Database tya selected", "<br>";
    $collection = $db -> emp;
    echo "Collection emp selected", "<br>";

    $collection -> update(array("name"=>"darshan"), array('$set'=> array('name'=>"Darshan Raval")));
    echo "Document updated successfully", "<br>";

    $cursor = $collection -> find();

    echo "<br>Updated documents", "<br>";

    foreach($cursor as $document) {
        echo $document["name"], "<br>";
    }
?>