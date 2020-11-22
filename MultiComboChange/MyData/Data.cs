using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData
{
    public class Data : Notifier
    {
        private IList<DivCom> divComs = new List<DivCom>();
        private IList<ComCode> comCodes = new List<ComCode>();

        public Data()
        {
            divComs.Add(new DivCom()
            {
                Seq = 1,
                DivCd = "UK",
                DivNm = "United Kingdom",
                OrderIdx = 1
            });
            divComs.Add(new DivCom()
            {
                Seq = 2,
                DivCd = "US",
                DivNm = "USA",
                OrderIdx = 2
            });
            divComs.Add(new DivCom()
            {
                Seq = 3,
                DivCd="SE",
                DivNm="Sweden",
                OrderIdx=3
            });
            divComs.Add(new DivCom()
            {
                Seq = 4,
                DivCd = "KR",
                DivNm = "Korea",
                OrderIdx = 4
            });
            divComs.Add(new DivCom()
            {
                Seq = 5,
                DivCd = "00",
                DivNm = "=Country=",
                OrderIdx = 0
            });

            //

            comCodes.Add(new ComCode()
            {
                Seq = 1,
                DivCd = "UK",
                ComCd = "UK21",
                ComCdNm = "London",
                OrderIdx = 1
            });
            comCodes.Add(new ComCode()
            {
                Seq = 2,
                DivCd = "UK",
                ComCd = "UK2",
                ComCdNm = "Brimingham",
                OrderIdx = 2
            });
            comCodes.Add(new ComCode()
            {
                Seq = 3,
                DivCd = "UK",
                ComCd = "UK3",
                ComCdNm = "Glasgow",
                OrderIdx = 3
            });

            comCodes.Add(new ComCode()
            {
                Seq = 4,
                DivCd = "US",
                ComCd = "US1",
                ComCdNm = "Los Angeles",
                OrderIdx = 1
            });
            comCodes.Add(new ComCode()
            {
                Seq = 5,
                DivCd = "US",
                ComCd = "US2",
                ComCdNm = "New York",
                OrderIdx = 2
            });
            comCodes.Add(new ComCode()
            {
                Seq = 6,
                DivCd = "US",
                ComCd = "US3",
                ComCdNm = "Washington",
                OrderIdx = 3
            });

            comCodes.Add(new ComCode()
            {
                Seq = 7,
                DivCd = "SE",
                ComCd = "SE1",
                ComCdNm = "Stockholm",
                OrderIdx = 1
            });
            comCodes.Add(new ComCode()
            {
                Seq = 8,
                DivCd = "SE",
                ComCd = "SE2",
                ComCdNm = "Goteborg",
                OrderIdx = 2
            });
            comCodes.Add(new ComCode()
            {
                Seq = 9,
                DivCd = "SE",
                ComCd = "SE3",
                ComCdNm = "Malmo",
                OrderIdx = 3
            });

            comCodes.Add(new ComCode()
            {
                Seq = 10,
                DivCd = "KR",
                ComCd = "KR1",
                ComCdNm = "Seoul",
                OrderIdx = 1
            });
            comCodes.Add(new ComCode()
            {
                Seq = 11,
                DivCd = "KR",
                ComCd = "KR2",
                ComCdNm = "Busan",
                OrderIdx = 2
            });
            comCodes.Add(new ComCode()
            {
                Seq = 12,
                DivCd = "KR",
                ComCd = "KR3",
                ComCdNm = "Daegu",
                OrderIdx = 3
            });
        }
        public IEnumerable<DivCom> GetAllDivCom()
        {
            return divComs.OrderBy(o => o.OrderIdx);
        }
        public IEnumerable<ComCode> FindComCode(string divCd)
        {
            return comCodes.Where(w => w.DivCd.Equals(divCd)).OrderBy(o => o.OrderIdx);
        }
        public List<DivCom> AllDivCom
        {
            get
            {
                return divComs.OrderBy(o => o.OrderIdx).ToList();
            }
        }
        private DivCom selectedDivCom;
        public DivCom SelectedDivCom
        {
            get { return selectedDivCom; }
            set
            {
                selectedDivCom = value;
                OnPropertyChanged("SelectedDivCom");

                RelatedComCode = comCodes.Where(w => w.DivCd.Equals(
                    SelectedDivCom.DivCd)).OrderBy(o => o.OrderIdx).ToList();
                OnPropertyChanged("RelatedComCode");
            }
        }
        public List<ComCode> RelatedComCode
        {
            get;
            set;
        }
        private ComCode selectedComCode;
        public ComCode SelectedComCode
        {
            get { return selectedComCode; }
            set
            {
                selectedComCode = value;
                OnPropertyChanged("SelectedComCode");
                if(selectedComCode != null)
                {
                    SelectedText = string.Format("[{0} : {1}]", selectedComCode.ComCd,
                        SelectedComCode.ComCdNm);
                }
                else
                {
                    SelectedText = "";
                }
                OnPropertyChanged("SelectedText");
            }
        }
        public string SelectedText
        {
            get; set;
        }
    }
}
