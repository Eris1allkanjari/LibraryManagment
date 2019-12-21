using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Services {
    public class CheckoutService {

        private CheckoutRepository checkoutRepository = new CheckoutRepository();

        public Checkout gjejMeId(int id) {
            return checkoutRepository.gjejMeId(id);
        }

        public List<Checkout> gjejTeGjitha() {
            return checkoutRepository.gjejTeGjitha();
        }

        public int shto(Checkout checkout) {
            return checkoutRepository.shto(checkout);
        }

        public int perditeso(Checkout checkout) {
            return checkoutRepository.perditeso(checkout);
        }

        public void fshijMeId(int id) {
            checkoutRepository.fshijMeId(id);
        }





    }
}