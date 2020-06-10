using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IRoomRepository
    {
        Room Add(Room room);
        void Remove(Room room);
        Room GetById(int roomId);
    }
}
