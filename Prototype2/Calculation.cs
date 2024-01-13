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
using System.Configuration;

namespace Prototype2
{
	public partial class Calculation : Form
	{
		DataSet calcul;
		DataSet calc = new DataSet();
		int inc;
		int MaxRows;
		private static Calculation defaultInstance;
		SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login.mdf;Integrated Security=True;Connect Timeout=30;");
		
		public static Calculation Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Calculation();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}

				return defaultInstance;
			}
		}

		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}

		public Calculation()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
				panelTitleBar.Size = new Size(910, 100);

			}
			else
			{
				WindowState = FormWindowState.Normal;
				panelTitleBar.Size = new Size(910, 75);
			}
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}


		private void Calculation_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "loginDataSetCalculation.calculation_tbl". При необходимости она может быть перемещена или удалена.
            this.calculation_tblTableAdapter2.Fill(this.loginDataSetCalculation.calculation_tbl);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "loginDataSetCalcul.calculation_tbl". При необходимости она может быть перемещена или удалена.
            this.calculation_tblTableAdapter1.Fill(this.loginDataSetCalcul.calculation_tbl);
			DataView.DataSource = GetCalculation();
			try
			{
				string selectQuery = "SELECT * FROM vegetable_tbl";
				con.Open();
				SqlCommand command = new SqlCommand(selectQuery, con);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					cmbCropName.Items.Add(reader.GetString(1));
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			try
			{
				string selectQuery = "SELECT * FROM city_tbl";
				con.Open();
				SqlCommand command = new SqlCommand(selectQuery, con);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					comboBox1.Items.Add(reader.GetString(1));
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private DataTable GetCalculation()
		{
			DataTable dtcalculation = new DataTable();
			string conString = ConfigurationManager.ConnectionStrings["Prototype2.Properties.Settings.LoginConnectionString"].ConnectionString;
			using (SqlConnection con = new SqlConnection(conString))
			{
				using (SqlCommand cmd = new SqlCommand("SELECT * FROM calculation_tbl", con))
                {
					con.Open();
					SqlDataReader reader = cmd.ExecuteReader();
					dtcalculation.Load(reader);
                }
			}
		
			
			

			return dtcalculation;

		}


	public void NavRecords()
		{

			textBox2.Text = (string)(calcul.Tables["grade1"].Rows[inc][1]);
		}



		private void Save_Click(object sender, EventArgs e)
		{
			string strmessage = default(string);
			DialogResult dgrResult;

			strmessage = "Вы уверены что хотите сохранить данные?";
			dgrResult = MessageBox.Show(strmessage, "Данные сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


			if (dgrResult == System.Windows.Forms.DialogResult.Yes)
			{

				calc = calculate.DataModule.SaveItem();
			}
		}

		private void REnew_Click(object sender, EventArgs e)
		{
			calcul = calculate.DataModule.updtedata();
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			string strmessage = default(string);
			DialogResult dgrResult;

			strmessage = "Вы уверены что хотите удалить данные?";
			dgrResult = MessageBox.Show(strmessage, "Данные удалены", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


			if (dgrResult == System.Windows.Forms.DialogResult.Yes)
			{

				calcul = calculate.DataModule.deldata();
			}
		}

		private void Details_Click(object sender, EventArgs e)
		{
			
		}

		private void FRST_Click_1(object sender, EventArgs e)
		{
			calcul = calculate.DataModule.navigate();
			if (inc != 0)
			{
				inc = 0;
				NavRecords();
				MessageBox.Show("Первая запись");//Если, inc не равен 0, то inc=0 и выходное сообшение "Первая запись"
			}
		}

		private void PREV_Click_1(object sender, EventArgs e)
		{
			calcul = calculate.DataModule.navigate();
			if (inc > 0)
			{
				inc--;
				NavRecords();
			}
			else if (inc == -1)
			{
				MessageBox.Show("Больше записей нет");
			}
			else if (inc == 0)
			{
				MessageBox.Show("Первая запись");
			}


		}

		private void NXT_Click_1(object sender, EventArgs e)
		{
			calcul = calculate.DataModule.navigate();
			try
			{
				if (inc != MaxRows - 1)
				{
					inc++;
					NavRecords();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Строк больше нет");
			}
		}

		private void LAST_Click_1(object sender, EventArgs e)
		{
			calcul = calculate.DataModule.navigate();
			MaxRows = calcul.Tables["grade1"].Rows.Count;
			if (inc != MaxRows)
			{
				inc = MaxRows - 1;
				NavRecords();
			}
			else
			{
				MessageBox.Show("Последняя запить");
			}
		}

		private void Loading_Click(object sender, EventArgs e)
		{
			con.Open();
			try
			{
				SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from calculation_tbl", con);
				DataTable dt = new DataTable();
				sda.Fill(dt);
				calc = calculate.DataModule.GetLoad();
				DataView.DataSource = calc;
				DataView.DataMember = "calculation_tbl";
			}
			finally
            {
				con.Close();
            }
		}

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			
			
		}

        private void btnClose_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
			int j = 0;
			int[] city_value = new int[12] { 570, 470, 480, 740, 480, 250, 170, 670, 9, 330, 450, 540 };
			float fctr; //Vegetable factor
			float dwu; //daily water use
			float total = 0;
			int s = Convert.ToInt32(txtArea.Text); // area in Ha
			float effprop = float.Parse(txtEffProp.Text); //Irrigation proportion/Effective area of shade
			float ineffprop = float.Parse(txtIneffProp.Text);//Irrigation inefficiency factor
			for (int i = 1; i > 13; i++)
			{
				float cv = city_value[i] / 1000;
				fctr = float.Parse(textBox1.Text);
				dwu = fctr * s * effprop * ineffprop*cv;
				total += dwu;
			
				txtTotal.Text = total.ToString();
				textBox3.Text = dwu.ToString();

				
			}
			MessageBox.Show("Data is successfully calculated.");
		}

        private void cmbShrubdsName_SelectedIndexChanged(object sender, EventArgs e)
        {
			con.Open();
			try
			{
				SqlCommand cmd = con.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from vegetable_tbl where vegetable_name='" + cmbCropName.SelectedItem.ToString() + "'";
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

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEffProp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIneffProp_TextChanged(object sender, EventArgs e)
        {
			int j = 0;
			int[] city_value = new int[12] { 570, 470, 480, 740, 480, 250, 170, 670, 9, 330, 450, 540 };
			float fctr; //Vegetable factor
			float dwu; //daily water use
			float total = 0;
			int s = Convert.ToInt32(txtArea.Text); // area in Ha
			float effprop = float.Parse(txtEffProp.Text); //Irrigation proportion/Effective area of shade
			float ineffprop = float.Parse(txtIneffProp.Text);//Irrigation inefficiency factor
			fctr = float.Parse(textBox1.Text);


			for (int i = 1; i > 13; i++)
			{
				float cv = city_value[i] / 1000;
				
				dwu = fctr * s * effprop * ineffprop * cv;
				total += dwu;

				txtTotal.Text = total.ToString();
				if (city_value[j] == 570)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox3.Text = dwu.ToString();
				}
				if (city_value[j] == 470)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox4.Text = dwu.ToString();
				}
				if (city_value[j] == 480)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox5.Text = dwu.ToString();
				}
				if (city_value[j] == 740)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox6.Text = dwu.ToString();
				}
				if (city_value[j] == 250)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox7.Text = dwu.ToString();
				}
				if (city_value[j] == 170)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox8.Text = dwu.ToString();
				}
				if (city_value[j] == 670)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox9.Text = dwu.ToString();
				}
				if (city_value[j] == 9)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox10.Text = dwu.ToString();
				}
				if (city_value[j] == 330)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox11.Text = dwu.ToString();
				}
				if (city_value[j] == 450)
				{
					dwu = fctr * s * effprop * ineffprop * cv;
					textBox12.Text = dwu.ToString();
				}
				if (city_value[j] == 540)
				{
					dwu = fctr * s * effprop * ineffprop * city_value[j]/1000;
					textBox13.Text = dwu.ToString();
				}

			}
		}
	}
}


    


