using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Model {
    public class Dega {

        private int id;
        private string emri;
        private string adresa;
        private string pershkrim;

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public string Emri {
            get { return emri; }
            set { this.emri = value; }
        }

        public string Adresa {
            get { return adresa; }
            set { this.adresa = value; }
        }

        public string Pershkrim {
            get { return pershkrim; }
            set { this.pershkrim = value; }
        }


    }
}