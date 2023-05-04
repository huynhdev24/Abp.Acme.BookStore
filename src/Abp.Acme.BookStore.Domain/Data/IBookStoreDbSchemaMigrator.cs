using System.Threading.Tasks;

namespace Abp.Acme.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
