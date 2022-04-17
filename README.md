# ModInfo.xml
This must be included in every mod with name and description tags. Place it, and any other files inside %userprofile%\appdata\locallow\ATATGames\Ghostlore\mods\\(your mod name) folder. Mods can include any combination of the options below. You may include an image file named screenshot.jpg/png inside to be used as the steam workshop preview image. You should then see your mod inside the mods panel when you run Ghostlore. Use that to upload your mod to the Steam workshop when you are happy with your mod.

# Changes to Code
To get this visual studio solution working, you will need to add references to the dlls you need inside (your steam folder)\steamapps\common\Ghostlore\Ghostlore_Data\Managed.
Assembly-CSharp.dll, the UnityEngine dlls of choice. For further guidance there are many guides and communities on the internet covering other Unity games such as Cities Skylines. Most of the methods used should be the same for Ghostlore.

# Changes to CSV
CSV changes allow you to make quick changes to game values without any coding.

The standard game data can be viewed here: https://docs.google.com/spreadsheets/d/1BfKgYtFYOS5y8MMacgA_Um9wyUyivQtlY0_-v8Q1mog/edit?usp=sharing
Copy any game object(s) you want to modify (including the headers) into your own spreadsheet. Then export the spreadsheet into a .csv file. Include the csv file in your mod folder.

For now, only direct replacement of existing values is available. Only include the rows which you want to change. The ability to add new entities with custom artwork easily will be added during early access.

The example mod includes a CSV file which changes the players starting HP.

# Saving Data
If your mod requires persistant data to be saved with each save game you can do so easily by implementing the IModDataSerializer interface like in the ModDataSerializer.cs interface. Reference protobuf-net.dll in the game folder for easy serialization of any data (although you can do it however you like). More about protobuf here: https://github.com/protobuf-net/protobuf-net
