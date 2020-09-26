using FirstApp.Contracts;
using FirstApp.Droid;
using System;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(FileHelper))]
namespace FirstApp.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}