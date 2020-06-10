using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IInventoryRepository
    {
        Inventory Add(Inventory plant);
        void Remove(Inventory plant);
        void AssignToRoom(Inventory inventory, Room room);
        IEnumerable<Inventory> FindByName(string name);
        IEnumerable<Inventory> FindByRoom(int roomId);
    }
}
