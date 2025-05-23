namespace MCCI_Event_Calculator
{
    partial class mainScreen
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
            this.btnRsr = new System.Windows.Forms.Button();
            this.btnBb = new System.Windows.Forms.Button();
            this.btnSb = new System.Windows.Forms.Button();
            this.btnHitw = new System.Windows.Forms.Button();
            this.btnTgttos = new System.Windows.Forms.Button();
            this.btnPkws = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRsr
            // 
            this.btnRsr.Location = new System.Drawing.Point(217, 210);
            this.btnRsr.Name = "btnRsr";
            this.btnRsr.Size = new System.Drawing.Size(75, 23);
            this.btnRsr.TabIndex = 0;
            this.btnRsr.Text = "Rocket Spleef Rush";
            this.btnRsr.UseVisualStyleBackColor = true;
            this.btnRsr.Click += new System.EventHandler(this.btnRsr_Click);
            // 
            // btnBb
            // 
            this.btnBb.Location = new System.Drawing.Point(217, 152);
            this.btnBb.Name = "btnBb";
            this.btnBb.Size = new System.Drawing.Size(75, 23);
            this.btnBb.TabIndex = 1;
            this.btnBb.Text = "Battle Box";
            this.btnBb.UseVisualStyleBackColor = true;
            this.btnBb.Click += new System.EventHandler(this.btnBb_Click);
            // 
            // btnSb
            // 
            this.btnSb.Location = new System.Drawing.Point(358, 210);
            this.btnSb.Name = "btnSb";
            this.btnSb.Size = new System.Drawing.Size(75, 23);
            this.btnSb.TabIndex = 2;
            this.btnSb.Text = "Sky Battle";
            this.btnSb.UseVisualStyleBackColor = true;
            this.btnSb.Click += new System.EventHandler(this.btnSb_Click);
            // 
            // btnHitw
            // 
            this.btnHitw.Location = new System.Drawing.Point(358, 152);
            this.btnHitw.Name = "btnHitw";
            this.btnHitw.Size = new System.Drawing.Size(75, 23);
            this.btnHitw.TabIndex = 3;
            this.btnHitw.Text = "Hole In The Wall";
            this.btnHitw.UseVisualStyleBackColor = true;
            this.btnHitw.Click += new System.EventHandler(this.btnHitw_Click);
            // 
            // btnTgttos
            // 
            this.btnTgttos.Location = new System.Drawing.Point(495, 210);
            this.btnTgttos.Name = "btnTgttos";
            this.btnTgttos.Size = new System.Drawing.Size(75, 23);
            this.btnTgttos.TabIndex = 4;
            this.btnTgttos.Text = "To Get To The Other Side";
            this.btnTgttos.UseVisualStyleBackColor = true;
            this.btnTgttos.Click += new System.EventHandler(this.btnTgttos_Click);
            // 
            // btnPkws
            // 
            this.btnPkws.Location = new System.Drawing.Point(495, 152);
            this.btnPkws.Name = "btnPkws";
            this.btnPkws.Size = new System.Drawing.Size(75, 23);
            this.btnPkws.TabIndex = 5;
            this.btnPkws.Text = "Parkour Warrior Survivor";
            this.btnPkws.UseVisualStyleBackColor = true;
            this.btnPkws.Click += new System.EventHandler(this.btnPkws_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPkws);
            this.Controls.Add(this.btnTgttos);
            this.Controls.Add(this.btnHitw);
            this.Controls.Add(this.btnSb);
            this.Controls.Add(this.btnBb);
            this.Controls.Add(this.btnRsr);
            this.Name = "mainScreen";
            this.Text = "mainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRsr;
        private System.Windows.Forms.Button btnBb;
        private System.Windows.Forms.Button btnSb;
        private System.Windows.Forms.Button btnHitw;
        private System.Windows.Forms.Button btnTgttos;
        private System.Windows.Forms.Button btnPkws;
    }
}