using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Model {
    public class Prenotim {

        private int id;
        private Liber liber;
        private Karta karta;
        private DateTime vendosjaPrenotimit;

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public Liber Liber {
            get { return liber; }
            set { this.liber = value; }
        }

        public Karta Karta {
            get { return karta; }
            set { this.karta = value; }
        }

        public DateTime VendosjaPrenotimit {
            get { return vendosjaPrenotimit; }
            set { this.vendosjaPrenotimit = value; }
        }

    }


}