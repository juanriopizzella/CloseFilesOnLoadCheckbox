# CloseFilesOnLoadCheckbox (Autodesk Navisworks Plugin)

This repository contains the source code and Visual Studio Solution of the CloseFilesOnLoadCheckbox Autodesk Navisworks Manage 2022 Plugin.

This plugin is intended to counteract a very common issue related to clash detection workflows: the inability to overwrite NWC files due to someone having them appended to a Navisworks Manage session that has the "Close NWC/NWD files on load" checkbox unticked.

The plugin will look into the checkbox state during Navisworks Manage startup. It will do nothing if already ticked. But if unticked, it will automatically tick it.

The user will still have the freedom to manually access the Options Editor to revert the plugin's action, but will be advised that after doing this the overwriting of appended NWC files may be affected.


## Installation (Navisworks Manage 2021 and 2022)

Download the file "CloseFilesOnLoadCheckbox.dll" (choose the Navisworks Installation File folder according to your required version) and paste it in the directory "C:\Program Files\Autodesk\Navisworks Manage 'year-release'\Plugins\CloseFilesOnLoadCheckbox\".

This should be done in all machines.

Please get in touch if you are using a different Navisworks Manage year-release so that I can prepare a different DLL file for you and afterwards upload it in case someone else could be interested as well.


## Author

Juan Rio Pizzella


## License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT).
Please see the [LICENSE](LICENSE) file for full details.
