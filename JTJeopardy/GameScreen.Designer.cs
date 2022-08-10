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
            this.playerOneName = new System.Windows.Forms.TextBox();
            this.playerTwoName = new System.Windows.Forms.TextBox();
            this.playerThreeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gameScreenTabControl = new System.Windows.Forms.TabControl();
            this.startUpTab = new System.Windows.Forms.TabPage();
            this.startGameTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.gameScreenTabControl.SuspendLayout();
            this.startUpTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerOneName
            // 
            this.playerOneName.Location = new System.Drawing.Point(678, 554);
            this.playerOneName.Name = "playerOneName";
            this.playerOneName.Size = new System.Drawing.Size(100, 26);
            this.playerOneName.TabIndex = 0;
            // 
            // playerTwoName
            // 
            this.playerTwoName.Location = new System.Drawing.Point(1029, 554);
            this.playerTwoName.Name = "playerTwoName";
            this.playerTwoName.Size = new System.Drawing.Size(100, 26);
            this.playerTwoName.TabIndex = 1;
            // 
            // playerThreeName
            // 
            this.playerThreeName.Location = new System.Drawing.Point(1372, 554);
            this.playerThreeName.Name = "playerThreeName";
            this.playerThreeName.Size = new System.Drawing.Size(100, 26);
            this.playerThreeName.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1063, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1050, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1399, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1062, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // gameScreenTabControl
            // 
            this.gameScreenTabControl.Controls.Add(this.startUpTab);
            this.gameScreenTabControl.Controls.Add(this.startGameTab);
            this.gameScreenTabControl.Controls.Add(this.settingsTab);
            this.gameScreenTabControl.Location = new System.Drawing.Point(24, 12);
            this.gameScreenTabControl.Name = "gameScreenTabControl";
            this.gameScreenTabControl.SelectedIndex = 0;
            this.gameScreenTabControl.Size = new System.Drawing.Size(2349, 1224);
            this.gameScreenTabControl.TabIndex = 8;
            // 
            // startUpTab
            // 
            this.startUpTab.BackColor = System.Drawing.Color.RosyBrown;
            this.startUpTab.Controls.Add(this.playerOneName);
            this.startUpTab.Controls.Add(this.label4);
            this.startUpTab.Controls.Add(this.label1);
            this.startUpTab.Controls.Add(this.button1);
            this.startUpTab.Controls.Add(this.label3);
            this.startUpTab.Controls.Add(this.playerThreeName);
            this.startUpTab.Controls.Add(this.label2);
            this.startUpTab.Controls.Add(this.playerTwoName);
            this.startUpTab.Location = new System.Drawing.Point(4, 29);
            this.startUpTab.Name = "startUpTab";
            this.startUpTab.Padding = new System.Windows.Forms.Padding(3);
            this.startUpTab.Size = new System.Drawing.Size(2341, 1191);
            this.startUpTab.TabIndex = 0;
            this.startUpTab.Text = "Start";
            // 
            // startGameTab
            // 
            this.startGameTab.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.startGameTab.Location = new System.Drawing.Point(4, 29);
            this.startGameTab.Name = "startGameTab";
            this.startGameTab.Padding = new System.Windows.Forms.Padding(3);
            this.startGameTab.Size = new System.Drawing.Size(2341, 1191);
            this.startGameTab.TabIndex = 1;
            this.startGameTab.Text = "Game";
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 29);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(2341, 1191);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // GameScreen
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2327, 1170);
            this.Controls.Add(this.gameScreenTabControl);
            this.Name = "GameScreen";
            this.gameScreenTabControl.ResumeLayout(false);
            this.startUpTab.ResumeLayout(false);
            this.startUpTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox playerOneName;
        private System.Windows.Forms.TextBox playerTwoName;
        private System.Windows.Forms.TextBox playerThreeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl gameScreenTabControl;
        private System.Windows.Forms.TabPage startUpTab;
        private System.Windows.Forms.TabPage startGameTab;
        private System.Windows.Forms.TabPage settingsTab;
    }
}

