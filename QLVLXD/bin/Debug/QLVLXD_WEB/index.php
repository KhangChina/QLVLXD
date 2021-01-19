<?php

// //echo phpinfo();

$serverName = "localhost,1456";
$uid = "sa";
$pwd = "Khang@china123";
$databaseName = "QLVTXD_BACKUP";

$connectionInfo = array(
  "UID" => $uid,
  "PWD" => $pwd,
  "Database" => $databaseName,
  "CharacterSet" => "UTF-8"
);

/* Connect using SQL Server Authentication. */
$conn = sqlsrv_connect($serverName, $connectionInfo);

$tsql = "SELECT tblHangHoa.*,tblDVT.TenDVT FROM tblHangHoa,tblDVT where tblDVT.ID = tblHangHoa.IDDVT and tblHangHoa.TrangThai = 1";

/* Execute the query. */

$stmt = sqlsrv_query($conn, $tsql);
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
  <title>Web Bán Vật Liệu Xây Dựng</title>
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
            <strong>
              <h1 style="color: red;">Vật Liệu Xây Dựng </h1>
            </strong>
            <div class="search lux-shadow">
              <!-- Search -->
              <input class="left" type="text" placeholder="Vật liệu">
              <button class="search-btn left">Tìm kiếm</button>
            </div>
          </div>
          <div class="hero-image" style="background-image: url('images/hero.jpg');">
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


        <?php while ($row = sqlsrv_fetch_array($stmt, SQLSRV_FETCH_ASSOC)) {   ?>
          <!-- Appartment  -->
          <div class="col-12 col-md-6 col-lg-4">
            <div class="appartment-box">
              <div class="appartment-image">
                <!-- Appartment Image  -->

                <img src="<?php $row['URLHinh']; 
                
                    echo "images/hinhVL/".pathinfo($row['URLHinh'])['basename'];
                
                ?>" alt="">
                
              </div>
              <div class="appartment-info">
                <div class="appartment-title">
                  <!-- Appartment Address  -->
                  <p><?= $row['TenHH'] ?></p>
                </div>
                <div class="appartment-details">
                  <div class="price left">
                    <!-- Appartment Price  -->
                    <p><?= $row['XuatXu'] ?></p>
                  </div>
                  <div class="bedrooms right flex-center">
                    <img src="images/bed.svg" class="left" alt="">
                    <!-- Appartment Number Of Bedrooms  -->
                    <p class="left">Còn hàng</p>
                  </div>
                  <div class="bathrooms right flex-center">
                    <img src="images/shower.svg" class="left" alt="">
                    <!-- Appartment Number of Bathrooms  -->
                    <p class="left"><?= $row['TenDVT']  ?></p>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <!-- ------------------------ -->
        <?php }   ?>
        <?php

        sqlsrv_free_stmt($stmt);
        sqlsrv_close($conn);


        ?>
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