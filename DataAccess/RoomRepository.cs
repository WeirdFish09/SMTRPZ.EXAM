using DataAccess.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class RoomRepository : IRoomRepository
    {
        private PlantShopDbContext _dbContext;

        public RoomRepository(PlantShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Room Add(Room room)
        {
            throw new NotImplementedException();
        }

        public Room GetById(int roomId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
