using System.Collections.Generic;
namespace OSK1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        private int timelimit = 20;
        private int timex;
        private int timeo;
        private char turn = 'x';
        private bool game = false;
        private char result;
        private string bluex = "blue_x.png";
        private string blackx = "black_x.png";
        private string blueo = "blue_circle.png";
        private string blacko = "black_circle.png";
        private string blackback = "black_square.png";
        private string blueback = "blue_square.png";
        private string picturex;
        private string pictureo;
        private string pictureback;
        private string theme = "light";
        private char[] moves = new char[9];
        private bool pause = false;
        private int turncount;
        private List<char> results = new List<char>();
        private List<int> timexresults = new List<int>();
        private List<int> timeoresults = new List<int>();
        private List<int> timelimitresults = new List<int>();
        public Form2 window;
        private bool arrows = false;
        private int focusedbox = 0;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox00 = new System.Windows.Forms.PictureBox();
            this.labelx = new System.Windows.Forms.Label();
            this.labelo = new System.Windows.Forms.Label();
            this.labeltx = new System.Windows.Forms.Label();
            this.labelto = new System.Windows.Forms.Label();
            this.timertx = new System.Windows.Forms.Timer(this.components);
            this.timerto = new System.Windows.Forms.Timer(this.components);
            this.buttongame = new System.Windows.Forms.Button();
            this.buttonpause = new System.Windows.Forms.Button();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonstat = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox01 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox02 = new System.Windows.Forms.PictureBox();
            this.labelwin = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.timer_setter = new System.Windows.Forms.TextBox();
            this.set_time = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox02)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox00
            // 
            this.pictureBox00.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox00.Image")));
            this.pictureBox00.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox00.InitialImage")));
            this.pictureBox00.Location = new System.Drawing.Point(4, 4);
            this.pictureBox00.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox00.Name = "pictureBox00";
            this.pictureBox00.Size = new System.Drawing.Size(93, 93);
            this.pictureBox00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox00.TabIndex = 0;
            this.pictureBox00.TabStop = false;
            this.pictureBox00.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox00.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox00.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelx.Location = new System.Drawing.Point(40, 107);
            this.labelx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(103, 18);
            this.labelx.TabIndex = 9;
            this.labelx.Text = "Czas gracza x";
            // 
            // labelo
            // 
            this.labelo.AutoSize = true;
            this.labelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelo.Location = new System.Drawing.Point(203, 107);
            this.labelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelo.Name = "labelo";
            this.labelo.Size = new System.Drawing.Size(105, 18);
            this.labelo.TabIndex = 10;
            this.labelo.Text = "Czas gracza o";
            // 
            // labeltx
            // 
            this.labeltx.AutoSize = true;
            this.labeltx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeltx.Location = new System.Drawing.Point(44, 139);
            this.labeltx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltx.Name = "labeltx";
            this.labeltx.Size = new System.Drawing.Size(55, 24);
            this.labeltx.TabIndex = 11;
            this.labeltx.Text = "00:00";
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelto.Location = new System.Drawing.Point(207, 139);
            this.labelto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(55, 24);
            this.labelto.TabIndex = 12;
            this.labelto.Text = "00:00";
            // 
            // timertx
            // 
            this.timertx.Enabled = true;
            this.timertx.Interval = 1000;
            this.timertx.Tick += new System.EventHandler(this.timertx_Tick);
            // 
            // timerto
            // 
            this.timerto.Interval = 1000;
            this.timerto.Tick += new System.EventHandler(this.timerto_Tick);
            // 
            // buttongame
            // 
            this.buttongame.CausesValidation = false;
            this.buttongame.Location = new System.Drawing.Point(43, 263);
            this.buttongame.Margin = new System.Windows.Forms.Padding(4);
            this.buttongame.Name = "buttongame";
            this.buttongame.Size = new System.Drawing.Size(127, 48);
            this.buttongame.TabIndex = 13;
            this.buttongame.Text = "1. Nowa gra";
            this.buttongame.UseVisualStyleBackColor = true;
            this.buttongame.Click += new System.EventHandler(this.buttongame_Click);
            this.buttongame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            // 
            // buttonpause
            // 
            this.buttonpause.Location = new System.Drawing.Point(206, 263);
            this.buttonpause.Margin = new System.Windows.Forms.Padding(4);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(123, 48);
            this.buttonpause.TabIndex = 14;
            this.buttonpause.Text = "2. Pauza";
            this.buttonpause.UseVisualStyleBackColor = true;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(43, 319);
            this.buttonsave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(127, 48);
            this.buttonsave.TabIndex = 15;
            this.buttonsave.Text = "3. Zapisz wynik";
            this.buttonsave.UseVisualStyleBackColor = true;
            this.buttonsave.Click += new System.EventHandler(this.buttonsave_Click);
            // 
            // buttonstat
            // 
            this.buttonstat.Location = new System.Drawing.Point(206, 319);
            this.buttonstat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonstat.Name = "buttonstat";
            this.buttonstat.Size = new System.Drawing.Size(123, 48);
            this.buttonstat.TabIndex = 16;
            this.buttonstat.Text = "4. Zobacz statystyki";
            this.buttonstat.UseVisualStyleBackColor = true;
            this.buttonstat.Click += new System.EventHandler(this.buttonstat_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox10.InitialImage")));
            this.pictureBox10.Location = new System.Drawing.Point(4, 4);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(93, 93);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox10.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox10.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox20.InitialImage")));
            this.pictureBox20.Location = new System.Drawing.Point(4, 3);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(93, 93);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 18;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox20.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox20.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox21.InitialImage")));
            this.pictureBox21.Location = new System.Drawing.Point(4, 3);
            this.pictureBox21.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(93, 93);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 21;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox21.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox21.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox11.InitialImage")));
            this.pictureBox11.Location = new System.Drawing.Point(4, 4);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(93, 93);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 20;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox11.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox11.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox01
            // 
            this.pictureBox01.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox01.Image")));
            this.pictureBox01.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox01.InitialImage")));
            this.pictureBox01.Location = new System.Drawing.Point(4, 4);
            this.pictureBox01.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox01.Name = "pictureBox01";
            this.pictureBox01.Size = new System.Drawing.Size(93, 93);
            this.pictureBox01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox01.TabIndex = 19;
            this.pictureBox01.TabStop = false;
            this.pictureBox01.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox01.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox01.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox22.InitialImage")));
            this.pictureBox22.Location = new System.Drawing.Point(4, 4);
            this.pictureBox22.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(93, 93);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 24;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox22.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox22.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox12.InitialImage")));
            this.pictureBox12.Location = new System.Drawing.Point(4, 4);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(93, 93);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox12.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox12.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // pictureBox02
            // 
            this.pictureBox02.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox02.Image")));
            this.pictureBox02.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox02.InitialImage")));
            this.pictureBox02.Location = new System.Drawing.Point(4, 4);
            this.pictureBox02.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox02.Name = "pictureBox02";
            this.pictureBox02.Size = new System.Drawing.Size(93, 93);
            this.pictureBox02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox02.TabIndex = 22;
            this.pictureBox02.TabStop = false;
            this.pictureBox02.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox02.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox02.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // labelwin
            // 
            this.labelwin.AutoSize = true;
            this.labelwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelwin.Location = new System.Drawing.Point(480, 79);
            this.labelwin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelwin.Name = "labelwin";
            this.labelwin.Size = new System.Drawing.Size(0, 20);
            this.labelwin.TabIndex = 25;
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Location = new System.Drawing.Point(41, 79);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(23, 17);
            this.State.TabIndex = 26;
            this.State.Text = "---";
            this.State.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            this.themeToolStripMenuItem.Click += new System.EventHandler(this.themeToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox00);
            this.panel1.Location = new System.Drawing.Point(428, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 101);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox01);
            this.panel2.Location = new System.Drawing.Point(535, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 101);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox02);
            this.panel3.Location = new System.Drawing.Point(642, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 101);
            this.panel3.TabIndex = 30;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Location = new System.Drawing.Point(428, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 101);
            this.panel4.TabIndex = 31;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox11);
            this.panel5.Location = new System.Drawing.Point(535, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(101, 101);
            this.panel5.TabIndex = 30;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox12);
            this.panel6.Location = new System.Drawing.Point(642, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(101, 101);
            this.panel6.TabIndex = 30;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox20);
            this.panel7.Location = new System.Drawing.Point(428, 316);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(101, 101);
            this.panel7.TabIndex = 30;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox21);
            this.panel8.Location = new System.Drawing.Point(535, 316);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(101, 101);
            this.panel8.TabIndex = 30;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pictureBox22);
            this.panel9.Location = new System.Drawing.Point(642, 315);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(101, 101);
            this.panel9.TabIndex = 30;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // timer_setter
            // 
            this.timer_setter.Location = new System.Drawing.Point(43, 185);
            this.timer_setter.Name = "timer_setter";
            this.timer_setter.Size = new System.Drawing.Size(127, 23);
            this.timer_setter.TabIndex = 32;
            // 
            // set_time
            // 
            this.set_time.CausesValidation = false;
            this.set_time.Location = new System.Drawing.Point(43, 211);
            this.set_time.Name = "set_time";
            this.set_time.Size = new System.Drawing.Size(127, 23);
            this.set_time.TabIndex = 33;
            this.set_time.Text = "Ustaw czas";
            this.set_time.UseVisualStyleBackColor = true;
            this.set_time.Click += new System.EventHandler(this.set_time_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.set_time);
            this.Controls.Add(this.timer_setter);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.State);
            this.Controls.Add(this.labelwin);
            this.Controls.Add(this.buttonstat);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.buttonpause);
            this.Controls.Add(this.buttongame);
            this.Controls.Add(this.labelto);
            this.Controls.Add(this.labeltx);
            this.Controls.Add(this.labelo);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox02)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox00;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labelo;
        private System.Windows.Forms.Label labeltx;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.Timer timertx;
        private System.Windows.Forms.Timer timerto;
        private System.Windows.Forms.Button buttongame;
        private System.Windows.Forms.Button buttonpause;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonstat;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox01;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox02;
        private System.Windows.Forms.Label labelwin;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox timer_setter;
        private System.Windows.Forms.Button set_time;
    }
}

