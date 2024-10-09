namespace RLMaze
{
    partial class AboutForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.grpAbout = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(422, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(189, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "O&K";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpAbout
            // 
            this.grpAbout.Controls.Add(this.label2);
            this.grpAbout.Controls.Add(this.label1);
            this.grpAbout.Location = new System.Drawing.Point(8, 6);
            this.grpAbout.Name = "grpAbout";
            this.grpAbout.Size = new System.Drawing.Size(603, 68);
            this.grpAbout.TabIndex = 3;
            this.grpAbout.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed by: Parinaz Sattarzadeh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "This application uses Reinforcement Learning (Q-Learning)  to solve a Maze proble" +
                "m";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 111);
            this.Controls.Add(this.grpAbout);
            this.Controls.Add(this.btnOK);
            this.Name = "AboutForm";
            this.Text = "About Maze";
            this.grpAbout.ResumeLayout(false);
            this.grpAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpAbout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}