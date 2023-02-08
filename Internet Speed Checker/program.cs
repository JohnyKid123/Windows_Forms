using System.Diagnostics;
using System.Net;

Console.WriteLine("Starting download...");

var watch = new Stopwatch();
byte[] data;

using (var client = new WebClient())
{
    watch.Start();
    data = client.DownloadData(
        "http://ardownload.adobe.com/pub/adobe/reader/win/AcrobatDC/2001220041/AcroRdrDC2001220041_en_US.exe");
    watch.Stop();
}

Console.WriteLine("Download complete!");

var speed = Math.Round((data.Length / watch.Elapsed.TotalSeconds) / (1000 * 1000), 2);
Console.WriteLine($"Download duration: {watch.Elapsed}");
Console.WriteLine($"Speed: {speed} Mbps");

Console.WriteLine("Press any key to continue...");
