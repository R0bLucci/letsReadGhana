using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetsReadGhana
{
    // custom data type to set difficulty of the game 
    enum difficulty
    {
        Easy, // sound enabled, alphabet and item in order
        Normal, // sound enabled, alphabet in order, item scrambled 
        Intermediate, // sound enabled, alphabet and item scrambled
        Hard // sound disabled, alphabet and item scrambled
    }

    public partial class frmMain : Form
    {
        /*
         * @Author: Robert Owusu Ntim
         * 
         * @App title: Let's read Ghana
         * 
         * @Date: 27/03/15
         * 
         * @Description: Simple leveled game to learn the English alphabet
         * 
         */

        private string[] _letters; // list of all letters in the letters folder [file path in the string too]
        private string[] _sounds;
        private int _counterLetters = 0; // counter to loop through list of letters in the letters array string
        private string _letterName; // containing just the letter name wtihout file extension

        private int _fullRound = 1; // counter to determine when all 26 letters have passed
        private Score _score = new Score(0.0); // score class 
        private Timer _timer = new Timer();
        private int _ticksCounter = 0; // counter to determine when a tick has occured

        private string[] _items; // list of all letters in the letters folder [file path in the string too]
        private int _counterItem = 0; // counter to loop through list of letters in the letters array string



        private string _itemName; // containing just the item name wtihout file extension
        private SoundPlayer _soundPlayer; // Instance of sound player NOTE [only .wav file are supported]


        
        
        
        
        
        private difficulty _level = difficulty.Normal;

        public frmMain()
        {
            try
            {
                InitializeComponent();
                this._initializeGame();

            }
            catch(System.IO.DirectoryNotFoundException ex) // file not found exception 
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex) // general exception
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            this._ticksCounter += 1;
            this._score.Points -= this._score.decrement; // take away point at each timer tick 
            this.lblPoints.Text = this._score.Points.ToString("00.00"); // update the total points
            this.lblPointToTakeAway.Text = (this._score.decrement * this._ticksCounter).ToString("00.00"); // show how many total points have been taken away 
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            this._soundPlayer = new SoundPlayer(this._sounds[this._counterLetters]);//create new SoundPlayer object with update sound file to match current picture display in the main form 
            this._soundPlayer.Play(); // play curent .wav sound file
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            this.lblTxtPointsTakenAway.Visible = true;
            this.lblPointToTakeAway.Visible = true;
            this._counterReset(); // reset game 
            this._score.resetPoints(); // reset points 
            MyTimer.setInterval(this._timer, this._level); // set interval for timer 
            MyTimer.startTimer(this._timer); // start timer 
            this.btnStartTimer.Enabled = false;
            this.btnStartTimer.BackColor = SystemColors.Control;
            this.btnStopTimer.Enabled = true;
            this.btnStopTimer.BackColor = Color.PaleVioletRed;
            this.btnPause.Enabled = true;
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            this.lblTxtPointsTakenAway.Visible = false;
            this.lblPointToTakeAway.Visible = false;
            this._counterReset(); // reset game 
            this._score.resetPoints(); // reset points 
            this.btnStartTimer.Enabled = true;
            this.btnStartTimer.BackColor = Color.GreenYellow;
            this.btnStopTimer.Enabled = false;
            this.btnStopTimer.BackColor = SystemColors.Control;
            this.btnPause.Enabled = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (this._timer.Enabled) // if the timer is enabled
            {
                MyTimer.stopTimer(this._timer); // stop timer
                this.picSelection.Enabled = false; // disabled selection picture 
                this.btnNext.Enabled = false; // disable next button 
                this.btnBack.Enabled = false; // disabled back button
                this.btnStopTimer.Enabled = false;
                this.btnPause.BackColor = Color.Red; // set pause game button to a red color for visual clue
                this.btnPause.Text = "RESUME GAME";
            }
            else
            {
                MyTimer.startTimer(this._timer); // start timer 
                this.picSelection.Enabled = true;
                this.btnNext.Enabled = true;
                this.btnBack.Enabled = true;
                this.btnStopTimer.Enabled = true;
                this.btnPause.BackColor = SystemColors.Control; // reset system control colour
                this.btnPause.Text = "PAUSE GAME";
            }         
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // close application when form in closed
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("Are you sure to close the game?", "Close game", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (decision == DialogResult.Yes)
            {
                Application.Exit(); // close application form tool strip menu
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this._counterItem -= 1;
            if (this._counterItem < 0)
            {
                this._counterItem = 25;
                this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem);
            }
            else
            {
                this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this._counterItem += 1;
            if (this._counterItem > this._items.Length - 1)
            {
                this._counterItem = 0;
                this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem);
            }
            else
            {
                this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem);
            }
        }

        private void picSelection_Click(object sender, EventArgs e)
        {
            this._itemName = this._itemImageLocationAndName(this._items, this._counterItem);

            string message; // message to output to the user 
            if (this._letterName == this._itemName.ToCharArray()[0].ToString()) // check if the main form's picture and the first letter of the selection picture's name match
            {
                message = (this._letterName == "x") ? "The letter X as in OX" : string.Format("The letter {0} is for {1}", this._letterName.ToUpper(), this._itemName.ToUpper());

                MessageBox.Show(message, "WELL DONE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this._nextLetter(); // show next picture on the main form              
            }
            else // names do not match 
            {
                this._score.pointsEngine(false); // check if the answer is either correct or not, true = correct, false = incorrect

                message = (this._itemName == "x as in ox" && this._letterName == "o") ?
                    //Handle error case where the item OX is put as an answer for the O letter
                    "Good try !!! The letter O is in OX but JUST for this instance is NOT the right answer (use the audio help if you need to)" :
                    //Output error message if letter and item do not match
                    string.Format("The letter {0} is NOT for {1}", this._letterName.ToUpper(), this._itemName.ToUpper());

                MessageBox.Show(message, "WRONG ANSWER", MessageBoxButtons.OK, MessageBoxIcon.Error); // show error message
            }

            // update user score 
            this.lblPoints.Text = this._score.Points.ToString("00.00");
        }

        // set level to easy
        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._easyLevel();
        }

        //set level to normal
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._normalLevel();
        }

        //set level to intermediate
        private void intermediateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._intermediateLevel();
        }

        //set level to hard
        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._hardLevel();
        }

        //Open info form
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfo formInfo = new frmInfo();
            formInfo.ShowDialog();
        }

        //Open rules form
        private void levelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRules formRules = new frmRules();
            formRules.ShowDialog();
        }

        //Open points form 
        private void pointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoints formPoints = new frmPoints();
            formPoints.ShowDialog();
        }

        //Open timer form 
        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimer formTimer = new frmTimer();
            formTimer.ShowDialog();
        }

        //Initialize game at first boot
        private void _initializeGame()
        {
            this._letters = Game.lettersAndSoundsArrayShuffler(this._letters, true, false);
            this._letterName = this._letterImageLocationAndName(this._letters, this._counterLetters);
            this._sounds = Game.lettersAndSoundsArrayShuffler(this._sounds, false, false);
            this._items = Game.itemsArrayShuffler(this._items); // get list of item and shuffle list of item images
            this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem); // set and show pictue to the selection form and get current picture name
            this._timer.Tick += _timer_Tick;
            this.lblTurn.Text = this._fullRound.ToString("00");
            this.lblPoints.Text = this._score.Points.ToString("00.00");
            this._score.setPoints(this._level);
            this.btnPause.Enabled = false;
        }

        // set letter picture box and set/get letter's name
        private string _letterImageLocationAndName(string[] arr, int index)
        {
            string letterName;
            this.picLetter.ImageLocation = arr[index];
            letterName = Game.letterName(arr, index);
            return letterName;
        }

        // set selection picture box and set/get selection's name
        private string _selectionImageLocationAndName(string[] arr, int index)
        {
            string selecionName;
            this.picSelection.ImageLocation = arr[index];
            selecionName = Game.itemName(arr, index);
            return selecionName;
        }

        // set item picture box and set/get item's name
        private string _itemImageLocationAndName(string[] arr, int index)
        {
            string itemName;
            this.picItem.ImageLocation = arr[index];
            itemName = Game.itemName(arr, index);
            return itemName;
        }

        // letters and items images list are in alphabetical order and sound is available
        private void _easyLevel()
        {
            if (this.btnAudio.Enabled == false)
            {
                this.btnAudio.Enabled = true; // check if audio button is currently enabled
                this.btnAudio.BackColor = Color.Yellow;
            }
            this._counterLetters = 0; // reset letters counter each time the game's level is changed
            this._counterItem = 0; // reset items counter 
            this._counterReset();
            this._items = Game.itemsArrayShuffler(this._items, false); // get list of items image from the items folder
            this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem);  // select and show the first picture from the items list and update name with the current display item image
            this._letters = Game.lettersAndSoundsArrayShuffler(this._letters, true, false); // get list of items image from the letters folder
            this._letterName = this._letterImageLocationAndName(this._letters, this._counterLetters); // select and show the first picture from the letters list and update name of the current display letter image
            this._sounds = Game.lettersAndSoundsArrayShuffler(this._sounds, false, false); // get list of files sound path from the sounds folder
            this._level = difficulty.Easy;
            this._score.setPoints(this._level);
            MyTimer.setInterval(this._timer, this._level);
            lblLevels.Text = "Easy";
        }

        // letter list images are in alphabetical order but item images list are shuffled and sound is available [DEFAULT LEVEL]
        private void _normalLevel()
        {
            if (this.btnAudio.Enabled == false)
            {
                this.btnAudio.Enabled = true; // check if audio button is currently enabled
                this.btnAudio.BackColor = Color.Yellow;
            }
            this._counterLetters = 0; // reset letter counter each time the game's level is changed
            this._counterReset();
            this._items = Game.itemsArrayShuffler(this._items); // randomize or shuffle list of item image
            this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem); // select and show the first picture from the items list and update name with the current display item image
            this._letters = Game.lettersAndSoundsArrayShuffler(this._letters, true, false); // get list of items image from the letters folder 
            this._letterName = this._letterImageLocationAndName(this._letters, this._counterLetters); // select and show the first picture from the letters list update name of the current display letter image 
            this._sounds = Game.lettersAndSoundsArrayShuffler(this._sounds, false, false); // get list of files sound path from the sounds folder
            this._level = difficulty.Normal;
            this._score.setPoints(this._level);
            MyTimer.setInterval(this._timer, this._level);
            lblLevels.Text = "Normal";
        }

        // letters and items images list are shuffled but sound is available 
        private void _intermediateLevel()
        {
            if (this.btnAudio.Enabled == false)
            {
                this.btnAudio.Enabled = true; // check if audio button is currently enabled
                this.btnAudio.BackColor = Color.Yellow;
            }
            this._counterLetters = 0; // reset letter counter each time the game's level is changed
            this._counterReset();
            this._items = Game.itemsArrayShuffler(this._items); // randomize or shuffle list of item images
            this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem); // select and show the first picture from the items list and update name with the current display item image
            this._letters = Game.lettersAndSoundsArrayShuffler(this._letters, true, true);  // randomize or shuffle list of letters images
            this._letterName = this._letterImageLocationAndName(this._letters, this._counterLetters); // select and show the first picture from the letters list and update name of the current display letter image
            this._sounds = Game.lettersAndSoundsArrayShuffler(this._sounds, false, true); // randomize or shuffle list of sound path files
            this._level = difficulty.Intermediate;
            this._score.setPoints(this._level);
            MyTimer.setInterval(this._timer, this._level);
            lblLevels.Text = "Intermediate";
        }

        // letters and items images list are shuffled and sound is not available
        private void _hardLevel()
        {
            this.btnAudio.Enabled = false; // disable audio button
            this.btnAudio.BackColor = Color.Transparent;
            this._counterLetters = 0; // reset letter counter each time the game's level is changed
            this._counterReset();
            this._items = Game.itemsArrayShuffler(this._items); // randomize or shuffle list of item images
            this._itemName = this._selectionImageLocationAndName(this._items, this._counterItem); // select and show the first picture from the items list and update name with the current display item image
            this._letters = Game.lettersAndSoundsArrayShuffler(this._letters, true, true); // randomize or shuffle list of letters images
            this._letterName = this._letterImageLocationAndName(this._letters, this._counterLetters); // select and show the first picture from the letters list and update name of the current display letter image
            this._sounds = Game.lettersAndSoundsArrayShuffler(this._sounds, false, true); // randomize or shuffle list of sound path files
            this._level = difficulty.Hard;
            this._score.setPoints(this._level);
            MyTimer.setInterval(this._timer, this._level);
            lblLevels.Text = "Hard";
        }

        // counter to keep track when the user has gone through the whole alphabet 
        private void _roundCounter()
        {
            this._fullRound += 1;
            this.lblPoints.Text = this._score.Points.ToString("00.00");
            
            // check if the whole alphabet is done
            if(this._fullRound > this._letters.Length) 
            {
                MyTimer.stopTimer(this._timer);
               
                //set message to warn the user that they have finished the round
                string gameFinish;

                gameFinish = (this._score.Points > 0.0) ?
                    // message when you have a positive score
                    string.Format("Congratulation your score is: {0} at level: {1}. Would you like to play again?", this._score.Points.ToString("00.00"), this._level.ToString()) :
                    //message when you have a negative score
                    string.Format("Your score is only: {0} at level: {1}. Next time you will do better. Would you like to play again?", this._score.Points.ToString("00.00"), this._level.ToString());

                //save dialog result 
                DialogResult result = MessageBox.Show(gameFinish,"Game finished!!!!!!!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                //if user presses on no close the game
                if(result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    //restart the game 
                    this._counterReset();
                }        
            }
            this.lblTurn.Text = this._fullRound.ToString("00"); 
        }

        // reset counter 
        private void _counterReset()
        {
            if(this._timer.Enabled)
            {
                MyTimer.stopTimer(this._timer);
            }
            
            this.picItem.Image = null;
            this._ticksCounter = 0;
            this.lblPointToTakeAway.Text = (this._score.decrement * this._ticksCounter).ToString("00.00");
            this.btnStopTimer.Enabled = false;
            this.btnStopTimer.BackColor = SystemColors.Control;
            this.btnStartTimer.Enabled = true;
            this.btnStartTimer.BackColor = Color.GreenYellow;
            this._fullRound = 1; // reset alphabet counter for full round
            this.lblTurn.Text = this._fullRound.ToString("00"); // update GUI with new round number 
            this._score.resetPoints(); // reset point to zero 
            this.lblPoints.Text = this._score.Points.ToString("00.00"); //update GUI with the new points
        }

        // algorithm for proceeding to next letter
        private void _nextLetter()
        {
            this._score.pointsEngine();
            this._counterLetters += 1; // increment counter by 1
            this._roundCounter();
            if (this._counterLetters > this._letters.Length - 1) // check if the counter is greater than array size 
            {
                this._counterLetters = 0; // reset counter to zero
                this._letterName = this._letterImageLocationAndName(this._letters, this._counterLetters); // show picture of current index from the letter list variable and update the name with the current selected picture
            }
            else
            {
                this._letterName = this._letterImageLocationAndName(this._letters, this._counterLetters); // show picture of current index from the letter list variable and update the name with the current selected picture
            }
        }
    }
}
