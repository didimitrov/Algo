using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    abstract class VideoCard:IVideoCard
    {
        public abstract void DrawTextData(string data);

        //protected void RenderInformation(string inputData)
        //{
        //   System.Console.WriteLine(inputData);
        //    System.Console.ResetColor();
        //}
    }
}
