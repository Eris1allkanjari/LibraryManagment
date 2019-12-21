using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface {
    interface IKlientRepository {

        List<Klient> gjejTeGjitha();
        Klient gjejMeId(int id);

        int shto(Klient klient);

        int perditeso(Klient klient);

        void fshijMeId(int id);
    }
}
