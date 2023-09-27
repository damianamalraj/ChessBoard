Console.OutputEncoding = System.Text.Encoding.Unicode;

int number = Convert.ToInt32(Console.ReadLine());

string[] list = new string[number];

for (int i = 0; i < number; i++)
{
    if (i % 2 != 0)
    {
        list[0] = "◻︎";
    }
    else
    {
        list[0] = "◼︎";
    }

    for (int j = 0; j < number - 1; j++)
    {
        if (list[j] == "◻︎")
        {
            list[j + 1] = "◼︎";
        }
        else
        {
            list[j + 1] = "◻︎";
        }
    }
    Console.WriteLine(string.Join(" ", list));
    list = new string[number];
}