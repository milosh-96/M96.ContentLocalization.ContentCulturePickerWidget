# Content Culture Picker Widget for Orchard Core

## About
Orchard Core provides a shape that renders languages/cultures dropdown. However, you need
to modify your theme files to display it and also add some other configuration.  

This widget will do all of that and you can then add it wherever you like - theme zones, flow part or anywhere else where widgets can be placed. 

## Why
If you just want to use a theme but you don't want to edit any templates than this is more than useful. Also, sometimes it's just easier to have a widget that can be moved around.

## How to use

1. Install `M96.ContentLocalization.ContentCulturePickerWidget` package from NuGet or clone this repo and add project reference to Orchard Core CMS project in your solution.
2. Go to Orchard Core Admin panel, then go to `Configuration -> Features` and enable `M96.ContentLocalization.ContentCulturePickerWidget`.
3. Now you can add this widget just like any other Orchard Core widget.

You can also configure wrapper CSS classes for each widget so you can apply custom styling.

## Tips

Make sure you have configured cultures in `Configuration -> Settings -> Localization -> Cultures`.
