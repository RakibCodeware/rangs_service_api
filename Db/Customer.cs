using System;
using System.Collections.Generic;

namespace RangsServiceApi.Db;

public partial class Customer
{
    public long CustAid { get; set; }

    public string? CustId { get; set; }

    public string? CustName { get; set; }

    public string? CustFatherName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? WebSite { get; set; }

    public int? Comcod { get; set; }

    public string? ContPer1 { get; set; }

    public string? ContPer2 { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public int? EId { get; set; }

    public string? Chno { get; set; }

    public DateTime? Chdate { get; set; }

    public string? Mrno { get; set; }

    public int? ProdId { get; set; }

    public double? TAmnt { get; set; }

    public DateTime? EntryDate { get; set; }

    public string? UserId { get; set; }

    public string? Profession { get; set; }

    public string? Org { get; set; }

    public string? Desg { get; set; }

    public string? CustSex { get; set; }

    public string? IdentityType { get; set; }

    public string? IdentityNo { get; set; }

    public string? CustRef { get; set; }

    public DateTime? Dob { get; set; }

    public string? Dobt { get; set; }

    public string? CustType { get; set; }

    public string? CustArea { get; set; }

    public string? CustAge { get; set; }

    public DateTime? UpdateDate { get; set; }
}
