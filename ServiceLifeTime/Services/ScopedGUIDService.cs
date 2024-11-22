namespace ServiceLifeTime.Services
{
    public class ScopedGUIDService : IScopedGUIDService
    {
        private readonly Guid Id;

        public ScopedGUIDService()
        {
            this.Id = Guid.NewGuid();            
        }
        public string GetGuid()
        {
            return this.Id.ToString();            
        }
    }
}
