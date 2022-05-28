<!Doctype html>
<html>
    <head>
        <title>Login </title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width-device-width, initial-scale-1">
        <link rel="stylesheet" href="loginn.css">
    </head>
    <body>
        <div class="container">
            <section class="login-box">
                <h2> Login  </h2>
                
                    <form method="post" action="aksi_login.php">
                        <label> Nama </label>
                        <input name ="Nama" type="text" placeholder="Nama" id="form_input">
                        <br>
                        <label> password </label>
                        <input name ="password" type="password" placeholder="password" id="form_input">
                        <br>
                        <input  type="submit" value="L o g i n" class="tombol">
                    </form>
            </section>
        </div>
    </body>
</html>
