using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Model {
    public class Klient {

        private int id;
        private String emri;
        private String mbiemri;
        private String username;
        private String email;
        private String password;
        private String adresa;
        private String numerTelefoni;
        private Dega dega;

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public String Emri {
            get { return emri; }
            set { this.emri = value; }
        }

        public String Mbiemri {
            get { return mbiemri; }
            set { this.mbiemri = value; }
        }

        public String Username {
            get { return username; }
            set { this.username = value; }
        }

        public String Email {
            get { return email; }
            set { this.email = value; }
        }

        public String Password {
            get { return password; }
            set { this.password = value; }
        }

        public String Adresa {
            get { return adresa; }
            set { this.adresa = value; }
        }

        public String NumerTelefoni {
            get { return numerTelefoni; }
            set { this.numerTelefoni = value; }
        }

        public Dega Dega {
            get { return dega; }
            set { this.dega = value; }
        }
    }
}