using System.IO;
using System.Web.Script.Serialization;
using DAL.Entity;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class Repository
    {
        public DraftLoanRequest Deserialize(string json)
        {
            DraftLoanRequest dlr = new DraftLoanRequest();
            dynamic d = JObject.Parse(json);
            int i = d.sector.Count;
            dlr.borrower = d.borrower;
            dlr.closingdate = d.closingdate;
            dlr.countrycode = d.countrycode;
            dlr.countryname = d.countryname;

            for (int j = 0; j < i; j++)
            {
                string properyName = "sector" + (j + 1);
                dlr.AddProperty(properyName, d.GetType().GetProperty(properyName));
            }
            return dlr;
        }


        public DraftLoanRequest Get()
        {
            string path = @"C:\Users\Kate\Desktop\WorldBank\WorldBank\DAL\json.json";
            string json = File.ReadAllText(path);

            return Deserialize(json);
        }
    }
}
