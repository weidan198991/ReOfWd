using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Kuanfang.Ims.Data
{
    /* This is used if database provider does't define
     * IImsDbSchemaMigrator implementation.
     */
    public class NullImsDbSchemaMigrator : IImsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}