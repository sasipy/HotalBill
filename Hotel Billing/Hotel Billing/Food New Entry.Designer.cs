namespace Hotel_Billing
{
    partial class Food_New_Entry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.tprice = new System.Windows.Forms.TextBox();
            this.rveg = new System.Windows.Forms.RadioButton();
            this.rnonveg = new System.Windows.Forms.RadioButton();
            this.cavailability = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food New Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(51, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Food Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(51, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Food Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(5, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Food Availability";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(145, 89);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(153, 27);
            this.tname.TabIndex = 5;
            this.tname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tprice
            // 
            this.tprice.Location = new System.Drawing.Point(145, 184);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(153, 27);
            this.tprice.TabIndex = 6;
            this.tprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rveg
            // 
            this.rveg.AutoSize = true;
            this.rveg.Location = new System.Drawing.Point(145, 140);
            this.rveg.Name = "rveg";
            this.rveg.Size = new System.Drawing.Size(57, 23);
            this.rveg.TabIndex = 7;
            this.rveg.TabStop = true;
            this.rveg.Text = "Veg";
            this.rveg.UseVisualStyleBackColor = true;
            // 
            // rnonveg
            // 
            this.rnonveg.AutoSize = true;
            this.rnonveg.Location = new System.Drawing.Point(208, 140);
            this.rnonveg.Name = "rnonveg";
            this.rnonveg.Size = new System.Drawing.Size(90, 23);
            this.rnonveg.TabIndex = 8;
            this.rnonveg.TabStop = true;
            this.rnonveg.Text = "NonVeg";
            this.rnonveg.UseVisualStyleBackColor = true;
            // 
            // cavailability
            // 
            this.cavailability.FormattingEnabled = true;
            this.cavailability.Items.AddRange(new object[] {
            "M",
            "A",
            "E",
            "N",
            "MA",
            "ME",
            "MN",
            "AE",
            "AN",
            "EN",
            "MAE",
            "MAN",
            "MEN",
            "AEN"});
            this.cavailability.Location = new System.Drawing.Point(145, 237);
            this.cavailability.Name = "cavailability";
            this.cavailability.Size = new System.Drawing.Size(153, 27);
            this.cavailability.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(304, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 175);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(116, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.submit);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(242, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.delete);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(354, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "LOAD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.load);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(480, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.update);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Location = new System.Drawing.Point(618, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 35);
            this.button5.TabIndex = 15;
            this.button5.Text = "VIEW";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.view);
            // 
            // Food_New_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Billing.Properties.Resources.Hotel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 368);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cavailability);
            this.Controls.Add(this.rnonveg);
            this.Controls.Add(this.rveg);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Food_New_Entry";
            this.Text = "Food_New_Entry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.RadioButton rveg;
        private System.Windows.Forms.RadioButton rnonveg;
        private System.Windows.Forms.ComboBox cavailability;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}