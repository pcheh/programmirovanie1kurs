using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Task_6
{
    public partial class MainForm : Form
    {
        Stack<Card>[] stacks = new Stack<Card>[9];
        Stack<Card> sbros = new Stack<Card>();

        Stack<Card> stack1 = null;
        Stack<Card> stack2 = null;

        Card activeCard;
        Card secondCard;
        int activeCardIndex;

        public MainForm()
        {
            InitializeComponent();

            NewGame();
        }

        private void NewGame()
        {
            var colors = new[] { "C", "D", "H", "S" };
            var values = new[] { "6", "7", "8", "9", "T", "J", "Q", "K", "A" };

            var cards = new Card[36];
            for (var i = 0; i < colors.Length; i++)
                for (var k = 0; k < values.Length; k++)
                    cards[(i * values.Length) + k] = new Card(colors[i], values[k]);

            Random rnd = new Random();

            for (int i = 0; i < cards.Length - 1; ++i)
            {
                int r = rnd.Next(i, cards.Length);
                (cards[r], cards[i]) = (cards[i], cards[r]);
            }

            for (var i = 0; i < stacks.Length; i++)
            {
                stacks[i] = new Stack<Card>();

                for (var k = 0; k < 4; k++)
                {
                    var curCard = cards[i * 4 + k];
                    stacks[i].Push(curCard);
                }
            }

            drawCards();
        }

        private static void loadPicture(Card c, PictureBox box)
        {
            var pic = Application.StartupPath + @"\Images\" + c.Color + c.Value + ".png";
            box.Load(pic);
        }

        private void drawCards()
        {
            for (var i = 0; i < stacks.Length; i++)
            {
                var pictureBox = (PictureBox)Controls.Find("pictureBox" + (i + 1).ToString(), true)[0];
                if (stacks[i].Count > 0)
                    loadPicture(stacks[i].Peek(), pictureBox);
                else
                    pictureBox.Image = null;
            }

            var sbrosBox = (PictureBox)Controls.Find("pictureBox10", true)[0];
            if (sbros.Count > 0)
                loadPicture(sbros.Peek(), sbrosBox);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form exit = new ExitForm();

            var result = exit.ShowDialog();

            if (result == DialogResult.OK)
                Application.Exit();

            else if (result == DialogResult.No)
                exit.Close();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            NewGame();
            sbros.Clear();
            var sbrosBox = (PictureBox)Controls.Find("pictureBox10", true)[0];
            sbrosBox.Image = null;
        }
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sbros.Count>0 && sbros.Count<36)
            {
                var c1 = sbros.Pop();
                stack1.Push(c1);
                var c2 = sbros.Pop();
                stack2.Push(c2);

                drawCards();
                if (sbros.Count == 0)
                    pictureBox10.Image = null;
                undoToolStripMenuItem.Enabled = false;
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rules = new Rules();

            var result = rules.ShowDialog();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            var box = (PictureBox)sender;
            if (activeCard == null)
            {
                var stackIndex = (string)box.Tag;
                var i = int.Parse(stackIndex);
                if (stacks[i].Count > 0)
                {
                    activeCard = stacks[i].Peek();
                    activeCardIndex = i;
                    box.BorderStyle = BorderStyle.Fixed3D;
                }
            }
            else
            {
                var stackIndex = (string)box.Tag;
                var i = int.Parse(stackIndex);
                if (stacks[i].Count > 0)
                    secondCard = stacks[i].Peek();

                if (activeCard.Value == secondCard.Value && activeCard.Color != secondCard.Color)
                {
                    var c1 = stacks[i].Pop();
                    var c2 = stacks[activeCardIndex].Pop();
                    sbros.Push(c2);
                    sbros.Push(c1);

                    stack1 = stacks[i];
                    stack2 = stacks[activeCardIndex];

                    drawCards();
                    undoToolStripMenuItem.Enabled = true;

                    if (sbros.Count == 36)
                    {
                        Form congrats = new CongratsForm();
                        var result = congrats.ShowDialog();
                        //NewGame();
                    }
                }

                activeCard = null;
                var pictureBox = (PictureBox)Controls.Find("pictureBox" + (activeCardIndex + 1).ToString(), true)[0];
                pictureBox.BorderStyle = BorderStyle.None;
            }

        }
    }
}
