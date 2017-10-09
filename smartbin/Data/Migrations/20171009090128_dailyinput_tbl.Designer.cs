﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using smartbin.Data;
using System;

namespace smartbin.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171009090128_dailyinput_tbl")]
    partial class dailyinput_tbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("smartbin.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("areaID");

                    b.Property<string>("fullName");

                    b.Property<string>("role");

                    b.Property<byte[]>("userImage");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("smartbin.Data.Models.BinDetail", b =>
                {
                    b.Property<string>("binID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("H00");

                    b.Property<double>("H01");

                    b.Property<double>("H02");

                    b.Property<double>("H03");

                    b.Property<double>("H04");

                    b.Property<double>("H05");

                    b.Property<double>("H06");

                    b.Property<double>("H07");

                    b.Property<double>("H08");

                    b.Property<double>("H09");

                    b.Property<double>("H10");

                    b.Property<double>("H11");

                    b.Property<double>("H12");

                    b.Property<double>("H13");

                    b.Property<double>("H14");

                    b.Property<double>("H15");

                    b.Property<double>("H16");

                    b.Property<double>("H17");

                    b.Property<double>("H18");

                    b.Property<double>("H19");

                    b.Property<double>("H20");

                    b.Property<double>("H21");

                    b.Property<double>("H22");

                    b.Property<double>("H23");

                    b.Property<string>("Status");

                    b.Property<string>("areaID");

                    b.Property<string>("areaName");

                    b.Property<double>("filedLevel");

                    b.Property<double>("latitude");

                    b.Property<double>("longitude");

                    b.HasKey("binID");

                    b.ToTable("bindetail_tbl");
                });

            modelBuilder.Entity("smartbin.Data.Models.dailyinput", b =>
                {
                    b.Property<string>("binID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BD");

                    b.Property<double>("GL");

                    b.Property<double>("PA");

                    b.Property<double>("PL");

                    b.Property<string>("areaID");

                    b.HasKey("binID");

                    b.ToTable("dailyinput_tbl");
                });

            modelBuilder.Entity("smartbin.Data.Models.Feedback", b =>
                {
                    b.Property<int>("fid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("binid");

                    b.Property<string>("cemail");

                    b.Property<string>("feedback");

                    b.Property<string>("feedbacktype");

                    b.HasKey("fid");

                    b.ToTable("feedback");
                });

            modelBuilder.Entity("smartbin.Data.Models.Workforce", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("areaID");

                    b.Property<string>("contactNo");

                    b.Property<string>("email");

                    b.Property<byte[]>("image");

                    b.Property<string>("pWord");

                    b.Property<string>("uName");

                    b.HasKey("userID");

                    b.ToTable("workforce_tbl");
                });

            modelBuilder.Entity("smartbin.Data.Models.working", b =>
                {
                    b.Property<int>("workID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("binID");

                    b.Property<DateTime>("time");

                    b.Property<int?>("userID");

                    b.HasKey("workID");

                    b.HasIndex("binID");

                    b.HasIndex("userID");

                    b.ToTable("working_tbl");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("smartbin.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("smartbin.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("smartbin.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("smartbin.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("smartbin.Data.Models.working", b =>
                {
                    b.HasOne("smartbin.Data.Models.BinDetail", "bin")
                        .WithMany()
                        .HasForeignKey("binID");

                    b.HasOne("smartbin.Data.Models.Workforce", "user")
                        .WithMany()
                        .HasForeignKey("userID");
                });
#pragma warning restore 612, 618
        }
    }
}
