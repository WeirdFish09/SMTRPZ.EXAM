using DataAccess.Interfaces;
using Model;
using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class PlantRepository : IPlantRepository
    {
        private PlantShopDbContext _dbContext;

        public PlantRepository(PlantShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Plant Add(Plant plant)
        {
            throw new NotImplementedException();
        }

        public bool AssignToRoom(Plant plant, Room room)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Plant> FindByFilter(PlantFilter filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(Plant plant)
        {
            throw new NotImplementedException();
        }
    }
}
