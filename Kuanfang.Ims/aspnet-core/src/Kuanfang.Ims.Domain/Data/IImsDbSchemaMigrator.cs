using System.Threading.Tasks;

namespace Kuanfang.Ims.Data
{
    public interface IImsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
