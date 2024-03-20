namespace Final_Project
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
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.doinghour = new System.Windows.Forms.TextBox();
            this.ResultCalculating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculation = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CSVfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeName
            // 
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.EmployeeName.Location = new System.Drawing.Point(648, 154);
            this.EmployeeName.Margin = new System.Windows.Forms.Padding(5);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(167, 44);
            this.EmployeeName.TabIndex = 0;
            this.EmployeeName.TextChanged += new System.EventHandler(this.EmployeeName_TextChanged);
            // 
            // doinghour
            // 
            this.doinghour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.doinghour.Location = new System.Drawing.Point(648, 233);
            this.doinghour.Margin = new System.Windows.Forms.Padding(5);
            this.doinghour.Name = "doinghour";
            this.doinghour.Size = new System.Drawing.Size(167, 44);
            this.doinghour.TabIndex = 0;
            this.doinghour.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ResultCalculating
            // 
            this.ResultCalculating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ResultCalculating.Location = new System.Drawing.Point(636, 502);
            this.ResultCalculating.Margin = new System.Windows.Forms.Padding(5);
            this.ResultCalculating.Name = "ResultCalculating";
            this.ResultCalculating.Size = new System.Drawing.Size(167, 44);
            this.ResultCalculating.TabIndex = 0;
            this.ResultCalculating.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(375, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อพนักงาน";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(375, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชั่วโมงที่ทำ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(334, 502);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "คิดออกมาเป็นเงิน";
            // 
            // calculation
            // 
            this.calculation.Location = new System.Drawing.Point(648, 310);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(155, 53);
            this.calculation.TabIndex = 2;
            this.calculation.Text = "คำนวณ";
            this.calculation.UseVisualStyleBackColor = true;
            this.calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.istockphoto_1316816913_1024x1024_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(26, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 183);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // CSVfile
            // 
            this.CSVfile.Location = new System.Drawing.Point(998, 493);
            this.CSVfile.Name = "CSVfile";
            this.CSVfile.Size = new System.Drawing.Size(155, 53);
            this.CSVfile.TabIndex = 2;
            this.CSVfile.Text = "เขียนไฟล์";
            this.CSVfile.UseVisualStyleBackColor = true;
            this.CSVfile.Click += new System.EventHandler(this.CSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources._01e70c71d32ecd084784f14b6c330815;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1405, 632);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CSVfile);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultCalculating);
            this.Controls.Add(this.doinghour);
            this.Controls.Add(this.EmployeeName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeName;
        private System.Windows.Forms.TextBox doinghour;
        private System.Windows.Forms.TextBox ResultCalculating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CSVfile;
    }
}

