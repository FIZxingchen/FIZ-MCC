﻿using System.Collections.Generic;

namespace MinecraftClient.Protocol.Handlers.PacketPalettes
{
    public class PacketPalette114 : PacketTypePalette
    {
        private readonly Dictionary<int, PacketTypesIn> typeIn = new()
        {
            { 0x00, PacketTypesIn.SpawnEntity },
            { 0x01, PacketTypesIn.SpawnExperienceOrb },
            { 0x02, PacketTypesIn.SpawnWeatherEntity },
            { 0x03, PacketTypesIn.SpawnLivingEntity },
            { 0x04, PacketTypesIn.SpawnPainting },
            { 0x05, PacketTypesIn.SpawnPlayer },
            { 0x06, PacketTypesIn.EntityAnimation },
            { 0x07, PacketTypesIn.Statistics },
            { 0x08, PacketTypesIn.BlockBreakAnimation },
            { 0x09, PacketTypesIn.BlockEntityData },
            { 0x0A, PacketTypesIn.BlockAction },
            { 0x0B, PacketTypesIn.BlockChange },
            { 0x0C, PacketTypesIn.BossBar },
            { 0x0D, PacketTypesIn.ServerDifficulty },
            { 0x0E, PacketTypesIn.ChatMessage },
            { 0x0F, PacketTypesIn.MultiBlockChange },
            { 0x10, PacketTypesIn.TabComplete },
            { 0x11, PacketTypesIn.DeclareCommands },
            { 0x12, PacketTypesIn.WindowConfirmation },
            { 0x13, PacketTypesIn.CloseWindow },
            { 0x14, PacketTypesIn.WindowItems },
            { 0x15, PacketTypesIn.WindowProperty },
            { 0x16, PacketTypesIn.SetSlot },
            { 0x17, PacketTypesIn.SetCooldown },
            { 0x18, PacketTypesIn.PluginMessage },
            { 0x19, PacketTypesIn.NamedSoundEffect },
            { 0x1A, PacketTypesIn.Disconnect },
            { 0x1B, PacketTypesIn.EntityStatus },
            { 0x1C, PacketTypesIn.Explosion },
            { 0x1D, PacketTypesIn.UnloadChunk },
            { 0x1E, PacketTypesIn.ChangeGameState },
            { 0x1F, PacketTypesIn.OpenHorseWindow },
            { 0x20, PacketTypesIn.KeepAlive },
            { 0x21, PacketTypesIn.ChunkData },
            { 0x22, PacketTypesIn.Effect },
            { 0x23, PacketTypesIn.Particle },
            { 0x24, PacketTypesIn.UpdateLight },
            { 0x25, PacketTypesIn.JoinGame },
            { 0x26, PacketTypesIn.MapData },
            { 0x27, PacketTypesIn.TradeList },
            { 0x28, PacketTypesIn.EntityPosition },
            { 0x29, PacketTypesIn.EntityPositionAndRotation },
            { 0x2A, PacketTypesIn.EntityRotation },
            { 0x2B, PacketTypesIn.EntityMovement },
            { 0x2C, PacketTypesIn.VehicleMove },
            { 0x2D, PacketTypesIn.OpenBook },
            { 0x2E, PacketTypesIn.OpenWindow },
            { 0x2F, PacketTypesIn.OpenSignEditor },
            { 0x30, PacketTypesIn.CraftRecipeResponse },
            { 0x31, PacketTypesIn.PlayerAbilities },
            { 0x32, PacketTypesIn.CombatEvent },
            { 0x33, PacketTypesIn.PlayerInfo },
            { 0x34, PacketTypesIn.FacePlayer },
            { 0x35, PacketTypesIn.PlayerPositionAndLook },
            { 0x36, PacketTypesIn.UnlockRecipes },
            { 0x37, PacketTypesIn.DestroyEntities },
            { 0x38, PacketTypesIn.RemoveEntityEffect },
            { 0x39, PacketTypesIn.ResourcePackSend },
            { 0x3A, PacketTypesIn.Respawn },
            { 0x3B, PacketTypesIn.EntityHeadLook },
            { 0x3C, PacketTypesIn.SelectAdvancementTab },
            { 0x3D, PacketTypesIn.WorldBorder },
            { 0x3E, PacketTypesIn.Camera },
            { 0x3F, PacketTypesIn.HeldItemChange },
            { 0x40, PacketTypesIn.UpdateViewPosition },
            { 0x41, PacketTypesIn.UpdateViewDistance },
            { 0x42, PacketTypesIn.DisplayScoreboard },
            { 0x43, PacketTypesIn.EntityMetadata },
            { 0x44, PacketTypesIn.AttachEntity },
            { 0x45, PacketTypesIn.EntityVelocity },
            { 0x46, PacketTypesIn.EntityEquipment },
            { 0x47, PacketTypesIn.SetExperience },
            { 0x48, PacketTypesIn.UpdateHealth },
            { 0x49, PacketTypesIn.ScoreboardObjective },
            { 0x4A, PacketTypesIn.SetPassengers },
            { 0x4B, PacketTypesIn.Teams },
            { 0x4C, PacketTypesIn.UpdateScore },
            { 0x4D, PacketTypesIn.SpawnPosition },
            { 0x4E, PacketTypesIn.TimeUpdate },
            { 0x4F, PacketTypesIn.Title },
            { 0x50, PacketTypesIn.EntitySoundEffect },
            { 0x51, PacketTypesIn.SoundEffect },
            { 0x52, PacketTypesIn.StopSound },
            { 0x53, PacketTypesIn.PlayerListHeaderAndFooter },
            { 0x54, PacketTypesIn.NBTQueryResponse },
            { 0x55, PacketTypesIn.CollectItem },
            { 0x56, PacketTypesIn.EntityTeleport },
            { 0x57, PacketTypesIn.Advancements },
            { 0x58, PacketTypesIn.EntityProperties },
            { 0x59, PacketTypesIn.EntityEffect },
            { 0x5A, PacketTypesIn.DeclareRecipes },
            { 0x5B, PacketTypesIn.Tags },
            { 0x5C, PacketTypesIn.AcknowledgePlayerDigging },
        };

        private readonly Dictionary<int, PacketTypesOut> typeOut = new()
        {
            { 0x00, PacketTypesOut.TeleportConfirm },
            { 0x01, PacketTypesOut.QueryBlockNBT },
            { 0x02, PacketTypesOut.SetDifficulty },
            { 0x03, PacketTypesOut.ChatMessage },
            { 0x04, PacketTypesOut.ClientStatus },
            { 0x05, PacketTypesOut.ClientSettings },
            { 0x06, PacketTypesOut.TabComplete },
            { 0x07, PacketTypesOut.WindowConfirmation },
            { 0x08, PacketTypesOut.ClickWindowButton },
            { 0x09, PacketTypesOut.ClickWindow },
            { 0x0A, PacketTypesOut.CloseWindow },
            { 0x0B, PacketTypesOut.PluginMessage },
            { 0x0C, PacketTypesOut.EditBook },
            { 0x0D, PacketTypesOut.EntityNBTRequest },
            { 0x0E, PacketTypesOut.InteractEntity },
            { 0x0F, PacketTypesOut.KeepAlive },
            { 0x10, PacketTypesOut.LockDifficulty },
            { 0x11, PacketTypesOut.PlayerPosition },
            { 0x12, PacketTypesOut.PlayerPositionAndRotation },
            { 0x13, PacketTypesOut.PlayerRotation },
            { 0x14, PacketTypesOut.PlayerMovement },
            { 0x15, PacketTypesOut.VehicleMove },
            { 0x16, PacketTypesOut.SteerBoat },
            { 0x17, PacketTypesOut.PickItem },
            { 0x18, PacketTypesOut.CraftRecipeRequest },
            { 0x19, PacketTypesOut.PlayerAbilities },
            { 0x1A, PacketTypesOut.PlayerDigging },
            { 0x1B, PacketTypesOut.EntityAction },
            { 0x1C, PacketTypesOut.SteerVehicle },
            { 0x1D, PacketTypesOut.RecipeBookData },
            { 0x1E, PacketTypesOut.NameItem },
            { 0x1F, PacketTypesOut.ResourcePackStatus },
            { 0x20, PacketTypesOut.AdvancementTab },
            { 0x21, PacketTypesOut.SelectTrade },
            { 0x22, PacketTypesOut.SetBeaconEffect },
            { 0x23, PacketTypesOut.HeldItemChange },
            { 0x24, PacketTypesOut.UpdateCommandBlock },
            { 0x25, PacketTypesOut.UpdateCommandBlockMinecart },
            { 0x26, PacketTypesOut.CreativeInventoryAction },
            { 0x27, PacketTypesOut.UpdateJigsawBlock },
            { 0x28, PacketTypesOut.UpdateStructureBlock },
            { 0x29, PacketTypesOut.UpdateSign },
            { 0x2A, PacketTypesOut.Animation },
            { 0x2B, PacketTypesOut.Spectate },
            { 0x2C, PacketTypesOut.PlayerBlockPlacement },
            { 0x2D, PacketTypesOut.UseItem },
        };

        protected override Dictionary<int, PacketTypesIn> GetListIn()
        {
            return typeIn;
        }

        protected override Dictionary<int, PacketTypesOut> GetListOut()
        {
            return typeOut;
        }
    }
}