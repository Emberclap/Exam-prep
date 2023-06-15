namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();
            string command = " ";
            int cupidPosition = 0;
            while ((command = Console.ReadLine()) != "Love!")
            {
                List<string> list = command
                    .Split()
                    .ToList();
                int jumpLenght = int.Parse(list[1]);
                cupidPosition += jumpLenght;

                if (cupidPosition > neighborhood.Count-1)
                {
                    cupidPosition = 0;
                    ValentinesDay(neighborhood, list, cupidPosition);
                    neighborhood[cupidPosition] -= 2;
                    
                }
                else
                {
                    ValentinesDay(neighborhood, list, cupidPosition);
                    neighborhood[cupidPosition] -= 2;
                }

            }
            Console.WriteLine($"Cupid's last position was {cupidPosition}.");

            int housesWithoutVday = 0;
            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] > 0)
                {
                    housesWithoutVday++;
                }
            }
            if (housesWithoutVday > 0)
            {
                Console.WriteLine($"Cupid has failed {housesWithoutVday} places.");
            }
            else 
            {
                Console.WriteLine("Mission was successful.");
            }

        }
        static void ValentinesDay(List<int> neighborhood, List<string> list, int number)
        {
            
            int houseIndex = number;
            if (neighborhood[houseIndex] <= 0)
            {
                Console.WriteLine($"Place {houseIndex} already had Valentine's day.");
            }
            else if (neighborhood[houseIndex] - 2 <= 0)
            {
                Console.WriteLine($"Place {houseIndex} has Valentine's day.");
            }
            
        }
    }
}