﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrendyShop.Data;

namespace TrendyShop.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201021022102_AddedSystemDefaultPricesModel")]
    partial class AddedSystemDefaultPricesModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrendyShop.Models.CashRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cash")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("CashRegisters");
                });

            modelBuilder.Entity("TrendyShop.Models.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastBlockedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEntrance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TrendyShop.Models.DailyClosing", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<float>("AmountInStorage")
                        .HasColumnType("real");

                    b.Property<float>("ConsuptionSincePreviuosClosing")
                        .HasColumnType("real");

                    b.Property<float>("Replenished")
                        .HasColumnType("real");

                    b.Property<float>("Room1")
                        .HasColumnType("real");

                    b.Property<float>("Room2")
                        .HasColumnType("real");

                    b.Property<float>("Room3")
                        .HasColumnType("real");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("real");

                    b.HasKey("Date", "Name", "Cost");

                    b.HasIndex("Cost", "Name");

                    b.ToTable("DailyClosings");
                });

            modelBuilder.Entity("TrendyShop.Models.DateOfClosing", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("PreviousClosingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PreviousClousingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Date");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PreviousClosingDate");

                    b.ToTable("DatesOfClosings");
                });

            modelBuilder.Entity("TrendyShop.Models.DefaultPrice", b =>
                {
                    b.Property<int>("DefaultPriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DefaultPriceId");

                    b.ToTable("SystemDefaultPrices");
                });

            modelBuilder.Entity("TrendyShop.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("DefaultSalary")
                        .HasColumnType("real");

                    b.Property<DateTime>("LastPayment")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastRestart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PendingPayment")
                        .HasColumnType("real");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalSalary")
                        .HasColumnType("real");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TrendyShop.Models.EmployeePaymentRecords", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Payment")
                        .HasColumnType("real");

                    b.HasKey("Date");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeePaymentRecords");
                });

            modelBuilder.Entity("TrendyShop.Models.ExpendableProduct", b =>
                {
                    b.Property<float?>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UnitOfMeasurement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cost", "Name");

                    b.ToTable("ExpendableProducts");
                });

            modelBuilder.Entity("TrendyShop.Models.ExpendableProductOperation", b =>
                {
                    b.Property<float?>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("AlreadyInStorageAmount")
                        .HasColumnType("real");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("OperationAmount")
                        .HasColumnType("real");

                    b.Property<int>("POTypeId")
                        .HasColumnType("int");

                    b.HasKey("Cost", "Name", "Date");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("POTypeId");

                    b.ToTable("ExpendableProductOperations");
                });

            modelBuilder.Entity("TrendyShop.Models.ExpendableProductStorage", b =>
                {
                    b.Property<float?>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float?>("LastInsertedQuantity")
                        .HasColumnType("real");

                    b.Property<DateTime>("LastInsertionDate")
                        .HasColumnType("datetime2");

                    b.Property<float?>("TotalQuantity")
                        .HasColumnType("real");

                    b.HasKey("Cost", "Name");

                    b.ToTable("ExpendableProductStorage");
                });

            modelBuilder.Entity("TrendyShop.Models.ExpenseType", b =>
                {
                    b.Property<int>("ExpenseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseTypeId");

                    b.ToTable("ExpenseTypes");
                });

            modelBuilder.Entity("TrendyShop.Models.FundMoneyOperation", b =>
                {
                    b.Property<int>("FundMoneyOperationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsExtraction")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FundMoneyOperationId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("FundMoneyOperations");
                });

            modelBuilder.Entity("TrendyShop.Models.GastronomicProduct", b =>
                {
                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Cost", "Name");

                    b.ToTable("GastronomicProducts");
                });

            modelBuilder.Entity("TrendyShop.Models.GastronomicProductOperation", b =>
                {
                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("AmountAvailable")
                        .HasColumnType("real");

                    b.Property<float>("AmountInrooms")
                        .HasColumnType("real");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("OperationAmount")
                        .HasColumnType("real");

                    b.Property<int>("POTypeId")
                        .HasColumnType("int");

                    b.HasKey("Cost", "Name", "Date");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("POTypeId");

                    b.ToTable("GastronomicProductOperations");
                });

            modelBuilder.Entity("TrendyShop.Models.HouseExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExpenseTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExpenseTypeId");

                    b.ToTable("HouseExpenses");
                });

            modelBuilder.Entity("TrendyShop.Models.Incidence", b =>
                {
                    b.Property<int>("IncidenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidenceId");

                    b.ToTable("Incidences");
                });

            modelBuilder.Entity("TrendyShop.Models.Lodging", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ActualFDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ActualIDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Companion")
                        .HasColumnType("int");

                    b.Property<float?>("Consumption")
                        .HasColumnType("real");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float?>("ExtraCharge")
                        .HasColumnType("real");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDouble")
                        .HasColumnType("bit");

                    b.Property<int>("LodgingNumber")
                        .HasColumnType("int");

                    b.Property<float>("Prepaid")
                        .HasColumnType("real");

                    b.Property<float?>("RentCost")
                        .IsRequired()
                        .HasColumnType("real");

                    b.Property<bool>("Romantic")
                        .HasColumnType("bit");

                    b.HasKey("RoomId", "Date");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Lodgings");
                });

            modelBuilder.Entity("TrendyShop.Models.LodgingIncidence", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IncidenceId")
                        .HasColumnType("int");

                    b.HasKey("RoomId", "Date", "IncidenceId");

                    b.HasIndex("IncidenceId");

                    b.ToTable("LodgingIncidences");
                });

            modelBuilder.Entity("TrendyShop.Models.MOType", b =>
                {
                    b.Property<int>("MOTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MOTypeId");

                    b.ToTable("MOTypes");
                });

            modelBuilder.Entity("TrendyShop.Models.Maintenance", b =>
                {
                    b.Property<int>("MaintenanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaintenanceId");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("TrendyShop.Models.MissingRecord", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.HasKey("Date", "Cost", "Name");

                    b.HasIndex("Cost", "Name");

                    b.ToTable("Missings");
                });

            modelBuilder.Entity("TrendyShop.Models.MoneyOperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsExtraction")
                        .HasColumnType("bit");

                    b.Property<int>("MOTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("MOTypeId");

                    b.ToTable("MoneyOperations");
                });

            modelBuilder.Entity("TrendyShop.Models.Package", b =>
                {
                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Cost", "Name");

                    b.ToTable("Package");
                });

            modelBuilder.Entity("TrendyShop.Models.ProductOperationType", b =>
                {
                    b.Property<int>("POTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("POTypeId");

                    b.ToTable("ProductOperationTypes");
                });

            modelBuilder.Entity("TrendyShop.Models.PurchasePerLodging", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.HasKey("Name", "Cost", "RoomId", "Date");

                    b.HasIndex("Cost", "Name");

                    b.HasIndex("RoomId", "Date");

                    b.ToTable("PurchasePerLodgings");
                });

            modelBuilder.Entity("TrendyShop.Models.RepositionRecord", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<bool>("Paid")
                        .HasColumnType("bit");

                    b.HasKey("Date", "Cost", "Name");

                    b.HasIndex("Cost", "Name");

                    b.ToTable("Repositions");
                });

            modelBuilder.Entity("TrendyShop.Models.Reservation", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Romantic")
                        .HasColumnType("bit");

                    b.HasKey("RoomId", "Date");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("TrendyShop.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("TrendyShop.Models.RoomProduct", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.HasKey("Name", "Cost", "RoomId");

                    b.HasIndex("RoomId");

                    b.HasIndex("Cost", "Name");

                    b.ToTable("RoomProducts");
                });

            modelBuilder.Entity("TrendyShop.Models.StockTaking", b =>
                {
                    b.Property<int>("StockTakingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Fund")
                        .HasColumnType("real");

                    b.HasKey("StockTakingId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("TrendyShop.Models.StorageRow", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<float>("AmountAvailable")
                        .HasColumnType("real");

                    b.Property<float>("AmountInRooms")
                        .HasColumnType("real");

                    b.HasKey("Name", "Cost");

                    b.HasIndex("Cost", "Name");

                    b.ToTable("Storage");
                });

            modelBuilder.Entity("TrendyShop.Models.YearStatistics", b =>
                {
                    b.Property<float>("Consumo")
                        .HasColumnType("real");

                    b.Property<float>("GananciaPorConsumo")
                        .HasColumnType("real");

                    b.Property<float>("IngresoBruto")
                        .HasColumnType("real");

                    b.Property<float>("IngresoPorDaños")
                        .HasColumnType("real");

                    b.Property<float>("IngresoPorRenta")
                        .HasColumnType("real");

                    b.Property<string>("Mes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("OtrosGastos")
                        .HasColumnType("real");

                    b.Property<int>("Reservas")
                        .HasColumnType("int");

                    b.Property<float>("ReservasDiarias")
                        .HasColumnType("real");

                    b.Property<int>("ReservasDobles")
                        .HasColumnType("int");

                    b.Property<float>("Salario")
                        .HasColumnType("real");

                    b.ToTable("YearStatistics");
                });

            modelBuilder.Entity("TrendyShop.Models.DailyClosing", b =>
                {
                    b.HasOne("TrendyShop.Models.DateOfClosing", "DateOfClosing")
                        .WithMany()
                        .HasForeignKey("Date")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendyShop.Models.GastronomicProduct", "Product")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.DateOfClosing", b =>
                {
                    b.HasOne("TrendyShop.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TrendyShop.Models.DateOfClosing", "PreviousClosing")
                        .WithMany()
                        .HasForeignKey("PreviousClosingDate");
                });

            modelBuilder.Entity("TrendyShop.Models.EmployeePaymentRecords", b =>
                {
                    b.HasOne("TrendyShop.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("TrendyShop.Models.ExpendableProductOperation", b =>
                {
                    b.HasOne("TrendyShop.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TrendyShop.Models.ProductOperationType", "POType")
                        .WithMany()
                        .HasForeignKey("POTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendyShop.Models.ExpendableProduct", "ExpendableProduct")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.ExpendableProductStorage", b =>
                {
                    b.HasOne("TrendyShop.Models.ExpendableProduct", "ExpendableProduct")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.FundMoneyOperation", b =>
                {
                    b.HasOne("TrendyShop.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("TrendyShop.Models.GastronomicProductOperation", b =>
                {
                    b.HasOne("TrendyShop.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TrendyShop.Models.ProductOperationType", "POType")
                        .WithMany()
                        .HasForeignKey("POTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendyShop.Models.GastronomicProduct", "GastronomicProduct")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.HouseExpense", b =>
                {
                    b.HasOne("TrendyShop.Models.ExpenseType", "ExpenseType")
                        .WithMany()
                        .HasForeignKey("ExpenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.Lodging", b =>
                {
                    b.HasOne("TrendyShop.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("TrendyShop.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("TrendyShop.Models.LodgingIncidence", b =>
                {
                    b.HasOne("TrendyShop.Models.Incidence", "Incidence")
                        .WithMany()
                        .HasForeignKey("IncidenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendyShop.Models.Lodging", "Lodging")
                        .WithMany()
                        .HasForeignKey("RoomId", "Date")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.MissingRecord", b =>
                {
                    b.HasOne("TrendyShop.Models.DateOfClosing", "DateOfClosing")
                        .WithMany()
                        .HasForeignKey("Date")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendyShop.Models.GastronomicProduct", "Product")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.MoneyOperation", b =>
                {
                    b.HasOne("TrendyShop.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TrendyShop.Models.MOType", "MOType")
                        .WithMany()
                        .HasForeignKey("MOTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.Package", b =>
                {
                    b.HasOne("TrendyShop.Models.GastronomicProduct", "GastronomicProduct")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.PurchasePerLodging", b =>
                {
                    b.HasOne("TrendyShop.Models.GastronomicProduct", "GastronomicProduct")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendyShop.Models.Lodging", "Lodging")
                        .WithMany()
                        .HasForeignKey("RoomId", "Date")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.RepositionRecord", b =>
                {
                    b.HasOne("TrendyShop.Models.DateOfClosing", "DateOfClosing")
                        .WithMany()
                        .HasForeignKey("Date")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendyShop.Models.GastronomicProduct", "Product")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.Reservation", b =>
                {
                    b.HasOne("TrendyShop.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.RoomProduct", b =>
                {
                    b.HasOne("TrendyShop.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrendyShop.Models.GastronomicProduct", "GastronomicProduct")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrendyShop.Models.StorageRow", b =>
                {
                    b.HasOne("TrendyShop.Models.GastronomicProduct", "GastronomicProduct")
                        .WithMany()
                        .HasForeignKey("Cost", "Name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
