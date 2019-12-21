using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Model {
    public class Checkout {

        private int id;
        private DateTime marrjaLibrit;
        private DateTime kthimiLibrit;
        private Karta karte;

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public DateTime MarrjaLibrit {
            get { return marrjaLibrit; }
            set { this.marrjaLibrit = value; }
        }

        public DateTime KthimiLibrit {
            get { return kthimiLibrit; }
            set { this.kthimiLibrit = value; }
        }

        public Karta Karte {
            get { return karte; }
            set { this.karte = value; }
        }

    }
}