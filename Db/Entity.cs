using System;
using System.Collections.Generic;

namespace RangsServiceApi.Db;

public partial class Entity
{
    public int Eid { get; set; }

    public int? SerialNo { get; set; }

    public string EName { get; set; } = null!;

    public string? ENameBangla { get; set; }

    public string? Edesc { get; set; }

    public string? EdescBangla { get; set; }

    public string? EntityType { get; set; }

    public string? ParentEntity { get; set; }

    public string? Showroomtype { get; set; }

    public int? CommissionGet { get; set; }

    public int? SalesOrShowroom { get; set; }

    public int? ActiveDeactive { get; set; }

    public int? GroupSl { get; set; }

    public string? UserId { get; set; }

    public string? Pcname { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? SFlag { get; set; }

    public int? EnableSalesSheet { get; set; }

    public decimal? SecurityMoney { get; set; }

    public decimal? DepositedUpTo0809 { get; set; }

    public string? EntityCode { get; set; }

    public int? NoTr { get; set; }

    public int? DpInactive { get; set; }

    public string? ContactPerson { get; set; }

    public string? Desg { get; set; }

    public string? Status { get; set; }

    public string? ContactNo { get; set; }

    public int? InDhk { get; set; }

    public int? ZoneId { get; set; }

    public string? PhoneNo { get; set; }

    public string? EmailAdd { get; set; }

    public int? CorporateSale { get; set; }

    public int? ITagStock { get; set; }

    public int? SalesCenterType { get; set; }

    public string? MapLink { get; set; }

    public int? PEid { get; set; }

    public string? ReqMailTo { get; set; }
}
