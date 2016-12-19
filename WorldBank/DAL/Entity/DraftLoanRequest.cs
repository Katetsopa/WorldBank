using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DAL.Entity
{
    public class DraftLoanBasic : DynamicObject
    {
        public string borrower { get; set; }
        public DateTime closingdate { get; set; }
        public string countrycode { get; set; }
        public string countryname { get; set; }
        public List<ProjectDoc> projectdocs { get; set; }
        public Sector sector { get; set; }
    }


    public class DraftLoanRequest : DraftLoanBasic
    {
        Dictionary<string, object> dynamicProperties = new Dictionary<string, object>();

        public void AddProperty(string key, object value)
        {
            dynamicProperties[key] = value;
        }

    }
}
