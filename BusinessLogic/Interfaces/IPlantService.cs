using Model;
using Model.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface IPlantService
    {
        IEnumerable<PlantDTO> FindByFilter(PlantFilter filter);
        PlantDTO AddPlant(PlantDTO plant);
        void RemovePlant(PlantDTO plant);
        bool AssignPlant(AssignPlantDTO assignPlantDTO);
        bool UnAssignPlant(AssignPlantDTO assignPlantDTO);
    }
}
