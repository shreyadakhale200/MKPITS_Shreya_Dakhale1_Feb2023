﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Template.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="banner" class="banner full-screen-mode parallax">
        <div class="container pr">
            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                <div class="banner-static">
                    <div class="banner-text">
                        <div class="banner-cell">
                           <h1>Wildlife &hearts;  <span class="typer" id="some-id" data-delay="200" data-delim=":" data-words=" Animals:Nature:Life" data-colors="red"></span><span class="cursor" data-cursorDisplay="_" data-owner="some-id"></span></h1>
                            <%--<h2 style="color:#be806d;">Discover Nature </h2>--%>
                            <p>"The real wealth of the Nation lies in the resources of the earth - soil, water, forests, minerals, and wildlife." <br /> - Rachel Carson.</p>
                            <%--<div class="book-btn">
                                <a href="#reservation" class="table-btn hvr-underline-from-center" style="background-color:#71351f;">Book my Table</a>
                            </div>--%>
                           <%-- <a href="#about">
                                <div class="mouse"></div>
                            </a>--%>
                        </div>
                        <!-- end banner-cell -->
                    </div>
                    <!-- end banner-text -->
                </div>
                <!-- end banner-static -->
            </div>
            <!-- end col -->
        </div>
        <!-- end container -->
    </div>
    <!-- end banner -->
    <div id="about" class="about-main pad-top-100 pad-bottom-100">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                    <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                        <h2 class="block-title"> About Us </h2>
                        
                        <h3>IT STARTED, QUITE SIMPLY, LIKE THIS...</h3>
                        <p> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusm incididunt ut labore et dolore magna aliqua. Ut enim ad minim venia, nostrud exercitation ullamco. </p>

                        <p> Aenean commodo ligula eget dolor aenean massa. Cum sociis nat penatibu set magnis dis parturient montes, nascetur ridiculus mus. quam felisorat, ultricies nec, Aenean commodo ligula eget dolor penatibu set magnis is parturient montes, nascetur ridiculus mus. quam felisorat, ultricies nec, pellentesque eu, pretium quis, sem. quat massa quis enim. Donec vitae sapien ut libero venenatis fauci Nullam quis ante. Etiam sit amet rci eget eros. </p>

                        <p> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusm incididunt ut labore et dolore magna aliqua. Ut enim ad minim venia, nostrud exercitation ullamco. </p>
                    </div>
                </div>
                <!-- end col -->
                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12">
                    <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                        <div class="about-images">
                            <img class="about-main" src="images/josh-miller-AEZEx7encQs-unsplash.jpg" alt="About Main Image">
                            <img class="about-inset" src="images/intricate-explorer-GK3_2LGSxOY-unsplash.jpg" alt="About Inset Image">
                        </div>
                    </div>
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>

    <div class="special-menu pad-top-100 parallax">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                        <h2 class="block-title color-white text-center"> Today's Special </h2>
                        
                        <h5 class="title-caption text-center"> Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusm incididunt ut labore et dolore magna aliqua. Ut enim ad minim venia,nostrud exercitation ullamco. </h5>
                    </div>
                    <div class="special-box">
                        <div id="owl-demo">
                            <div class="item item-type-zoom">
                                <a href="#" class="item-hover">
                                    <div class="item-info">
                                        <div class="headline">
                                            PUPPIES
                                            <div class="line"></div>
                                            <div class="dit-line">Lorem ipsum dolor sit amet, consectetur adip aliqua. Ut enim ad minim venia.</div>
                                        </div>
                                    </div>
                                </a>
                                <div class="item-img">
                                    <img src="images/meghna-r-d0Hl1VxpdSI-unsplash.jpg" alt="sp-menu">
                                </div>
                            </div>
                            <div class="item item-type-zoom">
                                <a href="#" class="item-hover">
                                    <div class="item-info">
                                        <div class="headline">
                                            RACOON
                                            <div class="line"></div>
                                            <div class="dit-line">Lorem ipsum dolor sit amet, consectetur adip aliqua. Ut enim ad minim venia.</div>
                                        </div>
                                    </div>
                                </a>
                                <div class="item-img">
                                    <img src="images/toan-chu-VEzDhGMlyb8-unsplash.jpg" alt="sp-menu">
                                </div>
                            </div>
                            <div class="item item-type-zoom">
                                <a href="#" class="item-hover">
                                    <div class="item-info">
                                        <div class="headline">
                                            DEER
                                            <div class="line"></div>
                                            <div class="dit-line">Lorem ipsum dolor sit amet, consectetur adip aliqua. Ut enim ad minim venia.</div>
                                        </div>
                                    </div>
                                </a>
                                <div class="item-img">
                                    <img src="images/timeo-buehrer-fCv8BXjPcOA-unsplash.jpg" alt="sp-menu">
                                </div>
                            </div>
                            <div class="item item-type-zoom">
                                <a href="#" class="item-hover">
                                    <div class="item-info">
                                        <div class="headline">
                                                BIRD
                                            <div class="line"></div>
                                            <div class="dit-line">Lorem ipsum dolor sit amet, consectetur adip aliqua. Ut enim ad minim venia.</div>
                                        </div>
                                    </div>
                                </a>
                                <div class="item-img">
                                    <img src="images/jeremy-hynes-q_bx5FSjSqc-unsplash.jpg" alt="sp-menu">
                                </div>
                            </div>
                            <div class="item item-type-zoom">
                                <a href="#" class="item-hover">
                                    <div class="item-info">
                                        <div class="headline">
                                            KOALA
                                            <div class="line"></div>
                                            <div class="dit-line">Lorem ipsum dolor sit amet, consectetur adip aliqua. Ut enim ad minim venia.</div>
                                        </div>
                                    </div>
                                </a>
                                <div class="item-img">
                                    <img src="images/lars-van-poucke-kS7pQ_Ad87g-unsplash.jpg" alt="sp-menu">
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- end special-box -->
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end special-menu -->

    <div id="menu" class="menu-main pad-top-100 pad-bottom-100">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                        <h2 class="block-title text-center" style="color:white;">
						Wildlife's Essence	
					</h2>
                        <p class="title-caption text-center" style="color:white;">There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. </p>
                    </div>
                    <div class="tab-menu">
                        <div class="slider slider-nav">
                            <div class="tab-title-menu">
                                <h2>LAND</h2>
                                <p> <img src="/images/cottage.png" alt="Alternate Text" class="cottage"/> </p>
                                <%--<p> <i class="flaticon-canape"></i> </p>--%>
                            </div>
                            <div class="tab-title-menu">
                                <h2>SEA</h2>
                                <p><img src="/images/waves.png" alt="Alternate Text" class="cottage"/></p>
                            </div>
                            <div class="tab-title-menu">
                                <h2>AIR</h2>
                                <p><img src="/images/air-hot-balloon.png" alt="Alternate Text" class="cottage"/> </p>
                            </div>
                            <div class="tab-title-menu">
                                <h2>FACTS</h2>
                                <p>
                                    <img src="/images/did-you-know.png" alt="Alternate Text" class="cottage" /></p>
                            </div>
                        </div>
                        <div class="slider slider-single">
                            <div>
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/chocolatefrog.png" alt="" class="img-responsive">
                                        <div>
                                            <h3>CHOCOLATE FROG</h3>
                                            <p>
                                               In the Peruvian Amazon, herpetologists followed a distinctive frog call to one of the rarest habitats in the forest, the Amazon peatlands. There, researchers dug up a new species of burrowing frog, Synapturanus danta.
                                            </p>
                                        </div>
                                        <span class="offer-price">$8.5</span>
                                    </div>
                                </div>
                                <!-- end col -->
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/tarantula.jpeg" alt="" class="img-responsive" id="tarantula">
                                        <div>
                                            <h3>Tarantula</h3>
                                            <p>
                                                In Thailand, a well-known wildlife YouTuber, JoCho Sippawat, found a new genus of tarantula and collaborated with scientists to describe the species, Taksinus bambus, nicknamed “bambootula.”
                                            </p>
                                        </div>
                                        <span class="offer-price">$25</span>
                                    </div>
                                </div>
                                <!-- end col -->
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-03.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>BBQ CHICKEN WINGS</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$10</span>
                                    </div>
                                </div>
                                <!-- end col -->
                            </div>
                            <div>
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-04.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>MEAT FEAST PIZZA</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$5</span>
                                    </div>
                                </div>
                                <!-- end col -->
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-05.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>CHICKEN TIKKA MASALA</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$15</span>
                                    </div>
                                </div>
                                <!-- end col -->
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-06.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>SPICY MEATBALLS</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$6.5</span>
                                    </div>
                                </div>
                                <!-- end col -->
                            </div>
                            <div>
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-07.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>CHOCOLATE FUDGECAKE</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$4.5</span>
                                    </div>
                                </div>
                                <!-- end col -->
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-08.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>CHICKEN TIKKA MASALA</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$9.5</span>
                                    </div>
                                </div>
                                <!-- end col -->
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-09.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>CHICKEN TIKKA MASALA</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$10</span>
                                    </div>
                                </div>
                                <!-- end col -->
                            </div>
                            <div>
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-10.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>MEAT FEAST PIZZA</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$12.5</span>
                                    </div>
                                </div>
                                <!-- end col -->
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-09.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>CHICKEN TIKKA MASALA</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$9.5</span>
                                    </div>
                                </div>
                                <!-- end col -->
                                <div class="col-lg-6 col-md-6 col-sm-12 col-xs-12 ">
                                    <div class="offer-item">
                                        <img src="images/menu-item-thumbnail-08.jpg" alt="" class="img-responsive">
                                        <div>
                                            <h3>CHICKEN TIKKA MASALA</h3>
                                            <p>
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc mollis eleifend dapibus.
                                            </p>
                                        </div>
                                        <span class="offer-price">$5.5</span>
                                    </div>
                                </div>
                                <!-- end col -->
                            </div>
                        </div>
                    </div>
                    <!-- end tab-menu -->
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end menu -->

    <div id="our_team" class="team-main pad-top-100 pad-bottom-100 parallax">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                        <h2 class="block-title text-center">
						Our Team 	
					</h2>
                        <p class="title-caption text-center">There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. </p>
                    </div>
                    <div class="team-box">

                        <div class="row">
                            <div class="col-md-4 col-sm-6">
                                <div class="sf-team">
                                    <div class="thumb">
                                        <a href="#"><img src="images/staff-01.jpg" alt=""></a>
                                    </div>
                                    <div class="text-col">
                                        <h3>John Doggett</h3>
                                        <p>Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Aenean commodo ligula.</p>
                                        <ul class="team-social">
                                            <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                                            <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
                                            <li><a href="#"><i class="fa fa-linkedin" aria-hidden="true"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-md-4 col-sm-6">
                                <div class="sf-team">
                                    <div class="thumb">
                                        <a href="#"><img src="images/staff-02.jpg" alt=""></a>
                                    </div>
                                    <div class="text-col">
                                        <h3>Jeffrey Spender</h3>
                                        <p>Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Aenean commodo ligula.</p>
                                        <ul class="team-social">
                                            <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                                            <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
                                            <li><a href="#"><i class="fa fa-linkedin" aria-hidden="true"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-md-4 col-sm-6">
                                <div class="sf-team">
                                    <div class="thumb">
                                        <a href="#"><img src="images/staff-03.jpg" alt=""></a>
                                    </div>
                                    <div class="text-col">
                                        <h3>Monica Reyes</h3>
                                        <p>Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Aenean commodo ligula.</p>
                                        <ul class="team-social">
                                            <li><a href="#"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
                                            <li><a href="#"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
                                            <li><a href="#"><i class="fa fa-linkedin" aria-hidden="true"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <!-- end col -->
                        </div>
                        <!-- end row -->

                    </div>
                    <!-- end team-box -->

                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end team-main -->

    <div id="gallery" class="gallery-main pad-top-100 pad-bottom-100">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                        <h2 class="block-title text-center">
						Our Gallery	
					</h2>
                        <p class="title-caption text-center">There are many variations of passages of Lorem Ipsum available </p>
                    </div>
                    <div class="gal-container clearfix">
                        <div class="col-md-8 col-sm-12 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#1">
                                    <img src="images/gallery_01.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="1" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_01.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 1 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#2">
                                    <img src="images/gallery_02.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="2" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_02.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 2 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#3">
                                    <img src="images/gallery_03.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="3" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_03.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 3 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#4">
                                    <img src="images/gallery_04.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="4" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_04.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 4 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#5">
                                    <img src="images/gallery_05.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="5" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_05.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 5 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#9">
                                    <img src="images/gallery_06.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="9" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_06.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 6 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-8 col-sm-12 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#10">
                                    <img src="images/gallery_07.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="10" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_07.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 7 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#11">
                                    <img src="images/gallery_08.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="11" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_08.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 8 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#12">
                                    <img src="images/gallery_09.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="12" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_09.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 9 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-4 col-sm-6 co-xs-12 gal-item">
                            <div class="box">
                                <a href="#" data-toggle="modal" data-target="#13">
                                    <img src="images/gallery_10.jpg" alt="" />
                                </a>
                                <div class="modal fade" id="13" tabindex="-1" role="dialog">
                                    <div class="modal-dialog" role="document">
                                        <div class="modal-content">
                                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                                            <div class="modal-body">
                                                <img src="images/gallery_10.jpg" alt="" />
                                            </div>
                                            <div class="col-md-12 description">
                                                <h4>This is the 10 one on my Gallery</h4>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- end gal-container -->
                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end gallery-main -->

    <div id="blog" class="blog-main pad-top-100 pad-bottom-100 parallax">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <h2 class="block-title text-center">
					Our Blog 	
				</h2>
                    <div class="blog-box clearfix">
                        <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                            <div class="col-md-6 col-sm-6">
                                <div class="blog-block">
                                    <div class="blog-img-box">
                                        <img src="images/featured-image-01.jpg" alt="" />
                                        <div class="overlay">
                                            <a href=""><i class="fa fa-link" aria-hidden="true"></i></a>
                                        </div>
                                    </div>
                                    <div class="blog-dit">
                                        <p><span>25 NOVEMBER, 2014</span></p>
                                        <h2>LATEST RECIPES JUST IN!</h2>
                                        <h5>BY John Doggett</h5>
                                    </div>
                                </div>
                            </div>
                            <!-- end col -->
                        </div>
                        <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                            <div class="col-md-6 col-sm-6">
                                <div class="blog-block">
                                    <div class="blog-img-box">
                                        <img src="images/featured-image-02.jpg" alt="" />
                                        <div class="overlay">
                                            <a href=""><i class="fa fa-link" aria-hidden="true"></i></a>
                                        </div>
                                    </div>
                                    <div class="blog-dit">
                                        <p><span>2 NOVEMBER, 2014</span></p>
                                        <h2>NEW RECRUITS HAVE ARRIVED!</h2>
                                        <h5>BY Jeffrey Spender</h5>
                                    </div>
                                </div>
                            </div>
                            <!-- end col -->
                        </div>
                        <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                            <div class="col-md-6 col-sm-6">
                                <div class="blog-block">
                                    <div class="blog-img-box">
                                        <img src="images/featured-image-03.jpg" alt="" />
                                        <div class="overlay">
                                            <a href=""><i class="fa fa-link" aria-hidden="true"></i></a>
                                        </div>
                                    </div>
                                    <div class="blog-dit">
                                        <p><span>4 NOVEMBER, 2014</span></p>
                                        <h2>BAKING TIPS FROM THE PROS</h2>
                                        <h5>BY Monica Reyes</h5>
                                    </div>
                                </div>
                            </div>
                            <!-- end col -->
                        </div>
                        <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                            <div class="col-md-6 col-sm-6">
                                <div class="blog-block">
                                    <div class="blog-img-box">
                                        <img src="images/featured-image-04.jpg" alt="" />
                                        <div class="overlay">
                                            <a href=""><i class="fa fa-link" aria-hidden="true"></i></a>
                                        </div>
                                    </div>
                                    <div class="blog-dit">
                                        <p><span>12 NOVEMBER, 2014</span></p>
                                        <h2>ALL YOUR EGGS BELONG TO US</h2>
                                        <h5>BY John Doggett</h5>
                                    </div>
                                </div>
                            </div>
                            <!-- end col -->
                        </div>
                    </div>
                    <!-- end blog-box -->

                    <div class="blog-btn-v">
                        <a class="hvr-underline-from-center" href="#">View the Blog</a>
                    </div>

                </div>
                <!-- end col -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end blog-main -->

    <div id="pricing" class="pricing-main pad-top-100 pad-bottom-100">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <h2 class="block-title text-center">
						Pricing 	
					</h2>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut orci varius, elementum lectus nec, aliquam lectus. Duis neque augue, maximus in sapien ut, porta pharetra odio.</p>
                </div>
                <div class="panel-pricing-in">
                    <!-- item -->
                    <div class="col-md-4 col-sm-4 text-center">
                        <div class="panel panel-pricing">
                            <div class="panel-heading">
                                <div class="pric-icon">
                                    <img src="images/store.png" alt="" />
                                </div>
                                <h3>Basic</h3>
                            </div>
                            <div class="panel-body text-center">
                                <p><strong>$30/<span>Month</span></strong></p>
                            </div>
                            <ul class="list-group text-center">
                                <li class="list-group-item"><i class="fa fa-check"></i> One Website</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> One User</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> 10 GB Bandwidth</li>
                                <li class="list-group-item"><i class="fa fa-times"></i> 2GB Storage</li>
                                <li class="list-group-item"><i class="fa fa-times"></i> Offline work</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> 24x7 Support</li>
                            </ul>
                            <div class="panel-footer">
                                <a class="btn btn-lg btn-block hvr-underline-from-center" href="#">Purchase Now!</a>
                            </div>
                        </div>
                    </div>
                    <!-- /item -->

                    <!-- item -->
                    <div class="col-md-4 col-sm-4 text-center">
                        <div class="panel panel-pricing">
                            <div class="panel-heading">
                                <div class="pric-icon">
                                    <img src="images/food.png" alt="" />
                                </div>
                                <h3>Pro</h3>
                            </div>
                            <div class="panel-body text-center">
                                <p><strong>$60/<span>Month</span></strong></p>
                            </div>
                            <ul class="list-group text-center">
                                <li class="list-group-item"><i class="fa fa-check"></i> One Website</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> One User</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> 50 GB Bandwidth</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> 2GB Storage</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> Offline work</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> 24x7 Support</li>
                            </ul>
                            <div class="panel-footer">
                                <a class="btn btn-lg btn-block hvr-underline-from-center" href="#">Purchase Now!</a>
                            </div>
                        </div>
                    </div>
                    <!-- /item -->

                    <!-- item -->
                    <div class="col-md-4 col-sm-4 text-center">
                        <div class="panel panel-pricing">
                            <div class="panel-heading">
                                <div class="pric-icon">
                                    <img src="images/coffee.png" alt="" />
                                </div>
                                <h3>Platinum</h3>
                            </div>
                            <div class="panel-body text-center">
                                <p><strong>$90/<span>Month</span></strong></p>
                            </div>
                            <ul class="list-group text-center">
                                <li class="list-group-item"><i class="fa fa-check"></i> One Website</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> One User</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> 100 GB Bandwidth</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> 2GB Storage</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> Offline work</li>
                                <li class="list-group-item"><i class="fa fa-check"></i> 24x7 Support</li>
                            </ul>
                            <div class="panel-footer">
                                <a class="btn btn-lg btn-block hvr-underline-from-center" href="#">Purchase Now!</a>
                            </div>
                        </div>
                    </div>
                    <!-- /item -->
                </div>
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end pricing-main -->

    <div id="reservation" class="reservations-main pad-top-100 pad-bottom-100">
        <div class="container">
            <div class="row">
                <div class="form-reservations-box">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="wow fadeIn" data-wow-duration="1s" data-wow-delay="0.1s">
                            <h2 class="block-title text-center">
						Reservations			
					</h2>
                        </div>
                        <h4 class="form-title">BOOKING FORM</h4>
                        <p>PLEASE FILL OUT ALL REQUIRED* FIELDS. THANKS!</p>

                        <form id="contact-form" method="post" class="reservations-box" name="contactform" action="mail.php">
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-box">
                                    <input type="text" name="form_name" id="form_name" placeholder="Name" required="required" data-error="Firstname is required.">
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-box">
                                    <input type="email" name="email" id="email" placeholder="E-Mail ID" required="required" data-error="E-mail id is required.">
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-box">
                                    <input type="text" name="phone" id="phone" placeholder="contact no.">
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-box">
                                    <select name="no_of_persons" id="no_of_persons" class="selectpicker">
                                        <option selected disabled>No. Of persons</option>
                                        <option>1</option>
                                        <option>2</option>
                                        <option>3</option>
                                    </select>
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-box">
                                    <input type="text" name="date-picker" id="date-picker" placeholder="Date" required="required" data-error="Date is required." />
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-box">
                                    <input type="text" name="time-picker" id="time-picker" placeholder="Time" required="required" data-error="Time is required." />
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-box">
                                    <select name="preferred_food" id="preferred_food" class="selectpicker">
                                        <option selected disabled>preferred food</option>
                                        <option>Indian</option>
                                        <option>Continental</option>
                                        <option>Mexican</option>
                                    </select>
                                </div>
                            </div>
                            <!-- end col -->
                            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                <div class="form-box">
                                    <select name="occasion" id="occasion" class="selectpicker">
                                        <option selected disabled>Occasion</option>
                                        <option>Wedding</option>
                                        <option>Birthday</option>
                                        <option>Anniversary</option>
                                    </select>
                                </div>
                            </div>
                            <!-- end col -->

                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                <div class="reserve-book-btn text-center">
                                    <button class="hvr-underline-from-center" type="submit" value="SEND" id="submit">BOOK MY TABLE </button>
                                </div>
                            </div>
                            <!-- end col -->
                        </form>
                        <!-- end form -->
                    </div>
                    <!-- end col -->
                </div>
                <!-- end reservations-box -->
            </div>
            <!-- end row -->
        </div>
        <!-- end container -->
    </div>
    <!-- end reservations-main -->
</asp:Content>
