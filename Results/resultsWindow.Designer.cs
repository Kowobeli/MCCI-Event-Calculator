namespace MCCI_Event_Calculator
{
    partial class resultsWindow
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
            this.dtgMembers = new System.Windows.Forms.DataGridView();
            this.dtgTeams = new System.Windows.Forms.DataGridView();
            this.btnBb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHitw = new System.Windows.Forms.Button();
            this.btnPkws = new System.Windows.Forms.Button();
            this.btnRsr = new System.Windows.Forms.Button();
            this.btnSb = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.rdbDes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMembers
            // 
            this.dtgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMembers.Location = new System.Drawing.Point(168, 102);
            this.dtgMembers.Margin = new System.Windows.Forms.Padding(4);
            this.dtgMembers.Name = "dtgMembers";
            this.dtgMembers.ReadOnly = true;
            this.dtgMembers.Size = new System.Drawing.Size(667, 512);
            this.dtgMembers.TabIndex = 0;
            // 
            // dtgTeams
            // 
            this.dtgTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeams.Location = new System.Drawing.Point(847, 102);
            this.dtgTeams.Margin = new System.Windows.Forms.Padding(4);
            this.dtgTeams.Name = "dtgTeams";
            this.dtgTeams.ReadOnly = true;
            this.dtgTeams.Size = new System.Drawing.Size(667, 512);
            this.dtgTeams.TabIndex = 1;
            // 
            // btnBb
            // 
            this.btnBb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBb.Location = new System.Drawing.Point(447, 42);
            this.btnBb.Margin = new System.Windows.Forms.Padding(4);
            this.btnBb.Name = "btnBb";
            this.btnBb.Size = new System.Drawing.Size(100, 34);
            this.btnBb.TabIndex = 3;
            this.btnBb.Text = "Battle Box";
            this.btnBb.UseVisualStyleBackColor = true;
            this.btnBb.Click += new System.EventHandler(this.btnBb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(27, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order by";
            // 
            // btnHitw
            // 
            this.btnHitw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHitw.Location = new System.Drawing.Point(581, 42);
            this.btnHitw.Margin = new System.Windows.Forms.Padding(4);
            this.btnHitw.Name = "btnHitw";
            this.btnHitw.Size = new System.Drawing.Size(100, 34);
            this.btnHitw.TabIndex = 5;
            this.btnHitw.Text = "HITW";
            this.btnHitw.UseVisualStyleBackColor = true;
            this.btnHitw.Click += new System.EventHandler(this.btnHitw_Click);
            // 
            // btnPkws
            // 
            this.btnPkws.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPkws.Location = new System.Drawing.Point(719, 42);
            this.btnPkws.Margin = new System.Windows.Forms.Padding(4);
            this.btnPkws.Name = "btnPkws";
            this.btnPkws.Size = new System.Drawing.Size(100, 34);
            this.btnPkws.TabIndex = 6;
            this.btnPkws.Text = "PKWS";
            this.btnPkws.UseVisualStyleBackColor = true;
            this.btnPkws.Click += new System.EventHandler(this.btnPkws_Click);
            // 
            // btnRsr
            // 
            this.btnRsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRsr.Location = new System.Drawing.Point(861, 42);
            this.btnRsr.Margin = new System.Windows.Forms.Padding(4);
            this.btnRsr.Name = "btnRsr";
            this.btnRsr.Size = new System.Drawing.Size(100, 34);
            this.btnRsr.TabIndex = 7;
            this.btnRsr.Text = "RSR";
            this.btnRsr.UseVisualStyleBackColor = true;
            this.btnRsr.Click += new System.EventHandler(this.btnRsr_Click);
            // 
            // btnSb
            // 
            this.btnSb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSb.Location = new System.Drawing.Point(1000, 42);
            this.btnSb.Margin = new System.Windows.Forms.Padding(4);
            this.btnSb.Name = "btnSb";
            this.btnSb.Size = new System.Drawing.Size(100, 34);
            this.btnSb.TabIndex = 8;
            this.btnSb.Text = "Sky Battle";
            this.btnSb.UseVisualStyleBackColor = true;
            this.btnSb.Click += new System.EventHandler(this.btnSb_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1140, 42);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = "TGTTOS";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // rdbAsc
            // 
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.BackColor = System.Drawing.Color.Transparent;
            this.rdbAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbAsc.Location = new System.Drawing.Point(12, 322);
            this.rdbAsc.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(96, 23);
            this.rdbAsc.TabIndex = 10;
            this.rdbAsc.Text = "Ascending";
            this.rdbAsc.UseVisualStyleBackColor = false;
            this.rdbAsc.CheckedChanged += new System.EventHandler(this.btnAsc_CheckedChanged);
            // 
            // rdbDes
            // 
            this.rdbDes.AutoSize = true;
            this.rdbDes.BackColor = System.Drawing.Color.Transparent;
            this.rdbDes.Checked = true;
            this.rdbDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbDes.Location = new System.Drawing.Point(12, 288);
            this.rdbDes.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDes.Name = "rdbDes";
            this.rdbDes.Size = new System.Drawing.Size(104, 23);
            this.rdbDes.TabIndex = 11;
            this.rdbDes.TabStop = true;
            this.rdbDes.Text = "Descending";
            this.rdbDes.UseVisualStyleBackColor = false;
            this.rdbDes.CheckedChanged += new System.EventHandler(this.rdbDes_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(808, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Classify by";
            // 
            // btnShowAll
            // 
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Location = new System.Drawing.Point(16, 580);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(105, 34);
            this.btnShowAll.TabIndex = 13;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::MCCI_Event_Calculator.Properties.Resources.arrow_back_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.btnBack.Location = new System.Drawing.Point(16, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // resultsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::MCCI_Event_Calculator.Properties.Resources.fundinho;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1527, 656);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbDes);
            this.Controls.Add(this.rdbAsc);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnSb);
            this.Controls.Add(this.btnRsr);
            this.Controls.Add(this.btnPkws);
            this.Controls.Add(this.btnHitw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBb);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtgTeams);
            this.Controls.Add(this.dtgMembers);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "resultsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEC";
            this.Load += new System.EventHandler(this.resultsWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMembers;
        private System.Windows.Forms.DataGridView dtgTeams;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHitw;
        private System.Windows.Forms.Button btnPkws;
        private System.Windows.Forms.Button btnRsr;
        private System.Windows.Forms.Button btnSb;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.RadioButton rdbDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowAll;
    }
}