<?php
   // connect to mongodb server
   $m = new MongoClient();
   echo "Connection to database successfully";
	
   // select a database
   $db = $m->tya;
   echo "Database tya selected";
   $collection = $db->mycol;
   echo "Collection selected succsessfully";
	
   $document = array( 
      "title" => "Hello, World!", 
      "description" => "Programming", 
      "likes" => 10000,
      "url" => "http://www.mongo.com",
      "by" => "NoSQL"
   );
	
   $collection->insert($document);
   echo "Document inserted successfully";
?>