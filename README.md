# AoC Advanced Scenario Editor
This is an external scenario editor for Ages of Conflict, allowing you to edit the game's save and scenario files beyond what the in game editor allows with no JSON knowledge required. Below is a guide (or more like a list of tips) to all of the editor's functions. If you have any issues or think you've found a bug, feel free to reach out to me @corruptedmatt on Discord

The program is currently **only available on Windows**, and will remain that way for the foreseeable future.

## How to use:
1. download the latest release from the releases page (shown above the contributors list)
2. extract and run the program
3. select the save/scenario you want to edit in the top left and the timescale you typically use then click load
4. navigate to other tabs and make all the edits you want
5. select name and destination for the modified copy of your save/scenario and click export

## Bottom Controls
On the bottom right you can select the folder structure your file will be exported with. Holding shift while selecting will set the output destination to the appropriate game folder, if available. This means you can export saves as scenarios and vice versa (why would you want to do this the other way around?)

If the provided name and destination would overwrite and existing file, you'll get a warning when attempting to export, so no need to worry about accidentally doing that.

You can also quickly run the game from here if you own it on Steam, pretty neat huh?

## Load Tab
Aside from the loading selection, here lives all the stuff that apples to the scenario as a whole. Here you can see some basic stats, change the current and starting dates as well as preview and export various global maps. 

Set your desired start date first before doing any edits to dates in other tabs, as all of them are defined in relation to the starting date.

Provided map export options are cross-compatible with my Image to Scenario Converter, you can find a link to it in the info tab or on my profile here. When cities are unchecked the map you see will be exported verbatim as you see it, otherwise the city map will be exported for use with my converter's separate city map option. When city map is exported and the selected map is De Jure, then capitals of dead countries will be marked as capitals to be used with the occupations option in the converter. If you want only the alive nations' capitals to be marked select any other map when exporting cities.

## Nations Tab
Look, I know it looks overwhelming, but that's not even all the stuff about a country that can be modified.

The table on the left lists all countries, you can edit their names and colors as well as sort them by id or name. Selecting a nation on this list will show a preview of the area surrounding its capital and allow you to edit its details. You can also click on the preview map to select a country.

By popular demand, you can paste a list of names from clipboard by using the button in the bottom left. They will be pasted in order they are in your clipboard into the table as it is currently sorted. The expected format is that all the names are separated by line breaks, but copying from a spreadsheet should work too. This is mostly for scenarios generated with my converter though, I really don't know why you'd use this otherwise.

Capital select lists all the cities in the country along with their coordinates. Flag can be selected by typing in the flag id or clicking the flag preview in the bottom right corner, assuming a `flags.png` file exists in the save/scenario folder. (you can also put one in there yourself)

Leaving the ending year at 0 will be displayed in game as "active: \[start year] - " implying that the country is still alive. Combat efficiency uses more precise value that the game doesn't normally display.

## Cities Tab

All cities are listed in the table on the right, here you can change everything and sort by anything. Similarly to the nation preview, you can also select the cities by clicking on the map. Because singular pixels are kinda hard to hit, there is a little bit of a buffer added around them, if you get tripped by it you can hold shift to bypass it. (but really, if you have cities close enough together for that to matter you should probably reconsider your choices)

Just like the nations table, you can paste a list of city names here too. But unlike the nations table, here you can add (by entering last row) and remove (by selecting an entire row and pressing delete) entries, though you should be careful to not remove capitals, as that might lead to unpredictable results.

If you don't fancy looking for a needle in a hay stack while choosing rightful owner, you can also start typing in the country name when the dropdown is open to quickly find the nation you're looking for.

Set as core and remove core buttons just do what they say on the tin, but you can also use modifier keys to quickly apply do that to all cities in a country or the whole map.

## Alliances Tab

On the left you have another table with countries, here you can choose what alliance they're in and how loyal they are to it. (even if they aren't in one, it won't do anything in that case though)

On the right you have a table where you can modify alliance name, color as well as unity and federation status right below it. You can add and remove alliances just like you can do with cities.

Just like in the previous two tabs, you can select both nation and the alliance they're in by clicking on the map.

## Puppets Tab

Another two tables, the one on the left allows you to set the master of any nation (yes, that means puppets of puppets are possible) from the dropdown in the last column, just like all dropdowns you can quickly find the entry you're looking for by typing first few letters. The table on the right is simply an overview of all puppet masters and what they control, there's nothing to edit here.

If the selected nation (in either of the tables) is a puppet or a master, the corresponding variables will become available for editing. The dropdowns in loyalty and autonomy show what will be displayed in game, you can also quickly jump between different tiers by changing them instead of typing numbers.

## Wars Tab

Table on the right displays all wars, because this table is for display only, buttons have been provided to add and remove entries. You might also notice a third button there, with it you can merge two or more wars into one. This is mostly useful when you've preset wars in some versions of the game that didn't group them together.

When you select a war, you can add and remove participants through the table on the right, there are two additional stances that warrant further explanation: former attacker and former defender will be displayed in the wars list but won't be taking part in the war. In the vanilla game this status is only used by countries that were conquered during the war.

In the bottom left you can set the start and end dates of the war, the to death button is just here to burst your bubble by showing you they aren't real. If a war is set to end before scenario's current date, peace will be made immediately after loading the save/scenario.
