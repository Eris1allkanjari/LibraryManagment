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
                LidhTeDhenatMeGridView();
            }
        }

        protected void fshijLiber(object sender, GridViewDeleteEventArgs e) {
            GridViewRow gridViewRow = libratGridView.Rows[e.RowIndex];
            int id = int.Parse(libratGridView.DataKeys[e.RowIndex].Value.ToString());

            liberService.fshijMeId(id);

            libratGridView.EditIndex = -1;
            LidhTeDhenatMeGridView();
        }

        public void LidhTeDhenatMeGridView() {

            List<Liber> librat = liberService.gjejTeGjitha();
            if(librat.Count > 0) {
                libratGridView.DataSource = librat;
                libratGridView.DataBind();
            } 
            else {
                message.Visible = true;
            }
        }

        protected void libratGridView_RowUpdate(object sender, GridViewUpdateEventArgs e) {
            GridViewRow gridViewRow = libratGridView.Rows[e.RowIndex];
            int id = int.Parse(libratGridView.DataKeys[e.RowIndex].Value.ToString());
            TextBox imageUrl = (TextBox)gridViewRow.Cells[0].Controls[0];
            TextBox titull = (TextBox)gridViewRow.Cells[1].Controls[0];
            TextBox autori = (TextBox)gridViewRow.Cells[2].Controls[0];
            TextBox viti = (TextBox)gridViewRow.Cells[3].Controls[0];
            TextBox cmimi = (TextBox)gridViewRow.Cells[4].Controls[0];

            Liber liber = new Liber();
            liber.Id = id;
            liber.ImageUrl = imageUrl.Text;
            liber.Titull = titull.Text;
            liber.Autori = autori.Text;
            liber.Viti = int.Parse(viti.Text);
            liber.Cmimi = int.Parse(cmimi.Text);
            liber.ImageUrl = imageUrl.Text;

            liberService.perditeso(liber);



        }

        protected void libratGridView_RowEditing(object sender, GridViewEditEventArgs e) {

            libratGridView.EditIndex = e.NewEditIndex;
            LidhTeDhenatMeGridView();
        }

        protected void libratGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e) {

        }
    }
}