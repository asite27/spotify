<?php
    $host = "localhost";
    $user = "root";
    $pass = "";
    $name = "spotify";
    $koneksi = mysqli_connect($host,$user,$pass) or die ("Koneksi Gagal");
    mysqli_select_db($koneksi,$name) 
?>
