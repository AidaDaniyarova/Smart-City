using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Prototype2
{
    public partial class FormShrubs : Form
    {
        

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;");

        public FormShrubs()
        {
            InitializeComponent();

        }

        private void FormShrubs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "loginDataShrubs.shrubs_tbl". При необходимости она может быть перемещена или удалена.
            this.shrubs_tblTableAdapter.Fill(this.loginDataShrubs.shrubs_tbl);
            try
            {
                string selectQuery = "SELECT * FROM shrubs_tbl";
                con.Open();
                SqlCommand command = new SqlCommand(selectQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbShrubdsName.Items.Add(reader.GetString(1));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbShrubdsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculation newForm = new Calculation();
            newForm.Show();
        }
    }    
}
