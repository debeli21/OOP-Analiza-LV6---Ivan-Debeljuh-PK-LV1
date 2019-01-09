namespace Zad2
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
            this.label1 = new System.Windows.Forms.Label();
            this.counter_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pojam_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.char_tb = new System.Windows.Forms.TextBox();
            this.provjera_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cijeli_tb = new System.Windows.Forms.TextBox();
            this.prijedlog_btn = new System.Windows.Forms.Button();
            this.sljedeci_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Broj preostalih pokušaja:";
            // 
            // counter_lbl
            // 
            this.counter_lbl.AutoSize = true;
            this.counter_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.counter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.counter_lbl.Location = new System.Drawing.Point(104, 77);
            this.counter_lbl.Name = "counter_lbl";
            this.counter_lbl.Size = new System.Drawing.Size(85, 93);
            this.counter_lbl.TabIndex = 1;
            this.counter_lbl.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(429, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pojam koji se traži:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.counter_lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pojam_lbl
            // 
            this.pojam_lbl.AutoSize = true;
            this.pojam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pojam_lbl.Location = new System.Drawing.Point(431, 115);
            this.pojam_lbl.Name = "pojam_lbl";
            this.pojam_lbl.Size = new System.Drawing.Size(0, 76);
            this.pojam_lbl.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(167, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unesi slovo: ";
            // 
            // char_tb
            // 
            this.char_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.char_tb.Location = new System.Drawing.Point(365, 317);
            this.char_tb.MaxLength = 1;
            this.char_tb.Name = "char_tb";
            this.char_tb.Size = new System.Drawing.Size(76, 38);
            this.char_tb.TabIndex = 6;
            // 
            // provjera_btn
            // 
            this.provjera_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.provjera_btn.Location = new System.Drawing.Point(491, 319);
            this.provjera_btn.Name = "provjera_btn";
            this.provjera_btn.Size = new System.Drawing.Size(100, 39);
            this.provjera_btn.TabIndex = 7;
            this.provjera_btn.Text = "Provjeri";
            this.provjera_btn.UseVisualStyleBackColor = true;
            this.provjera_btn.Click += new System.EventHandler(this.provjera_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Prijedlog cijelog pojma:";
            // 
            // cijeli_tb
            // 
            this.cijeli_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cijeli_tb.Location = new System.Drawing.Point(350, 382);
            this.cijeli_tb.Name = "cijeli_tb";
            this.cijeli_tb.Size = new System.Drawing.Size(208, 38);
            this.cijeli_tb.TabIndex = 9;
            // 
            // prijedlog_btn
            // 
            this.prijedlog_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijedlog_btn.Location = new System.Drawing.Point(587, 382);
            this.prijedlog_btn.Name = "prijedlog_btn";
            this.prijedlog_btn.Size = new System.Drawing.Size(92, 38);
            this.prijedlog_btn.TabIndex = 10;
            this.prijedlog_btn.Text = "Predloži";
            this.prijedlog_btn.UseVisualStyleBackColor = true;
            this.prijedlog_btn.Click += new System.EventHandler(this.prijedlog_btn_Click);
            // 
            // sljedeci_btn
            // 
            this.sljedeci_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sljedeci_btn.Location = new System.Drawing.Point(762, 306);
            this.sljedeci_btn.Name = "sljedeci_btn";
            this.sljedeci_btn.Size = new System.Drawing.Size(131, 82);
            this.sljedeci_btn.TabIndex = 11;
            this.sljedeci_btn.Text = "Sljedeći pojam";
            this.sljedeci_btn.UseVisualStyleBackColor = true;
            this.sljedeci_btn.Click += new System.EventHandler(this.sljedeci_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 480);
            this.Controls.Add(this.sljedeci_btn);
            this.Controls.Add(this.prijedlog_btn);
            this.Controls.Add(this.cijeli_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.provjera_btn);
            this.Controls.Add(this.char_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pojam_lbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Igra vješala";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label counter_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox char_tb;
        private System.Windows.Forms.Button provjera_btn;
        public System.Windows.Forms.Label pojam_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cijeli_tb;
        private System.Windows.Forms.Button prijedlog_btn;
        private System.Windows.Forms.Button sljedeci_btn;
    }
}

