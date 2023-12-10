using System;
using System.Collections.Generic;

namespace RangsServiceApi.Db;

public partial class Product
{
    public int ProductId { get; set; }

    public string Code { get; set; } = null!;

    public string? ProdName { get; set; }

    public string? NameBan { get; set; }

    public string? ModelSerial { get; set; }

    public string Model { get; set; } = null!;

    public int? ModelMqserial { get; set; }

    public int? CategoryId { get; set; }

    public string? Country { get; set; }

    public string? Measure { get; set; }

    public int? Qoh { get; set; }

    public int? ReOrder { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? UserName { get; set; }

    public DateTime? DateTime { get; set; }

    public decimal? Mrp { get; set; }

    public string? Comcod { get; set; }

    public string? Color { get; set; }

    public string? Specification { get; set; }

    public string? ProdType { get; set; }

    public decimal? Vat { get; set; }

    public decimal? ComSho { get; set; }

    public decimal? ComDel { get; set; }

    public string? Pcategory { get; set; }

    public string? GroupName { get; set; }

    public string? Discontinue { get; set; }

    public int? GroupSl { get; set; }

    public int? CustomsVat { get; set; }

    public int? ProdTag { get; set; }

    public string? UserId { get; set; }

    public string? Pcname { get; set; }

    public DateTime? EntryDate { get; set; }

    public byte? InActivePs { get; set; }

    public decimal? DealerPrice { get; set; }

    public int? Hchidden { get; set; }

    public int? GetCommission { get; set; }

    public double? VatPer { get; set; }

    public string? DiscontinueType { get; set; }

    public string? RegularDesc { get; set; }

    public double? SizeCapacity { get; set; }

    public string? SizeCapacityUnit { get; set; }

    public int? Sctag { get; set; }

    public string? ACode { get; set; }

    public int? AProductId { get; set; }

    public string? CatCode { get; set; }

    public string? Ctpcode { get; set; }

    public int? Ctpid { get; set; }

    public string? OrderType { get; set; }

    public string? GroupPrefix { get; set; }

    public int? GroupPrefixSl { get; set; }

    public decimal? FobpriceUsd { get; set; }

    public int? HpsalesTag { get; set; }

    public double? Blipamnt { get; set; }

    public double? IncentiveAmnt { get; set; }

    public bool? GetIncentive { get; set; }

    public double? Wpprice { get; set; }

    public double? BlipofWp { get; set; }

    public double? Wpincentive { get; set; }

    public int? WpminQty { get; set; }

    public string? IncentiveType { get; set; }

    public int? InstallmentTag { get; set; }

    public int? MustSerial { get; set; }

    public decimal? DealerSpecialPrice { get; set; }

    public DateTime? DealerSpecialPriceExp { get; set; }
}
