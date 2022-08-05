Console.Write ("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "ника")
    {
        Console.WriteLine("Ура, Это Ты!!");
    }
else
    {
        Console.Write ("Привет, "+username);
    }