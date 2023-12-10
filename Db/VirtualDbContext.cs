using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RangsServiceApi.Db;

public partial class VirtualDbContext : DbContext
{
    public VirtualDbContext()
    {
    }

    public VirtualDbContext(DbContextOptions<VirtualDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<Mrsrdetail> Mrsrdetails { get; set; }

    public virtual DbSet<Mrsrmaster> Mrsrmasters { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=10.12.3.16;Initial Catalog=dbCID;User ID=sa;Password=Adminn321;Integrated Security=False;TrustServerCertificate=True;Trusted_Connection=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer");

            entity.Property(e => e.Address).HasMaxLength(555);
            entity.Property(e => e.Chdate)
                .HasColumnType("datetime")
                .HasColumnName("CHDate");
            entity.Property(e => e.Chno)
                .HasMaxLength(50)
                .HasColumnName("CHNo");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Comcod).HasColumnName("comcod");
            entity.Property(e => e.ContPer1).HasMaxLength(50);
            entity.Property(e => e.ContPer2).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.CustAge)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CustAid)
                .ValueGeneratedOnAdd()
                .HasColumnName("CustAID");
            entity.Property(e => e.CustArea)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CustFatherName).HasMaxLength(50);
            entity.Property(e => e.CustId)
                .HasMaxLength(50)
                .HasColumnName("CustID");
            entity.Property(e => e.CustName).HasMaxLength(250);
            entity.Property(e => e.CustRef).HasMaxLength(50);
            entity.Property(e => e.CustSex).HasMaxLength(50);
            entity.Property(e => e.CustType).HasMaxLength(50);
            entity.Property(e => e.Desg).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Dobt)
                .HasMaxLength(20)
                .HasColumnName("DOBT");
            entity.Property(e => e.EId).HasColumnName("eID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.IdentityNo).HasMaxLength(50);
            entity.Property(e => e.IdentityType).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(50);
            entity.Property(e => e.Mrno)
                .HasMaxLength(50)
                .HasColumnName("MRNo");
            entity.Property(e => e.Org).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ProdId).HasColumnName("ProdID");
            entity.Property(e => e.Profession).HasMaxLength(50);
            entity.Property(e => e.TAmnt).HasColumnName("tAmnt");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.WebSite).HasMaxLength(70);
        });

        modelBuilder.Entity<Entity>(entity =>
        {
            entity.HasKey(e => e.EName);

            entity.ToTable("Entity");

            entity.Property(e => e.EName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("eName");
            entity.Property(e => e.ActiveDeactive).HasDefaultValueSql("((0))");
            entity.Property(e => e.ContactNo).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.CorporateSale).HasDefaultValueSql("((0))");
            entity.Property(e => e.DepositedUpTo0809)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Desg).HasMaxLength(50);
            entity.Property(e => e.DpInactive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DP_Inactive");
            entity.Property(e => e.ENameBangla)
                .HasMaxLength(50)
                .HasColumnName("eNameBangla");
            entity.Property(e => e.Edesc)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EDesc");
            entity.Property(e => e.EdescBangla)
                .HasMaxLength(200)
                .HasColumnName("EDescBangla");
            entity.Property(e => e.Eid)
                .ValueGeneratedOnAdd()
                .HasColumnName("EID");
            entity.Property(e => e.EmailAdd).HasMaxLength(50);
            entity.Property(e => e.EnableSalesSheet).HasDefaultValueSql("((0))");
            entity.Property(e => e.EntityCode)
                .HasMaxLength(20)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.GroupSl).HasColumnName("GroupSL");
            entity.Property(e => e.ITagStock)
                .HasDefaultValueSql("((0))")
                .HasColumnName("iTagStock");
            entity.Property(e => e.InDhk).HasDefaultValueSql("((1))");
            entity.Property(e => e.MapLink).HasMaxLength(1050);
            entity.Property(e => e.NoTr).HasDefaultValueSql("((0))");
            entity.Property(e => e.PEid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("pEID");
            entity.Property(e => e.ParentEntity)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pcname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PCName");
            entity.Property(e => e.PhoneNo).HasMaxLength(50);
            entity.Property(e => e.ReqMailTo).HasMaxLength(50);
            entity.Property(e => e.SFlag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("sFlag");
            entity.Property(e => e.SalesCenterType).HasDefaultValueSql("((0))");
            entity.Property(e => e.SecurityMoney)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Showroomtype).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.ZoneId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ZoneID");
        });

        modelBuilder.Entity<Mrsrdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MRSRDetails");

            entity.Property(e => e.BarCode).HasMaxLength(50);
            entity.Property(e => e.BinNmbr).HasMaxLength(50);
            entity.Property(e => e.Blipamnt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BLIPAmnt");
            entity.Property(e => e.CampDisAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Comcod)
                .HasMaxLength(3)
                .HasColumnName("comcod");
            entity.Property(e => e.CustShowPrice).HasDefaultValueSql("((0))");
            entity.Property(e => e.DisCode).HasMaxLength(50);
            entity.Property(e => e.DisRef).HasMaxLength(50);
            entity.Property(e => e.DiscountAmnt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DiscountPercent).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FreeWithProdId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("FreeWithProdID");
            entity.Property(e => e.InEid).HasColumnName("InEID");
            entity.Property(e => e.IncentiveAmnt).HasDefaultValueSql("((0))");
            entity.Property(e => e.IncentiveType).HasMaxLength(50);
            entity.Property(e => e.JobNmbr).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(15);
            entity.Property(e => e.Mrp)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MRP");
            entity.Property(e => e.Mrsrcode)
                .HasMaxLength(15)
                .HasColumnName("MRSRCode");
            entity.Property(e => e.Mrsrdid)
                .ValueGeneratedOnAdd()
                .HasColumnName("MRSRDID");
            entity.Property(e => e.Mrsrmid).HasColumnName("MRSRMID");
            entity.Property(e => e.NetAmnt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NextPurchaseAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OdrNmbr).HasMaxLength(50);
            entity.Property(e => e.Origin).HasMaxLength(50);
            entity.Property(e => e.OutEid).HasColumnName("OutEID");
            entity.Property(e => e.ProdCond).HasMaxLength(250);
            entity.Property(e => e.ProdRemarks).HasMaxLength(100);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.Purpose).HasMaxLength(50);
            entity.Property(e => e.RedeemAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Rpcode)
                .HasMaxLength(50)
                .HasColumnName("RPCode");
            entity.Property(e => e.Slno)
                .HasMaxLength(1150)
                .HasColumnName("SLNO");
            entity.Property(e => e.TotalAmnt).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UnitName).HasMaxLength(15);
            entity.Property(e => e.UnitPriceUsd).HasColumnName("UnitPriceUSD");
            entity.Property(e => e.VatAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.WithAdjAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Mrsrmaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MRSRMaster");

            entity.Property(e => e.Acc)
                .HasMaxLength(15)
                .HasColumnName("ACC");
            entity.Property(e => e.AdvanceSales).HasDefaultValueSql("((0))");
            entity.Property(e => e.AppBy).HasMaxLength(50);
            entity.Property(e => e.AppovalCode1).HasMaxLength(10);
            entity.Property(e => e.AppovalCode2).HasMaxLength(10);
            entity.Property(e => e.Authorby).HasMaxLength(50);
            entity.Property(e => e.Bank1).HasMaxLength(50);
            entity.Property(e => e.Bank2).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.Blno)
                .HasMaxLength(50)
                .HasColumnName("BLNo");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.CardAmnt1)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CardAmnt2)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CardNo1)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CardNo2)
                .HasMaxLength(50)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.CardType1).HasMaxLength(50);
            entity.Property(e => e.CardType2).HasMaxLength(50);
            entity.Property(e => e.CarrierId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CarrierID");
            entity.Property(e => e.CarrierType).HasMaxLength(10);
            entity.Property(e => e.CarryNo).HasMaxLength(20);
            entity.Property(e => e.CashAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ChaDate)
                .HasColumnType("datetime")
                .HasColumnName("chaDate");
            entity.Property(e => e.ChequeIssueDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ChequeNmbr).HasMaxLength(50);
            entity.Property(e => e.ChequeNo).HasMaxLength(50);
            entity.Property(e => e.Comcod)
                .HasMaxLength(5)
                .HasColumnName("comcod");
            entity.Property(e => e.CustAid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CustAID");
            entity.Property(e => e.Customer).HasMaxLength(50);
            entity.Property(e => e.Daid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DAID");
            entity.Property(e => e.DelDate).HasColumnType("datetime");
            entity.Property(e => e.DelStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.DelivaryCharge).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DeliveryFrom).HasDefaultValueSql("((0))");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Deposit)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.DriverId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("DriverID");
            entity.Property(e => e.DueAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.EditTag).HasDefaultValueSql("((0))");
            entity.Property(e => e.Emei)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMEI");
            entity.Property(e => e.EmeichargeOnPercent)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EMEIChargeOnPercent");
            entity.Property(e => e.Emeitenure)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EMEITenure");
            entity.Property(e => e.EmidownPayment)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EMIDownPayment");
            entity.Property(e => e.EmimonthlyToPay)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("EMIMonthlyToPay");
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.Fc)
                .HasMaxLength(15)
                .HasColumnName("FC");
            entity.Property(e => e.HelperId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HelperID");
            entity.Property(e => e.Hpstatus)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HPStatus");
            entity.Property(e => e.InvoiceNo)
                .HasMaxLength(20)
                .HasColumnName("InvoiceNO");
            entity.Property(e => e.Issby).HasMaxLength(50);
            entity.Property(e => e.IssueTo).HasMaxLength(50);
            entity.Property(e => e.Jcn)
                .HasMaxLength(15)
                .HasColumnName("JCN");
            entity.Property(e => e.JobNo).HasMaxLength(50);
            entity.Property(e => e.Lcdate)
                .HasColumnType("datetime")
                .HasColumnName("LCDate");
            entity.Property(e => e.Lcno)
                .HasMaxLength(50)
                .HasColumnName("LCNO");
            entity.Property(e => e.Loc)
                .HasMaxLength(50)
                .HasColumnName("LOC");
            entity.Property(e => e.Mrno)
                .HasMaxLength(50)
                .HasColumnName("MRNO");
            entity.Property(e => e.Mrsrcode)
                .HasMaxLength(50)
                .HasColumnName("MRSRCode");
            entity.Property(e => e.Mrsrmid)
                .ValueGeneratedOnAdd()
                .HasColumnName("MRSRMID");
            entity.Property(e => e.NetSalesAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OnLineSales).HasDefaultValueSql("((0))");
            entity.Property(e => e.PayAmnt)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.PayMode).HasMaxLength(50);
            entity.Property(e => e.PayType).HasMaxLength(20);
            entity.Property(e => e.Pcname)
                .HasMaxLength(50)
                .HasColumnName("PCName");
            entity.Property(e => e.Pn)
                .HasMaxLength(15)
                .HasColumnName("PN");
            entity.Property(e => e.Pocode)
                .HasMaxLength(50)
                .HasColumnName("POCode");
            entity.Property(e => e.ProdCode).HasMaxLength(50);
            entity.Property(e => e.ProductGroup)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RcvChDate).HasColumnType("datetime");
            entity.Property(e => e.RcvChNo).HasMaxLength(50);
            entity.Property(e => e.RecBy).HasMaxLength(50);
            entity.Property(e => e.RefChno)
                .HasMaxLength(50)
                .HasColumnName("RefCHNo");
            entity.Property(e => e.RefStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.Remarks).HasMaxLength(1050);
            entity.Property(e => e.ReportId)
                .HasMaxLength(50)
                .HasColumnName("ReportID");
            entity.Property(e => e.ReqBy).HasMaxLength(50);
            entity.Property(e => e.Rosdetails)
                .HasMaxLength(1050)
                .HasColumnName("ROSDetails");
            entity.Property(e => e.SalesTypeHp)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SalesTypeHP");
            entity.Property(e => e.SecurityCode).HasMaxLength(10);
            entity.Property(e => e.SecurityCode2).HasMaxLength(10);
            entity.Property(e => e.ShipDate).HasColumnType("datetime");
            entity.Property(e => e.ShipFrom).HasMaxLength(50);
            entity.Property(e => e.Sid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SID");
            entity.Property(e => e.SourceOfInfo).HasMaxLength(50);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(20)
                .HasColumnName("SupplierID");
            entity.Property(e => e.Tag).HasMaxLength(75);
            entity.Property(e => e.Tdate)
                .HasColumnType("datetime")
                .HasColumnName("TDate");
            entity.Property(e => e.TermsCondition).HasMaxLength(1050);
            entity.Property(e => e.TotalDiscount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
            entity.Property(e => e.VehId)
                .HasMaxLength(15)
                .HasColumnName("VehID");
            entity.Property(e => e.VehicleId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("VehicleID");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Model).IsClustered(false);

            entity.ToTable("Product");

            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.ACode)
                .HasMaxLength(50)
                .HasColumnName("aCode");
            entity.Property(e => e.AProductId)
                .HasDefaultValueSql("((0))")
                .HasColumnName("aProductID");
            entity.Property(e => e.Blipamnt)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BLIPAmnt");
            entity.Property(e => e.BlipofWp)
                .HasDefaultValueSql("((0))")
                .HasColumnName("BLIPofWP");
            entity.Property(e => e.CatCode).HasMaxLength(50);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .HasColumnName("color");
            entity.Property(e => e.ComDel).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ComSho).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Comcod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("comcod");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.Ctpcode)
                .HasMaxLength(50)
                .HasColumnName("CTPCode");
            entity.Property(e => e.Ctpid)
                .HasDefaultValueSql("((0))")
                .HasColumnName("CTPID");
            entity.Property(e => e.CustomsVat).HasColumnName("CustomsVAT");
            entity.Property(e => e.DateTime)
                .HasColumnType("smalldatetime")
                .HasColumnName("Date_time");
            entity.Property(e => e.DealerPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DealerSpecialPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DealerSpecialPriceExp).HasColumnType("datetime");
            entity.Property(e => e.Discontinue).HasMaxLength(50);
            entity.Property(e => e.DiscontinueType).HasMaxLength(20);
            entity.Property(e => e.EntryDate).HasColumnType("datetime");
            entity.Property(e => e.FobpriceUsd)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FOBPriceUSD");
            entity.Property(e => e.GetCommission).HasDefaultValueSql("((0))");
            entity.Property(e => e.GetIncentive).HasDefaultValueSql("((0))");
            entity.Property(e => e.GroupName).HasMaxLength(50);
            entity.Property(e => e.GroupPrefix).HasMaxLength(10);
            entity.Property(e => e.GroupPrefixSl)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GroupPrefixSL");
            entity.Property(e => e.GroupSl).HasColumnName("GroupSL");
            entity.Property(e => e.Hchidden)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HCHidden");
            entity.Property(e => e.HpsalesTag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HPSalesTag");
            entity.Property(e => e.InActivePs)
                .HasDefaultValueSql("((0))")
                .HasColumnName("InActivePS");
            entity.Property(e => e.IncentiveAmnt).HasDefaultValueSql("((0))");
            entity.Property(e => e.IncentiveType).HasMaxLength(50);
            entity.Property(e => e.InstallmentTag).HasDefaultValueSql("((0))");
            entity.Property(e => e.Measure).HasMaxLength(50);
            entity.Property(e => e.ModelMqserial)
                .HasDefaultValueSql("((0))")
                .HasColumnName("ModelMQSerial");
            entity.Property(e => e.ModelSerial).HasMaxLength(50);
            entity.Property(e => e.Mrp)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MRP");
            entity.Property(e => e.MustSerial).HasDefaultValueSql("((0))");
            entity.Property(e => e.NameBan).HasMaxLength(200);
            entity.Property(e => e.OrderType).HasMaxLength(50);
            entity.Property(e => e.Pcategory)
                .HasMaxLength(50)
                .HasColumnName("PCategory");
            entity.Property(e => e.Pcname)
                .HasMaxLength(20)
                .HasColumnName("PCName");
            entity.Property(e => e.ProdName).HasMaxLength(255);
            entity.Property(e => e.ProdTag).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProdType).HasMaxLength(50);
            entity.Property(e => e.ProductId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ProductID");
            entity.Property(e => e.Qoh).HasColumnName("QOH");
            entity.Property(e => e.RegularDesc).HasMaxLength(20);
            entity.Property(e => e.Sctag)
                .HasDefaultValueSql("((0))")
                .HasColumnName("SCTag");
            entity.Property(e => e.SizeCapacity)
                .HasDefaultValueSql("((0))")
                .HasColumnName("Size_Capacity");
            entity.Property(e => e.SizeCapacityUnit)
                .HasMaxLength(20)
                .HasColumnName("Size_Capacity_Unit");
            entity.Property(e => e.Specification).HasColumnType("ntext");
            entity.Property(e => e.UnitPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("VAt");
            entity.Property(e => e.VatPer).HasDefaultValueSql("((0))");
            entity.Property(e => e.Wpincentive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("WPIncentive");
            entity.Property(e => e.WpminQty)
                .HasDefaultValueSql("((0))")
                .HasColumnName("WPMinQty");
            entity.Property(e => e.Wpprice)
                .HasDefaultValueSql("((0))")
                .HasColumnName("WPPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
