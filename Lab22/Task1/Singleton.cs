namespace Task1
{
class Singleton
{
    private static Singleton instance;
    private Singleton() {}
    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }
    public void ShowMessage()
    {
        Console.WriteLine("Привет, я Singleton!");
    }
}
}
