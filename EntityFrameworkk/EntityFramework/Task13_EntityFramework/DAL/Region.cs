using System.Collections.Generic;
using Task13_EntityFramework.DAL.Interfaces;

namespace Task13_EntityFramework.DAL
{
    public class Region : IEntity
    {
        public int Id { get; set; }
        public string RegionDescription { get; set; }

        public virtual List<Region> Regions { get; set; }
    }
}
