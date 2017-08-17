using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* Name: Anupom Roy
* Date: August 17,2017
* StudentID: 300853516
* Description:ScoreBoard class is for assign score
* Version: 0.1 ScoreBoard class

*/
namespace COMP123_S2017_FinalExam_300853516
{
    class ScoreBoard
    {
        // private member variable
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _ScoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
        //PUBLIC PROPERTIES
        public TextBox FinalScoreTextBox
        {
            get; set;                
        }
        public int Score { get; set; }
        public TextBox ScoreTextBox { get; set; }
        public int Time { get; set; }
        public TextBox TimeTextBox { get; set; }
        /// <summary>
        /// this is public constractor
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            ScoreTextBox = scoreTextBox;
            TimeTextBox = timeTextBox;
            FinalScoreTextBox = finalScoreTextBox;
        }
        public void UpdateTime()
        {

        }
    }
}
