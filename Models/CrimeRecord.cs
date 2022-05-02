using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class CrimeRecord
    {
        [Key]
        public Guid Id { get; set; }
        public List<Crime> results { get; set; }

    }
    //"data_year" : 2019, "offense" : "aggravated-assault", "state_abbr" : "CA", 
    public class Crime
    {
        [Key]
        public Guid id { get; set; }

        public string cleared { get; set; }
        public string actual { get; set; }
        public string data_year { get; set; }
        public string offense { get; set; }
        public string state_abbr { get; set; }
        public string data_range { get; set; }
        public CrimeRecord Crimes { get; set; }
    }
}
