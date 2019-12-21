using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Services {
    public class LibrarianService {

        private LibrarianRepository librarianRepository = new LibrarianRepository();

        public Librarian gjejMeId(int id) {
            return librarianRepository.gjejMeId(id);
        }

        public List<Librarian> gjejTeGjitha() {
            return librarianRepository.gjejTeGjitha();
        }

        public int shto(Librarian librarian) {
            return librarianRepository.shto(librarian);
        }

        public int perditeso(Librarian librarian) {
            return librarianRepository.perditeso(librarian);
        }

        public void fshijMeId(int id) {
            librarianRepository.fshijMeId(id);
        }
    }
}