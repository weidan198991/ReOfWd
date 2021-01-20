using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Kuanfang.Ims.EntityFrameworkCore
{
    public static class ImsDbContextModelCreatingExtensions
    {
        public static void ConfigureIms(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ImsConsts.DbTablePrefix + "YourEntities", ImsConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}