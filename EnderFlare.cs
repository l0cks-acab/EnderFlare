using System;
using UnityEngine;
using Oxide.Core.Plugins;
using System.Collections.Generic;

namespace Oxide.Plugins
{
    [Info("EnderFlare", "herbs.acab", "1.7.0")]
    [Description("Teleports the player to where the thrown flare lands.")]
    public class EnderFlare : RustPlugin
    {
        private const string FlarePrefab = "assets/prefabs/tools/flare/flare.deployed.prefab";
        private const ulong FlareSkinID = 3278321692;
        private const string FlareItemShortName = "flare";

        [ChatCommand("givepearl")]
        private void GivePearlCommand(BasePlayer player, string command, string[] args)
        {
            GiveEnderPearl(player);
            player.ChatMessage("You have received an Ender Flare!");
        }

        private void GiveEnderPearl(BasePlayer player)
        {
            Item item = ItemManager.CreateByName(FlareItemShortName, 1, FlareSkinID);
            if (item != null)
            {
                player.GiveItem(item);
            }
        }

        private void OnExplosiveThrown(BasePlayer player, BaseEntity entity)
        {
            if (entity == null || player == null)
                return;

            if (entity.ShortPrefabName == "flare.deployed")
            {
                player.ChatMessage("You have thrown a <color=#800080>Ender</color> Flare");

                timer.Once(1.5f, () =>
                {
                    if (entity != null && !entity.IsDestroyed)
                    {
                        Vector3 flarePosition = entity.transform.position;
                        TeleportPlayer(player, flarePosition);
                    }
                });
            }
        }

        private void TeleportPlayer(BasePlayer player, Vector3 position)
        {
            if (player == null || position == Vector3.zero)
                return;

            player.Teleport(position);
        }

        private void Init()
        {
            Puts("EnderFlare plugin loaded.");
        }

        private void Unload()
        {
            Puts("EnderFlare plugin unloaded.");
        }
    }
}
