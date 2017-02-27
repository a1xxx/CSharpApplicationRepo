using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*******************************************************************
//*                                                                 *
//*                             MIKE                                *
//*                                                                 *
//*******************************************************************

namespace groupProject
{
    public class package
    {

        public package() { }
        public int PackageId { get; set; }
        public string PkgName { get; set; }

        public string PkgStartDate { get; set; }
        public string PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public string PkgBasePrice { get; set; }
        public string PkgAgencyCommission { get; set; }
  

        public int CSVstring()
        {
            return PackageId;
        }
    }
}