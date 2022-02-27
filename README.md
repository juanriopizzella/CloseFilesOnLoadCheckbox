# CloseFilesOnLoadCheckbox (Autodesk Navisworks Plugin)


This plugin is intended to counteract a very common issue related to clash detection workflows: the inability to overwrite NWC files due to someone having them appended to a Navisworks Manage session that has the "Close NWC/NWD files on load" checkbox unticked.

The plugin will look into the checkbox state during Navisworks Manage startup. It will do nothing if already ticked. But if unticked, it will automatically tick it.

The user will still have the freedom to manually access the Options Editor to revert the plugin's action, but will be advised that after doing this the overwriting of appended NWC files may be affected.


Developed for Navisworks Manage 2021, targetting the 4.7.2 .NET Framework
