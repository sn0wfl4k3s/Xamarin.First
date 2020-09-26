using FirstApp.Contracts;
using FirstApp.UWP;
using System.IO;
using Windows.Storage;

[assembly: Xamarin.Forms.Dependency(typeof(FileHelper))]
namespace FirstApp.UWP
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
