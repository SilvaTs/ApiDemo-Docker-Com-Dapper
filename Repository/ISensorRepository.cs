using ApiDocker.Domain;

namespace ApiDocker.Repository
{
    public interface ISensorRepository
    {
        public IEnumerable<Sensor> ListAll();

        public int Insert(long step);
    }
}
