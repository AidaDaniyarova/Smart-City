
namespace Prototype2
{
    partial class FormGrass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrass));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.txtIneffProp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFactor = new System.Windows.Forms.Label();
            this.txtEffProp = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblProp = new System.Windows.Forms.Label();
            this.txtArea = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblShrubsName = new System.Windows.Forms.Label();
            this.cmbShrubdsName = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(731, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 25;
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
            this.btnCalculate.Location = new System.Drawing.Point(408, 355);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.ShadowDecoration.Parent = this.btnCalculate;
            this.btnCalculate.Size = new System.Drawing.Size(180, 45);
            this.btnCalculate.TabIndex = 24;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
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
            this.txtIneffProp.Location = new System.Drawing.Point(347, 264);
            this.txtIneffProp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIneffProp.Name = "txtIneffProp";
            this.txtIneffProp.PasswordChar = '\0';
            this.txtIneffProp.PlaceholderText = "";
            this.txtIneffProp.SelectedText = "";
            this.txtIneffProp.ShadowDecoration.Parent = this.txtIneffProp;
            this.txtIneffProp.Size = new System.Drawing.Size(208, 40);
            this.txtIneffProp.TabIndex = 23;
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            this.lblFactor.ForeColor = System.Drawing.Color.Lavender;
            this.lblFactor.Location = new System.Drawing.Point(343, 241);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(198, 20);
            this.lblFactor.TabIndex = 22;
            this.lblFactor.Text = "Irrigation inefficiency factor";
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
            this.txtEffProp.Location = new System.Drawing.Point(347, 192);
            this.txtEffProp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEffProp.Name = "txtEffProp";
            this.txtEffProp.PasswordChar = '\0';
            this.txtEffProp.PlaceholderText = "";
            this.txtEffProp.SelectedText = "";
            this.txtEffProp.ShadowDecoration.Parent = this.txtEffProp;
            this.txtEffProp.Size = new System.Drawing.Size(208, 40);
            this.txtEffProp.TabIndex = 21;
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.ForeColor = System.Drawing.Color.Lavender;
            this.lblProp.Location = new System.Drawing.Point(343, 169);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(315, 20);
            this.lblProp.TabIndex = 20;
            this.lblProp.Text = "Irrigation proportion/Effective area of shade";
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
            this.txtArea.Location = new System.Drawing.Point(58, 264);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtArea.Name = "txtArea";
            this.txtArea.PasswordChar = '\0';
            this.txtArea.PlaceholderText = "";
            this.txtArea.SelectedText = "";
            this.txtArea.ShadowDecoration.Parent = this.txtArea;
            this.txtArea.Size = new System.Drawing.Size(208, 40);
            this.txtArea.TabIndex = 19;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.ForeColor = System.Drawing.Color.Lavender;
            this.lblArea.Location = new System.Drawing.Point(54, 241);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 20);
            this.lblArea.TabIndex = 18;
            this.lblArea.Text = "Area planted";
            // 
            // lblShrubsName
            // 
            this.lblShrubsName.AutoSize = true;
            this.lblShrubsName.ForeColor = System.Drawing.Color.Lavender;
            this.lblShrubsName.Location = new System.Drawing.Point(54, 169);
            this.lblShrubsName.Name = "lblShrubsName";
            this.lblShrubsName.Size = new System.Drawing.Size(190, 20);
            this.lblShrubsName.TabIndex = 15;
            this.lblShrubsName.Text = "Choose the type of Grass";
            // 
            // cmbShrubdsName
            // 
            this.cmbShrubdsName.BackColor = System.Drawing.Color.MediumPurple;
            this.cmbShrubdsName.DisplayMember = "shrubs_name";
            this.cmbShrubdsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbShrubdsName.ForeColor = System.Drawing.Color.Lavender;
            this.cmbShrubdsName.FormattingEnabled = true;
            this.cmbShrubdsName.Location = new System.Drawing.Point(58, 199);
            this.cmbShrubdsName.Name = "cmbShrubdsName";
            this.cmbShrubdsName.Size = new System.Drawing.Size(208, 33);
            this.cmbShrubdsName.TabIndex = 14;
            this.cmbShrubdsName.ValueMember = "shrubs_id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormGrass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(888, 495);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtIneffProp);
            this.Controls.Add(this.lblFactor);
            this.Controls.Add(this.txtEffProp);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblShrubsName);
            this.Controls.Add(this.cmbShrubdsName);
            this.Name = "FormGrass";
            this.Text = "FormGrass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private Guna.UI2.WinForms.Guna2TextBox txtIneffProp;
        private System.Windows.Forms.Label lblFactor;
        private Guna.UI2.WinForms.Guna2TextBox txtEffProp;
        private System.Windows.Forms.Label lblProp;
        private Guna.UI2.WinForms.Guna2TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblShrubsName;
        private System.Windows.Forms.ComboBox cmbShrubdsName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}