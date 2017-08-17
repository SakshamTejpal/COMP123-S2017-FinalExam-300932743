using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name:Saksham Tejpal
 * Date:8/17/17
 * StudentID:300932743
 * Description:Driver Class
 * Version:0.3-Added constructor and methods to Scoreboard Class
 */
namespace COMP123_S2017_FinalExam_300932743
{/// <summary>
/// 
/// </summary>
    public class Scoreboard
    {
        
        /// <summary>
        /// Feilds for this class
        /// </summary>
        private TextBox _finalScoreTextBox;
        private TextBox _scoreTextBox;
        private TextBox _timeTextBox;
        private int _score;
        private int _time;
        /// <summary>
        /// Properties
        /// </summary>
        
           
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }

        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = int.Parse(this.ScoreTextBox.Text);
                this._score = int.Parse(this.FinalScoreTextBox.Text);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = Convert.ToInt16(this.TimeTextBox);

            }
        }

        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }
        /// <summary>
        /// Counstructor
        /// </summary>
        public Scoreboard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            scoreTextBox = _scoreTextBox;
            timeTextBox = _timeTextBox;
            finalScoreTextBox = _finalScoreTextBox;

        }
        /// <summary>
        /// Public methods
        /// </summary>
        public void UpdateTime()
        {
            this.Time = ((int.Parse(this.TimeTextBox.Text)) - 1);
            this.TimeTextBox.Text = Convert.ToString(this.Time);

        }

    }

}
