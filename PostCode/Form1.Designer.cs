namespace PostCode
{
    partial class Form1
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
            this.bt_zoeken = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_error = new MaterialSkin.Controls.MaterialLabel();
            this.tb_housenumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tb_zipcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_city = new MaterialSkin.Controls.MaterialLabel();
            this.lb_province = new MaterialSkin.Controls.MaterialLabel();
            this.lb_zipcode = new MaterialSkin.Controls.MaterialLabel();
            this.lb_number = new MaterialSkin.Controls.MaterialLabel();
            this.lb_streetname = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gotogoogle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.list = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tf_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_zoeken
            // 
            this.bt_zoeken.Depth = 0;
            this.bt_zoeken.Location = new System.Drawing.Point(12, 172);
            this.bt_zoeken.MouseState = MaterialSkin.MouseState.HOVER;
            this.bt_zoeken.Name = "bt_zoeken";
            this.bt_zoeken.Primary = true;
            this.bt_zoeken.Size = new System.Drawing.Size(310, 38);
            this.bt_zoeken.TabIndex = 0;
            this.bt_zoeken.Text = "Zoeken...";
            this.bt_zoeken.UseVisualStyleBackColor = true;
            this.bt_zoeken.Click += new System.EventHandler(this.bt_zoeken_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tf_name);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.lb_error);
            this.groupBox1.Controls.Add(this.tb_housenumber);
            this.groupBox1.Controls.Add(this.tb_zipcode);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zoeken";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Depth = 0;
            this.lb_error.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_error.Location = new System.Drawing.Point(7, 69);
            this.lb_error.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 19);
            this.lb_error.TabIndex = 10;
            // 
            // tb_housenumber
            // 
            this.tb_housenumber.Depth = 0;
            this.tb_housenumber.Hint = "";
            this.tb_housenumber.Location = new System.Drawing.Point(156, 84);
            this.tb_housenumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_housenumber.Name = "tb_housenumber";
            this.tb_housenumber.PasswordChar = '\0';
            this.tb_housenumber.SelectedText = "";
            this.tb_housenumber.SelectionLength = 0;
            this.tb_housenumber.SelectionStart = 0;
            this.tb_housenumber.Size = new System.Drawing.Size(148, 23);
            this.tb_housenumber.TabIndex = 9;
            this.tb_housenumber.UseSystemPasswordChar = false;
            // 
            // tb_zipcode
            // 
            this.tb_zipcode.Depth = 0;
            this.tb_zipcode.Hint = "";
            this.tb_zipcode.Location = new System.Drawing.Point(156, 55);
            this.tb_zipcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_zipcode.Name = "tb_zipcode";
            this.tb_zipcode.PasswordChar = '\0';
            this.tb_zipcode.SelectedText = "";
            this.tb_zipcode.SelectionLength = 0;
            this.tb_zipcode.SelectionStart = 0;
            this.tb_zipcode.Size = new System.Drawing.Size(148, 23);
            this.tb_zipcode.TabIndex = 6;
            this.tb_zipcode.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(2, 84);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(95, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Huisnummer";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(2, 59);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Postcode";
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.Depth = 0;
            this.lb_city.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_city.Location = new System.Drawing.Point(6, 45);
            this.lb_city.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(39, 19);
            this.lb_city.TabIndex = 3;
            this.lb_city.Text = "Stad";
            // 
            // lb_province
            // 
            this.lb_province.AutoSize = true;
            this.lb_province.Depth = 0;
            this.lb_province.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_province.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_province.Location = new System.Drawing.Point(6, 16);
            this.lb_province.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_province.Name = "lb_province";
            this.lb_province.Size = new System.Drawing.Size(71, 19);
            this.lb_province.TabIndex = 4;
            this.lb_province.Text = "Provincie";
            // 
            // lb_zipcode
            // 
            this.lb_zipcode.AutoSize = true;
            this.lb_zipcode.Depth = 0;
            this.lb_zipcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_zipcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_zipcode.Location = new System.Drawing.Point(6, 79);
            this.lb_zipcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_zipcode.Name = "lb_zipcode";
            this.lb_zipcode.Size = new System.Drawing.Size(73, 19);
            this.lb_zipcode.TabIndex = 5;
            this.lb_zipcode.Text = "Postcode";
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Depth = 0;
            this.lb_number.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_number.Location = new System.Drawing.Point(158, 113);
            this.lb_number.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(95, 19);
            this.lb_number.TabIndex = 7;
            this.lb_number.Text = "Huisnummer";
            // 
            // lb_streetname
            // 
            this.lb_streetname.AutoSize = true;
            this.lb_streetname.Depth = 0;
            this.lb_streetname.Font = new System.Drawing.Font("Roboto", 11F);
            this.lb_streetname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_streetname.Location = new System.Drawing.Point(6, 113);
            this.lb_streetname.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_streetname.Name = "lb_streetname";
            this.lb_streetname.Size = new System.Drawing.Size(86, 19);
            this.lb_streetname.TabIndex = 6;
            this.lb_streetname.Text = "Straatnaam";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gotogoogle);
            this.groupBox2.Controls.Add(this.lb_province);
            this.groupBox2.Controls.Add(this.lb_number);
            this.groupBox2.Controls.Add(this.lb_city);
            this.groupBox2.Controls.Add(this.lb_streetname);
            this.groupBox2.Controls.Add(this.lb_zipcode);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 191);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informatie";
            // 
            // gotogoogle
            // 
            this.gotogoogle.Depth = 0;
            this.gotogoogle.Location = new System.Drawing.Point(0, 153);
            this.gotogoogle.MouseState = MaterialSkin.MouseState.HOVER;
            this.gotogoogle.Name = "gotogoogle";
            this.gotogoogle.Primary = true;
            this.gotogoogle.Size = new System.Drawing.Size(310, 38);
            this.gotogoogle.TabIndex = 9;
            this.gotogoogle.Text = "Ga naar google maps";
            this.gotogoogle.UseVisualStyleBackColor = true;
            this.gotogoogle.Click += new System.EventHandler(this.gotogoogle_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 458);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(310, 21);
            this.list.TabIndex = 9;
            this.list.Text = "Geschiedenis";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(2, 24);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Onderwerp";
            // 
            // tf_name
            // 
            this.tf_name.Depth = 0;
            this.tf_name.Hint = "";
            this.tf_name.Location = new System.Drawing.Point(158, 20);
            this.tf_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.tf_name.Name = "tf_name";
            this.tf_name.PasswordChar = '\0';
            this.tf_name.SelectedText = "";
            this.tf_name.SelectionLength = 0;
            this.tf_name.SelectionStart = 0;
            this.tf_name.Size = new System.Drawing.Size(146, 23);
            this.tf_name.TabIndex = 12;
            this.tf_name.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 572);
            this.Controls.Add(this.list);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_zoeken);
            this.Name = "Form1";
            this.Text = "Straatnaam zoeker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton bt_zoeken;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_housenumber;
        private MaterialSkin.Controls.MaterialSingleLineTextField tb_zipcode;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lb_city;
        private MaterialSkin.Controls.MaterialLabel lb_province;
        private MaterialSkin.Controls.MaterialLabel lb_zipcode;
        private MaterialSkin.Controls.MaterialLabel lb_number;
        private MaterialSkin.Controls.MaterialLabel lb_streetname;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel lb_error;
        private MaterialSkin.Controls.MaterialRaisedButton gotogoogle;
        private System.Windows.Forms.ComboBox list;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField tf_name;
    }
}

