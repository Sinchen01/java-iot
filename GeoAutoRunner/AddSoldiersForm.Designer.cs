namespace GeoAutoRunner
{
    partial class AddSoldierorm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSoldierorm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PicSearch = new System.Windows.Forms.PictureBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtOrigin = new System.Windows.Forms.TextBox();
            this.TxtGeo = new System.Windows.Forms.TextBox();
            this.TxtSoldiersName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PicSearch);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.TxtOrigin);
            this.groupBox1.Controls.Add(this.TxtGeo);
            this.groupBox1.Controls.Add(this.TxtSoldiersName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // PicSearch
            // 
            this.PicSearch.Image = ((System.Drawing.Image)(resources.GetObject("PicSearch.Image")));
            this.PicSearch.Location = new System.Drawing.Point(279, 52);
            this.PicSearch.Name = "PicSearch";
            this.PicSearch.Size = new System.Drawing.Size(37, 35);
            this.PicSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSearch.TabIndex = 7;
            this.PicSearch.TabStop = false;
            this.PicSearch.Click += new System.EventHandler(this.PicSearch_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.LightBlue;
            this.BtnSave.Location = new System.Drawing.Point(259, 203);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 34);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtOrigin
            // 
            this.TxtOrigin.Location = new System.Drawing.Point(23, 169);
            this.TxtOrigin.Name = "TxtOrigin";
            this.TxtOrigin.Size = new System.Drawing.Size(194, 24);
            this.TxtOrigin.TabIndex = 5;
            // 
            // TxtGeo
            // 
            this.TxtGeo.Location = new System.Drawing.Point(23, 112);
            this.TxtGeo.Name = "TxtGeo";
            this.TxtGeo.Size = new System.Drawing.Size(121, 24);
            this.TxtGeo.TabIndex = 4;
            // 
            // TxtSoldiersName
            // 
            this.TxtSoldiersName.Location = new System.Drawing.Point(23, 52);
            this.TxtSoldiersName.Name = "TxtSoldiersName";
            this.TxtSoldiersName.Size = new System.Drawing.Size(249, 24);
            this.TxtSoldiersName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Camp location(Origin eg:72.8973,27.8937)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geo Distance from origin( In Kms )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soilder name";
            // 
            // AddSoldierorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 277);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSoldierorm";
            this.Text = "Add Soilder Form";
            this.Load += new System.EventHandler(this.AddPatientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtOrigin;
        private System.Windows.Forms.TextBox TxtGeo;
        private System.Windows.Forms.TextBox TxtSoldiersName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicSearch;
    }
}