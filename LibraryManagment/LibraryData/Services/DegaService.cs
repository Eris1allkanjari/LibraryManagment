using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Services {
    public class DegaService {

        private DegaRepository degaRepository = new DegaRepository();

        public Dega gjejMeId(int id) {
            return degaRepository.gjejMeId(id);
        }

        public List<Dega> gjejTeGjitha() {
            return degaRepository.gjejTeGjitha();
        }

        public int shto(Dega dega) {
            return degaRepository.shto(dega);
        }

        public int perditeso(Dega dega) {
            return degaRepository.perditeso(dega);
        }

        public void fshijMeId(int id) {
            degaRepository.fshijMeId(id);
        }
    }
}