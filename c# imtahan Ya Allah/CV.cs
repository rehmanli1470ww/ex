using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace c__imtahan_Ya_Allah
{
    public class Cv
    {
        public int Id { get; set; }
        public string ?Ixtisas { get; set; }
        public string? OMekteb { get; set; }
        public int UQBali{ get; set; }
        public string? Bacariqlari { get; set; }
        public string? Companies { get; set; }
        public DateTime IBTarixi { get; set; }
        public string? BDiller { get; set; }
        public string ?FDiplomu { get; set; }
        public string ?GitLink { get; set; }
        public string ?Linkedin { get; set; }
        public Cv(string? ıxtisas, string? oMekteb, int uQBali, string? bacariqlari, string? companies, DateTime ıBTarixi, string? bDiller, string fDiplomu, string gitLink, string linkedin, int id)
        {
            Ixtisas = ıxtisas;
            OMekteb = oMekteb;
            UQBali = uQBali;
            Bacariqlari = bacariqlari;
            Companies = companies;
            IBTarixi = ıBTarixi;
            BDiller = bDiller;
            FDiplomu = fDiplomu;
            GitLink = gitLink;
            Linkedin = linkedin;
            Id = id;
        }
        public override string ToString()
        {
            return "ID: "+Id+"\nIxtisas : "+Ixtisas+"\nOxudugu Mekteb : "+ OMekteb+"\nUniye qebul bali : "+ UQBali
                + "\nBacariqlari : " + Bacariqlari+ "\nCompanies : " + Companies+ "\nIse baslama tarixi : " + IBTarixi+
                "\nBildiyi diller : " + BDiller+ "\nFull diplomu : " + FDiplomu+ "\nGitLink : " + GitLink+ "\nLinkedin : " + Linkedin;
        }
    }
}
