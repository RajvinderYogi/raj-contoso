using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.ModelBinding;
namespace week6
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getStudents();
        }
        protected void getStudents()
        {

            //connect to db
            var conn = new ContosoEntities();

            var Students = from s in conn.Students
                              select s;

            grdStudents.DataSource = Students.ToList();
            grdStudents.DataBind();
        }

        protected void grdStudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // function to delete department
            // determine the row clicked
            Int32 gridIndex = e.RowIndex;
            //find the department id value in selected row
            Int32 StudentID = Convert.ToInt32(grdStudents.DataKeys[gridIndex].Value);
            //connect the DB
            var conn = new ContosoEntities();

            //delete the department
            Student d = new Student();
            d.StudentID = StudentID;
            conn.Students.Attach(d);
            conn.Students.Remove(d);
            conn.SaveChanges();
            //refresh the grid view
            getStudents();
        }
    }
}