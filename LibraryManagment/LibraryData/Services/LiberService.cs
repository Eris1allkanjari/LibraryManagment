using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Services {
    public class LiberService {

        private LiberRepository liberRepository = new LiberRepository();

        public Liber gjejMeId(int id) {
            return liberRepository.gjejMeId(id);
        }

        public List<Liber> gjejTeGjitha() {
            return liberRepository.gjejTeGjitha();
        }

        public int shto(Liber liber) {
            return liberRepository.shto(liber);
        }

        public int perditeso(Liber liber) {
            return liberRepository.perditeso(liber);
        }

        public void fshijMeId(int id) {
            liberRepository.fshijMeId(id);
        }

        public List<Liber> kerko(String fjala) {

            return liberRepository.kerko(fjala);
        }
    }
}