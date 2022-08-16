namespace Inventory.API.Contracts
{
    public interface IBaseRepository <Entity> where Entity : class
    {
        public IEnumerable<Entity> Get ();

        public Entity Find(int id);

        public void Add(Entity entity);

        public void Update(Entity entity);

    }
}
