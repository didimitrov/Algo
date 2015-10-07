using Computers.UI.Console.Interfaces;

namespace Computers.UI.Console
{
    class Motherboard:IMotherboard
    {
        private IRam _ram;
        private IVideoCard _videoCard;

        public Motherboard(IRam ram, IVideoCard videoCard)
        {
            this.Ram = ram;
            this.VideoCard = videoCard;
        }

        public IRam Ram
        {
            get { return _ram; }
            set { _ram = value; }
        }

        public IVideoCard VideoCard
        {
            get { return _videoCard; }
            set { _videoCard = value; }
        }

        public int LoadRamValue()
        {
            throw new System.NotImplementedException();
        }

        public void SaveRamValue(int value)
        {
            throw new System.NotImplementedException();
        }

        public void DrawOnVideoCard(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}
