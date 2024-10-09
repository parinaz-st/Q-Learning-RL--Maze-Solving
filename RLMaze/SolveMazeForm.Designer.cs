namespace RLMaze
{
    partial class SolveMazeForm
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
            this.grpCommand = new System.Windows.Forms.GroupBox();
            this.grpControl = new System.Windows.Forms.GroupBox();
            this.txtEpisodeLimit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetQLearning = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnEpisode = new System.Windows.Forms.Button();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpLoad = new System.Windows.Forms.GroupBox();
            this.btnLoadMaze = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOReward = new System.Windows.Forms.TextBox();
            this.txtIReward = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.ofdMaze = new System.Windows.Forms.OpenFileDialog();
            this.btnTenEpisodes = new System.Windows.Forms.Button();
            this.grpCommand.SuspendLayout();
            this.grpControl.SuspendLayout();
            this.grpLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.grpControl);
            this.grpCommand.Controls.Add(this.grpLoad);
            this.grpCommand.Controls.Add(this.btnExit);
            this.grpCommand.Location = new System.Drawing.Point(8, 8);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(949, 87);
            this.grpCommand.TabIndex = 1;
            this.grpCommand.TabStop = false;
            // 
            // grpControl
            // 
            this.grpControl.Controls.Add(this.btnTenEpisodes);
            this.grpControl.Controls.Add(this.txtEpisodeLimit);
            this.grpControl.Controls.Add(this.label5);
            this.grpControl.Controls.Add(this.btnSetQLearning);
            this.grpControl.Controls.Add(this.btnReset);
            this.grpControl.Controls.Add(this.btnStep);
            this.grpControl.Controls.Add(this.btnEpisode);
            this.grpControl.Controls.Add(this.txtDelay);
            this.grpControl.Controls.Add(this.label4);
            this.grpControl.Location = new System.Drawing.Point(290, 8);
            this.grpControl.Name = "grpControl";
            this.grpControl.Size = new System.Drawing.Size(576, 69);
            this.grpControl.TabIndex = 21;
            this.grpControl.TabStop = false;
            // 
            // txtEpisodeLimit
            // 
            this.txtEpisodeLimit.Location = new System.Drawing.Point(326, 10);
            this.txtEpisodeLimit.Name = "txtEpisodeLimit";
            this.txtEpisodeLimit.Size = new System.Drawing.Size(37, 20);
            this.txtEpisodeLimit.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Episode Limit";
            // 
            // btnSetQLearning
            // 
            this.btnSetQLearning.Location = new System.Drawing.Point(6, 9);
            this.btnSetQLearning.Name = "btnSetQLearning";
            this.btnSetQLearning.Size = new System.Drawing.Size(125, 25);
            this.btnSetQLearning.TabIndex = 32;
            this.btnSetQLearning.Text = "Set &Q-Learning Param";
            this.btnSetQLearning.UseVisualStyleBackColor = true;
            this.btnSetQLearning.Click += new System.EventHandler(this.btnSetQLearning_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(445, 39);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 25);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(6, 39);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(125, 25);
            this.btnStep.TabIndex = 30;
            this.btnStep.Text = "&Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnEpisode
            // 
            this.btnEpisode.Location = new System.Drawing.Point(137, 39);
            this.btnEpisode.Name = "btnEpisode";
            this.btnEpisode.Size = new System.Drawing.Size(125, 25);
            this.btnEpisode.TabIndex = 28;
            this.btnEpisode.Text = "&Complete Episode";
            this.btnEpisode.UseVisualStyleBackColor = true;
            this.btnEpisode.Click += new System.EventHandler(this.btnEpisode_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(199, 10);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(37, 20);
            this.txtDelay.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Delay (ms)";
            // 
            // grpLoad
            // 
            this.grpLoad.Controls.Add(this.btnLoadMaze);
            this.grpLoad.Controls.Add(this.txtDiscount);
            this.grpLoad.Controls.Add(this.label2);
            this.grpLoad.Controls.Add(this.label3);
            this.grpLoad.Controls.Add(this.txtOReward);
            this.grpLoad.Controls.Add(this.txtIReward);
            this.grpLoad.Controls.Add(this.label1);
            this.grpLoad.Location = new System.Drawing.Point(6, 8);
            this.grpLoad.Name = "grpLoad";
            this.grpLoad.Size = new System.Drawing.Size(278, 69);
            this.grpLoad.TabIndex = 20;
            this.grpLoad.TabStop = false;
            // 
            // btnLoadMaze
            // 
            this.btnLoadMaze.Location = new System.Drawing.Point(144, 40);
            this.btnLoadMaze.Name = "btnLoadMaze";
            this.btnLoadMaze.Size = new System.Drawing.Size(125, 25);
            this.btnLoadMaze.TabIndex = 26;
            this.btnLoadMaze.Text = "&Load Maze";
            this.btnLoadMaze.UseVisualStyleBackColor = true;
            this.btnLoadMaze.Click += new System.EventHandler(this.btnLoadMaze_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(230, 11);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(37, 20);
            this.txtDiscount.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Discount Factor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Other Reward";
            // 
            // txtOReward
            // 
            this.txtOReward.Location = new System.Drawing.Point(81, 43);
            this.txtOReward.Name = "txtOReward";
            this.txtOReward.Size = new System.Drawing.Size(37, 20);
            this.txtOReward.TabIndex = 22;
            // 
            // txtIReward
            // 
            this.txtIReward.Location = new System.Drawing.Point(81, 11);
            this.txtIReward.Name = "txtIReward";
            this.txtIReward.Size = new System.Drawing.Size(37, 20);
            this.txtIReward.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Goal Reward";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(872, 48);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ofdMaze
            // 
            this.ofdMaze.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMaze_FileOk);
            // 
            // btnTenEpisodes
            // 
            this.btnTenEpisodes.Location = new System.Drawing.Point(268, 39);
            this.btnTenEpisodes.Name = "btnTenEpisodes";
            this.btnTenEpisodes.Size = new System.Drawing.Size(125, 25);
            this.btnTenEpisodes.TabIndex = 35;
            this.btnTenEpisodes.Text = "&Complete 10 Episodes";
            this.btnTenEpisodes.UseVisualStyleBackColor = true;
            this.btnTenEpisodes.Click += new System.EventHandler(this.btnTenEpisodes_Click);
            // 
            // SolveMazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 542);
            this.Controls.Add(this.grpCommand);
            this.Name = "SolveMazeForm";
            this.Text = "SolveMazeForm";
            this.Click += new System.EventHandler(this.SolveMazeForm_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SolveMazeForm_Paint);
            this.grpCommand.ResumeLayout(false);
            this.grpControl.ResumeLayout(false);
            this.grpControl.PerformLayout();
            this.grpLoad.ResumeLayout(false);
            this.grpLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpControl;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpLoad;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOReward;
        private System.Windows.Forms.TextBox txtIReward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEpisode;
        private System.Windows.Forms.Button btnLoadMaze;
        private System.Windows.Forms.OpenFileDialog ofdMaze;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnSetQLearning;
        private System.Windows.Forms.TextBox txtEpisodeLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTenEpisodes;
    }
}