using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Model {


    public class Karta {

        private int id;
        private decimal pagesa;
        private Klient klient;

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public decimal Pagesa {
            get { return pagesa; }
            set { this.pagesa = value; }
        }

        public Klient Klient {
            get{ return klient; }
            set{ this.klient = value; }
            }
    }
}