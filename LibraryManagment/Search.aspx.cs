using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagment {
    public partial class Search : System.Web.UI.Page {

        LiberService liberService = new LiberService();
        protected void Page_Load(object sender, EventArgs e) {

           
            List<Liber> librat = liberService.gjejTeGjitha();
            if (!Page.IsPostBack) {
                BindDataToGridView();
            }
        }

        protected void fshijLiber(object sender, GridViewDeleteEventArgs e) {
            GridViewRow gridViewRow = searchGridView.Rows[e.RowIndex];
            int id = int.Parse(searchGridView.DataKeys[e.RowIndex].Value.ToString());

            liberService.fshijMeId(id);

            searchGridView.EditIndex = -1;
            BindDataToGridView();
        }

        protected void libratGridView_RowUpdated(object sender, GridViewUpdatedEventArgs e) {

        }

        public void BindDataToGridView() {

            String searchWord = Server.HtmlEncode(Request.QueryString["search"]);

            List<Liber> librat = liberService.kerko(searchWord);
            if (librat.Count > 0) {
                searchGridView.DataSource = librat;
                searchGridView.DataBind();
            }
            else {
                message.Visible = true;
            }
        }
    }
}