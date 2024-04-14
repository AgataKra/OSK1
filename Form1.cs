using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSK1
{   
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            this.timertx.Stop();
            this.timerto.Stop();
            this.picturex = OSK1.Properties.Resources.black_x;
            this.pictureo = OSK1.Properties.Resources.black_circle;
            this.pictureback = OSK1.Properties.Resources.black_square;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        private void reset_Picture()
        {
            change_Theme();
        }
        private bool validate_Move(char value)
        {
            if (value != 'x' && value != 'o')
                return true;
            else
                return false;
        }
        private void change_Theme()
        {
            Panel[] panels = { this.panel1, this.panel2, this.panel3, this.panel4, this.panel5, this.panel6, this.panel7, this.panel8, this.panel9 };
            PictureBox[] boxes = {this.pictureBox00, this.pictureBox01, this.pictureBox02, 
                this.pictureBox10, this.pictureBox11, this.pictureBox12,
                this.pictureBox20, this.pictureBox21, this.pictureBox22};
            Label[] labels = { this.State, this.labelo, this.labelx, this.labelto, this.labeltx, this.labelwin};
            Color labelcolor = Color.White;
            Color panelcolor = Color.White;
            switch (this.theme)
            {
                case "light":
                    this.picturex = OSK1.Properties.Resources.black_x;
                    this.pictureo = OSK1.Properties.Resources.black_circle;
                    this.pictureback = OSK1.Properties.Resources.black_square;
                    this.BackColor = Color.White;
                    labelcolor = Color.Black;
                    panelcolor = Color.White;
                    break;

                case "dark":
                    this.picturex = OSK1.Properties.Resources.blue_x;
                    this.pictureo = OSK1.Properties.Resources.blue_circle;
                    this.pictureback = OSK1.Properties.Resources.blue_square;
                    this.BackColor = Color.Black;
                    labelcolor = Color.LightSkyBlue;
                    panelcolor = Color.Black;
                    break;
            }
            for (int i = 0; i < boxes.Length; i++)
            {
                if (this.moves[i] == 'x')
                    boxes[i].Image = this.picturex;
                else if (this.moves[i] == 'o')
                    boxes[i].Image = this.pictureo;
                else
                    boxes[i].Image = this.pictureback;
                panels[i].BackColor = panelcolor;
            }
            for(int i = 0; i < labels.Length; i++)
            {
                labels[i].ForeColor = labelcolor;
            }
        }
        private void display_Time(Label label, int time)
        {
            int seconds = time % 60;
            int minutes = (time - seconds) / 60;
            label.Text = minutes + ":" + seconds;
        }
        private void change_Timer()
        {
            this.timertx.Enabled = !this.timertx.Enabled;
            this.timerto.Enabled = !this.timerto.Enabled;
        }
        private bool insert_Move(string name)
        {
            this.turncount++;
            int row = (int)(name[name.Length - 2] - '0');
            int column = (int)(name[name.Length - 1] - '0');
            if (!validate_Move(moves[3 * row + column])) {
                return false;
            }
            this.moves[row*3 + column] = this.turn;
            //this.label1.Text = row + " " + column + " " + this.moves[row*3 + column];
            return true;
        }
        private void end_Game(char result)
        {
            this.result = result;
            this.game = false;
            this.timertx.Stop();
            this.timerto.Stop();
            for (int i = 0; i < 9; i++)
            {
                this.moves[i] = ' ';
            }
            if (result == 'd')
            {
                this.labelwin.Text = "Koniec gry! Remis";
                return;
            }
            else
            {
                this.labelwin.Text = "Koniec gry! Wygrał gracz: " + result;
            }
        }
        private void check_State()
        {
            // Horizontal/Vertical
            for (int i = 0; i < 9; i+=3)
            {
                if (this.moves[i] == this.moves[i + 1] && this.moves[i] == this.moves[i + 2] && (this.moves[i] == 'x' || this.moves[i] == 'o'))
                {
                    this.end_Game(this.turn);
                    //this.State.Text = "Hor win";
                    return;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (this.moves[i] == this.moves[i + 3] && this.moves[i] == this.moves[i + 6] && (this.moves[i] == 'x' || this.moves[i] == 'o'))
                {
                    this.end_Game(this.turn);
                    //this.State.Text = "Ver win";
                    return;
                }
            }
            // Diagonal
            if (this.moves[0] == this.moves[4] && this.moves[0] == this.moves[8] && (this.moves[0] == 'x' || this.moves[0] == 'o'))
            {
                this.end_Game(this.turn);
                return;
            }
            else if (this.moves[2] == this.moves[4] && this.moves[2] == this.moves[6] && (this.moves[2] == 'x' || this.moves[2] == 'o'))
            {
                this.end_Game(this.turn);
                return;
            } 
            // Draw
            else if (this.turncount > 9)
                this.end_Game('d');
        }
        private void buttongame_Click(object sender, EventArgs e)
        {   
            if (this.game == true)
            {
                return;
            }
            else
            {
                reset_Picture();
                this.State.Text = "Tura: " + '1' + " Gracz: " + this.turn;
                this.turncount = 1;
                this.timex = timelimit;
                this.timeo = timelimit;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        this.moves[3 * i + j] = ' ';
                    }
                }
                //this.label1.Text = this.moves[0, 0].ToString() + this.moves[0, 1].ToString() + this.moves[0, 2].ToString() + this.moves[2, 1].ToString();
                this.labelwin.Text = "";
                this.display_Time(this.labeltx, this.timex);
                this.display_Time(this.labelto, this.timeo);
                this.game = true;
                this.turn = 'x';
                this.timertx.Start();
            }
        }
        private void buttonpause_Click(object sender, EventArgs e)
        {
            if (!this.pause)
            {
                if (this.timertx.Enabled)
                {
                    this.timertx.Stop();
                }
                if (this.timerto.Enabled)
                {
                    this.timerto.Stop();
                }
                this.pause = true;
                this.State.Text = "PAUZA";
            }
            else
            {
                if (this.turn == 'x')
                {
                    this.timertx.Start();
                }
                else if (this.turn == 'o')
                {
                    this.timerto.Start();
                }
                this.pause = false;
                this.State.Text = "";
            }
        }
        private void timertx_Tick(object sender, EventArgs e)
        {
            this.timex--;
            this.display_Time(this.labeltx, this.timex);
            if (this.timex <= 0)
            {
                this.end_Game('o');
            }
        }
        private void timerto_Tick(object sender, EventArgs e)
        {    
            this.timeo--;
            this.display_Time(this.labelto, this.timeo);
            
            if (this.timeo <= 0)
            {
                this.end_Game('x');
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {   
            if (this.pause)
            {
                MessageBox.Show("Trwa pauza!");
                return;
            }
            if (!this.game)
            {
                MessageBox.Show("Nie trwa gra!");
                return;
            }
            PictureBox box = (PictureBox)sender;
            if (!this.insert_Move(box.Name))
                return;
            if (this.turn == 'x')
            {
                box.Image = picturex;
                this.check_State();
                if (!this.game)
                    return;
                this.turn = 'o';
                this.change_Timer();
            }
            else if (this.turn == 'o')
            {
                box.Image = pictureo;
                this.check_State();
                if (!this.game)
                    return;
                this.turn = 'x';
                this.change_Timer();
            }
            this.State.Text = "Tura: " + turncount + " Gracz: " + this.turn;
        }
        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.theme = "light";
            this.change_Theme();
        }
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.theme = "dark";
            this.change_Theme();
        }
        private void buttonsave_Click(object sender, EventArgs e)
        {
            // Save results to results; save :
            // - time left for each side
            // - beginning time
            // - result
            if (this.game)
                return;
            this.results.Add(this.result);
            this.timelimitresults.Add(this.timelimit);
            this.timexresults.Add(this.timex);
            this.timeoresults.Add(this.timeo);
        }
        private void buttonstat_Click(object sender, EventArgs e)
        {
            this.window = new Form2(this, this.results, this.timexresults, this.timeoresults, this.timelimitresults);
            this.window.Show();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   
            
        }
        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            Panel[] panels = { this.panel1, this.panel2, this.panel3, this.panel4, this.panel5, this.panel6, this.panel7, this.panel8, this.panel9 };
            PictureBox box = (PictureBox)sender;
            string name = box.Name;
            int row = (int)(name[name.Length - 2] - '0');
            int column = (int)(name[name.Length - 1] - '0');
            int number = row * 3 + column;
            panels[number].BackColor = Color.LightBlue;
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            Panel[] panels = { this.panel1, this.panel2, this.panel3, this.panel4, this.panel5, this.panel6, this.panel7, this.panel8, this.panel9 };
            PictureBox box = (PictureBox)sender;
            string name = box.Name;
            int row = (int)(name[name.Length - 2] - '0');
            int column = (int)(name[name.Length - 1] - '0');
            int number = row * 3 + column;
            if (this.theme == "light")
                panels[number].BackColor = Color.White;
            else if (this.theme == "dark")
                panels[number].BackColor = Color.Black;
        }
        private void Form1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1')
            {
                this.buttongame.PerformClick();
            }
            else if (e.KeyChar == '2')
            {
                this.buttonpause.PerformClick();
            }
            else if (e.KeyChar == '3')
            {
                this.buttonsave.PerformClick();
            }
            else if (e.KeyChar == '4')
            {
                this.buttonstat.PerformClick();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void set_time_Click(object sender, EventArgs e)
        {
            if (this.game)
            {
                MessageBox.Show("Trwa gra!");
                return;
            }    
            try
            {
                int time = int.Parse(timer_setter.Text);
                this.timelimit = time;
            } catch (FormatException)
            {
                MessageBox.Show("Wpisz poprawny czas w sekundach!");
            }
        }
    }
}
