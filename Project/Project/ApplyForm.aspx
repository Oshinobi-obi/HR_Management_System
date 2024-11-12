<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplyForm.aspx.cs" Inherits="Project.ApplyForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Application Form</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous" />
    <style>
        .bg-image {
            display: flex;
            justify-content: center;
            align-items: center;
            background-image: linear-gradient(90deg, rgba(2,0,36,0.955) 0%, rgba(9,9,121,1) 19%, rgba(0,212,255,0) 100%), url("image/Best-State-School-in-the-UK.jpg");
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
            height: 100vh;
            width: 100%;
            position: absolute;
        }
        .form-container {
            background-color: rgba(255, 255, 255, 0.9);
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
            max-width: 1000px;
            margin: auto;
            position: relative;
        }
        .form-header {
            text-align: center;
            margin-bottom: 20px;
            font-weight: bold;
            font-size: 1.5rem;
            color: #333;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg bg-body-tertiary justify-content-end ms-auto">
            <div class="container-fluid">
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse text" id="navbarNav">
                    <ul class="navbar-nav">
                        <li class="nav-item"><a class="nav-link" href="Home.aspx">Home</a></li>
                        <li class="nav-item"><a class="nav-link" href="#">About Us</a></li>
                        <li class="nav-item"><a class="nav-link" href="ApplyForm.aspx">Apply</a></li>
                    </ul>
                </div>
            </div>
        </nav>

        <div class="bg-image">
            <div class="form-container">
                <div class="form-header">SCHOOL ONLINE APPLICATION FORM FOR ASPIRING EMPLOYEE</div>
                <div class="row">
                    <!--This is Column 1-->
                    <div class="col-md-6">
                        <div class="row mb-3">
                            <div class="col">
                                <label for="firstName" class="form-label">First Name</label>
                                <input type="text" autocomplete="off" class="form-control" id="firstName" runat="server" />
                            </div>
                            <div class="col">
                                <label for="middleName" class="form-label">Middle Name</label>
                                <input type="text" autocomplete="off" class="form-control" id="middleName" runat="server" />
                            </div>
                            <div class="col">
                                <label for="lastName" class="form-label">Last Name</label>
                                <input type="text" autocomplete="off" class="form-control" id="lastName" runat="server" />
                            </div>
                        </div>
                        <div class="row mb-3">
                            <div class="col">
                                <label for="month" class="form-label">Month</label>
                                <input type="text" autocomplete="off" class="form-control" id="month" runat="server" />
                            </div>
                            <div class="col">
                                <label for="day" class="form-label">Day</label>
                                <input type="text" autocomplete="off" class="form-control" id="day" runat="server" />
                            </div>
                            <div class="col">
                                <label for="year" class="form-label">Year</label>
                                <input type="text" autocomplete="off" class="form-control" id="year" runat="server" />
                            </div>
                        </div>

                        <div class="row mb-3">
                            <div class="col">
                                <label for="age" class="form-label">Age</label>
                                <input type="text" autocomplete="off" class="form-control" id="age" runat="server"/>
                            </div>
                        </div>

                        <div class="row mb-3">
                            <label class="form-label">Gender</label>
                            <div class="col">
                                <input type="radio" name="gender" id="male" value="Male" runat="server" class="form-check-input" />
                                <label for="male" class="form-check-label">Male</label>
                                <input type="radio" name="gender" id="female" value="Female" runat="server" class="form-check-input" />
                                <label for="female" class="form-check-label">Female</label>
                            </div>
                        </div>
                    </div>

                    <!--This is Column 2-->
                    <div class="col-md-6">
                        <div class="mb-3">
                            <label for="address" class="form-label">Current Address</label>
                            <input type="text" autocomplete="off" class="form-control" id="address" runat="server" />
                        </div>
                        <div class="mb-3">
                            <label for="email" class="form-label">Email Address</label>
                            <input type="email" class="form-control" id="email" runat="server" />
                        </div>
                        <div class="mb-3">
                            <label for="contact" class="form-label">Contact Number</label>
                            <input type="text" autocomplete="off" class="form-control" id="contact" runat="server" />
                        </div>
                        <div class="mb-3">
                            <label for="resume" class="form-label">Resume Submit Here</label>
                            <input type="file" class="form-control" id="resume" runat="server" />
                        </div>
                        <div class="mb-3">
                            <label for="position" class="form-label">Position Applying</label>
                            <input type="text" autocomplete="off" class="form-control" id="position" runat="server" />
                        </div>
                    </div>
                </div>
                <div class="text-center mt-4">
                    <button type="submit" class="btn btn-primary">Submit</button>
                </div>
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
</body>
</html>