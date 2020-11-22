using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData
{
    class Models
    {
    }

    public class DivCom
    {
        public int Seq { get; set; }
        public string DivCd { get; set; }
        public string DivNm { get; set; }

        public int OrderIdx { get; set; }
    }

    public class ComCode
    {
        public int Seq { get; set; }
        public string DivCd { get; set; }
        public string ComCd { get; set; }
        public string ComCdNm { get; set; }
        public int OrderIdx { get; set; }
    }
}
