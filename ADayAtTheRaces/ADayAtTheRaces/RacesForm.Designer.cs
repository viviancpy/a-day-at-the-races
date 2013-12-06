namespace ADayAtTheRaces
{
    partial class RacesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bettorNameLabel = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dogNumber = new System.Windows.Forms.NumericUpDown();
            this.raceButton = new System.Windows.Forms.Button();
            this.dogRunTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dog1IsHandicapped = new System.Windows.Forms.CheckBox();
            this.dog2IsHandicapped = new System.Windows.Forms.CheckBox();
            this.dog3IsHandicapped = new System.Windows.Forms.CheckBox();
            this.dog4IsHandicapped = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dog4PictureBox = new System.Windows.Forms.PictureBox();
            this.dog3PictureBox = new System.Windows.Forms.PictureBox();
            this.dog2PictureBox = new System.Windows.Forms.PictureBox();
            this.dog1PictureBox = new System.Windows.Forms.PictureBox();
            this.raceTrackerPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dog4IsHandicapped);
            this.groupBox1.Controls.Add(this.dog3IsHandicapped);
            this.groupBox1.Controls.Add(this.dog2IsHandicapped);
            this.groupBox1.Controls.Add(this.dog1IsHandicapped);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Controls.Add(this.dogNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.betAmount);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.bettorNameLabel);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(3, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(12, 27);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(98, 16);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "Minimum bet:";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Checked = true;
            this.joeRadioButton.Location = new System.Drawing.Point(15, 46);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(15, 69);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(15, 92);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(92, 17);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bets";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(200, 50);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(117, 13);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "Joe hasn\'t placed a bet";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(200, 73);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(119, 13);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "Bob hasn\'t placed a bet";
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(200, 96);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(109, 13);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "Al hasn\'t placed a bet";
            // 
            // bettorNameLabel
            // 
            this.bettorNameLabel.AutoSize = true;
            this.bettorNameLabel.Location = new System.Drawing.Point(15, 116);
            this.bettorNameLabel.Name = "bettorNameLabel";
            this.bettorNameLabel.Size = new System.Drawing.Size(35, 13);
            this.bettorNameLabel.TabIndex = 8;
            this.bettorNameLabel.Text = "Name";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(56, 111);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(51, 23);
            this.betButton.TabIndex = 9;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(122, 114);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(55, 20);
            this.betAmount.TabIndex = 10;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "bucks on dog number";
            // 
            // dogNumber
            // 
            this.dogNumber.Location = new System.Drawing.Point(300, 114);
            this.dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumber.Name = "dogNumber";
            this.dogNumber.Size = new System.Drawing.Size(55, 20);
            this.dogNumber.TabIndex = 12;
            this.dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(511, 116);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(75, 29);
            this.raceButton.TabIndex = 13;
            this.raceButton.Text = "Race !";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // dogRunTimer
            // 
            this.dogRunTimer.Interval = 2;
            this.dogRunTimer.Tick += new System.EventHandler(this.dogRunTimer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Handicap dogs";
            // 
            // dog1IsHandicapped
            // 
            this.dog1IsHandicapped.AutoSize = true;
            this.dog1IsHandicapped.Location = new System.Drawing.Point(405, 69);
            this.dog1IsHandicapped.Name = "dog1IsHandicapped";
            this.dog1IsHandicapped.Size = new System.Drawing.Size(52, 17);
            this.dog1IsHandicapped.TabIndex = 15;
            this.dog1IsHandicapped.Text = "Dog1";
            this.dog1IsHandicapped.UseVisualStyleBackColor = true;
            this.dog1IsHandicapped.CheckedChanged += new System.EventHandler(this.dog1IsHandicapped_CheckedChanged);
            // 
            // dog2IsHandicapped
            // 
            this.dog2IsHandicapped.AutoSize = true;
            this.dog2IsHandicapped.Location = new System.Drawing.Point(492, 69);
            this.dog2IsHandicapped.Name = "dog2IsHandicapped";
            this.dog2IsHandicapped.Size = new System.Drawing.Size(52, 17);
            this.dog2IsHandicapped.TabIndex = 16;
            this.dog2IsHandicapped.Text = "Dog2";
            this.dog2IsHandicapped.UseVisualStyleBackColor = true;
            this.dog2IsHandicapped.CheckedChanged += new System.EventHandler(this.dog2IsHandicapped_CheckedChanged);
            // 
            // dog3IsHandicapped
            // 
            this.dog3IsHandicapped.AutoSize = true;
            this.dog3IsHandicapped.Location = new System.Drawing.Point(405, 88);
            this.dog3IsHandicapped.Name = "dog3IsHandicapped";
            this.dog3IsHandicapped.Size = new System.Drawing.Size(52, 17);
            this.dog3IsHandicapped.TabIndex = 17;
            this.dog3IsHandicapped.Text = "Dog3";
            this.dog3IsHandicapped.UseVisualStyleBackColor = true;
            this.dog3IsHandicapped.CheckedChanged += new System.EventHandler(this.dog3IsHandicapped_CheckedChanged);
            // 
            // dog4IsHandicapped
            // 
            this.dog4IsHandicapped.AutoSize = true;
            this.dog4IsHandicapped.Location = new System.Drawing.Point(492, 88);
            this.dog4IsHandicapped.Name = "dog4IsHandicapped";
            this.dog4IsHandicapped.Size = new System.Drawing.Size(52, 17);
            this.dog4IsHandicapped.TabIndex = 18;
            this.dog4IsHandicapped.Text = "Dog4";
            this.dog4IsHandicapped.UseVisualStyleBackColor = true;
            this.dog4IsHandicapped.CheckedChanged += new System.EventHandler(this.dog4IsHandicapped_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "(winnings x 2)";
            // 
            // dog4PictureBox
            // 
            this.dog4PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog4PictureBox.Location = new System.Drawing.Point(9, 161);
            this.dog4PictureBox.Name = "dog4PictureBox";
            this.dog4PictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog4PictureBox.TabIndex = 4;
            this.dog4PictureBox.TabStop = false;
            // 
            // dog3PictureBox
            // 
            this.dog3PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog3PictureBox.Location = new System.Drawing.Point(9, 112);
            this.dog3PictureBox.Name = "dog3PictureBox";
            this.dog3PictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog3PictureBox.TabIndex = 3;
            this.dog3PictureBox.TabStop = false;
            // 
            // dog2PictureBox
            // 
            this.dog2PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog2PictureBox.Location = new System.Drawing.Point(9, 57);
            this.dog2PictureBox.Name = "dog2PictureBox";
            this.dog2PictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog2PictureBox.TabIndex = 2;
            this.dog2PictureBox.TabStop = false;
            // 
            // dog1PictureBox
            // 
            this.dog1PictureBox.Image = global::ADayAtTheRaces.Properties.Resources.dog;
            this.dog1PictureBox.Location = new System.Drawing.Point(9, 8);
            this.dog1PictureBox.Name = "dog1PictureBox";
            this.dog1PictureBox.Size = new System.Drawing.Size(75, 20);
            this.dog1PictureBox.TabIndex = 1;
            this.dog1PictureBox.TabStop = false;
            // 
            // raceTrackerPictureBox
            // 
            this.raceTrackerPictureBox.Image = global::ADayAtTheRaces.Properties.Resources.racetrack;
            this.raceTrackerPictureBox.Location = new System.Drawing.Point(0, 0);
            this.raceTrackerPictureBox.Name = "raceTrackerPictureBox";
            this.raceTrackerPictureBox.Size = new System.Drawing.Size(601, 202);
            this.raceTrackerPictureBox.TabIndex = 0;
            this.raceTrackerPictureBox.TabStop = false;
            // 
            // RacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dog4PictureBox);
            this.Controls.Add(this.dog3PictureBox);
            this.Controls.Add(this.dog2PictureBox);
            this.Controls.Add(this.dog1PictureBox);
            this.Controls.Add(this.raceTrackerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RacesForm";
            this.Text = "A Day at the Races";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrackerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrackerPictureBox;
        private System.Windows.Forms.PictureBox dog1PictureBox;
        private System.Windows.Forms.PictureBox dog2PictureBox;
        private System.Windows.Forms.PictureBox dog3PictureBox;
        private System.Windows.Forms.PictureBox dog4PictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.NumericUpDown dogNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label bettorNameLabel;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Timer dogRunTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox dog4IsHandicapped;
        private System.Windows.Forms.CheckBox dog3IsHandicapped;
        private System.Windows.Forms.CheckBox dog2IsHandicapped;
        private System.Windows.Forms.CheckBox dog1IsHandicapped;
        private System.Windows.Forms.Label label3;
    }
}

