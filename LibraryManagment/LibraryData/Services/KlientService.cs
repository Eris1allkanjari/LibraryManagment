using LibraryManagment.LibraryData.DatabaseContext;
using LibraryManagment.LibraryData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Services {
    public class KlientService {

        private KlientRepository klientRepository = new KlientRepository();

        public Klient gjejMeId(int id) {
            return klientRepository.gjejMeId(id);
        }

        public List<Klient> gjejTeGjitha() {
            return klientRepository.gjejTeGjitha();
        }

        public int shto(Klient klient) {
            return klientRepository.shto(klient);
        }

        public int perditeso(Klient klient) {
            return klientRepository.perditeso(klient);
        }

        public void fshijMeId(int id) {
            klientRepository.fshijMeId(id);
        }
    }
}