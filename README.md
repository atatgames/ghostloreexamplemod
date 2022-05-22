# ModInfo.xml
This must be included in every mod with name and description tags. Place it, and any other files inside %userprofile%\appdata\locallow\ATATGames\Ghostlore\mods\\(your mod name) folder. Mods can include any combination of the options below. You may include an image file named screenshot.jpg/png inside to be used as the steam workshop preview image. You should then see your mod inside the mods panel when you run Ghostlore. Use that to upload your mod to the Steam workshop when you are happy with your mod.

# Changes to Code
To get this visual studio solution working, you will need to add references to the dlls you need inside (your steam folder)\steamapps\common\Ghostlore\Ghostlore_Data\Managed.
Assembly-CSharp.dll, and the UnityEngine dlls of choice. For further guidance there are many guides and communities on the internet covering other Unity games such as Cities Skylines. Most of the methods used should be the same for Ghostlore.

# Changes to CSV
CSV changes allow you to make quick changes to game values without any coding.

The standard game data can be viewed here: https://docs.google.com/spreadsheets/d/1BfKgYtFYOS5y8MMacgA_Um9wyUyivQtlY0_-v8Q1mog/edit?usp=sharing
Copy any game object(s) you want to modify (including the headers) into your own spreadsheet. Then export the spreadsheet into a .csv file. Include the csv file in your mod folder.

# Importing Sprites
You can include custom spritesheets by including .png files in the mod folder. Then run Ghostlore, go to the mod menu, click on the assets button for your mod. In the menu you can set the number of columns and rows in the spritesheet and the location of the pivot. After that click on "Splice Sprites". Creatures or projectiles with a direction should have 8 rows.

The "Target Path" setting for each sprite is the path used to reference the sprite in the CSVs. You can set this to the path of a sprite from the base game to overwrite that sprite easily. The examplepower sprite included in this example mod replaces the arrow projectile this way.

# New Projectiles and Creatures
When creating new projectiles and creatures be sure to set the "Base Projectile" and "Base Creature" parameters to an entry from the base game. This is required as some components like lights on projectiles are not changeable by CSV file (and have to be changed by code). These settings are just copied from the base creature or projectile choosen. To change creature sprites you need to reference a new "Creature Animation Controller". You can refer to the "Example Creature" entry included in this mod.

# Importing Audio
To include custom sound files you need to download FMOD 2.1 for free. You must use the included FMOD project file in this mod, after you have used FMOD to build your .bank files, copy it to the mod folder. You should then be able to reference your sounds from the CSV files. You can refer to the arrow projectile in this mod which has a custom sound.

# Saving Data
If your mod requires persistant data to be saved with each save game you can do so easily by implementing the IModDataSerializer interface like in the ModDataSerializer.cs interface. Reference protobuf-net.dll in the game folder for easy serialization of any data (although you can do it however you like). More about protobuf here: https://github.com/protobuf-net/protobuf-net
