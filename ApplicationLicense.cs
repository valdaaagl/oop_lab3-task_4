public class ApplicationLicense
{
    public string trial_key = "123456";
    public string pro_key = "654321";
    public string common_key = "";
    public void AllowTrial()
    {
        Console.WriteLine("Триальний режим");
    }
    public void AllowCommon()
    {
        Console.WriteLine("Безкоштовна версія");
    }
    public void AllowPro()
    {
        Console.WriteLine("Платна версія");
    }
}