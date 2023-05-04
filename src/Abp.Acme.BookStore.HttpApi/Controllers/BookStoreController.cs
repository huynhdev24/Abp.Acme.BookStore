using Abp.Acme.BookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Acme.BookStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreController : AbpControllerBase
{
    protected BookStoreController()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
