using Volo.Abp.Modularity;

namespace Abp.Acme.BookStore;

[DependsOn(
    typeof(BookStoreApplicationModule),
    typeof(BookStoreDomainTestModule)
    )]
public class BookStoreApplicationTestModule : AbpModule
{

}
