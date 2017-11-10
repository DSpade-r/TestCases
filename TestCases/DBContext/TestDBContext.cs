using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCases.Models
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {
        }
        //I declare a collection of objects that is mapped to a specific table in the database
        public DbSet<TestCase> TestCases { get; set; }  //Table of cases
        public DbSet<CaseStep> CaseSteps { get; set; }  //Table of steps
    }
}
