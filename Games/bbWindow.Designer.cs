namespace MCCI_Event_Calculator.Games
{
    partial class bbWindow
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtgBb = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPointsPerRound = new System.Windows.Forms.TextBox();
            this.dtgTeams = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Location = new System.Drawing.Point(281, 607);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(153, 34);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Insert Points";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // dtgBb
            // 
            this.dtgBb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBb.Location = new System.Drawing.Point(16, 111);
            this.dtgBb.Margin = new System.Windows.Forms.Padding(4);
            this.dtgBb.Name = "dtgBb";
            this.dtgBb.ReadOnly = true;
            this.dtgBb.Size = new System.Drawing.Size(1035, 212);
            this.dtgBb.TabIndex = 28;
            this.dtgBb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBb_CellClick);
            this.dtgBb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBb_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(499, 607);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 34);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(711, 607);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 34);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(604, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Multiplier";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultiplier.Location = new System.Drawing.Point(571, 48);
            this.txtMultiplier.Margin = new System.Windows.Forms.Padding(4);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(133, 27);
            this.txtMultiplier.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(359, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Points Per Round";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(147, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "ID:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(175, 26);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 19);
            this.lblId.TabIndex = 36;
            // 
            // txtPointsPerRound
            // 
            this.txtPointsPerRound.AllowDrop = true;
            this.txtPointsPerRound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPointsPerRound.Location = new System.Drawing.Point(352, 48);
            this.txtPointsPerRound.Margin = new System.Windows.Forms.Padding(4);
            this.txtPointsPerRound.Multiline = true;
            this.txtPointsPerRound.Name = "txtPointsPerRound";
            this.txtPointsPerRound.Size = new System.Drawing.Size(133, 28);
            this.txtPointsPerRound.TabIndex = 42;
            this.txtPointsPerRound.Click += new System.EventHandler(this.txtPointsPerRound_Click);
            this.txtPointsPerRound.TextChanged += new System.EventHandler(this.txtPointsPerRound_TextChanged);
            this.txtPointsPerRound.Leave += new System.EventHandler(this.txtPointsPerRound_Leave);
            // 
            // dtgTeams
            // 
            this.dtgTeams.AllowUserToAddRows = false;
            this.dtgTeams.AllowUserToDeleteRows = false;
            this.dtgTeams.AllowUserToOrderColumns = true;
            this.dtgTeams.AllowUserToResizeColumns = false;
            this.dtgTeams.AllowUserToResizeRows = false;
            this.dtgTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTeams.Location = new System.Drawing.Point(17, 341);
            this.dtgTeams.Margin = new System.Windows.Forms.Padding(4);
            this.dtgTeams.Name = "dtgTeams";
            this.dtgTeams.ReadOnly = true;
            this.dtgTeams.Size = new System.Drawing.Size(1033, 212);
            this.dtgTeams.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(904, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 100;
            this.label2.Text = "Battle Box";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::MCCI_Event_Calculator.Properties.Resources.arrow_back_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.btnBack.Location = new System.Drawing.Point(17, 19);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bbWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::MCCI_Event_Calculator.Properties.Resources.fundinho;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgTeams);
            this.Controls.Add(this.txtPointsPerRound);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtgBb);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBack);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bbWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEC";
            this.Load += new System.EventHandler(this.bbWindow_Load);
            this.Click += new System.EventHandler(this.bbWindow_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTeams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dtgBb;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtPointsPerRound;
        private System.Windows.Forms.DataGridView dtgTeams;
        private System.Windows.Forms.Label label2;
    }
}