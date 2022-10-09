using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Software2KnowledgeCheck1.Entities;

namespace Software2KnowledgeCheck1.Interfaces
{
    public interface IConstructionService
    {
        public void CreateApartment(Apartment apartment);
        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T: Building;
    }
}