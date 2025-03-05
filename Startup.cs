using M96.ContentLocalization.ContentCulturePickerWidget.Migrations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;

namespace M96.ContentLocalization.ContentCulturePickerWidget;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddDataMigration<ContentCulturePickerWidgetMigrations>();
    }
}
