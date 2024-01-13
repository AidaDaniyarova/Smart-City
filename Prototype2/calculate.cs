
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;


namespace Prototype2
{
	public class calculate
	{
		string mDataPath;
		public static calculate DataModule;
		private static Calculation defaultInstance;


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

		private System.Data.OleDb.OleDbConnection GetConnection()
		{
			return new System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + mDataPath + "\\grade1.accdb");
		}

		public calculate(string sDatapath)
		{
			this.mDataPath = sDatapath;
			calculate.DataModule = this;

		}

		public DataSet GetLoad()
		{
			return this.GetLoad("data1");
		}

		public DataSet GetLoad(string sortfield)
		{

			System.Data.OleDb.OleDbConnection conn = GetConnection();
			DataSet ds = new DataSet();

			try
			{

				// Dim sql As String = "SELECT ID data1 as [Firstname],data2 as [Lastname],data3 as [20],data4 as [EG],data5 as [1st-10%],data6 as [50pt],data7 as [EG1],data8 as [2nd-10%],data9 as [50pts],data10 as [EG2],data11 as [20%],data12 as [100pt],data13 as [EG3],data14 as [30%],data15 as [100],data16 as [EG4],data17 as [2nd-30%],data18 as [PrelimGrade],data19 as [Remarks]FROM Table1 order by " + sortfield
				string sql = "SELECT STUDENTID,data1 AS Firstname, data2 AS Lastname," + "data3 AS 20, data4 AS EG, data5 AS [1st-10%], data6 AS 50pt," + "data7 AS EG1, data8 AS [2nd-10%], data9 AS 50pts, data10 AS EG2," + "data11 AS [20%], data12 AS 100pt, data13 AS EG3, data14 AS [30%]," + "data15 AS 100, data16 AS EG4, data17 AS [2nd-30%], data18 AS PrelimGrade," + "data19 AS Remarks FROM Table1 ORDER BY ID";

				System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
				try
				{
					da.Fill(ds, "grade1");
				}
				finally
				{
					da.Dispose();
				}
				return ds;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}
		public void RefreshDGV()
		{

			System.Data.OleDb.OleDbConnection conn = GetConnection();
			string sql = default(string);
			sql = "SELECT STUDENTID,data1 AS Firstname, data2 AS Lastname," + "data3 AS 20, data4 AS EG, data5 AS [1st-10%], data6 AS 50pt," + "data7 AS EG1, data8 AS [2nd-10%], data9 AS 50pts, data10 AS EG2," + "data11 AS [20%], data12 AS 100pt, data13 AS EG3, data14 AS [30%]," + "data15 AS 100, data16 AS EG4, data17 AS [2nd-30%], data18 AS PrelimGrade," + "data19 AS Remarks FROM Table1 ORDER BY ID";

			System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable("grade1");
			da.Fill(dt);
			Calculation.Default.DataView.DataSource = dt;
		}

		public DataSet SaveItem()
		{
			return this.SaveItem("data1");
		}
		public DataSet SaveItem(string sortfield)
		{

			System.Data.OleDb.OleDbConnection conn = GetConnection();

			try
			{

				string SQL = default(string);

				SQL = "INSERT INTO TABLE1 (STUDENTID, DATA1, DATA2, DATA3, DATA4, DATA5,DATA6, DATA7," + "DATA8, DATA9, DATA10, DATA11, DATA12, DATA13, DATA14, DATA15, DATA16, DATA17, DATA18," + "DATA19) VALUES(@STUDENTID, @DATA1, @DATA2, @DATA3, @DATA4, @DATA5,@DATA6, @DATA7,DATA8, @DATA9," + "@DATA10, @DATA11, @DATA12, @DATA13, @DATA14, @DATA15, @DATA16, @DATA17, @DATA18, @DATA19)";
				System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(SQL, conn);
				conn.Open();
				cmd.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("Новая запись была добавлена!");
				RefreshDGV();
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}

			return default(DataSet);
		}


		public DataSet deldata()
		{
			return this.deldata("data2");
		}
		public DataSet deldata(string sortfield)
		{

			System.Data.OleDb.OleDbConnection conn = GetConnection();
			DataSet ds = new DataSet();

			try
			{

				int inc;
				int MaxRows;

				//Dim sql As String = "select * from table1"
				//Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, conn)

				try
				{

					string sqldelete = default(string);
					
					System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sqldelete, conn);

					// Gets the records from the table and fills our adapter with those.
					DataTable dt = new DataTable("grade1");
					da.Fill(dt);
					MessageBox.Show("Запись была удалена");
					calculate.Default.DataView.DataSource = dt;

					RefreshDGV();

				}
				finally
				{
					//da.Dispose()
				}

				return ds;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}

		public DataSet navigate()
		{
			return this.navigate("data2");
		}
		public DataSet navigate(string sortfield)
		{

			System.Data.OleDb.OleDbConnection conn = GetConnection();
			DataSet ds = new DataSet();

			try
			{

				int inc;
				int MaxRows;

				string sql = "select * from table1";
				System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);

				try
				{
					da.Fill(ds, "grade1");
					MaxRows = ds.Tables["grade1"].Rows.Count;
					inc = -1;


				}
				finally
				{
					da.Dispose();
				}

				return ds;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
		}
		

		public DataSet updtedata()
		{
			return this.updtedata("data0");
		}
		public DataSet updtedata(string sortfield)
		{

			System.Data.OleDb.OleDbConnection conn = GetConnection();
			DataSet ds = new DataSet();

			try
			{

				string sqlupdate = default(string);
				System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(sqlupdate, conn);

				conn.Open();
				cmd.ExecuteNonQuery();
				conn.Close();
				MessageBox.Show("Запись обновлена в Базе Данных");
				RefreshDGV();

			}
			finally
			{
			}
			return ds;
		}


	}
}
