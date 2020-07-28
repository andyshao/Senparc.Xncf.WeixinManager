﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Senparc.Xncf.WeixinManager;

namespace Senparc.Xncf.WeixinManager.Migrations
{
    [DbContext(typeof(WeixinSenparcEntities))]
    partial class WeixinSenparcEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Senparc.Xncf.WeixinManager.Models.MpAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("AppId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AppSecret")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("EncodingAESKey")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("WeixinManager_MpAccount");
                });

            modelBuilder.Entity("Senparc.Xncf.WeixinManager.Models.UserTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("MpAccountId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MpAccountId");

                    b.ToTable("WeixinManager_UserTag");
                });

            modelBuilder.Entity("Senparc.Xncf.WeixinManager.Models.UserTag_WeixinUser", b =>
                {
                    b.Property<int>("UserTagId")
                        .HasColumnType("int");

                    b.Property<int>("WeixinUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime");

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime");

                    b.HasKey("UserTagId", "WeixinUserId");

                    b.HasIndex("WeixinUserId");

                    b.ToTable("WeixinManager_UserTag_WeixinUser");
                });

            modelBuilder.Entity("Senparc.Xncf.WeixinManager.Models.WeixinUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddTime")
                        .HasColumnType("datetime");

                    b.Property<string>("AdminRemark")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Flag")
                        .HasColumnType("bit");

                    b.Property<int>("Groupid")
                        .HasColumnType("int");

                    b.Property<string>("HeadImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastUpdateTime")
                        .HasColumnType("datetime");

                    b.Property<int>("MpAccountId")
                        .HasColumnType("int");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Qr_Scene")
                        .HasColumnType("bigint");

                    b.Property<string>("Qr_Scene_Str")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("Subscribe")
                        .HasColumnType("int");

                    b.Property<string>("Subscribe_Scene")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Subscribe_Time")
                        .HasColumnType("bigint");

                    b.Property<string>("UnionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MpAccountId");

                    b.ToTable("WeixinManager_WeixinUser");
                });

            modelBuilder.Entity("Senparc.Xncf.WeixinManager.Models.UserTag", b =>
                {
                    b.HasOne("Senparc.Xncf.WeixinManager.Models.MpAccount", "MpAccount")
                        .WithMany("UserTags")
                        .HasForeignKey("MpAccountId")
                        .HasConstraintName("FK__UserTag__MpAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Senparc.Xncf.WeixinManager.Models.UserTag_WeixinUser", b =>
                {
                    b.HasOne("Senparc.Xncf.WeixinManager.Models.UserTag", "UserTag")
                        .WithMany("UserTags_WeixinUsers")
                        .HasForeignKey("UserTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Senparc.Xncf.WeixinManager.Models.WeixinUser", "WeixinUser")
                        .WithMany("UserTags_WeixinUsers")
                        .HasForeignKey("WeixinUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Senparc.Xncf.WeixinManager.Models.WeixinUser", b =>
                {
                    b.HasOne("Senparc.Xncf.WeixinManager.Models.MpAccount", "MpAccount")
                        .WithMany("WeixinUsers")
                        .HasForeignKey("MpAccountId")
                        .HasConstraintName("FK__WeixinUser__MpAccountId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}