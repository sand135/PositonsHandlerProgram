using System;

namespace Labb2
{
    internal class Position
    {

        private int x; 
        private int y;

        public Position(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        public int GetX()
        {
            return x; 
        }

        public int GetY()
        {
            return y; 
        }

        /// <summary>
        /// sätter eventuella negativa värden till 0
        /// </summary>
        /// <param name="value"></param>
        public void SetX(int value)
        {
            this.x = value < 0 ? 0 : value;
        }

        /// <summary>
        /// Sätter eventuella negativa värden till 0
        /// </summary>
        /// <param name="value"></param>
        public void SetY(int value)
        {
            
            this.y = value<0 ? 0 : value;  
        }


        /// <summary>
        /// returnerar avståndet från origo(koordinaten (0, 0)) till den här punkten.
        /// </summary>
        /// <returns>punkten längd från origo</returns>
        public double Length()
        {
            var distanceFromOrigo = System.Math.Sqrt((this.x * this.x) + (this.y * this.y)); 

            return distanceFromOrigo;
        }

       
        public bool Equals(Position p)
        {
            if (p.GetX() == this.x && p.GetY() == this.y)
            {
                return true; 
            }
            else
            {
                return false;
            }
            
        }

        /// <summary>
        /// "Deep-klonar" punkten
        /// </summary>
        /// <returns>en ny instans av Position, som har samma X och Y•värden som den nuvarande punktne</returns>
        public Position Clone()
        { 
            var clone = new Position(this.x, this.y);
            return clone;
        }



        /// <summary>
        /// jämför två positioners avstånd från origo
        /// Om positionerna har samma längd från origo:
        /// jämför x•variablen istället
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Returnerar true om p1 ligger längst ifrånorigo</returns>
        public static bool operator >(Position p1, Position p2)
        {
            if (p1.Length() > p2.Length())
            {
                return true;
            }

            if (p1.Length() == p2.Length())
            {
                if (p1.GetX() > p2.GetX())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// jämför två positioners avstånd från orig
        /// Om positionerna har samma längd från origo:
        ///jämför x•variablen istället
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>true om p2 ligger längst ifrånorigo</returns>
        public static bool operator <(Position p1, Position p2)
        {
            if(p1.Length() < p2.Length())
            {
                return true;
            }

            if (p1.Length() == p2.Length())
            {
                if(p1.GetX() < p2.GetX())
                {
                    return true;
                }
            }
            return false;
        }


        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.GetX()+p2.GetX(), p1.GetY() + p2.GetY());
        }

        public static Position operator -(Position p1, Position p2)
        {
            if (p1 < p2)
            {
                return new Position(p2.GetX() - p1.GetX(), p2.GetY() - p1.GetY());
            }
            else
            {
                return new Position(p1.GetX() - p2.GetX(), p1.GetY() - p2.GetY());
            }
        }


        /// <summary>
        /// Räknar ut avståndet mellan två punkter
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double operator %(Position p1, Position p2)
        {
            var position = p1 - p2; 
            var lengthBetweenPoints = Math.Sqrt((position.GetX() * position.GetX()) + (position.GetY()* position.GetY())); 
            return lengthBetweenPoints; 

        }


        public override string ToString()
        {
            return $"({this.x},{this.y})"; 
        }

    }
}