namespace ServiceLifeTime.Services
{
    public class SingletonGUIDService : ISingletonGUIDService
    {
        private readonly Guid Id;

        public SingletonGUIDService()
        {
            this.Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return this.Id.ToString();
        }
    }
}
