<?php
$title = str_replace(".php", "", basename($_SERVER["PHP_SELF"])); // Auto-Generate Title
$title = str_replace("index", "home", $title); // So That The Index File Is Called Home
?>

<meta charset="UTF-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link rel="stylesheet" href="../css/main.css">
<link rel="shortcut icon" href="../assets/icons/fav.png" type="image/x-icon">
<title><?php echo ucwords($title) ?></title>