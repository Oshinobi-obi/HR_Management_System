<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project.Home" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Document</title>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css" rel="stylesheet">
    <script src="https://kit.fontawesome.com/a076d05399.js" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <style>
   .banner {
    height: 90vh;
    background: linear-gradient(90deg, rgba(2,0,36,0.955) 0%, rgba(9,9,121,1) 19%, rgba(0,212,255,0) 100%), url('/image/Best-State-School-in-the-UK.jpg');
    background-size: cover;
    background-position: center;
    position: relative;
    color: white;
  }
  .about-section {
    position: relative;
    padding: 5rem 0;
    background: url('/image/Best-State-School-in-the-UK.jpg') no-repeat center center cover;
    color: white;
    }
    .about-section::before {
        content: "";
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        background: linear-gradient(90deg, rgba(2, 0, 36, 0.95) 0%, rgba(9, 9, 121, 0.8) 50%, rgba(0, 212, 255, 0.2) 100%);
        z-index: 1;
    }
    .about-content {
        position: relative;
        z-index: 2;
    }
    .about-text h2 {
        font-size: 1.5rem;
        text-transform: uppercase;
        letter-spacing: 2px;
    }
    .about-text h1 {
        font-size: 2.5rem;
        font-weight: bold;
    }
    .about-image img {
        width: 100%;
        border: 5px solid white;
        padding: 5px;
        box-shadow: 0px 0px 15px rgba(0, 0, 0, 0.3);
    }
  </style>
</head>
<body>
    <form id="form1" runat="server">
           <nav class="navbar navbar-expand-lg navbar-light bg-light">
        <div class="container">
          <a class="navbar-brand" href="#"><img src="/image/logo (4).jpg" width="80" height="80"/></a>
          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
            <div class="navbar-nav ms-auto">
              <a style="color: rgb(63, 138, 236);font-family: 'Times New Roman', Times, serif;font-size: 1.2rem;" class="nav-link active" aria-current="page" href="#">Home</a>
              <a style="color: rgb(63, 138, 236);font-family: 'Times New Roman', Times, serif;font-size: 1.2rem;" class="nav-link" href="#">About Us</a>
              <a style="color: rgb(63, 138, 236);font-family: 'Times New Roman', Times, serif;font-size: 1.2rem;" class="nav-link" href="ApplyForm.aspx">Apply</a>
            </div>
          </div>
        </div>
      </nav>
      
      <div class="banner d-flex align-items-center text-white">
        <div class="container text-start">
          <div class="row">
                <div class="col-lg-6">
                    <h1 class="display-4 fw-bold">KUMDAN JUNGANG CHRISTIAN SCHOOL</h1>
                    <p class="lead">"Transforming Lives Through Education: Where Faith Guides Learning and Character Development."</p>
                </div>
                <div class="col-lg-6">
                   
                </div>
          </div>
        </div>
      </div>
              <div class="banner d-flex align-items-center text-white">
                <div class="container text-start">
                  <div class="row">
                        <div class="col-lg-6">
                            <h1 class="display-4 fw-bold">KUMDAN JUNGANG CHRISTIAN SCHOOL</h1>
                            <p class="lead">"Transforming Lives Through Education: Where Faith Guides Learning and Character Development."</p>
                        </div>
                        <div class="col-lg-6">
                   
                        </div>
                  </div>
                </div>
              </div>


        <!-- ABOUT US SECTION -->
        <div class="about-section">
            <div class="container about-content">
                <div class="row p-5">
                    <div class="col-lg-6">
                        <div class="about-text">
                            <h2 style="font-size: 2.3rem;font-family: 'Times New Roman', Times, serif;">About Us</h2>
                            <h1>KUMDAN JUNGANG CHRISTIAN SCHOOL</h1>
                            <p>
                                At Kumdan Jungang Christian School, we are dedicated to cultivating the minds and hearts of our students
                                to create Christ-centered individuals. Our mission is to provide a holistic education that prioritizes 
                                spiritual, academic, and moral growth in an environment that nurtures every child’s potential.
                            </p>
                            <p>
                                With high expectations, a supportive learning environment, and a strong focus on faith and character development, 
                                we guide our students toward excellence. Join us in our mission of creating a future filled with character, 
                                knowledge, and faith to guide us all forward.
                            </p>
                        </div>
                    </div>
                    <div class="col-lg-6">
                        <div class="about-image">
                            <img src="/image/Childred.jpg" alt="School Group Photo">
                        </div>
                    </div>
                </div>
            </div>
        </div>
              <footer class="bg-light text-white py-4">
    <div class="container">
      <!-- Navigation Menu -->
      <div class="row justify-content-center mb-3">
        <nav class="col-12 text-center">
          <ul class="nav" style="display: flex;justify-content: center;">
            <li class="nav-item">
              <a style="color: grey;" class="nav-link" href="#">Home</a>
            </li>
            <li class="nav-item">
              <a style="color: grey;" class="nav-link" href="#">About Us</a>
            </li>
            <li class="nav-item">
              <a style="color: grey;" class="nav-link" href="#">Apply Here</a>
            </li>
          </ul>
        </nav>
      </div>
      
      <div class="row justify-content-center">
        <div class="col-auto">
          <a style="color: grey;" href="https://www.facebook.com/KJCSI/photos_by" target="_blank" class="mx-2"><i class="fab fa-facebook"></i></a>
          <a style="color: grey;" href="#" class="mx-2"><i class="fab fa-twitter"></i></a>
          <a style="color: grey;" href="#" class="mx-2"><i class="fab fa-instagram"></i></a>
          <a style="color: grey;" href="#" class="mx-2"><i class="fab fa-linkedin"></i></a>
        </div>
      </div>
    </div>
  </footer>
  <div style="display: flex;justify-content: center;background-color: #CCCCCC;padding: 1rem;">
    <p class="mb-0">Designed by <a href="#" style="color: white;text-decoration: none;" class="font-weight-bold">Your Company Name</a></p>
</div>
    </form>
</body>
</html>