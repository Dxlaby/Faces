using System.Net;
namespace Faces;

public class Finder
{
    internal List<string> DownloadPictures(int numOfPhotos)
    {
        List<string> paths = new List<string>();
        for (int i = 0; i < numOfPhotos; i++)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(@"https://www.thispersondoesnotexist.com/"),  
                    Path.Combine("Photos/", "Photo" + i + ".png"));
                paths.Add(Path.Combine("Photos/", "Photo" + i + ".png"));
            }
        }

        return paths;
    }
}