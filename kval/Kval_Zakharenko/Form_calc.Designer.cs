namespace Kval_Zakharenko
{
    partial class Калькулятор
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_main = new System.Windows.Forms.TextBox();
            this.buttton_conun = new System.Windows.Forms.Button();
            this.button_disun = new System.Windows.Forms.Button();
            this.button_impl = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_disagr = new System.Windows.Forms.Button();
            this.button_A = new System.Windows.Forms.Button();
            this.button_B = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_D = new System.Windows.Forms.Button();
            this.button_levskobka = new System.Windows.Forms.Button();
            this.button_pravskobka = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(408, 654);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Розв\'язати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(139, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(692, 357);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество выражений";
            // 
            // textBox_main
            // 
            this.textBox_main.Location = new System.Drawing.Point(265, 28);
            this.textBox_main.Name = "textBox_main";
            this.textBox_main.ReadOnly = true;
            this.textBox_main.Size = new System.Drawing.Size(281, 29);
            this.textBox_main.TabIndex = 4;
            this.textBox_main.TextChanged += new System.EventHandler(this.textBox_main_TextChanged);
            // 
            // buttton_conun
            // 
            this.buttton_conun.Location = new System.Drawing.Point(258, 214);
            this.buttton_conun.Name = "buttton_conun";
            this.buttton_conun.Size = new System.Drawing.Size(82, 36);
            this.buttton_conun.TabIndex = 5;
            this.buttton_conun.Text = "conun";
            this.buttton_conun.UseVisualStyleBackColor = true;
            this.buttton_conun.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_disun
            // 
            this.button_disun.Location = new System.Drawing.Point(346, 214);
            this.button_disun.Name = "button_disun";
            this.button_disun.Size = new System.Drawing.Size(85, 36);
            this.button_disun.TabIndex = 6;
            this.button_disun.Text = "disun";
            this.button_disun.UseVisualStyleBackColor = true;
            this.button_disun.Click += new System.EventHandler(this.button_disun_Click);
            // 
            // button_impl
            // 
            this.button_impl.Location = new System.Drawing.Point(438, 214);
            this.button_impl.Name = "button_impl";
            this.button_impl.Size = new System.Drawing.Size(83, 36);
            this.button_impl.TabIndex = 7;
            this.button_impl.Text = "impl";
            this.button_impl.UseVisualStyleBackColor = true;
            this.button_impl.Click += new System.EventHandler(this.button_impl_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(527, 214);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(92, 36);
            this.button_equal.TabIndex = 8;
            this.button_equal.Text = "↔";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_disagr
            // 
            this.button_disagr.Location = new System.Drawing.Point(626, 214);
            this.button_disagr.Name = "button_disagr";
            this.button_disagr.Size = new System.Drawing.Size(84, 36);
            this.button_disagr.TabIndex = 9;
            this.button_disagr.Text = "disagr";
            this.button_disagr.UseVisualStyleBackColor = true;
            this.button_disagr.Click += new System.EventHandler(this.button_disagr_Click);
            // 
            // button_A
            // 
            this.button_A.Location = new System.Drawing.Point(265, 87);
            this.button_A.Name = "button_A";
            this.button_A.Size = new System.Drawing.Size(90, 33);
            this.button_A.TabIndex = 10;
            this.button_A.Text = "A";
            this.button_A.UseVisualStyleBackColor = true;
            this.button_A.Click += new System.EventHandler(this.button_A_Click);
            // 
            // button_B
            // 
            this.button_B.Enabled = false;
            this.button_B.Location = new System.Drawing.Point(383, 87);
            this.button_B.Name = "button_B";
            this.button_B.Size = new System.Drawing.Size(84, 33);
            this.button_B.TabIndex = 11;
            this.button_B.Text = "B";
            this.button_B.UseVisualStyleBackColor = true;
            this.button_B.Click += new System.EventHandler(this.button_B_Click);
            // 
            // button_C
            // 
            this.button_C.Enabled = false;
            this.button_C.Location = new System.Drawing.Point(491, 87);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(85, 33);
            this.button_C.TabIndex = 12;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_D
            // 
            this.button_D.Enabled = false;
            this.button_D.Location = new System.Drawing.Point(595, 87);
            this.button_D.Name = "button_D";
            this.button_D.Size = new System.Drawing.Size(87, 33);
            this.button_D.TabIndex = 13;
            this.button_D.Text = "D";
            this.button_D.UseVisualStyleBackColor = true;
            this.button_D.Click += new System.EventHandler(this.button_D_Click);
            // 
            // button_levskobka
            // 
            this.button_levskobka.Location = new System.Drawing.Point(383, 152);
            this.button_levskobka.Name = "button_levskobka";
            this.button_levskobka.Size = new System.Drawing.Size(84, 31);
            this.button_levskobka.TabIndex = 14;
            this.button_levskobka.Text = "(";
            this.button_levskobka.UseVisualStyleBackColor = true;
            this.button_levskobka.Click += new System.EventHandler(this.button_levskobka_Click);
            // 
            // button_pravskobka
            // 
            this.button_pravskobka.Location = new System.Drawing.Point(491, 152);
            this.button_pravskobka.Name = "button_pravskobka";
            this.button_pravskobka.Size = new System.Drawing.Size(85, 31);
            this.button_pravskobka.TabIndex = 15;
            this.button_pravskobka.Text = ")";
            this.button_pravskobka.UseVisualStyleBackColor = true;
            this.button_pravskobka.Click += new System.EventHandler(this.button_pravskobka_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "очистити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(571, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 41);
            this.button3.TabIndex = 18;
            this.button3.Text = "видалити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(747, 654);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(214, 45);
            this.button4.TabIndex = 19;
            this.button4.Text = "До законів матлогіки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 654);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 45);
            this.button5.TabIndex = 20;
            this.button5.Text = "Електросхеми";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Калькулятор
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_pravskobka);
            this.Controls.Add(this.button_levskobka);
            this.Controls.Add(this.button_D);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_B);
            this.Controls.Add(this.button_A);
            this.Controls.Add(this.button_disagr);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_impl);
            this.Controls.Add(this.button_disun);
            this.Controls.Add(this.buttton_conun);
            this.Controls.Add(this.textBox_main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Калькулятор";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_main;
        private System.Windows.Forms.Button buttton_conun;
        private System.Windows.Forms.Button button_disun;
        private System.Windows.Forms.Button button_impl;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_disagr;
        private System.Windows.Forms.Button button_A;
        private System.Windows.Forms.Button button_B;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_D;
        private System.Windows.Forms.Button button_levskobka;
        private System.Windows.Forms.Button button_pravskobka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

