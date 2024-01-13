
namespace Prototype2
{
    partial class FormShrubs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShrubs));
            this.cmbShrubdsName = new System.Windows.Forms.ComboBox();
            this.shrubstblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataShrubs = new Prototype2.LoginDataShrubs();
            this.shrubs_tblTableAdapter = new Prototype2.LoginDataShrubsTableAdapters.shrubs_tblTableAdapter();
            this.lblShrubsName = new System.Windows.Forms.Label();
            this.cmbPlantedMonth = new System.Windows.Forms.ComboBox();
            this.lblPalntedData = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEffProp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProp = new System.Windows.Forms.Label();
            this.txtIneffProp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFactor = new System.Windows.Forms.Label();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbShrubfactor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.shrubstblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataShrubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbShrubdsName
            // 
            this.cmbShrubdsName.BackColor = System.Drawing.Color.MediumPurple;
            this.cmbShrubdsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbShrubdsName.ForeColor = System.Drawing.Color.Lavender;
            this.cmbShrubdsName.FormattingEnabled = true;
            this.cmbShrubdsName.Location = new System.Drawing.Point(53, 239);
            this.cmbShrubdsName.Name = "cmbShrubdsName";
            this.cmbShrubdsName.Size = new System.Drawing.Size(208, 33);
            this.cmbShrubdsName.TabIndex = 0;
            this.cmbShrubdsName.SelectedIndexChanged += new System.EventHandler(this.cmbShrubdsName_SelectedIndexChanged);
            // 
            // shrubstblBindingSource
            // 
            this.shrubstblBindingSource.DataMember = "shrubs_tbl";
            this.shrubstblBindingSource.DataSource = this.loginDataShrubs;
            // 
            // loginDataShrubs
            // 
            this.loginDataShrubs.DataSetName = "LoginDataShrubs";
            this.loginDataShrubs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shrubs_tblTableAdapter
            // 
            this.shrubs_tblTableAdapter.ClearBeforeFill = true;
            // 
            // lblShrubsName
            // 
            this.lblShrubsName.AutoSize = true;
            this.lblShrubsName.ForeColor = System.Drawing.Color.Lavender;
            this.lblShrubsName.Location = new System.Drawing.Point(49, 209);
            this.lblShrubsName.Name = "lblShrubsName";
            this.lblShrubsName.Size = new System.Drawing.Size(190, 20);
            this.lblShrubsName.TabIndex = 1;
            this.lblShrubsName.Text = "Choose the type of Shrub";
            // 
            // cmbPlantedMonth
            // 
            this.cmbPlantedMonth.BackColor = System.Drawing.Color.MediumPurple;
            this.cmbPlantedMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbPlantedMonth.ForeColor = System.Drawing.Color.Lavender;
            this.cmbPlantedMonth.FormattingEnabled = true;
            this.cmbPlantedMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmbPlantedMonth.Location = new System.Drawing.Point(53, 320);
            this.cmbPlantedMonth.Name = "cmbPlantedMonth";
            this.cmbPlantedMonth.Size = new System.Drawing.Size(208, 33);
            this.cmbPlantedMonth.TabIndex = 2;
            // 
            // lblPalntedData
            // 
            this.lblPalntedData.AutoSize = true;
            this.lblPalntedData.ForeColor = System.Drawing.Color.Lavender;
            this.lblPalntedData.Location = new System.Drawing.Point(49, 288);
            this.lblPalntedData.Name = "lblPalntedData";
            this.lblPalntedData.Size = new System.Drawing.Size(161, 20);
            this.lblPalntedData.TabIndex = 3;
            this.lblPalntedData.Text = "When it was planted?";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(162, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(597, 186);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ForeColor = System.Drawing.Color.Lavender;
            this.lblArea.Location = new System.Drawing.Point(49, 372);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 20);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area planted";
            // 
            // txtArea
            // 
            this.txtArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArea.DefaultText = "";
            this.txtArea.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArea.DisabledState.Parent = this.txtArea;
            this.txtArea.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArea.FillColor = System.Drawing.Color.MediumPurple;
            this.txtArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArea.FocusedState.Parent = this.txtArea;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtArea.ForeColor = System.Drawing.Color.Lavender;
            this.txtArea.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArea.HoverState.Parent = this.txtArea;
            this.txtArea.Location = new System.Drawing.Point(53, 395);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtArea.Name = "txtArea";
            this.txtArea.PasswordChar = '\0';
            this.txtArea.PlaceholderText = "";
            this.txtArea.SelectedText = "";
            this.txtArea.ShadowDecoration.Parent = this.txtArea;
            this.txtArea.Size = new System.Drawing.Size(208, 40);
            this.txtArea.TabIndex = 7;
            // 
            // txtEffProp
            // 
            this.txtEffProp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEffProp.DefaultText = "";
            this.txtEffProp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEffProp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEffProp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEffProp.DisabledState.Parent = this.txtEffProp;
            this.txtEffProp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEffProp.FillColor = System.Drawing.Color.MediumPurple;
            this.txtEffProp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEffProp.FocusedState.Parent = this.txtEffProp;
            this.txtEffProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEffProp.ForeColor = System.Drawing.Color.Lavender;
            this.txtEffProp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEffProp.HoverState.Parent = this.txtEffProp;
            this.txtEffProp.Location = new System.Drawing.Point(342, 232);
            this.txtEffProp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEffProp.Name = "txtEffProp";
            this.txtEffProp.PasswordChar = '\0';
            this.txtEffProp.PlaceholderText = "";
            this.txtEffProp.SelectedText = "";
            this.txtEffProp.ShadowDecoration.Parent = this.txtEffProp;
            this.txtEffProp.Size = new System.Drawing.Size(208, 40);
            this.txtEffProp.TabIndex = 9;
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.ForeColor = System.Drawing.Color.Lavender;
            this.lblProp.Location = new System.Drawing.Point(338, 209);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(315, 20);
            this.lblProp.TabIndex = 8;
            this.lblProp.Text = "Irrigation proportion/Effective area of shade";
            // 
            // txtIneffProp
            // 
            this.txtIneffProp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIneffProp.DefaultText = "";
            this.txtIneffProp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIneffProp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIneffProp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIneffProp.DisabledState.Parent = this.txtIneffProp;
            this.txtIneffProp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIneffProp.FillColor = System.Drawing.Color.MediumPurple;
            this.txtIneffProp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIneffProp.FocusedState.Parent = this.txtIneffProp;
            this.txtIneffProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIneffProp.ForeColor = System.Drawing.Color.Lavender;
            this.txtIneffProp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIneffProp.HoverState.Parent = this.txtIneffProp;
            this.txtIneffProp.Location = new System.Drawing.Point(342, 304);
            this.txtIneffProp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIneffProp.Name = "txtIneffProp";
            this.txtIneffProp.PasswordChar = '\0';
            this.txtIneffProp.PlaceholderText = "";
            this.txtIneffProp.SelectedText = "";
            this.txtIneffProp.ShadowDecoration.Parent = this.txtIneffProp;
            this.txtIneffProp.Size = new System.Drawing.Size(208, 40);
            this.txtIneffProp.TabIndex = 11;
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            this.lblFactor.ForeColor = System.Drawing.Color.Lavender;
            this.lblFactor.Location = new System.Drawing.Point(338, 281);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(198, 20);
            this.lblFactor.TabIndex = 10;
            this.lblFactor.Text = "Irrigation inefficiency factor";
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
            this.btnCalculate.Location = new System.Drawing.Point(403, 395);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.ShadowDecoration.Parent = this.btnCalculate;
            this.btnCalculate.Size = new System.Drawing.Size(180, 45);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(726, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // cmbShrubfactor
            // 
            this.cmbShrubfactor.FormattingEnabled = true;
            this.cmbShrubfactor.Location = new System.Drawing.Point(662, 244);
            this.cmbShrubfactor.Name = "cmbShrubfactor";
            this.cmbShrubfactor.Size = new System.Drawing.Size(121, 28);
            this.cmbShrubfactor.TabIndex = 14;
            this.cmbShrubfactor.Visible = false;
            // 
            // FormShrubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(888, 495);
            this.Controls.Add(this.cmbShrubfactor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtIneffProp);
            this.Controls.Add(this.lblFactor);
            this.Controls.Add(this.txtEffProp);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblPalntedData);
            this.Controls.Add(this.cmbPlantedMonth);
            this.Controls.Add(this.lblShrubsName);
            this.Controls.Add(this.cmbShrubdsName);
            this.Name = "FormShrubs";
            this.Text = "FormShrubs";
            this.Load += new System.EventHandler(this.FormShrubs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shrubstblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataShrubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShrubdsName;
        private LoginDataShrubs loginDataShrubs;
        private System.Windows.Forms.BindingSource shrubstblBindingSource;
        private LoginDataShrubsTableAdapters.shrubs_tblTableAdapter shrubs_tblTableAdapter;
        private System.Windows.Forms.Label lblShrubsName;
        private System.Windows.Forms.ComboBox cmbPlantedMonth;
        private System.Windows.Forms.Label lblPalntedData;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblArea;
        private Guna.UI2.WinForms.Guna2TextBox txtArea;
        private Guna.UI2.WinForms.Guna2TextBox txtEffProp;
        private System.Windows.Forms.Label lblProp;
        private Guna.UI2.WinForms.Guna2TextBox txtIneffProp;
        private System.Windows.Forms.Label lblFactor;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbShrubfactor;
    }
}