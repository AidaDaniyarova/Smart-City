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
    public partial class FormVegetables : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;");

        public FormVegetables()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculation newForm = new Calculation();
            newForm.Show();
        }
        private void FormVegetables_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "loginDataSet4.vegetable_tbl". При необходимости она может быть перемещена или удалена.
            this.vegetable_tblTableAdapter.Fill(this.loginDataSet4.vegetable_tbl);
            try
            {
                string selectQuery = "SELECT * FROM vegetable_tbl";
                con.Open();
                SqlCommand command = new SqlCommand(selectQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbVegetableName.Items.Add(reader.GetString(1));
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
         private void cmbVegetableName_SelectedIndexChanged_1(object sender, EventArgs e)
         {
            con.Open();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from vegetable_tbl where vegetable_name='" + cmbVegetableName.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["vegetable_factor"].ToString();
                }
                con.Close();
            }
            finally
            {
                con.Close();
            }
        }
        
    }
}
