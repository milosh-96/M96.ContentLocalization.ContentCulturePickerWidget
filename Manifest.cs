using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Content Culture Picker Widget",
    Author = "M96",
    Website = "https://github.com/milosh-96",
    Version = "1.1.0",
    Description = "Provides a widget that renders the culture picker shape from OrchardCore.ContentLocalization.ContentCulturePicker.",
    Category = "Localization",
    Dependencies = ["OrchardCore.ContentFields", "OrchardCore.ContentLocalization"]
)]
