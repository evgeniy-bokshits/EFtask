using Task13_EntityFramework.DAL.Interfaces;

namespace Task13_EntityFramework.DAL
{
    public class Territory : IEntity
    {
        public int Id { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
    }
}
