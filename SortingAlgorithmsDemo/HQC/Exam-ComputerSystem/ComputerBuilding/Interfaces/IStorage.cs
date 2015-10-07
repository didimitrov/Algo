
namespace Computers.UI.Console.Interfaces
{
    public interface IStorage
    {
        void SaveData(int address, string newData);

        string LoadData(int address);
    }
}
