using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_Automation.Model;
using System.Data.SqlClient;

namespace Attendance_Automation
{
    public partial class Frm_Host : Form
    {
        Attendance_DBEntities context = new Attendance_DBEntities();
        object sizeDB;
        public Frm_Host()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetDbSize()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "data source=185.55.224.141,1433;initial catalog=develop4_Attendance_DB_Dan;User ID=develop4_daneshjooyar;Password=123456789&&&&&&dan;Network Library=dbmssocn";

            SqlCommand commnad = new SqlCommand("sp_spaceused", Conn);
            commnad.CommandType = CommandType.StoredProcedure;
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();

            SqlDataReader reader = commnad.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sizeDB = reader["database_size"];
                }
            }

        }

        private void Frm_Host_Load(object sender, EventArgs e)
        {
            GetDbSize();
            string s = sizeDB.ToString();
            string s2 = s.Replace("MB", "");
            decimal finalSize = Convert.ToDecimal(s2);

            progressBar1.Value =(int) finalSize;
            var a = 100 - finalSize;
            lbl_space.Text = "میزان فضای باقی مانده : " + a.ToString() +" "+ "مگابایت";
            lbl_used.Text = "میزان فضای استفاده شده : " + finalSize + " مگابایت";
            var q = context.Tbl_SettingApp.FirstOrDefault();
            if (q != null)
            {
                lbl_expireDate.Text = q.ExpireDate_Host;
            }

        }
    }
}
