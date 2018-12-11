using System;

// 2018-12-11 13:28:43.041584200 UTC

namespace hazedumper
{
    public const Int32 timestamp = 1544534923;
    public static class netvars
    {
        public const Int32 cs_gamerules_data = 0x0;
        public const Int32 m_ArmorValue = 0xB324;
        public const Int32 m_Collision = 0x31C;
        public const Int32 m_CollisionGroup = 0x474;
        public const Int32 m_Local = 0x2FBC;
        public const Int32 m_MoveType = 0x25C;
        public const Int32 m_OriginalOwnerXuidHigh = 0x31B4;
        public const Int32 m_OriginalOwnerXuidLow = 0x31B0;
        public const Int32 m_SurvivalGameRuleDecisionTypes = 0x1318;
        public const Int32 m_SurvivalRules = 0xCF0;
        public const Int32 m_aimPunchAngle = 0x302C;
        public const Int32 m_aimPunchAngleVel = 0x3038;
        public const Int32 m_bGunGameImmunity = 0x3928;
        public const Int32 m_bHasDefuser = 0xB334;
        public const Int32 m_bHasHelmet = 0xB318;
        public const Int32 m_bInReload = 0x3285;
        public const Int32 m_bIsDefusing = 0x3914;
        public const Int32 m_bIsScoped = 0x390A;
        public const Int32 m_bSpotted = 0x93D;
        public const Int32 m_bSpottedByMask = 0x980;
        public const Int32 m_clrRender = 0x70;
        public const Int32 m_dwBoneMatrix = 0x26A8;
        public const Int32 m_fAccuracyPenalty = 0x3304;
        public const Int32 m_fFlags = 0x104;
        public const Int32 m_flC4Blow = 0x2990;
        public const Int32 m_flDefuseCountDown = 0x29AC;
        public const Int32 m_flDefuseLength = 0x29A8;
        public const Int32 m_flFallbackWear = 0x31C0;
        public const Int32 m_flFlashDuration = 0xA3E0;
        public const Int32 m_flFlashMaxAlpha = 0xA3DC;
        public const Int32 m_flNextPrimaryAttack = 0x3218;
        public const Int32 m_flTimerLength = 0x2994;
        public const Int32 m_hActiveWeapon = 0x2EF8;
        public const Int32 m_hMyWeapons = 0x2DF8;
        public const Int32 m_hObserverTarget = 0x3388;
        public const Int32 m_hOwner = 0x29CC;
        public const Int32 m_hOwnerEntity = 0x14C;
        public const Int32 m_iAccountID = 0x2FC8;
        public const Int32 m_iClip1 = 0x3244;
        public const Int32 m_iCompetitiveRanking = 0x1A84;
        public const Int32 m_iCompetitiveWins = 0x1B88;
        public const Int32 m_iCrosshairId = 0xB390;
        public const Int32 m_iEntityQuality = 0x2FAC;
        public const Int32 m_iFOVStart = 0x31E8;
        public const Int32 m_iGlowIndex = 0xA3F8;
        public const Int32 m_iHealth = 0x100;
        public const Int32 m_iItemDefinitionIndex = 0x2FAA;
        public const Int32 m_iItemIDHigh = 0x2FC0;
        public const Int32 m_iObserverMode = 0x3374;
        public const Int32 m_iShotsFired = 0xA370;
        public const Int32 m_iState = 0x3238;
        public const Int32 m_iTeamNum = 0xF4;
        public const Int32 m_lifeState = 0x25F;
        public const Int32 m_nFallbackPaintKit = 0x31B8;
        public const Int32 m_nFallbackSeed = 0x31BC;
        public const Int32 m_nFallbackStatTrak = 0x31C4;
        public const Int32 m_nForceBone = 0x268C;
        public const Int32 m_nTickBase = 0x342C;
        public const Int32 m_rgflCoordinateFrame = 0x444;
        public const Int32 m_szCustomName = 0x303C;
        public const Int32 m_szLastPlaceName = 0x35B0;
        public const Int32 m_thirdPersonViewAngles = 0x31D8;
        public const Int32 m_vecOrigin = 0x138;
        public const Int32 m_vecVelocity = 0x114;
        public const Int32 m_vecViewOffset = 0x108;
        public const Int32 m_viewPunchAngle = 0x3020;
    }
    public static class signatures
    {
        public const Int32 clientstate_choked_commands = 0x4CB0;
        public const Int32 clientstate_delta_ticks = 0x174;
        public const Int32 clientstate_last_outgoing_command = 0x4CAC;
        public const Int32 clientstate_net_channel = 0x9C;
        public const Int32 convar_name_hash_table = 0x2F0F8;
        public const Int32 dwClientState = 0x58ACFC;
        public const Int32 dwClientState_GetLocalPlayer = 0x180;
        public const Int32 dwClientState_IsHLTV = 0x4CC8;
        public const Int32 dwClientState_Map = 0x28C;
        public const Int32 dwClientState_MapDirectory = 0x188;
        public const Int32 dwClientState_MaxPlayer = 0x310;
        public const Int32 dwClientState_PlayerInfo = 0x5240;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_ViewAngles = 0x4D10;
        public const Int32 dwEntityList = 0x4CC3514;
        public const Int32 dwForceAttack = 0x30F4BD8;
        public const Int32 dwForceAttack2 = 0x30F4BE4;
        public const Int32 dwForceBackward = 0x30F4C2C;
        public const Int32 dwForceForward = 0x30F4C38;
        public const Int32 dwForceJump = 0x5166670;
        public const Int32 dwForceLeft = 0x30F4C50;
        public const Int32 dwForceRight = 0x30F4C44;
        public const Int32 dwGameDir = 0x628E70;
        public const Int32 dwGameRulesProxy = 0x51D89B4;
        public const Int32 dwGetAllClasses = 0xCD75A4;
        public const Int32 dwGlobalVars = 0x58AA00;
        public const Int32 dwGlowObjectManager = 0x5203288;
        public const Int32 dwInput = 0x510E2A8;
        public const Int32 dwInterfaceLinkList = 0x896494;
        public const Int32 dwLocalPlayer = 0xCB3694;
        public const Int32 dwMouseEnable = 0xCB91E0;
        public const Int32 dwMouseEnablePtr = 0xCB91B0;
        public const Int32 dwPlayerResource = 0x30F2F7C;
        public const Int32 dwRadarBase = 0x50F8254;
        public const Int32 dwSensitivity = 0xCB907C;
        public const Int32 dwSensitivityPtr = 0xCB9050;
        public const Int32 dwSetClanTag = 0x894F0;
        public const Int32 dwViewMatrix = 0x4CB4F44;
        public const Int32 dwWeaponTable = 0x510ED6C;
        public const Int32 dwWeaponTableIndex = 0x323C;
        public const Int32 dwYawPtr = 0xCB8E40;
        public const Int32 dwZoomSensitivityRatioPtr = 0xCBE080;
        public const Int32 dwbSendPackets = 0xD206A;
        public const Int32 dwppDirect3DDevice9 = 0xA3FC0;
        public const Int32 interface_engine_cvar = 0x3E9EC;
        public const Int32 m_bDormant = 0xED;
        public const Int32 m_pStudioHdr = 0x294C;
        public const Int32 m_pitchClassPtr = 0x50F8508;
        public const Int32 m_yawClassPtr = 0xCB8E40;
    }
} // namespace hazedumper
