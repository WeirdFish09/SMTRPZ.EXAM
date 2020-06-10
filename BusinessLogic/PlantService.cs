using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class PlantService : IPlantService
    {
        private IPlantRepository _plantRepository;
        private IRoomRepository _roomRepository;

        public PlantService(IPlantRepository plantRepository, IRoomRepository roomRepository)
        {
            _plantRepository = plantRepository;
            _roomRepository = roomRepository;
        }

        public PlantDTO AddPlant(PlantDTO plant)
        {
            throw new NotImplementedException();
        }

        public bool AssignPlant(AssignPlantDTO assignPlantDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlantDTO> FindByFilter(PlantFilter filter)
        {
            throw new NotImplementedException();
        }

        public void RemovePlant(PlantDTO plant)
        {
            throw new NotImplementedException();
        }

        public bool UnAssignPlant(AssignPlantDTO assignPlantDTO)
        {
            throw new NotImplementedException();
        }
    }
}
