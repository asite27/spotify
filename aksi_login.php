<?php
session_start();
include('koneksi.php');
$Nama=$_POST['Nama'];
$password=$_POST['password'];
$query=mysqli_query($koneksi,"Select * from user where Nama = '$Nama' and password = '$password'");

$masuk=mysqli_num_rows($query);
if($masuk==TRUE){
    $_SESSION['password']=$password;
    header("location:index.php");
}
else{
    "<script>alert('Salah Nih');location = 'login.php';</script>";
}
 ?>
