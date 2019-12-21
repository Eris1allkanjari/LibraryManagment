using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Model {
    public class Status {

        private int id;
        private String emer;
        private String pershkrim;

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public String Emer {
            get { return emer; }
            set { this.emer = value; }
        }

        public String Pershkrim {
            get { return pershkrim; }
            set { this.pershkrim = value; }
        }

    }
}