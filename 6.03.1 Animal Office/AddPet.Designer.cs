namespace _6._03._1_Animal_Office
{
    partial class AddPet
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
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblReasonForAdmission = new System.Windows.Forms.Label();
            this.lblDateAdmitted = new System.Windows.Forms.Label();
            this.txtReasonForAdmission = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDateAdmitted = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Location = new System.Drawing.Point(12, 9);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(38, 13);
            this.lblEnterName.TabIndex = 0;
            this.lblEnterName.Text = "Name:";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(12, 40);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(41, 13);
            this.lblAnimal.TabIndex = 1;
            this.lblAnimal.Text = "Animal:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 82);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Weight";
            // 
            // lblReasonForAdmission
            // 
            this.lblReasonForAdmission.AutoSize = true;
            this.lblReasonForAdmission.Location = new System.Drawing.Point(12, 112);
            this.lblReasonForAdmission.Name = "lblReasonForAdmission";
            this.lblReasonForAdmission.Size = new System.Drawing.Size(112, 13);
            this.lblReasonForAdmission.TabIndex = 3;
            this.lblReasonForAdmission.Text = "Reason for Admission:";
            // 
            // lblDateAdmitted
            // 
            this.lblDateAdmitted.AutoSize = true;
            this.lblDateAdmitted.Location = new System.Drawing.Point(12, 230);
            this.lblDateAdmitted.Name = "lblDateAdmitted";
            this.lblDateAdmitted.Size = new System.Drawing.Size(77, 13);
            this.lblDateAdmitted.TabIndex = 4;
            this.lblDateAdmitted.Text = "Date Admitted:";
            // 
            // txtReasonForAdmission
            // 
            this.txtReasonForAdmission.Location = new System.Drawing.Point(131, 112);
            this.txtReasonForAdmission.Multiline = true;
            this.txtReasonForAdmission.Name = "txtReasonForAdmission";
            this.txtReasonForAdmission.Size = new System.Drawing.Size(293, 112);
            this.txtReasonForAdmission.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(293, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtAnimal
            // 
            this.txtAnimal.Location = new System.Drawing.Point(131, 37);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(293, 20);
            this.txtAnimal.TabIndex = 8;
            // 
            // nudWeight
            // 
            this.nudWeight.Location = new System.Drawing.Point(131, 80);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(293, 20);
            this.nudWeight.TabIndex = 18;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(131, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(265, 71);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit Pet";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDateAdmitted
            // 
            this.txtDateAdmitted.Location = new System.Drawing.Point(131, 230);
            this.txtDateAdmitted.Name = "txtDateAdmitted";
            this.txtDateAdmitted.Size = new System.Drawing.Size(293, 20);
            this.txtDateAdmitted.TabIndex = 20;
            // 
            // AddPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 380);
            this.Controls.Add(this.txtDateAdmitted);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.nudWeight);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtReasonForAdmission);
            this.Controls.Add(this.lblDateAdmitted);
            this.Controls.Add(this.lblReasonForAdmission);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lblEnterName);
            this.Name = "AddPet";
            this.Text = "AddPet";
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblReasonForAdmission;
        private System.Windows.Forms.Label lblDateAdmitted;
        private System.Windows.Forms.TextBox txtReasonForAdmission;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDateAdmitted;
    }
}