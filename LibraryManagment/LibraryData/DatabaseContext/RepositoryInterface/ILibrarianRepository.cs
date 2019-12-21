using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface {
    interface ILibrarianRepository {
        List<Librarian> gjejTeGjitha();
        Librarian gjejMeId(int id);

        int shto(Librarian librarian);

        int perditeso(Librarian librarian);

        void fshijMeId(int id);
    }
}
