class ImageManager
{
    private string _imagePath;
    private string _os;
    public ImageManager(string imagePath)
    {
        _imagePath = imagePath;
        _os = Environment.OSVersion.ToString();

    }
    public void DisplayOsInfo()
    {
        Console.WriteLine($"Operating System: {_os}");
    }
}