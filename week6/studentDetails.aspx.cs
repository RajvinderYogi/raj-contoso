using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.ModelBinding;

namespace week6
{
    public partial class studentDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //check the url for an id so we know if we are  adding or editing
                if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
                {
                    //get id from the url
                    Int32 StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
                    //connect
                    var conn = new ContosoEntities();
                    //lookup the selected student
                    var Stu = (from s in conn.Students
                               where s.StudentID == StudentID
                               select s).FirstOrDefault();
                    //populate the form
                    txtLastName.Text = Stu.LastName;
                    txtFirstName.Text = Stu.FirstMidName;
                    txtEDate.Text = Stu.EnrollmentDate.ToString();
                }
            }
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            Int32 StudentID = 0;

            if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
            {
                StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            }
            //db connection
            var conn = new ContosoEntities();

            //use the student class to create a new student object
            Student s = new Student();

            //fill the properties of new student object
            s.LastName = txtLastName.Text;
            s.FirstMidName = txtFirstName.Text;
            s.EnrollmentDate = Convert.ToDateTime(txtEDate.Text);

            //save new data to DB
            if (StudentID == 0)
            {
                conn.Students.Add(s);
            }
            else
            {
                s.StudentID = StudentID;
                conn.Students.Attach(s);
                conn.Entry(s).State = System.Data.Entity.EntityState.Modified;
            }
            conn.SaveChanges();

            //redirect to students page
            Response.Redirect("students.aspx");
        }
    }
}