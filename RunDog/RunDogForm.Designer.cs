namespace RunDog
{
    partial class RunDogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunDogForm));
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.DogPictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.onDogLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BetButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.RaceButton = new System.Windows.Forms.Button();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.Betslabel = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.minBetLabel = new System.Windows.Forms.Label();
            this.DogPictureBox2 = new System.Windows.Forms.PictureBox();
            this.DogPictureBox3 = new System.Windows.Forms.PictureBox();
            this.DogPictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBG.Image")));
            this.pictureBoxBG.Location = new System.Drawing.Point(2, 8);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(738, 273);
            this.pictureBoxBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBG.TabIndex = 0;
            this.pictureBoxBG.TabStop = false;
            // 
            // DogPictureBox1
            // 
            this.DogPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("DogPictureBox1.Image")));
            this.DogPictureBox1.Location = new System.Drawing.Point(12, 18);
            this.DogPictureBox1.Name = "DogPictureBox1";
            this.DogPictureBox1.Size = new System.Drawing.Size(91, 38);
            this.DogPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogPictureBox1.TabIndex = 1;
            this.DogPictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.onDogLabel);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.BetButton);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.RaceButton);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.Betslabel);
            this.groupBox1.Controls.Add(this.alRadioButton);
            this.groupBox1.Controls.Add(this.bobRadioButton);
            this.groupBox1.Controls.Add(this.joeRadioButton);
            this.groupBox1.Controls.Add(this.minBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(2, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(326, 150);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 23);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // onDogLabel
            // 
            this.onDogLabel.AutoSize = true;
            this.onDogLabel.Location = new System.Drawing.Point(182, 153);
            this.onDogLabel.Name = "onDogLabel";
            this.onDogLabel.Size = new System.Drawing.Size(138, 17);
            this.onDogLabel.TabIndex = 12;
            this.onDogLabel.Text = "bucks on dog number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(112, 150);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 23);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BetButton
            // 
            this.BetButton.Location = new System.Drawing.Point(57, 150);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(40, 23);
            this.BetButton.TabIndex = 10;
            this.BetButton.Text = "Bets";
            this.BetButton.UseVisualStyleBackColor = true;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(19, 153);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "name";
            // 
            // RaceButton
            // 
            this.RaceButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RaceButton.Location = new System.Drawing.Point(538, 28);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(176, 145);
            this.RaceButton.TabIndex = 8;
            this.RaceButton.Text = "Race!";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alBetLabel.Location = new System.Drawing.Point(256, 114);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(247, 21);
            this.alBetLabel.TabIndex = 7;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bobBetLabel.Location = new System.Drawing.Point(256, 87);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(247, 21);
            this.bobBetLabel.TabIndex = 6;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joeBetLabel.Location = new System.Drawing.Point(256, 59);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(247, 21);
            this.joeBetLabel.TabIndex = 5;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // Betslabel
            // 
            this.Betslabel.AutoSize = true;
            this.Betslabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Betslabel.Location = new System.Drawing.Point(256, 28);
            this.Betslabel.Name = "Betslabel";
            this.Betslabel.Size = new System.Drawing.Size(40, 19);
            this.Betslabel.TabIndex = 4;
            this.Betslabel.Text = "Bets";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(10, 113);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(108, 21);
            this.alRadioButton.TabIndex = 3;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "alRadioButton";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(10, 86);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(122, 21);
            this.bobRadioButton.TabIndex = 2;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "bobRadioButton";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(10, 59);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(116, 21);
            this.joeRadioButton.TabIndex = 1;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "joeRadioButton";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // minBetLabel
            // 
            this.minBetLabel.AutoSize = true;
            this.minBetLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minBetLabel.Location = new System.Drawing.Point(10, 28);
            this.minBetLabel.Name = "minBetLabel";
            this.minBetLabel.Size = new System.Drawing.Size(99, 19);
            this.minBetLabel.TabIndex = 0;
            this.minBetLabel.Text = "minBetBabel";
            // 
            // DogPictureBox2
            // 
            this.DogPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("DogPictureBox2.Image")));
            this.DogPictureBox2.Location = new System.Drawing.Point(12, 86);
            this.DogPictureBox2.Name = "DogPictureBox2";
            this.DogPictureBox2.Size = new System.Drawing.Size(91, 38);
            this.DogPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogPictureBox2.TabIndex = 3;
            this.DogPictureBox2.TabStop = false;
            // 
            // DogPictureBox3
            // 
            this.DogPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("DogPictureBox3.Image")));
            this.DogPictureBox3.Location = new System.Drawing.Point(12, 161);
            this.DogPictureBox3.Name = "DogPictureBox3";
            this.DogPictureBox3.Size = new System.Drawing.Size(91, 38);
            this.DogPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogPictureBox3.TabIndex = 4;
            this.DogPictureBox3.TabStop = false;
            // 
            // DogPictureBox4
            // 
            this.DogPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("DogPictureBox4.Image")));
            this.DogPictureBox4.Location = new System.Drawing.Point(12, 230);
            this.DogPictureBox4.Name = "DogPictureBox4";
            this.DogPictureBox4.Size = new System.Drawing.Size(91, 38);
            this.DogPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DogPictureBox4.TabIndex = 5;
            this.DogPictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RunDogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 491);
            this.Controls.Add(this.DogPictureBox4);
            this.Controls.Add(this.DogPictureBox3);
            this.Controls.Add(this.DogPictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DogPictureBox1);
            this.Controls.Add(this.pictureBoxBG);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(760, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 519);
            this.Name = "RunDogForm";
            this.Text = "RunDogForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogPictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBoxBG;
        private PictureBox DogPictureBox1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown2;
        private Label onDogLabel;
        private NumericUpDown numericUpDown1;
        private Button BetButton;
        private Label nameLabel;
        private Button RaceButton;
        private Label alBetLabel;
        private Label bobBetLabel;
        private Label joeBetLabel;
        private Label Betslabel;
        private RadioButton alRadioButton;
        private RadioButton bobRadioButton;
        private RadioButton joeRadioButton;
        private Label minBetLabel;
        private PictureBox DogPictureBox2;
        private PictureBox DogPictureBox3;
        private PictureBox DogPictureBox4;
        private System.Windows.Forms.Timer timer1;
    }
}