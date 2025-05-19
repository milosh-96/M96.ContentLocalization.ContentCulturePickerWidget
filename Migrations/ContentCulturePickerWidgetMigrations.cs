using M96.ContentLocalization.ContentCulturePickerWidget.Constants;
using M96.ContentLocalization.ContentCulturePickerWidget.Models;
using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentFields.Settings;
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
        await _contentDefinitionManager.AlterPartDefinitionAsync(nameof(ContentCulturePickerWidgetPart), part =>
        {
            part.WithField(nameof(ContentCulturePickerWidgetPart.WrapperCssClasses), field =>
            {
                field.OfType(nameof(TextField));
                field.WithSettings(new TextFieldSettings()
                {
                    Required = false
                });
                field.WithPosition("0");
            });
        });

        await _contentDefinitionManager.AlterTypeDefinitionAsync(ContentTypes.ContentCulturePickerWidget, type => {
            type.Stereotype("Widget");
        });
        return 2;
    }

    public async Task<int> UpdateFrom1Async()
    {
        await _contentDefinitionManager.AlterPartDefinitionAsync(nameof(ContentCulturePickerWidgetPart), part =>
        {
            part.WithField(nameof(ContentCulturePickerWidgetPart.WrapperCssClasses), field =>
            {
                field.OfType(nameof(TextField));
                field.WithSettings(new TextFieldSettings()
                {
                    Required = false
                });
                field.WithPosition("0");
            });
        });

        await _contentDefinitionManager.AlterTypeDefinitionAsync(ContentTypes.ContentCulturePickerWidget, type => {
            type.WithPart<ContentCulturePickerWidgetPart>().Stereotype("Widget");
        });
        return 2;
    }
}
