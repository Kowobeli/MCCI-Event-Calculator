namespace MCCI_Event_Calculator
{
    partial class inputScreen
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
            this.btnAdvance = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdvance
            // 
            this.btnAdvance.Location = new System.Drawing.Point(326, 277);
            this.btnAdvance.Name = "btnAdvance";
            this.btnAdvance.Size = new System.Drawing.Size(104, 23);
            this.btnAdvance.TabIndex = 4;
            this.btnAdvance.Text = "Proceed";
            this.btnAdvance.UseVisualStyleBackColor = true;
            this.btnAdvance.Click += new System.EventHandler(this.btnAdvance_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Location = new System.Drawing.Point(109, 157);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(75, 23);
            this.btnTeams.TabIndex = 5;
            this.btnTeams.Text = "Edit Teams";
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(520, 159);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(117, 23);
            this.btnMembers.TabIndex = 6;
            this.btnMembers.Text = "Edit team members";
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // inputScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnTeams);
            this.Controls.Add(this.btnAdvance);
            this.Name = "inputScreen";
            this.Text = "inputScreen";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdvance;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnMembers;
    }
}