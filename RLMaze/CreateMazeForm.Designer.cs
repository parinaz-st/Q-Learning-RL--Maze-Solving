namespace RLMaze
{
    partial class CreateMazeForm
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
            this.btnLoadMaze = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSetDim = new System.Windows.Forms.Button();
            this.grpDimention = new System.Windows.Forms.GroupBox();
            this.txtColCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRowCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpObject = new System.Windows.Forms.GroupBox();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radObstacle = new System.Windows.Forms.RadioButton();
            this.radInit = new System.Windows.Forms.RadioButton();
            this.radGoal = new System.Windows.Forms.RadioButton();
            this.btnSetLoc = new System.Windows.Forms.Button();
            this.rtxtTemp = new System.Windows.Forms.RichTextBox();
            this.sfdMaze = new System.Windows.Forms.SaveFileDialog();
            this.ofdMaze = new System.Windows.Forms.OpenFileDialog();
            this.grpCommand.SuspendLayout();
            this.grpDimention.SuspendLayout();
            this.grpObject.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCommand
            // 
            this.grpCommand.Controls.Add(this.btnLoadMaze);
            this.grpCommand.Controls.Add(this.btnExit);
            this.grpCommand.Controls.Add(this.btnSave);
            this.grpCommand.Controls.Add(this.btnSetDim);
            this.grpCommand.Controls.Add(this.grpDimention);
            this.grpCommand.Controls.Add(this.grpObject);
            this.grpCommand.Controls.Add(this.btnSetLoc);
            this.grpCommand.Location = new System.Drawing.Point(8, 8);
            this.grpCommand.Name = "grpCommand";
            this.grpCommand.Size = new System.Drawing.Size(588, 123);
            this.grpCommand.TabIndex = 0;
            this.grpCommand.TabStop = false;
            // 
            // btnLoadMaze
            // 
            this.btnLoadMaze.Location = new System.Drawing.Point(457, 17);
            this.btnLoadMaze.Name = "btnLoadMaze";
            this.btnLoadMaze.Size = new System.Drawing.Size(125, 25);
            this.btnLoadMaze.TabIndex = 12;
            this.btnLoadMaze.Text = "&Load Maze";
            this.btnLoadMaze.UseVisualStyleBackColor = true;
            this.btnLoadMaze.Click += new System.EventHandler(this.btnLoadMaze_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(457, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 25);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(457, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 25);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "&Save Maze";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSetDim
            // 
            this.btnSetDim.Location = new System.Drawing.Point(12, 93);
            this.btnSetDim.Name = "btnSetDim";
            this.btnSetDim.Size = new System.Drawing.Size(125, 25);
            this.btnSetDim.TabIndex = 8;
            this.btnSetDim.Text = "New Maze";
            this.btnSetDim.UseVisualStyleBackColor = true;
            this.btnSetDim.Click += new System.EventHandler(this.btnSetDim_Click);
            // 
            // grpDimention
            // 
            this.grpDimention.Controls.Add(this.txtColCount);
            this.grpDimention.Controls.Add(this.label2);
            this.grpDimention.Controls.Add(this.txtRowCount);
            this.grpDimention.Controls.Add(this.label1);
            this.grpDimention.Location = new System.Drawing.Point(6, 8);
            this.grpDimention.Name = "grpDimention";
            this.grpDimention.Size = new System.Drawing.Size(138, 80);
            this.grpDimention.TabIndex = 7;
            this.grpDimention.TabStop = false;
            // 
            // txtColCount
            // 
            this.txtColCount.Location = new System.Drawing.Point(66, 43);
            this.txtColCount.Name = "txtColCount";
            this.txtColCount.Size = new System.Drawing.Size(43, 20);
            this.txtColCount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Col. Count";
            // 
            // txtRowCount
            // 
            this.txtRowCount.Location = new System.Drawing.Point(66, 17);
            this.txtRowCount.Name = "txtRowCount";
            this.txtRowCount.Size = new System.Drawing.Size(43, 20);
            this.txtRowCount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Row Count";
            // 
            // grpObject
            // 
            this.grpObject.Controls.Add(this.txtCol);
            this.grpObject.Controls.Add(this.label3);
            this.grpObject.Controls.Add(this.txtRow);
            this.grpObject.Controls.Add(this.label4);
            this.grpObject.Controls.Add(this.radObstacle);
            this.grpObject.Controls.Add(this.radInit);
            this.grpObject.Controls.Add(this.radGoal);
            this.grpObject.Location = new System.Drawing.Point(154, 8);
            this.grpObject.Name = "grpObject";
            this.grpObject.Size = new System.Drawing.Size(289, 80);
            this.grpObject.TabIndex = 6;
            this.grpObject.TabStop = false;
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(235, 43);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(43, 20);
            this.txtCol.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Col. Num.";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(235, 17);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(43, 20);
            this.txtRow.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Row Num.";
            // 
            // radObstacle
            // 
            this.radObstacle.AutoSize = true;
            this.radObstacle.Location = new System.Drawing.Point(6, 54);
            this.radObstacle.Name = "radObstacle";
            this.radObstacle.Size = new System.Drawing.Size(103, 17);
            this.radObstacle.TabIndex = 2;
            this.radObstacle.TabStop = true;
            this.radObstacle.Text = "Obstacle (Black)";
            this.radObstacle.UseVisualStyleBackColor = true;
            // 
            // radInit
            // 
            this.radInit.AutoSize = true;
            this.radInit.Location = new System.Drawing.Point(6, 32);
            this.radInit.Name = "radInit";
            this.radInit.Size = new System.Drawing.Size(155, 17);
            this.radInit.TabIndex = 1;
            this.radInit.TabStop = true;
            this.radInit.Text = "Robot Initial Location (Blue)";
            this.radInit.UseVisualStyleBackColor = true;
            // 
            // radGoal
            // 
            this.radGoal.AutoSize = true;
            this.radGoal.Location = new System.Drawing.Point(6, 10);
            this.radGoal.Name = "radGoal";
            this.radGoal.Size = new System.Drawing.Size(120, 17);
            this.radGoal.TabIndex = 0;
            this.radGoal.TabStop = true;
            this.radGoal.Text = "Goal Location (Red)";
            this.radGoal.UseVisualStyleBackColor = true;
            // 
            // btnSetLoc
            // 
            this.btnSetLoc.Location = new System.Drawing.Point(154, 93);
            this.btnSetLoc.Name = "btnSetLoc";
            this.btnSetLoc.Size = new System.Drawing.Size(271, 25);
            this.btnSetLoc.TabIndex = 5;
            this.btnSetLoc.Text = "Set Location";
            this.btnSetLoc.UseVisualStyleBackColor = true;
            this.btnSetLoc.Click += new System.EventHandler(this.btnSetLoc_Click);
            // 
            // rtxtTemp
            // 
            this.rtxtTemp.Location = new System.Drawing.Point(602, 16);
            this.rtxtTemp.Name = "rtxtTemp";
            this.rtxtTemp.Size = new System.Drawing.Size(403, 113);
            this.rtxtTemp.TabIndex = 1;
            this.rtxtTemp.Text = "";
            // 
            // sfdMaze
            // 
            this.sfdMaze.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdMaze_FileOk);
            // 
            // ofdMaze
            // 
            this.ofdMaze.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMaze_FileOk);
            // 
            // CreateMazeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 597);
            this.Controls.Add(this.rtxtTemp);
            this.Controls.Add(this.grpCommand);
            this.Name = "CreateMazeForm";
            this.Text = "Create and Save Maze";
            this.Activated += new System.EventHandler(this.CreateMazeForm_Activated);
            this.SizeChanged += new System.EventHandler(this.CreateMazeForm_SizeChanged);
            this.Click += new System.EventHandler(this.CreateMazeForm_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateMazeForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreateMazeForm_MouseClick);
            this.grpCommand.ResumeLayout(false);
            this.grpDimention.ResumeLayout(false);
            this.grpDimention.PerformLayout();
            this.grpObject.ResumeLayout(false);
            this.grpObject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCommand;
        private System.Windows.Forms.Button btnSetLoc;
        private System.Windows.Forms.GroupBox grpObject;
        private System.Windows.Forms.RadioButton radObstacle;
        private System.Windows.Forms.RadioButton radInit;
        private System.Windows.Forms.RadioButton radGoal;
        private System.Windows.Forms.Button btnSetDim;
        private System.Windows.Forms.GroupBox grpDimention;
        private System.Windows.Forms.TextBox txtColCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRowCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtTemp;
        private System.Windows.Forms.Button btnLoadMaze;
        private System.Windows.Forms.SaveFileDialog sfdMaze;
        private System.Windows.Forms.OpenFileDialog ofdMaze;
    }
}