﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title -G.D.O. Store</title>
    @*@Styles.Render("~/Content/css")*@
    <link rel="stylesheet" href="http://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/MainLayout.css" rel="stylesheet" />
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>

    <div class="container">
        <div class="row">
            <div class="col-md-6 col-sm-6 col-xs-6">
                <div class="logo">
                    <h1><a href="#">G.D.O. Store</a></h1>
                </div>
            </div>
        </div>

        @*<div class="col-md-6 col-sm-6 col-xs-6">
                <div class="account">
                    <ul>
                        <li>
                            <div class="hidden-xs">
                                <h4><a>Call</a></h4>
                                <p>123-456-7899</p>
                            </div>

                            <div class="visible-xs">
                                <p>1123-456-7899</p>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>*@
    </div>

    <div class="row">

        <div class="col-md-12">

            <div class="nav_menus">

                <ul class="nav nav-pills">
                    <li class="active"><a style="border-radius:initial" href="#">Home</a></li>
                    <li><a style="border-radius:initial" href="#">Location</a></li>
                    <li><a style="border-radius:initial" href="#">About</a></li>


                </ul>

            </div>

        </div>

    </div>

    @RenderBody()
    <hr />
    <footer>
        <div class="row">
            <div class="col-md-12 copyright">
                <div class="col-md-6 col-sm-6 copyright-left">
                    <p>&copy; @DateTime.Now.Date. - G.D.O. Store. All rights reserved.</p>

                </div>

                <div class="col-md-6 col-sm-6 copyright-right">
                    <ul class="list-unstyled list-social">
                        <li><a href="#" target="_blank"><i class="fa fa-facebook-square"></i></a></li>
                        <li><a href="#" target="_blank"><i class="fa fa-twitter"></i></a></li>
                        <li><a href="#" target="_blank"><i class="fa fa-google-plus"></i></a></li>

                    </ul>
                </div>

            </div>
        </div>
    </footer>


    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
