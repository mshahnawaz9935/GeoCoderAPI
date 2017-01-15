using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeoCoder1.Models
{
    public class Townlands
    {
        [Key]
        public string X { get; set; }
        public string Y { get; set; }
        public string OBJECTID { get; set; }
        public string County { get; set; }
        public string Contae { get; set; }
        public string Classification { get; set; }
        public string Local_Government_Area { get; set; }
        public long id { get; set; }
        public string English_name { get; set; }
        public string IG_E { get; set; }
        public string IG_N { get; set; }
        public string ITM_E { get; set; }
        public string ITM_N { get; set; }
        public string Validated_By { get; set; }
    }
}