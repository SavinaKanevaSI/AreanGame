namespace WinFormArenaGame
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewGame = new Button();
            leftTextBox = new TextBox();
            rightTextBox = new TextBox();
            imgFight = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lbWinner = new Label();
            comboBox1 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imgFight).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(695, 12);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // leftTextBox
            // 
            leftTextBox.Location = new Point(12, 35);
            leftTextBox.Multiline = true;
            leftTextBox.Name = "leftTextBox";
            leftTextBox.Size = new Size(474, 437);
            leftTextBox.TabIndex = 1;
            // 
            // rightTextBox
            // 
            rightTextBox.Location = new Point(978, 35);
            rightTextBox.Multiline = true;
            rightTextBox.Name = "rightTextBox";
            rightTextBox.Size = new Size(474, 437);
            rightTextBox.TabIndex = 2;
            rightTextBox.TextChanged += tbAssassin_TextChanged;
            // 
            // imgFight
            // 
            imgFight.Enabled = false;
            imgFight.Image = (Image)resources.GetObject("imgFight.Image");
            imgFight.Location = new Point(632, 275);
            imgFight.Name = "imgFight";
            imgFight.Size = new Size(206, 134);
            imgFight.TabIndex = 3;
            imgFight.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1162, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 5;
            label1.Text = "Second opponent";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 6;
            label2.Text = "First opponent";
            label2.Click += label2_Click;
            // 
            // lbWinner
            // 
            lbWinner.Location = new Point(658, 59);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(219, 93);
            lbWinner.TabIndex = 4;
            lbWinner.Visible = false;
            lbWinner.Click += lbWinner_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Assassin", "Knight", "Fairy", "Unicorn", "Wizard" });
            comboBox1.Location = new Point(658, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Pick Opponent 1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Assassin", "Knight", "Fairy", "Unicorn", "Wizard" });
            comboBox3.Location = new Point(658, 211);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 9;
            comboBox3.Text = "Pick Opponent 2";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 504);
            Controls.Add(comboBox3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbWinner);
            Controls.Add(imgFight);
            Controls.Add(rightTextBox);
            Controls.Add(leftTextBox);
            Controls.Add(btnNewGame);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)imgFight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private TextBox leftTextBox;
        private TextBox rightTextBox;
        private PictureBox imgFight;
        private Label label1;
        private Label label2;
        private Label lbWinner;
        private ComboBox comboBox1;
        private ComboBox comboBox3;
    }
}