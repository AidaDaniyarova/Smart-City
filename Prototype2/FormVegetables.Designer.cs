
namespace Prototype2
{
    partial class FormVegetables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVegetables));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.vegetabletblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet4 = new Prototype2.LoginDataSet4();
            this.vegetable_tblTableAdapter = new Prototype2.LoginDataSet4TableAdapters.vegetable_tblTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblVegetableName = new System.Windows.Forms.Label();
            this.cmbVegetableName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetabletblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BorderThickness = 1;
            this.btnCalculate.CheckedState.Parent = this.btnCalculate;
            this.btnCalculate.CustomImages.Parent = this.btnCalculate;
            this.btnCalculate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalculate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalculate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalculate.DisabledState.Parent = this.btnCalculate;
            this.btnCalculate.FillColor = System.Drawing.Color.MediumPurple;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Lavender;
            this.btnCalculate.HoverState.Parent = this.btnCalculate;
            this.btnCalculate.Location = new System.Drawing.Point(348, 294);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.ShadowDecoration.Parent = this.btnCalculate;
            this.btnCalculate.Size = new System.Drawing.Size(232, 88);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calculation panel";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // vegetabletblBindingSource
            // 
            this.vegetabletblBindingSource.DataMember = "vegetable_tbl";
            this.vegetabletblBindingSource.DataSource = this.loginDataSet4;
            // 
            // loginDataSet4
            // 
            this.loginDataSet4.DataSetName = "LoginDataSet4";
            this.loginDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vegetable_tblTableAdapter
            // 
            this.vegetable_tblTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(776, 457);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 25;
            this.textBox1.Visible = false;
            // 
            // lblVegetableName
            // 
            this.lblVegetableName.AutoSize = true;
            this.lblVegetableName.ForeColor = System.Drawing.Color.Lavender;
            this.lblVegetableName.Location = new System.Drawing.Point(102, 187);
            this.lblVegetableName.Name = "lblVegetableName";
            this.lblVegetableName.Size = new System.Drawing.Size(220, 20);
            this.lblVegetableName.TabIndex = 27;
            this.lblVegetableName.Text = "Choose the type of Vegetable";
            // 
            // cmbVegetableName
            // 
            this.cmbVegetableName.BackColor = System.Drawing.Color.MediumPurple;
            this.cmbVegetableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbVegetableName.ForeColor = System.Drawing.Color.Lavender;
            this.cmbVegetableName.FormattingEnabled = true;
            this.cmbVegetableName.Location = new System.Drawing.Point(106, 238);
            this.cmbVegetableName.Name = "cmbVegetableName";
            this.cmbVegetableName.Size = new System.Drawing.Size(208, 33);
            this.cmbVegetableName.TabIndex = 26;
            this.cmbVegetableName.SelectedIndexChanged += new System.EventHandler(this.cmbVegetableName_SelectedIndexChanged_1);
            // 
            // FormVegetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(888, 495);
            this.Controls.Add(this.lblVegetableName);
            this.Controls.Add(this.cmbVegetableName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormVegetables";
            this.Text = "FormVegetables";
            this.Load += new System.EventHandler(this.FormVegetables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vegetabletblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private LoginDataSet4 loginDataSet4;
        private System.Windows.Forms.BindingSource vegetabletblBindingSource;
        private LoginDataSet4TableAdapters.vegetable_tblTableAdapter vegetable_tblTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblVegetableName;
        private System.Windows.Forms.ComboBox cmbVegetableName;
    }
}