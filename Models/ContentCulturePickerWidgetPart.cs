using OrchardCore.ContentFields.Fields;
using OrchardCore.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M96.ContentLocalization.ContentCulturePickerWidget.Models;

public class ContentCulturePickerWidgetPart : ContentPart
{
    public TextField WrapperCssClasses { get; set; } = new TextField();
}
