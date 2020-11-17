using System;
using System.Drawing;
using System.Windows.Forms;

namespace HangMan_s_Game
{
    public partial class HangsManGame : Form
    {
        private int CurrentLabelLetter = 1;
        private string WordToGuess;
        private Image[] Images = new Image[6];
        private int CountError = 0;
        private bool IsFirstPlayer = true;
        private string input;

        public HangsManGame()
        {
            InitializeComponent();

            Setup();
        }
        private void InsertLetter(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;
            if (IsFirstPlayer)
            {
                groupBoxWordToGuess.Controls["letter" + CurrentLabelLetter].Text = buttonText;
                CurrentLabelLetter++;
                if (CurrentLabelLetter == 6)
                {
                    for (int i = 1; i <= 26; i++)
                    {
                        groupBoxKeyBoard.Controls["button" + i].Enabled = false;
                    }
                    BackSpace.Enabled = false;
                }
            }
            else
            {
                if (WordToGuess.Contains(buttonText))
                {
                    for (int i = 0; i < WordToGuess.Length; i++)
                    {
                        if (WordToGuess[i].ToString() == buttonText)
                        {
                            groupBoxWordToGuess.Controls["letter" + (i + 1)].Text = buttonText;
                        }
                    }

                    input = letter1.Text + letter2.Text + letter3.Text + letter4.Text + letter5.Text;

                    if (WordToGuess == input)
                        replayBtn.Visible = true;
                }
                else
                {
                    CountError++;
                    if (CountError == 6)
                    {
                        groupBoxKeyBoard.Enabled = false;
                        pictureBox.Size = new Size(330, 220);
                    }
                    pictureBox.Image = Images[CountError - 1];
                }
                (sender as Button).Enabled = false;
            }
        }
        private void BackSpace_Click(object sender, EventArgs e)
        {
            if (CurrentLabelLetter > 1)
                groupBoxWordToGuess.Controls["letter" + (CurrentLabelLetter - 1)].Text = "";
            CurrentLabelLetter--;
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            Label curLabel;
            for (int i = 1; i <= 5; i++)
            {
                curLabel = groupBoxWordToGuess.Controls["letter" + i] as Label;
                WordToGuess += curLabel.Text;
                curLabel.Text = "";
            }
            BackSpace.Visible = false;
            Enter.Visible = false;
            if (CurrentLabelLetter == 6)
                Enter.Enabled = true;
            for (int i = 1; i <= 26; i++)
            {
                groupBoxKeyBoard.Controls["button" + i].Enabled = true;
            }
            Enter.Enabled = false;
            IsFirstPlayer = false;
        }
        public void Setup()
        {
            replayBtn.Visible = false;
            pictureBox.Size = new Size(330, 179);
            BackSpace.Visible = true;
            Enter.Visible = true;
            BackSpace.Enabled = true;
            Enter.Enabled = true;
            //מציבה תמונות בכל תאי מערך התמונות
            Images[0] = Properties.Resources.stage1;
            Images[1] = Properties.Resources.stage2;
            Images[2] = Properties.Resources.stage3;
            Images[3] = Properties.Resources.stage4;
            Images[4] = Properties.Resources.stage5;
            Images[5] = Properties.Resources.stage6;
            pictureBox.Image = null;
            groupBoxKeyBoard.Enabled = true;
            for (int i = 0; i < WordToGuess.Length; i++)
            {
                groupBoxWordToGuess.Controls["letter" + (i + 1)].Text = "";
            }
            IsFirstPlayer = true;
            for (int i = 1; i <= 26; i++)
            {
                groupBoxKeyBoard.Controls["button" + i].Enabled = true;
            }
            CurrentLabelLetter = 1;
        }

        private void Replay(object sender, EventArgs e)
        {
            Setup();
        }
        /*
הוספת התייחסות למצב שהשחקן השני ניצח
עיצוב + שינוי פונט
רקע GIF
אפשרות ללחוץ על המקלדת ?
*/
    }
}
