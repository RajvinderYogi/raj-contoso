using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//db references
using System.Web.ModelBinding;


namespace week6
{
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //get departments and display in the gridview
            getDepartments();
        }
        protected void getDepartments()
        {
            //connect to db
            var conn = new ContosoEntities();

            var Departments = from d in conn.Departments
                              select d;

            grdDepartments.DataSource = Departments.ToList();
            grdDepartments.DataBind();
        }

        protected void grdDepartments_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // function to delete department
            // determine the row clicked
            Int32 gridIndex = e.RowIndex;
            //find the department id value in selected row
            Int32 DepartmentID = Convert.ToInt32(grdDepartments.DataKeys[gridIndex].Value);
            //connect the DB
            var conn = new ContosoEntities();

            //delete the department
            //Department objDep = (from d in conn.Departments
            //                where d.DepartmentID == DepartmentID
            //                select d).First();

            Department d = new Department();
            d.DepartmentID = DepartmentID;
            conn.Departments.Attach(d);
            conn.Departments.Remove(d);
            conn.SaveChanges();
            //refresh the grid view
            getDepartments();


        }
    }
}