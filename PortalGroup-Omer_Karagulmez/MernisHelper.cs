using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalGroup_Omer_Karagulmez.MernisReference;

namespace PortalGroup_Omer_Karagulmez
{
    public class MernisHelper
    {
        public static bool IDCheck(long idNumber, string name, string surname, int dateyear)
        {
            KPSPublicSoapClient dogrula = new KPSPublicSoapClient();
            return dogrula.TCKimlikNoDogrula(idNumber, name, surname, dateyear);
        }
        
    }
}