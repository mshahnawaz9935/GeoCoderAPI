using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GeoCoder1.Models
{
    public class GeoCoderContext : DbContext
    {
            public GeoCoderContext() : base()
            {
                Database.SetInitializer<GeoCoderContext>(null);
            }

            public System.Data.Entity.DbSet<GeoCoder1.Models.Townlands> Townlands { get; set; }
           // public System.Data.Entity.DbSet<DIS.Automation.API.Models.SearchQueries> SearchQueries { get; set; }
        }
    }