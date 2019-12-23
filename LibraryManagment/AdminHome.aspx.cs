using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagment {
    public partial class AdminHome : System.Web.UI.Page {

        LiberRepository liberRepository = new LiberRepository();
        protected void Page_Load(object sender, EventArgs e) {

            if (!Page.IsPostBack) {
                BindDataToGridView();
            }
        }

        protected void fshijLiber(object sender, GridViewDeleteEventArgs e) {

        }

        public void BindDataToGridView() {

            List<Liber> librat = liberRepository.gjejTeGjitha();
            if(librat.Count > 0) {
                libratGridView.DataSource = librat;
                libratGridView.DataBind();
            }
        }
    }
}