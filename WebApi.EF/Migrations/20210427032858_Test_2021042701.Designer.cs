﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using WebApi.EF.SalerDb;

namespace WebApi.EF.Migrations
{
    [DbContext(typeof(SalerDbContext))]
    [Migration("20210427032858_Test_2021042701")]
    partial class Test_2021042701
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("SALER")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn);

            modelBuilder.HasSequence("SEQ_INFO_ID")
                .IncrementsBy(10);

            modelBuilder.Entity("WebApi.EF.SalerDb.SalerInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)")
                        .HasAnnotation("Oracle:HiLoSequenceName", "SEQ_INFO_ID")
                        .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("AccountId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("UserName")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("SalerInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
