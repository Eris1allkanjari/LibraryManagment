using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using System.Collections.Generic;



namespace LibraryManagment.LibraryData.Services {
    public class KartaService {

        private KartaRepository kartaRepository = new KartaRepository();

        public Karta gjejMeId(int id) {
            return kartaRepository.gjejMeId(id);
        }

        public List<Karta> gjejTeGjitha() {
            return kartaRepository.gjejTeGjitha();
        }

        public int shto(Karta karta) {
            return kartaRepository.shto(karta);
        }

        public int perditeso(Karta karta) {
            return kartaRepository.perditeso(karta);
        }

        public void fshijMeId(int id) {
            kartaRepository.fshijMeId(id);
        }
    }
}