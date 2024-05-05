
namespace FootballManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Position_txt = new System.Windows.Forms.ComboBox();
            this.Side_txt = new System.Windows.Forms.ComboBox();
            this.Num_txt = new System.Windows.Forms.ComboBox();
            this.Position = new System.Windows.Forms.Label();
            this.Side = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.New_Player = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 831);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Position_txt
            // 
            this.Position_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Position_txt.FormattingEnabled = true;
            this.Position_txt.Items.AddRange(new object[] {
            "GoalKeeper",
            "Defender",
            "Midfielder",
            "Striker"});
            this.Position_txt.Location = new System.Drawing.Point(925, 32);
            this.Position_txt.Name = "Position_txt";
            this.Position_txt.Size = new System.Drawing.Size(121, 24);
            this.Position_txt.TabIndex = 1;
            // 
            // Side_txt
            // 
            this.Side_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Side_txt.FormattingEnabled = true;
            this.Side_txt.Items.AddRange(new object[] {
            "L",
            "M",
            "R",
            " "});
            this.Side_txt.Location = new System.Drawing.Point(925, 77);
            this.Side_txt.Name = "Side_txt";
            this.Side_txt.Size = new System.Drawing.Size(121, 24);
            this.Side_txt.TabIndex = 2;
            // 
            // Num_txt
            // 
            this.Num_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Num_txt.FormattingEnabled = true;
            this.Num_txt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.Num_txt.Location = new System.Drawing.Point(925, 122);
            this.Num_txt.Name = "Num_txt";
            this.Num_txt.Size = new System.Drawing.Size(121, 24);
            this.Num_txt.TabIndex = 3;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(861, 35);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(58, 17);
            this.Position.TabIndex = 4;
            this.Position.Text = "Position";
            // 
            // Side
            // 
            this.Side.AutoSize = true;
            this.Side.Location = new System.Drawing.Point(861, 80);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(36, 17);
            this.Side.TabIndex = 5;
            this.Side.Text = "Side";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(861, 125);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(58, 17);
            this.Number.TabIndex = 6;
            this.Number.Text = "Number";
            // 
            // New_Player
            // 
            this.New_Player.Location = new System.Drawing.Point(864, 175);
            this.New_Player.Name = "New_Player";
            this.New_Player.Size = new System.Drawing.Size(182, 42);
            this.New_Player.TabIndex = 7;
            this.New_Player.Text = "Add Player";
            this.New_Player.UseVisualStyleBackColor = true;
            this.New_Player.Click += new System.EventHandler(this.New_Player_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(992, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(992, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 858);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.New_Player);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Side);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.Num_txt);
            this.Controls.Add(this.Side_txt);
            this.Controls.Add(this.Position_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Football Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Position_txt;
        private System.Windows.Forms.ComboBox Side_txt;
        private System.Windows.Forms.ComboBox Num_txt;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label Side;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Button New_Player;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

