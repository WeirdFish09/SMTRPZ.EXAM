using DataAccess.Interfaces;
using Model;
using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryRepository : IInventoryRepository
    {
        private PlantShopDbContext _dbContext;

        public InventoryRepository(PlantShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Inventory Add(Inventory plant)
        {
            throw new NotImplementedException();
        }

        public void AssignToRoom(Inventory inventory, Room room)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Inventory> FindByFilter(InventoryFilter filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(Inventory plant)
        {
            throw new NotImplementedException();
        }
    }
}
