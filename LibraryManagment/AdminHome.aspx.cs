using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagment {
    public partial class AdminHome : System.Web.UI.Page {

        LiberService liberService = new LiberService();
        protected void Page_Load(object sender, EventArgs e) {

            if (!Page.IsPostBack) {
                BindDataToGridView();
            }
        }

        protected void fshijLiber(object sender, GridViewDeleteEventArgs e) {
            GridViewRow gridViewRow = libratGridView.Rows[e.RowIndex];
            int id = int.Parse(libratGridView.DataKeys[e.RowIndex].Value.ToString());

            liberService.fshijMeId(id);

            libratGridView.EditIndex = -1;
            BindDataToGridView();
        }

        public void BindDataToGridView() {

            List<Liber> librat = liberService.gjejTeGjitha();
            if(librat.Count > 0) {
                libratGridView.DataSource = librat;
                libratGridView.DataBind();
            }
        }

        protected void libratGridView_RowUpdated(object sender, GridViewUpdatedEventArgs e) {

        }
    }
}