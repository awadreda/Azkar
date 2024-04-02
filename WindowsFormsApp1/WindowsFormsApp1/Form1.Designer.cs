namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.nudTimerDurration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNudSave = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblConter = new System.Windows.Forms.Label();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIDForDelete = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerDurration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("001 Al Kamal Hadith", 55F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 118);
            this.label1.TabIndex = 0;
            this.label1.Text = "AZKAR";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipTitle = "ذِكر";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // nudTimerDurration
            // 
            this.nudTimerDurration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTimerDurration.Location = new System.Drawing.Point(47, 208);
            this.nudTimerDurration.Name = "nudTimerDurration";
            this.nudTimerDurration.Size = new System.Drawing.Size(74, 35);
            this.nudTimerDurration.TabIndex = 1;
            this.nudTimerDurration.ValueChanged += new System.EventHandler(this.nudTimerDurration_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("001 Al Kamal Hadith", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter The Durration";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(573, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(273, 309);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("001 Al Kamal Hadith", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(544, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "AL AZkar";
            // 
            // txtAddNew
            // 
            this.txtAddNew.Location = new System.Drawing.Point(553, 202);
            this.txtAddNew.Name = "txtAddNew";
            this.txtAddNew.Size = new System.Drawing.Size(139, 20);
            this.txtAddNew.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("001 Al Kamal Hadith", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(507, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 49);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add  a new Zekr";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("001 Al Kamal Hadith", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "in Minutes";
            // 
            // btnNudSave
            // 
            this.btnNudSave.Location = new System.Drawing.Point(148, 236);
            this.btnNudSave.Name = "btnNudSave";
            this.btnNudSave.Size = new System.Drawing.Size(62, 25);
            this.btnNudSave.TabIndex = 9;
            this.btnNudSave.Text = "Save";
            this.btnNudSave.UseVisualStyleBackColor = true;
            this.btnNudSave.Click += new System.EventHandler(this.btnNudSave_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(209, 320);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblConter
            // 
            this.lblConter.AutoSize = true;
            this.lblConter.Font = new System.Drawing.Font("001 Al Kamal Hadith", 55F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConter.ForeColor = System.Drawing.Color.Red;
            this.lblConter.Location = new System.Drawing.Point(161, 380);
            this.lblConter.Name = "lblConter";
            this.lblConter.Size = new System.Drawing.Size(84, 118);
            this.lblConter.TabIndex = 11;
            this.lblConter.Text = "0";
            // 
            // testTimer
            // 
            this.testTimer.Enabled = true;
            this.testTimer.Interval = 1000;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(410, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 33);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtIDForDelete
            // 
            this.txtIDForDelete.Location = new System.Drawing.Point(410, 468);
            this.txtIDForDelete.Mask = "00000";
            this.txtIDForDelete.Name = "txtIDForDelete";
            this.txtIDForDelete.Size = new System.Drawing.Size(48, 20);
            this.txtIDForDelete.TabIndex = 15;
            this.txtIDForDelete.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("001 Al Kamal Hadith", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(464, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(845, 665);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDForDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblConter);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnNudSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTimerDurration);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AZKAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerDurration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown nudTimerDurration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNudSave;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblConter;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox txtIDForDelete;
        private System.Windows.Forms.Label label6;
    }
}

