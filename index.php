<?php
	session_start();
	include "koneksi.php";
	if (!isset($_SESSION['password'])){
		header ("location:login.php");
	}

	if (isset($_SESSION['password'])){
		$password = $_SESSION['password'];
	}
?>

<!doctype html>
<html lang="en">
	<!-- Bootstrap link Website-->
	<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" integrity="sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l" crossorigin="anonymous"><!-- CSS -->
	<!-- CSS yang dibuat -->
	<link rel="stylesheet" href="style.css">
	<title> P R O G R A M </title>
</head>

<body>
	

		<!-- T A B E L -->
		<section class="main">
            <marquee direction="left">    
                <h1 class="judul" > Playlist Lagu </h2>
            </marquee>   
                <table class="class=table table-success table-striped">
                    <thead>
                        <tr>
                            <th>No</th>
                            <th>Playlist</th>
							<th>Lagu</th>
							<th> Waktu </th>
							<th> Ditambah </th>
                        </tr>                        
                    </thead>
                    <!--   S P O T I F Y Y  -->
                    <?php
                        include_once 'koneksi.php';

                        $no=1;
                        $data=mysqli_query($koneksi, "SELECT * from playlist");
              
						while ($d=mysqli_fetch_array($data)){
                            
                            ?>
                                    <tr>
                                        <td><?php echo $no++; ?></td>
                                        <td><?php echo $d['nama_playlist']; ?></td>
                                        <td><?php echo $d['judul']; ?></td>
                                        <td><?php echo $d['lama_lagu']; ?></td>
										<td><?php echo $d['waktu_ditambah']; ?></td>
                                        
                                </tr>
                            <?php
                        }
                    ?>
                </table>
            </section>

		<!-- END T A B E L -->

		
	</body>
</html>