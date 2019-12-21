using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Services {
    public class PrenotimService {

        private PrenotimRepository prenotimRepository = new PrenotimRepository();

        public Prenotim gjejMeId(int id) {
            return prenotimRepository.gjejMeId(id);
        }

        public List<Prenotim> gjejTeGjitha() {
            return prenotimRepository.gjejTeGjitha();
        }

        public int shto(Prenotim prenotim) {
            return prenotimRepository.shto(prenotim);
        }

        public int perditeso(Prenotim prenotim) {
            return prenotimRepository.perditeso(prenotim);
        }

        public void fshijMeId(int id) {
            prenotimRepository.fshijMeId(id);
        }
    }
}