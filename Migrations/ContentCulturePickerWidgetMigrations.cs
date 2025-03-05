using M96.ContentLocalization.ContentCulturePickerWidget.Constants;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M96.ContentLocalization.ContentCulturePickerWidget.Migrations;

public class ContentCulturePickerWidgetMigrations : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public ContentCulturePickerWidgetMigrations(IContentDefinitionManager contentDefinitionManager)
    {
        _contentDefinitionManager = contentDefinitionManager;
    }

    public async Task<int> CreateAsync()
    {
        await _contentDefinitionManager.AlterTypeDefinitionAsync(ContentTypes.ContentCulturePickerWidget, type => {
            type.Stereotype("Widget");
        });
        return 1;
    }
}