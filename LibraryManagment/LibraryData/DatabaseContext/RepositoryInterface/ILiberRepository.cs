using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface {
    interface ILiberRepository {

        List<Liber> gjejTeGjitha();
        Liber gjejMeId(int id);

        int shto(Liber liber);

        int perditeso(Liber liber);

        void fshijMeId(int id);

        List<Liber> kerko(String fjala);
    }
}
