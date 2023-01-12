int time = 0;
int counter = 0;
bool isDone = false;




do
{

    Console.WriteLine($"Parkingtime : {PrintParkingTime()}");
    Console.Write("Your Input: ");
    string input = Console.ReadLine()!;

    counter++;
    isDone = EnterCoins(input, counter);

} while (!isDone);

bool EnterCoins(string input, int counter)
{

    if (input == "d" || input == "D")
        if (counter == 1)
        {
            Console.WriteLine("Min Input 50 Cent");
            return false;
        }
        else
        {
            Console.WriteLine($"You'r allowed to park {PrintParkingTime()}");
            return true;
        }
    else
    {

        AddParkingTime(input);
        if (time >= 130)
        {

            Console.WriteLine(PrintParkingTime());
            PrintDonation();
            return true;
        }
        else
        {
            return false;
        }
    }
}

int AddParkingTime(string input)
{
    switch (input)
    {
        case "5": time += 3; break;
        case "10": time += 6; break;
        case "20": time += 12; break;
        case "50": time += 30; break;
        case "1": time += 60; break;
        case "2": time += 120; break;
        default: time += 0; break;
    }
    return time;
}

string PrintParkingTime()
{

    int hours = time / 60;
    if (hours > 1)

        return $"You'r allowed to park 01:30 hours";
    else

        return $"{hours}:{time - (hours * 60)}";
}

void PrintDonation()
{
    double donation = Convert.ToDouble(time / 60.00 - 1.50);
    Console.WriteLine($"Thank you for your donation of {donation:f2} €!");
}
