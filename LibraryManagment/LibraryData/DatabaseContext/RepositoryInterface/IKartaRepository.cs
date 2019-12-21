using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface {
    interface IKartaRepository {

        List<Karta> gjejTeGjitha();
        Karta gjejMeId(int id);

        int shto(Karta karta);

        int perditeso(Karta karta);

        void fshijMeId(int id);
    }
}
