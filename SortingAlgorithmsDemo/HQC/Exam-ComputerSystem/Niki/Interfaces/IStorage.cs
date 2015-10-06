
namespace Computers.UI.Console.Interfaces
{
    interface IStorage
    {
        void SaveData(int address, string newData);

        string LoadData(int address);
    }
}
