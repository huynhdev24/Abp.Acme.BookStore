using Abp.Acme.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Acme.BookStore;

[DependsOn(
    typeof(BookStoreEntityFrameworkCoreTestModule)
    )]
public class BookStoreDomainTestModule : AbpModule
{

}
