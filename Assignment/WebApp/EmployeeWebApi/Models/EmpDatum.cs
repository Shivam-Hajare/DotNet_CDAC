﻿using System;
using System.Collections.Generic;

namespace EmployeeWebApi.Models;

public partial class EmpDatum
{
    public int EmployeeId { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string EmployeeCity { get; set; } = null!;

    public DateTime EmployeeDob { get; set; }

    public string EmployeeGender { get; set; } = null!;

    public decimal EmployeeSalary { get; set; }
}
