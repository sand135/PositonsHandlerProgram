using System.Collections.Generic;

namespace Labb2
{
    internal class SortedPosList
    {

        private List<Position> positionList = new List<Position>();


        public Position this[int key]
        {
            get => GetPositionAt(key);

        }


        public Position GetPositionAt(int index)
        {
            if (positionList.Count >= index)
            {
                return positionList[index];
            }
            else
            {
                return new Position(0, 0);
            }
        }


        public int Count()
        {
            return positionList.Count;
        }


        /// <summary>
        /// Sätter till en punkt i listan på rätt ställe så att listan alltid sorterar punkterna enligt längd från origo
        /// </summary>
        /// <param name="pos"></param>
        public void Add(Position pos)
        {
            for (int i = 0; i < positionList.Count; i++)
            {
                if (pos < positionList[i])
                {
                    positionList.Insert(i, pos);
                    return;
                }
            }
            positionList.Add(pos);
        }



        public bool Remove(Position pos)
        {
            for (int i = 0; i < positionList.Count; i++)
            {
                if (pos.Equals(positionList[i]))
                {
                    positionList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// Deep-Klonar listan och dens punkter
        /// </summary>
        /// <returns>En ny sorterad lista med exakt samma värden</returns>
        public SortedPosList Clone()
        {
            var clonedList = new SortedPosList();
            for (int i = 0; i < positionList.Count; i++)
            {
                clonedList.Add(positionList[i].Clone());
            }
            return clonedList;
        }



        /// <summary>
        /// Kollar ifall punkterna i en lista faller inom en cirkel med en specifik centerpunkt och radie.
        /// </summary>
        /// <param name="centerPos">centerpunkten för cirkeln</param>
        /// <param name="radius">cirkelns radie</param>
        /// <returns>En ny lista med alla punkter som finns inom cirkeln</returns>
        public SortedPosList CircleContent(Position centerPos, double radius)
        {
            var circlePosList = Clone();
            for (int i = 0; i < circlePosList.Count(); i++)
            {
                if (circlePosList[i] % centerPos > radius)
                {
                    if (circlePosList.Remove(circlePosList[i]))
                    {
                        i--;
                    }
                }
            }
            return circlePosList;
        }


        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            var sumList = sp1.Clone();
            foreach (Position p in sp2.positionList)
            {
                sumList.Add(p);
            }
            return sumList;
        }


        public static SortedPosList operator -(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList newList = sp1.Clone();
            for (int i = 0; i < sp2.Count(); i++)
            {
                for (int j = 0; j < newList.Count(); j++)
                {
                    if (sp2[i].Equals(newList[j]))
                    {
                        if (newList.Remove(newList[j]))
                        {
                            j--;
                        }
                    }
                }
            }
            return newList;
        }


        public override string ToString()
        {
            return string.Join(", ", positionList);
        }

    }
}