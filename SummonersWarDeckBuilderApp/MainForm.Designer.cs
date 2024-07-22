namespace SummonersWarDeckBuilderApp
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
            elementComboBox = new ComboBox();
            elementLabel = new Label();
            monsterLabel = new Label();
            monsterComboBox = new ComboBox();
            searchMonsterButton = new Button();
            searchMonsterTextBox = new TextBox();
            searchMonsterLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // elementComboBox
            // 
            elementComboBox.FormattingEnabled = true;
            elementComboBox.Location = new Point(24, 68);
            elementComboBox.Name = "elementComboBox";
            elementComboBox.Size = new Size(121, 27);
            elementComboBox.TabIndex = 0;
            elementComboBox.SelectedIndexChanged += elementComboBox_SelectedIndexChanged;
            // 
            // elementLabel
            // 
            elementLabel.AutoSize = true;
            elementLabel.Location = new Point(24, 46);
            elementLabel.Name = "elementLabel";
            elementLabel.Size = new Size(58, 19);
            elementLabel.TabIndex = 1;
            elementLabel.Text = "Element";
            // 
            // monsterLabel
            // 
            monsterLabel.AutoSize = true;
            monsterLabel.Location = new Point(180, 46);
            monsterLabel.Name = "monsterLabel";
            monsterLabel.Size = new Size(61, 19);
            monsterLabel.TabIndex = 2;
            monsterLabel.Text = "Monster";
            // 
            // monsterComboBox
            // 
            monsterComboBox.FormattingEnabled = true;
            monsterComboBox.Location = new Point(180, 68);
            monsterComboBox.Name = "monsterComboBox";
            monsterComboBox.Size = new Size(121, 27);
            monsterComboBox.TabIndex = 3;
            monsterComboBox.SelectedIndexChanged += monsterComboBox_SelectedIndexChanged;
            // 
            // searchMonsterButton
            // 
            searchMonsterButton.Location = new Point(202, 155);
            searchMonsterButton.Name = "searchMonsterButton";
            searchMonsterButton.Size = new Size(75, 23);
            searchMonsterButton.TabIndex = 4;
            searchMonsterButton.Text = "Search";
            searchMonsterButton.UseVisualStyleBackColor = true;
            searchMonsterButton.Click += searchMonsterButton_Click;
            // 
            // searchMonsterTextBox
            // 
            searchMonsterTextBox.Location = new Point(24, 152);
            searchMonsterTextBox.Name = "searchMonsterTextBox";
            searchMonsterTextBox.Size = new Size(100, 26);
            searchMonsterTextBox.TabIndex = 5;
            // 
            // searchMonsterLabel
            // 
            searchMonsterLabel.AutoSize = true;
            searchMonsterLabel.Location = new Point(24, 130);
            searchMonsterLabel.Name = "searchMonsterLabel";
            searchMonsterLabel.Size = new Size(108, 19);
            searchMonsterLabel.TabIndex = 6;
            searchMonsterLabel.Text = "Search by Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(354, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 589);
            Controls.Add(pictureBox1);
            Controls.Add(searchMonsterLabel);
            Controls.Add(searchMonsterTextBox);
            Controls.Add(searchMonsterButton);
            Controls.Add(monsterComboBox);
            Controls.Add(monsterLabel);
            Controls.Add(elementLabel);
            Controls.Add(elementComboBox);
            Name = "MainForm";
            Text = "Summoners War Deck Builder";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox elementComboBox;
        private Label elementLabel;
        private Label monsterLabel;
        private ComboBox monsterComboBox;
        private Button searchMonsterButton;
        private TextBox searchMonsterTextBox;
        private Label searchMonsterLabel;
        private PictureBox pictureBox1;
    }
}
