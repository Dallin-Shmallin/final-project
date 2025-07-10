using System;
using Microsoft.VisualBasic;
class Program
{
    static void Main(string[] args)
    {
        ImageManager imageManager = new ImageManager("path/to/image");
        imageManager.DisplayOsInfo();
    }
}