using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryManagment.LibraryData.DatabaseContext.Repository;
using LibraryManagment.LibraryData.Model;

namespace LibraryManagment {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            LiberRepository liberRepository = new LiberRepository();
            List<Liber> librat = liberRepository.gjejTeGjitha();

            Table table = new Table();

            foreach (Liber liber in librat) {
                TableRow tableRow = new TableRow();
                
                   TableCell tableCell = new TableCell();
                    tableCell.Text= liber.Autori.ToString();
                    tableRow.Cells.Add(tableCell);
                
                table.Rows.Add(tableRow);
            }

            tableForm.Controls.Add(table);

        }
    }
}