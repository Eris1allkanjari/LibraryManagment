using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Model {
    public class Liber {

        private int id;
        private String titull;
        private String autori;
        private int viti;
        private decimal cmimi;
        private String imageUrl;

        public int Id {
            get { return id; }
            set { this.id = value; }
        }

        public String Titull {
            get { return titull; }
            set { this.titull = value; }
        }

        public String Autori {
            get { return autori; }
            set { this.autori = value; }
        }

        public int Viti {
            get { return viti; }
            set { this.viti = value; }
        }

        public decimal Cmimi {
            get { return cmimi; }
            set { this.cmimi = value; }
        }

        public String ImageUrl {
            get { return imageUrl; }
            set { this.imageUrl = value; }
        }
    }
}