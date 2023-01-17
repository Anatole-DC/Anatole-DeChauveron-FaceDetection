// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Anatole.DeChauveron.FaceDetection;

namespace Anatole.DeChauveron.FaceDetection.Console;


class Program
{
    static void Main(String[] args)
    {

        IList<byte[]> images = new List<byte[]>();
        foreach (string argument in args)
        {
            images.Add(System.IO.File.ReadAllBytes(argument));
        }

        IList<FaceDetectionResult> detectFaceInScenesResults = new FaceDetection().DetectInScenes(images);
    
        foreach (var detectionResult in detectFaceInScenesResults)
        {
            System.Console.WriteLine($"Points:{JsonSerializer.Serialize(detectionResult.Points)}");
        } 
    }
}

