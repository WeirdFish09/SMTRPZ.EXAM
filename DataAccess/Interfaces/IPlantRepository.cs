using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IPlantRepository
    {
        Plant Add(Plant plant);
        void Remove(Plant plant);
        IEnumerable<Plant> FindByName(string name);
        IEnumerable<Plant> FindByEnvironment(int environmentId);
        IEnumerable<Plant> FindByRoom(int roomId);
        bool AssignToRoom(Plant plant, Room room);
    }
}
