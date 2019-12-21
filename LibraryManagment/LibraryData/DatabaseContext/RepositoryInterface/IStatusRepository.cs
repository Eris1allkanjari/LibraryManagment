using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface {
    interface IStatusRepository {
        List<Status> gjejTeGjitha();
        Status gjejMeId(int id);

        int shto(Status status);

        int perditeso(Status status);

        void fshijMeId(int id);
    }
}
