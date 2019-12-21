using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment.LibraryData.DatabaseContext.RepositoryInterface {
    interface ICheckoutRepository {
        List<Checkout> gjejTeGjitha();
        Checkout gjejMeId(int id);

        int shto(Checkout checkout);

        int perditeso(Checkout checkout);

        void fshijMeId(int id);
    }
}
