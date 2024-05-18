using System;
using System.Collections.Generic;

namespace De4_Vu.Models;

public partial class SlTblCustomerList
{
    public string CustomerId { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string? TaxCode { get; set; }

    public bool IsCustomer { get; set; }

    public bool IsVendor { get; set; }

    public bool IsPersonal { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? ContactPerson { get; set; }

    public decimal DebtLimit { get; set; }

    public int NumberDayLimit { get; set; }
}
