using System.Reflection;

namespace _2024_05_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array.Resize() methodunu araşdırın və nə iş gördüyünü öyrənin. Və bu methodu custom şəkildə yazın.

            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            CustomResize<int>(ref numbers, 10);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //Aşağıdaki parametrlərə sahib Car class yaradın    
            //        -Brand
            //        - Model
            //        - CurrentFuel - masinin hazirki benzin miqdari
            //        - FuelFor1Km - masinin 1 km ucun xerclediyi benzin
            //-Millage - Masinin bu vaxtadək neçə km sürüldüyü
            //- Drive() - sürülmə metodu.Bu metod int parametr qəbul edir(neçə km sürmək istədiyimiz)
            // Car obyekti yaradın drive metodunu işə saldıqda arqument olaraq neçə km sürmək istədyimizi daxil edirik
            // və əgər benzin kifayət edirsə maşının millage dəyəri artır və benzini azalır,
            // benzin kifayət etmirsə console-da xəta mesajı yazılır

            Car car = new Car("Hundai","Grandeur",48,0.2,48500);

            Console.WriteLine($"{car.Brand}\n{car.Model}\n{car.CurrentFuel}\n{car.FuelPerKm}\n{car.Millage}");

            car.Drive(45);

            Console.WriteLine($"{car.Brand}\n{car.Model}\n{car.CurrentFuel}\n{car.FuelPerKm}\n{car.Millage}");
        }

        static void CustomResize<T>(ref T[] array, int newSize)
        {
            T[] newArray = new T[newSize];
            if (array.Length > newSize)
            {
                for (int i = 0; i < newSize; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
        }
    }
}
