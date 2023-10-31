<?php
   // connect to mongodb
   $m = new MongoClient();
   echo "Connection to database successfully";
	
   // select a database
   $db = $m->tya;
   echo "Database mydb selected";
   $collection = $db->Emp;
   echo "Collection selected succsessfully";

   $cursor = $collection->find();
   // iterate cursor to display title of documents
	
   foreach ($cursor as $document) {
      echo "<br>". $document["Name"] . "<br>";
      echo "<br>". $document["Address"] . "<br>";
      echo "<br>". $document["Salary"] . "<br>";
      echo "<br>". $document["Department"] . "<br>";
   }
