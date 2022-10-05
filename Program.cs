Console.Write("Введіть ключ доступу: ");
string? user_key = Console.ReadLine();

ApplicationLicense application = new ApplicationLicense();

if (user_key == application.common_key)
{
    application.AllowCommon();
}
else if (user_key == application.pro_key)
{
    application.AllowPro();
}
else if (user_key == application.trial_key)
{
    application.AllowTrial();
}
else
{
    Console.WriteLine("Невірний ключ.");
}