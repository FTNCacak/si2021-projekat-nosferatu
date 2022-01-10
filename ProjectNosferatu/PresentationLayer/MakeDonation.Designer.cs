
namespace PresentationLayer
{
    partial class MakeDonation
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
            this.submitButton = new System.Windows.Forms.Button();
            this.bloodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.titleLable = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.bloodTypeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(28)))));
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.submitButton.Location = new System.Drawing.Point(42, 380);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(516, 45);
            this.submitButton.TabIndex = 35;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // bloodTypeComboBox
            // 
            this.bloodTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bloodTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.bloodTypeComboBox.FormattingEnabled = true;
            this.bloodTypeComboBox.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-"});
            this.bloodTypeComboBox.Location = new System.Drawing.Point(209, 278);
            this.bloodTypeComboBox.Name = "bloodTypeComboBox";
            this.bloodTypeComboBox.Size = new System.Drawing.Size(205, 45);
            this.bloodTypeComboBox.TabIndex = 32;
            // 
            // genderComboBox
            // 
            this.genderComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.genderComboBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(42, 177);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(205, 45);
            this.genderComboBox.TabIndex = 33;
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(78, 33);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(483, 81);
            this.titleLable.TabIndex = 31;
            this.titleLable.Text = "Make a donation";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ageLabel.Location = new System.Drawing.Point(348, 149);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(122, 25);
            this.ageLabel.TabIndex = 26;
            this.ageLabel.Text = "Patient name";
            // 
            // ageTextBox
            // 
            this.ageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ageTextBox.Location = new System.Drawing.Point(353, 177);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(179, 36);
            this.ageTextBox.TabIndex = 23;
            // 
            // bloodTypeLabel
            // 
            this.bloodTypeLabel.AutoSize = true;
            this.bloodTypeLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bloodTypeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bloodTypeLabel.Location = new System.Drawing.Point(204, 253);
            this.bloodTypeLabel.Name = "bloodTypeLabel";
            this.bloodTypeLabel.Size = new System.Drawing.Size(105, 25);
            this.bloodTypeLabel.TabIndex = 28;
            this.bloodTypeLabel.Text = "Blood Type";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Location = new System.Drawing.Point(37, 149);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 25);
            this.nameLabel.TabIndex = 30;
            this.nameLabel.Text = "Patient ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 46);
            this.label1.TabIndex = 36;
            this.label1.Text = "X";
            // 
            // MakeDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(614, 469);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.bloodTypeComboBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.bloodTypeLabel);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeDonation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Donation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox bloodTypeComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label bloodTypeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
    }
}