# EnderFlare

**Author:** herbs.acab  
**Version:** 1.7.0  

## Description

The EnderFlare plugin teleports the player to the location where a thrown flare lands, similar to the Ender Pearl in Minecraft. This plugin adds a fun and strategic element to gameplay by allowing players to quickly traverse distances using flares.

## Installation

1. Download the `EnderFlare.cs` file.
2. Place the `EnderFlare.cs` file in the `oxide/plugins` directory of your Rust server.
3. Restart the server or load the plugin using the Oxide console command: `oxide.load EnderFlare`.

## Features

- Custom item (Ender Flare) that can be spawned with the `/givepearl` command.
- Uses the skin: [Ender Flare Skin](https://steamcommunity.com/sharedfiles/filedetails/?id=3278321692).
- Teleports the player to the location where a thrown flare lands.
- Sends a chat message to the player when they throw an Ender Flare.

## Usage

1. Use the command `/givepearl` to receive an Ender Flare.
2. Throw the Ender Flare in the game.
3. After 1.5 seconds, you will be teleported to the location where the flare lands.
4. A chat message will notify you that you have thrown an Ender Flare.

## Hooks

- `OnExplosiveThrown`: Listens for when a flare is thrown by a player.
- `Init`: Initializes the plugin when it is loaded.
- `Unload`: Cleans up resources when the plugin is unloaded.

## Based on Ender Pearl from Minecraft

This plugin is inspired by the Ender Pearl mechanic from Minecraft, where throwing an Ender Pearl teleports the player to the location where it lands. Similarly, EnderFlare allows Rust players to use flares for instant teleportation, adding a dynamic and exciting gameplay element.

## Changelog

- **1.7.0**
  - Added custom item with `/givepearl` command.
  - Used specified skin for the custom item.
  - Added Init and Unload hooks for proper loading and unloading.
  - Ensured the player does not take fall damage upon landing.
  - Added chat messages for better user feedback.
  - Teleportation occurs 1.5 seconds after throwing the flare.

## Credits

- **Author:** herbs.acab

Feel free to modify and distribute this plugin as needed.
