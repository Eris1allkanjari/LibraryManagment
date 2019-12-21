using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagment.LibraryData.Services {
    public class StatusService {

        private StatusRepository statusRepository = new StatusRepository();

        public Status gjejMeId(int id) {
            return statusRepository.gjejMeId(id);
        }

        public List<Status> gjejTeGjitha() {
            return statusRepository.gjejTeGjitha();
        }

        public int shto(Status status) {
            return statusRepository.shto(status);
        }

        public int perditeso(Status status) {
            return statusRepository.perditeso(status);
        }

        public void fshijMeId(int id) {
            statusRepository.fshijMeId(id);
        }

        public void kontrolloPerVleraNull(Status status, Status newStatus) {
            if (newStatus.Emer != null) {
                status.Emer = newStatus.Emer;
            }
            if (newStatus.Pershkrim != null) {
                status.Pershkrim = newStatus.Pershkrim;
            }
        }
    }
}