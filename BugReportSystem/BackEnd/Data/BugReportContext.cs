﻿using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class BugReportContext : DbContext
    {
        public DbSet<BugReport> BugReports { get; set; }
    }
}
