Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();
if(username.ToLower() == "Света");
{
    Console.WriteLine("Приветики, Светик!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

