using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface {
    interface IDegaRepository {

        List<Dega> gjejTeGjitha();
        Dega gjejMeId(int id);

        int shto(Dega dega);

        int perditeso(Dega dega);

        void fshijMeId(int id);


    }
}
