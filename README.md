# EnderFlare

**Author:** herbs.acab  
**Version:** 1.9.6  

## Description

The EnderFlare plugin teleports the player to the location where a thrown custom flare lands, similar to the Ender Pearl in Minecraft. This plugin adds a fun and strategic element to gameplay by allowing players to quickly traverse distances using flares.

## Installation

1. Download the `EnderFlare.cs` file.
2. Place the `EnderFlare.cs` file in the `oxide/plugins` directory of your Rust server.
3. Restart the server or load the plugin using the Oxide console command: `oxide.load EnderFlare`.

## Features

- Custom item (Ender Flare) that can be crafted with the `/craftpearl` command.
- Uses the skin: [Ender Flare Skin](https://steamcommunity.com/sharedfiles/filedetails/?id=3278321692).
- Teleports the player to the location where a thrown custom flare lands.
- Sends a chat message to the player when they throw an Ender Flare.
- Admins can use the `/givepearl` command to give Ender Flares to players.

## Crafting

- Use the command `/craftpearl` to craft an Ender Flare.
- Crafting recipe: 50 Metal Fragments, 5 Low Grade Fuel, 1 High Quality Metal.
- You will receive 5 Ender Flares per craft.
- If you do not have enough resources, the message will display: `To craft Ender Flares you must have [red]50x Metal Frags, 5x Low Grade & 1 HQM![/red]`.

## Usage

1. Use the command `/craftpearl` to craft Ender Flares.
2. Throw an Ender Flare in the game.
3. After 1.5 seconds, you will be teleported to the location where the flare lands.
4. A chat message will notify you that you have thrown an Ender Flare.

## Hooks

- `OnExplosiveThrown`: Listens for when a flare is thrown by a player.
- `Init`: Initializes the plugin when it is loaded.
- `Unload`: Cleans up resources when the plugin is unloaded.

## Based on Ender Pearl from Minecraft

This plugin is inspired by the Ender Pearl mechanic from Minecraft, where throwing an Ender Pearl teleports the player to the location where it lands. Similarly, EnderFlare allows Rust players to use flares for instant teleportation, adding a dynamic and exciting gameplay element.

## Changelog

- **1.9.6**
  - Fixed teleportation issue for custom Ender Flare.
  - Ensured regular flares do not trigger teleportation.
  - Added custom identifier to distinguish custom flares from regular flares.
  - Added crafting command `/craftpearl` with specified recipe.
  - Restricted `/givepearl` command to admins only.
  - Added Init and Unload hooks for proper loading and unloading.
  - Ensured the player does not take fall damage upon landing.
  - Added chat messages for better user feedback.
  - Teleportation occurs 1.5 seconds after throwing the custom flare.

## Credits

- **Author:** herbs.acab

Feel free to modify and distribute this plugin as needed.
