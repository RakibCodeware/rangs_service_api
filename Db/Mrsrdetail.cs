using System;
using System.Collections.Generic;

namespace RangsServiceApi.Db;

public partial class Mrsrdetail
{
    public string? Comcod { get; set; }

    public int Mrsrdid { get; set; }

    public int? ProductId { get; set; }

    public int? Mrsrmid { get; set; }

    public double? Qty { get; set; }

    public double? UnitPrice { get; set; }

    public decimal? TotalAmnt { get; set; }

    public string? JobNmbr { get; set; }

    public int? QtyUsed { get; set; }

    public string? Purpose { get; set; }

    public string? Mrsrcode { get; set; }

    public string? Model { get; set; }

    public string? Rpcode { get; set; }

    public string? OdrNmbr { get; set; }

    public string? Origin { get; set; }

    public double? UnitPriceUsd { get; set; }

    public string? UnitName { get; set; }

    public string? BinNmbr { get; set; }

    public double? RetPrice { get; set; }

    public int? InEid { get; set; }

    public int? OutEid { get; set; }

    public string? Slno { get; set; }

    public decimal? DiscountAmnt { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? NetAmnt { get; set; }

    public string? Color { get; set; }

    public string? ProdCond { get; set; }

    public string? BarCode { get; set; }

    public string? ProdRemarks { get; set; }

    public string? DisRef { get; set; }

    public string? DisCode { get; set; }

    public decimal? WithAdjAmnt { get; set; }

    public decimal? CampDisAmnt { get; set; }

    public int? FreeWithProdId { get; set; }

    public decimal? Mrp { get; set; }

    public double? Blipamnt { get; set; }

    public double? IncentiveAmnt { get; set; }

    public string? IncentiveType { get; set; }

    public double? CustShowPrice { get; set; }

    public decimal? RedeemAmnt { get; set; }

    public decimal? NextPurchaseAmount { get; set; }

    public decimal? VatAmount { get; set; }
}
