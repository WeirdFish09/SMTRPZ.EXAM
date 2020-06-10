using Model;
using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IPlantRepository
    {
        Plant Add(Plant plant);
        void Remove(Plant plant);
        IEnumerable<Plant> FindByFilter(PlantFilter filter);
        bool AssignToRoom(Plant plant, Room room);
    }
}
