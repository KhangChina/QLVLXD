<?php  

// echo phpinfo();

// $serverName = "localhost,1456"; 
// $uid = "sa";   
// $pwd = "Khang@china123";  
// $databaseName = "QLVLXD_BACKUP"; 

// $connectionInfo = array( "UID"=>$uid,                            
//                          "PWD"=>$pwd,                            
//                          "Database"=>$databaseName); 

// /* Connect using SQL Server Authentication. */  
// $conn = sqlsrv_connect( $serverName, $connectionInfo);  

// $tsql = "SELECT id, FirstName, LastName, Email FROM tblContact";  

// /* Execute the query. */  

// $stmt = sqlsrv_query( $conn, $tsql);  

// if ( $stmt )  
// {  
//      echo "Statement executed.<br>\n";  
// }   
// else   
// {  
//      echo "Error in statement execution.\n";  
//      die( print_r( sqlsrv_errors(), true));  
// }  

// /* Iterate through the result set printing a row of data upon each iteration.*/  

// while( $row = sqlsrv_fetch_array( $stmt, SQLSRV_FETCH_NUMERIC))  
// {  
//      echo "Col1: ".$row[0]."\n";  
//      echo "Col2: ".$row[1]."\n";  
//      echo "Col3: ".$row[2]."<br>\n";  
//      echo "-----------------<br>\n";  
// }  

// /* Free statement and connection resources. */  
// sqlsrv_free_stmt( $stmt);  
// sqlsrv_close( $conn);  
?>  



<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Metas -->
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="author" content="Graphberry" />
    <!-- Links -->
    <link rel="icon" type="image/png" href="images/favicon.png" />
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,600&display=swap" rel="stylesheet">
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <link href="css/style.css" rel="stylesheet" />
    <!-- Document Title -->
    <title>Luxestate - Multipurpose HTML Template</title>
  </head>
  <body>
    <!------------------------------------------------ HEADER SECTION -->
    <header id="home">
      <nav class="animate">
        <div class="container">
          <div class="logo left">
            <!-- Logo -->
            <a href="#home">QLVLXD</a>
          </div>
          <div class="menu-button hide right pointer">
            <span></span>
            <span></span>
            <span></span>
          </div>
          <div class="menu left">
            <div class="page-menu left">
              <!-- Navigation -->
              <li><a href="#home">Trang Chủ</a></li>           
            </div>
            <div class="registration flex-center">
              <div class="join-us">
                <!-- Join Us Button -->
                <li class="pointer animate"><a href="#"></a></li>
              </div>
              <div class="getting-started">
                <!-- Get Started Button -->
                <li class="main-btn pointer text-center animate"><a href="#">Liên Hệ</a></li>
              </div>
            </div>
          </div>
        </div>
      </nav>
      <div class="hero">
        <div class="container">
          <div class="hero-wrapper">
            <div class="title">
              <!-- Hero Title -->
              <h1>Web Bán Vật Liệu Xây Dựng</h1>
              <div class="search lux-shadow">
                <!-- Search -->
                <input class="left" type="text" placeholder="Vật liệu">
                <button class="search-btn left">Tìm kiếm</button>
              </div>
            </div>
            <div class="hero-image">
              <div class="hero-image-info yellow-bg flex-center">
                <div class="info flex-center">
                  <img src="images/call-icon.svg" alt="">
                  <!-- Phone -->
                  <p>0964440775</p>
                </div>
                <div class="info flex-center">
                  <img src="images/point-icon.svg" alt="">
                  <!-- Place -->
                  <p>Sài Gòn, Việt Nam</p>
                </div>
              </div>
            </div>
            
          </div>
        </div>
      </div>
    </header>
    <section id="appartments" class="appartments">
      <div class="container">
        <div class="row">
          <div class="col-12">
            <h2>Danh Sách<br>Vật Liệu Xây Dựng Đang Kinh Doanh</h2>
          </div>
        </div>
        <div class="row">



          <!-- Appartment  -->
          <div class="col-12 col-md-6 col-lg-4">
            <div class="appartment-box">
              <div class="appartment-image">
                <!-- Appartment Image  -->
                <img src="images/appartment.png" alt="">
              </div>
              <div class="appartment-info">
                <div class="appartment-title">
                  <!-- Appartment Address  -->
                  <p>Random Street, Apt B453, New York</p>
                </div>
                <div class="appartment-details">
                  <div class="price left">
                    <!-- Appartment Price  -->
                    <p>$3,500</p>
                  </div>
                  <div class="bedrooms right flex-center">
                    <img src="images/bed.svg" class="left" alt="">
                    <!-- Appartment Number Of Bedrooms  -->
                    <p class="left">2 BD</p>
                  </div>
                  <div class="bathrooms right flex-center">
                    <img src="images/shower.svg" class="left" alt="">
                    <!-- Appartment Number of Bathrooms  -->
                    <p class="left">2 BA</p>
                  </div>
                </div>
              </div>
            </div>
          </div>
          

        </div>
      </div>
    </section>
    <section id="works" class="how-it-works">
      <div class="container">
        <div class="row">
          <div class="col-12 works-title">
            <h3>Liên Hệ Với Chúng Tôi</h3>
           
          </div>
        </div>
        <div class="row">
          <div class="col-12 col-md-12 col-lg-4">
            <div class="work-box animate">
              <div class="work-box-number">
                <p>01</p>
              </div>
              <div class="work-box-title">
                <p class="left">01</p>
                <p class="left">Địa chỉ</p>
              </div>
              <div class="work-box-text">
                <p>Số 6 Phan Đình Giót 12 Tân Bình, HCM</p>
              </div>
              <div class="work-box-link">
                <a href="#">Đi Tới Google Map</a>
              </div>           
            </div>
          </div>
          <div class="col-12 col-md-12 col-lg-4">
            <div class="work-box animate">
              <div class="work-box-number">
                <p>02</p>
              </div>
              <div class="work-box-title">
                <p class="left">02</p>
                <p class="left">Thông Tin Liên Lạc</p>
              </div>
              <div class="work-box-text">
                <p>Số Điện Thoại: 0964440775</p>
              </div>
              <div class="work-box-link">
                <a href="#">Gọi đến</a>
              </div>           
            </div>
          </div>
          <div class="col-12 col-md-12 col-lg-4">
            <div class="work-box animate">
              <div class="work-box-number">
                <p>03</p>
              </div>
              <div class="work-box-title">
                <p class="left">03</p>
                <p class="left">Giao Hàng</p>
              </div>
              <div class="work-box-text">
                <p>Giao theo từ đợt, nhanh - an toàn</p>
              </div>
              <div class="work-box-link">
                <a href="#"></a>
              </div>           
            </div>
          </div>
        </div>
        <!-- Services Area -->   
      </div>
    </section>
    <footer id="contact">
      <div class="container">
        <div class="row footer-top">
          <div class="col-12 col-md-6">
            <!-- logo -->
            <h3>Hệ Thống</h3>
            <h3>Cung Cấp Liệu Xây Dựng</h3>
          </div>
       
        </div>
        <div class="row footer-bottom">
          <div class="col-sm-12 col-md-4 footer-logo">
            <h4>QLVLXD</h4>
            <p>© 2021 - Việt Nam,<br>All Right Reserved</p>
          </div>
        
      
        </div>
      </div>
    </footer>
    <!-- Scripts -->
    <script src="js/jquery.min.js"></script>
    <script src="js/popper.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/main.js"></script>
    <!-- Scripts Ends -->
  </body>
</html>
