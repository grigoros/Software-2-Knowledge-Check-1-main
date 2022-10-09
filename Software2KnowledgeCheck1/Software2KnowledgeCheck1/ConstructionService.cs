using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Software2KnowledgeCheck1.Entities;
using Software2KnowledgeCheck1.Interfaces;
using Software2KnowledgeCheck1.Repos;

namespace Software2KnowledgeCheck1.Services
{
    public class ConstructionService
    {
        private readonly City _city;
        private readonly IConstructionService _constructionService;

        public ConstructionService(City city, IConstructionService constructionService)
        {
            _city = city;
            _constructionService = constructionService;
        }
        
        public void CreateApartment(Apartment apartment)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                _city.Buildings.Add(apartment);
            }
        }

        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T: Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}