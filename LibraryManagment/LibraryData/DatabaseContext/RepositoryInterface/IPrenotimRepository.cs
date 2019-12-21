using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface {
    interface IPrenotimRepository {

        List<Prenotim> gjejTeGjitha();
        Prenotim gjejMeId(int id);

        int shto(Prenotim prenotim);

        int perditeso(Prenotim prenotim);

        void fshijMeId(int id);
    }
}
