namespace LetsReadGhana
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picLetter = new System.Windows.Forms.PictureBox();
            this.picItem = new System.Windows.Forms.PictureBox();
            this.tipGame = new System.Windows.Forms.ToolTip(this.components);
            this.btnAudio = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picSelection = new System.Windows.Forms.PictureBox();
            this.lblLevels = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.lblPointToTakeAway = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.mnsGame = new System.Windows.Forms.MenuStrip();
            this.mnsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTextLevel = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblTextScore = new System.Windows.Forms.Label();
            this.lblTxtPointsTakenAway = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelection)).BeginInit();
            this.mnsGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLetter
            // 
            this.picLetter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picLetter.BackColor = System.Drawing.SystemColors.Highlight;
            this.picLetter.Location = new System.Drawing.Point(45, 259);
            this.picLetter.Name = "picLetter";
            this.picLetter.Size = new System.Drawing.Size(264, 446);
            this.picLetter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLetter.TabIndex = 0;
            this.picLetter.TabStop = false;
            this.tipGame.SetToolTip(this.picLetter, "Alphabetical letter ");
            // 
            // picItem
            // 
            this.picItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.picItem.Location = new System.Drawing.Point(1168, 259);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(264, 446);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 2;
            this.picItem.TabStop = false;
            this.tipGame.SetToolTip(this.picItem, "Item selected to be matched with the current alphabet letter diplayed");
            // 
            // btnAudio
            // 
            this.btnAudio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAudio.BackColor = System.Drawing.Color.Yellow;
            this.btnAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudio.Location = new System.Drawing.Point(621, 761);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(238, 105);
            this.btnAudio.TabIndex = 3;
            this.btnAudio.Text = "&PLAY AUDIO";
            this.tipGame.SetToolTip(this.btnAudio, "Play sound to find out which letter matches with which item");
            this.btnAudio.UseVisualStyleBackColor = false;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1003, 761);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(403, 147);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "&NEXT >>";
            this.tipGame.SetToolTip(this.btnNext, "Surf to the next selection of item");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(71, 761);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(403, 147);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<< &BACK";
            this.tipGame.SetToolTip(this.btnBack, "Surf to the previous selection of item");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picSelection
            // 
            this.picSelection.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSelection.BackColor = System.Drawing.SystemColors.Highlight;
            this.picSelection.Location = new System.Drawing.Point(621, 38);
            this.picSelection.Name = "picSelection";
            this.picSelection.Size = new System.Drawing.Size(238, 315);
            this.picSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelection.TabIndex = 6;
            this.picSelection.TabStop = false;
            this.tipGame.SetToolTip(this.picSelection, "Selection item. Click on it to select it");
            this.picSelection.Click += new System.EventHandler(this.picSelection_Click);
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevels.Location = new System.Drawing.Point(179, 68);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(143, 42);
            this.lblLevels.TabIndex = 9;
            this.lblLevels.Text = "Normal";
            this.tipGame.SetToolTip(this.lblLevels, "Current level");
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(1236, 68);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(194, 42);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "  out of 26";
            this.tipGame.SetToolTip(this.lblText, "Total round to finish the game");
            // 
            // lblPoints
            // 
            this.lblPoints.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(1015, 465);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(0, 42);
            this.lblPoints.TabIndex = 12;
            this.tipGame.SetToolTip(this.lblPoints, "Your total score");
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartTimer.BackColor = System.Drawing.Color.GreenYellow;
            this.btnStartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTimer.Location = new System.Drawing.Point(745, 659);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(114, 68);
            this.btnStartTimer.TabIndex = 14;
            this.btnStartTimer.Text = "START TIMER";
            this.tipGame.SetToolTip(this.btnStartTimer, "Play with timer enabled");
            this.btnStartTimer.UseVisualStyleBackColor = false;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStopTimer.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopTimer.Enabled = false;
            this.btnStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTimer.Location = new System.Drawing.Point(621, 659);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(114, 68);
            this.btnStopTimer.TabIndex = 15;
            this.btnStopTimer.Text = "STOP TIMER";
            this.tipGame.SetToolTip(this.btnStopTimer, "Stop timer is it is enabled");
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // lblPointToTakeAway
            // 
            this.lblPointToTakeAway.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPointToTakeAway.AutoSize = true;
            this.lblPointToTakeAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPointToTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPointToTakeAway.Location = new System.Drawing.Point(1015, 563);
            this.lblPointToTakeAway.Name = "lblPointToTakeAway";
            this.lblPointToTakeAway.Size = new System.Drawing.Size(117, 42);
            this.lblPointToTakeAway.TabIndex = 16;
            this.lblPointToTakeAway.Text = "00.00";
            this.tipGame.SetToolTip(this.lblPointToTakeAway, "Points taken away when timer in enabled");
            this.lblPointToTakeAway.Visible = false;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(621, 872);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(238, 36);
            this.btnPause.TabIndex = 18;
            this.btnPause.Text = "P&AUSE GAME";
            this.tipGame.SetToolTip(this.btnPause, "Pause game when timer is enabled");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // mnsGame
            // 
            this.mnsGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsMenuStrip,
            this.gameRulesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnsGame.Location = new System.Drawing.Point(0, 0);
            this.mnsGame.Name = "mnsGame";
            this.mnsGame.Size = new System.Drawing.Size(1467, 24);
            this.mnsGame.TabIndex = 7;
            // 
            // mnsMenuStrip
            // 
            this.mnsMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.intermediateToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.mnsMenuStrip.Name = "mnsMenuStrip";
            this.mnsMenuStrip.Size = new System.Drawing.Size(46, 20);
            this.mnsMenuStrip.Text = "Level";
            this.mnsMenuStrip.ToolTipText = "Select the level of difficulty of the game";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.easyToolStripMenuItem.Text = "&Easy";
            this.easyToolStripMenuItem.ToolTipText = "Letters and items are displayed in alphabetical order";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.normalToolStripMenuItem.Text = "&Normal";
            this.normalToolStripMenuItem.ToolTipText = "Each letter is displayed in alphabatical order but items are random";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // intermediateToolStripMenuItem
            // 
            this.intermediateToolStripMenuItem.Name = "intermediateToolStripMenuItem";
            this.intermediateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.intermediateToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.intermediateToolStripMenuItem.Text = "&Intermediate";
            this.intermediateToolStripMenuItem.ToolTipText = "Letters and itmes are displayed in a random order ";
            this.intermediateToolStripMenuItem.Click += new System.EventHandler(this.intermediateToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.hardToolStripMenuItem.Text = "&Hard";
            this.hardToolStripMenuItem.ToolTipText = "Letters and itmes are displayed in a random order and no sound";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelsToolStripMenuItem,
            this.pointsToolStripMenuItem,
            this.timerToolStripMenuItem});
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.gameRulesToolStripMenuItem.Text = "Game\'s rules ";
            // 
            // levelsToolStripMenuItem
            // 
            this.levelsToolStripMenuItem.Name = "levelsToolStripMenuItem";
            this.levelsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.levelsToolStripMenuItem.Text = "Levels";
            this.levelsToolStripMenuItem.Click += new System.EventHandler(this.levelsToolStripMenuItem_Click);
            // 
            // pointsToolStripMenuItem
            // 
            this.pointsToolStripMenuItem.Name = "pointsToolStripMenuItem";
            this.pointsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pointsToolStripMenuItem.Text = "Points";
            this.pointsToolStripMenuItem.Click += new System.EventHandler(this.pointsToolStripMenuItem_Click);
            // 
            // timerToolStripMenuItem
            // 
            this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            this.timerToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.timerToolStripMenuItem.Text = "Timer";
            this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.ToolTipText = "About the game";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.infoToolStripMenuItem.Text = "Game Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Close the game";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTextLevel
            // 
            this.lblTextLevel.AutoSize = true;
            this.lblTextLevel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTextLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextLevel.Location = new System.Drawing.Point(38, 68);
            this.lblTextLevel.Name = "lblTextLevel";
            this.lblTextLevel.Size = new System.Drawing.Size(135, 42);
            this.lblTextLevel.TabIndex = 8;
            this.lblTextLevel.Text = "Level :";
            // 
            // lblTurn
            // 
            this.lblTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(1203, 68);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 42);
            this.lblTurn.TabIndex = 11;
            // 
            // lblTextScore
            // 
            this.lblTextScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTextScore.AutoSize = true;
            this.lblTextScore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTextScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextScore.Location = new System.Drawing.Point(339, 465);
            this.lblTextScore.Name = "lblTextScore";
            this.lblTextScore.Size = new System.Drawing.Size(139, 42);
            this.lblTextScore.TabIndex = 13;
            this.lblTextScore.Text = "Points:";
            // 
            // lblTxtPointsTakenAway
            // 
            this.lblTxtPointsTakenAway.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTxtPointsTakenAway.AutoSize = true;
            this.lblTxtPointsTakenAway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTxtPointsTakenAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtPointsTakenAway.Location = new System.Drawing.Point(1000, 535);
            this.lblTxtPointsTakenAway.Name = "lblTxtPointsTakenAway";
            this.lblTxtPointsTakenAway.Size = new System.Drawing.Size(132, 18);
            this.lblTxtPointsTakenAway.TabIndex = 17;
            this.lblTxtPointsTakenAway.Text = "Points taken away:";
            this.lblTxtPointsTakenAway.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 920);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblTxtPointsTakenAway);
            this.Controls.Add(this.lblPointToTakeAway);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.lblTextScore);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblLevels);
            this.Controls.Add(this.lblTextLevel);
            this.Controls.Add(this.mnsGame);
            this.Controls.Add(this.picSelection);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAudio);
            this.Controls.Add(this.picItem);
            this.Controls.Add(this.picLetter);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1206, 657);
            this.Name = "frmMain";
            this.Text = "Let\'s read Ghana";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSelection)).EndInit();
            this.mnsGame.ResumeLayout(false);
            this.mnsGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picLetter;
        public System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.ToolTip tipGame;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.PictureBox picSelection;
        private System.Windows.Forms.MenuStrip mnsGame;
        private System.Windows.Forms.ToolStripMenuItem mnsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTextLevel;
        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblTextScore;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnStopTimer;
        public System.Windows.Forms.Label lblPointToTakeAway;
        private System.Windows.Forms.Label lblTxtPointsTakenAway;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ToolStripMenuItem levelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;

    }
}

