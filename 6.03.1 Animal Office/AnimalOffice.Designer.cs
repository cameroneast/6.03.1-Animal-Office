namespace _6._03._1_Animal_Office
{
    partial class AnimalOffice
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Animal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReasonForAdmission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateAdmitted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddPet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.Animal,
            this.Weight,
            this.ReasonForAdmission,
            this.DateAdmitted});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(722, 336);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Tag = "name";
            this.name.Text = "Name";
            this.name.Width = 52;
            // 
            // Animal
            // 
            this.Animal.Tag = "Animal";
            this.Animal.Text = "Animal";
            // 
            // Weight
            // 
            this.Weight.Tag = "Weight";
            this.Weight.Text = "Weight";
            // 
            // ReasonForAdmission
            // 
            this.ReasonForAdmission.Tag = "Reason for Admission";
            this.ReasonForAdmission.Text = "Reason for Admission";
            this.ReasonForAdmission.Width = 160;
            // 
            // DateAdmitted
            // 
            this.DateAdmitted.Tag = "Date Admitted";
            this.DateAdmitted.Text = "Date Admitted";
            this.DateAdmitted.Width = 132;
            // 
            // btnAddPet
            // 
            this.btnAddPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPet.Location = new System.Drawing.Point(12, 354);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(123, 64);
            this.btnAddPet.TabIndex = 1;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(141, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Write to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnimalOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.listView1);
            this.Name = "AnimalOffice";
            this.Text = "AnimalOffice";
            this.Load += new System.EventHandler(this.AnimalOffice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Animal;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.ColumnHeader ReasonForAdmission;
        private System.Windows.Forms.ColumnHeader DateAdmitted;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Button button1;
    }
}

