namespace RadioButtonKontrola
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
            this.gbVrstaPrijevoza = new System.Windows.Forms.GroupBox();
            this.rbVlastitiPrijevoz = new System.Windows.Forms.RadioButton();
            this.rbAutobus = new System.Windows.Forms.RadioButton();
            this.rbAvion = new System.Windows.Forms.RadioButton();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.gbVrstaPrijevoza.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVrstaPrijevoza
            // 
            this.gbVrstaPrijevoza.Controls.Add(this.rbVlastitiPrijevoz);
            this.gbVrstaPrijevoza.Controls.Add(this.rbAutobus);
            this.gbVrstaPrijevoza.Controls.Add(this.rbAvion);
            this.gbVrstaPrijevoza.Location = new System.Drawing.Point(130, 72);
            this.gbVrstaPrijevoza.Name = "gbVrstaPrijevoza";
            this.gbVrstaPrijevoza.Size = new System.Drawing.Size(158, 95);
            this.gbVrstaPrijevoza.TabIndex = 6;
            this.gbVrstaPrijevoza.TabStop = false;
            this.gbVrstaPrijevoza.Text = "Odaberite vrstu prijevoza";
            this.gbVrstaPrijevoza.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbVlastitiPrijevoz
            // 
            this.rbVlastitiPrijevoz.AutoSize = true;
            this.rbVlastitiPrijevoz.Location = new System.Drawing.Point(58, 65);
            this.rbVlastitiPrijevoz.Name = "rbVlastitiPrijevoz";
            this.rbVlastitiPrijevoz.Size = new System.Drawing.Size(94, 17);
            this.rbVlastitiPrijevoz.TabIndex = 8;
            this.rbVlastitiPrijevoz.TabStop = true;
            this.rbVlastitiPrijevoz.Text = "Vlastiti prijevoz";
            this.rbVlastitiPrijevoz.UseVisualStyleBackColor = true;
            this.rbVlastitiPrijevoz.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbAutobus
            // 
            this.rbAutobus.AutoSize = true;
            this.rbAutobus.Location = new System.Drawing.Point(58, 42);
            this.rbAutobus.Name = "rbAutobus";
            this.rbAutobus.Size = new System.Drawing.Size(64, 17);
            this.rbAutobus.TabIndex = 7;
            this.rbAutobus.TabStop = true;
            this.rbAutobus.Text = "Autobus";
            this.rbAutobus.UseVisualStyleBackColor = true;
            this.rbAutobus.CheckedChanged += new System.EventHandler(this.rbAutobus_CheckedChanged);
            // 
            // rbAvion
            // 
            this.rbAvion.AutoSize = true;
            this.rbAvion.Location = new System.Drawing.Point(58, 19);
            this.rbAvion.Name = "rbAvion";
            this.rbAvion.Size = new System.Drawing.Size(52, 17);
            this.rbAvion.TabIndex = 6;
            this.rbAvion.TabStop = true;
            this.rbAvion.Text = "Avion";
            this.rbAvion.UseVisualStyleBackColor = true;
            this.rbAvion.CheckedChanged += new System.EventHandler(this.rbAvion_CheckedChanged);
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(188, 187);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnRezerviraj.TabIndex = 7;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(130, 229);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(158, 115);
            this.txtIspis.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.gbVrstaPrijevoza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbVrstaPrijevoza.ResumeLayout(false);
            this.gbVrstaPrijevoza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVrstaPrijevoza;
        private System.Windows.Forms.RadioButton rbVlastitiPrijevoz;
        private System.Windows.Forms.RadioButton rbAutobus;
        private System.Windows.Forms.RadioButton rbAvion;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

