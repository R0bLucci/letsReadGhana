using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LetsReadGhana
{

    class Score 
    {

        private double _point; // user total points 
        private double _levelPointsToAdd; // points to add for every right answer 
        private double _levelPointsToSub; // points to subtract for every wrong answer
        public double decrement; // points to subtract at every timer tick
        

        //constructor 
        public Score(double p)
        {
            this.Points = p;
        }

        //proprierty 
        public double Points
        {
            get
            {
                return _point;
            }

            set 
            {
                this._point = value;
            }
        }

        //set points based on level of difficulty 
        public void setPoints(difficulty level)
        {
            switch (level)
            {
                case difficulty.Easy:
                    this._levelPointsToAdd = 2.50;
                    this._levelPointsToSub = 1.00;
                    this.decrement = 0.50;
                    break;
                case difficulty.Normal:
                    this._levelPointsToAdd = 2.50;
                    this._levelPointsToSub = 1.50;
                    this.decrement = 0.75;
                    break;
                case difficulty.Intermediate:
                    this._levelPointsToAdd = 2.50;
                    this._levelPointsToSub = 2.00;
                    this.decrement = 1.0;
                    break;
                case difficulty.Hard:
                    this._levelPointsToAdd = 2.50;
                    this._levelPointsToSub = 2.50;
                    this.decrement = 1.25;
                    break;
            }
        }

        public void pointsEngine(bool correct = true)
        { 
            if (correct) 
            {
                this.Points += this._levelPointsToAdd;
            }
            else
            {
                this.Points -= this._levelPointsToSub; 
            }
        }
        
        //method to subtract Points NOT USED
        //public void takeAwayPoint(double p)
        //{
        //    this.Points -= p;
        //}

        ////method to add Points NOT USED 
        //public void givePoint(double p)
        //{
        //    this.Points += p;
        //}

        public void resetPoints()
        {
            this.Points = 0.0;
        }
    }
}