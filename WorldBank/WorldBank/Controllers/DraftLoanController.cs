using DAL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WorldBank.Controllers
{
    public class DraftLoanController : ApiController
    {
        Repository repository = new Repository();

        // GET: api/DraftLoan
        public DraftLoanRequest Get()
        {
            return repository.Get();
        }
    }
}
