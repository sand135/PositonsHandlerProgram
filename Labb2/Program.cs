        using System;

        namespace Labb2
        {
            class MainClass
            {
                public static void Main(string[] args)
                {
       
                    Console.WriteLine(new Position(2, 4) + new Position(1, 2) + "\n");
                    Console.WriteLine(new Position(2, 4) - new Position(1, 2) + "\n");
                    Console.WriteLine(new Position(1, 2) - new Position(3, 6) + "\n");
                    Console.WriteLine(new Position(3, 5) % new Position(1, 3) + "\n");

                    SortedPosList list1 = new SortedPosList();
                    SortedPosList list2 = new SortedPosList();
                    list1.Add(new Position(3, 7));
                    list1.Add(new Position(1, 4));
                    list1.Add(new Position(2, 6));
                    list1.Add(new Position(2, 3));
                    Console.WriteLine(list1 + "\n");
                    list1.Remove(new Position(2, 6));
                    Console.WriteLine(list1 + "\n");

                    list2.Add(new Position(3, 7));
                    list2.Add(new Position(1, 2));
                    list2.Add(new Position(3, 6));
                    list2.Add(new Position(2, 3));
                    Console.WriteLine((list2 + list1) + "\n");

                    SortedPosList circleList = new SortedPosList();
                    circleList.Add(new Position(1, 1));
                    circleList.Add(new Position(2, 2));
                    circleList.Add(new Position(3, 3));
                    Console.WriteLine(circleList.CircleContent(new Position(5, 5), 4) + "\n");


                    SortedPosList A = new SortedPosList();
                    A.Add(new Position(3, 7));
                    A.Add(new Position(1, 4));
                    A.Add(new Position(2, 6));
                    A.Add(new Position(2, 3));

                    SortedPosList B = new SortedPosList();
                    B.Add(new Position(3, 7));
                    B.Add(new Position(1, 2));
                    B.Add(new Position(3, 6));
                    B.Add(new Position(2, 3));
                    B.Add(new Position(22, 3));
            B.Add(new Position(24, 3));

            Console.WriteLine($"A-listan innehåller punkterna: {A}");
                    Console.WriteLine($"B-listan innehåller {B}");
                    Console.WriteLine($"A-B blir: {A-B}");
                    Console.WriteLine($"B-A blir: {B - A}");
            }
        }
        }
