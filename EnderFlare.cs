using System;
using UnityEngine;
using Oxide.Core.Plugins;

namespace Oxide.Plugins
{
    [Info("EnderFlare", "herbs.acab", "1.6.0")]
    [Description("Teleports the player to where the thrown flare lands.")]
    public class EnderFlare : RustPlugin
    {
        private const string FlarePrefab = "assets/prefabs/tools/flare/flare.deployed.prefab";

        private void Init()
        {
            Puts("EnderFlare plugin loaded.");
        }

        private void Unload()
        {
            Puts("EnderFlare plugin unloaded.");
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
    }
}
