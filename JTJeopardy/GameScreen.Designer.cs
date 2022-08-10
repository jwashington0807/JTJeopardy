namespace JTJeopardy
{
    partial class GameScreen
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
            this.label4 = new System.Windows.Forms.Label();
            this.gameScreenTabControl = new System.Windows.Forms.TabControl();
            this.startUpTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerThree = new System.Windows.Forms.TextBox();
            this.playerTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerOne = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.startGameTab = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameScreenTabControl.SuspendLayout();
            this.startUpTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.startGameTab.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(829, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "JT Jeopardy!";
            // 
            // gameScreenTabControl
            // 
            this.gameScreenTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameScreenTabControl.Controls.Add(this.startUpTab);
            this.gameScreenTabControl.Controls.Add(this.startGameTab);
            this.gameScreenTabControl.Controls.Add(this.settingsTab);
            this.gameScreenTabControl.Location = new System.Drawing.Point(1, 0);
            this.gameScreenTabControl.Name = "gameScreenTabControl";
            this.gameScreenTabControl.SelectedIndex = 0;
            this.gameScreenTabControl.Size = new System.Drawing.Size(1927, 1286);
            this.gameScreenTabControl.TabIndex = 8;
            // 
            // startUpTab
            // 
            this.startUpTab.BackColor = System.Drawing.Color.SteelBlue;
            this.startUpTab.Controls.Add(this.panel4);
            this.startUpTab.Controls.Add(this.panel1);
            this.startUpTab.Location = new System.Drawing.Point(4, 22);
            this.startUpTab.Name = "startUpTab";
            this.startUpTab.Padding = new System.Windows.Forms.Padding(3);
            this.startUpTab.Size = new System.Drawing.Size(1919, 1260);
            this.startUpTab.TabIndex = 0;
            this.startUpTab.Text = "Start";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(3, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1916, 623);
            this.panel4.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.playerThree, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerTwo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerOne, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(484, 195);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // playerThree
            // 
            this.playerThree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerThree.Location = new System.Drawing.Point(685, 113);
            this.playerThree.Name = "playerThree";
            this.playerThree.Size = new System.Drawing.Size(260, 20);
            this.playerThree.TabIndex = 5;
            this.playerThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // playerTwo
            // 
            this.playerTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerTwo.Location = new System.Drawing.Point(359, 113);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(260, 20);
            this.playerTwo.TabIndex = 4;
            this.playerTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contestant One";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 82);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contestant Two";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 82);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contestant Three";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerOne
            // 
            this.playerOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerOne.Location = new System.Drawing.Point(33, 113);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(260, 20);
            this.playerOne.TabIndex = 3;
            this.playerOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(380, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1913, 319);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 325);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1906, 407);
            this.panel2.TabIndex = 9;
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(1919, 1260);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // startGameTab
            // 
            this.startGameTab.BackColor = System.Drawing.Color.Azure;
            this.startGameTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startGameTab.Controls.Add(this.panel5);
            this.startGameTab.Location = new System.Drawing.Point(4, 22);
            this.startGameTab.Name = "startGameTab";
            this.startGameTab.Padding = new System.Windows.Forms.Padding(3);
            this.startGameTab.Size = new System.Drawing.Size(1919, 1260);
            this.startGameTab.TabIndex = 1;
            this.startGameTab.Text = "Game";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(7, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1900, 915);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(122, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GameScreen
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 975);
            this.Controls.Add(this.gameScreenTabControl);
            this.Name = "GameScreen";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.gameScreenTabControl.ResumeLayout(false);
            this.startUpTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.startGameTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl gameScreenTabControl;
        private System.Windows.Forms.TabPage startUpTab;
        private System.Windows.Forms.TabPage startGameTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerThree;
        private System.Windows.Forms.TextBox playerTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox playerOne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

