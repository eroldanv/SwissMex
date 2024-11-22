namespace ServiceLifeTime.Services
{
    public class TransientGUIDService : ITransientGUIDService
    {
        private readonly Guid Id;

        public TransientGUIDService()
        {
            this.Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return this.Id.ToString();
        }
    }
}
