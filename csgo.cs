using System;

// 2018-11-15 16:21:16.263463700 UTC

namespace hazedumper
{
    public const Int32 timestamp = 1542298876;
    public static class netvars
    {
        public const Int32 m_ArmorValue = 0xB270;
        public const Int32 m_Collision = 0x318;
        public const Int32 m_CollisionGroup = 0x470;
        public const Int32 m_Local = 0x2FAC;
        public const Int32 m_MoveType = 0x258;
        public const Int32 m_OriginalOwnerXuidHigh = 0x31A4;
        public const Int32 m_OriginalOwnerXuidLow = 0x31A0;
        public const Int32 m_aimPunchAngle = 0x301C;
        public const Int32 m_aimPunchAngleVel = 0x3028;
        public const Int32 m_bGunGameImmunity = 0x38C0;
        public const Int32 m_bHasDefuser = 0xB280;
        public const Int32 m_bHasHelmet = 0xB264;
        public const Int32 m_bInReload = 0x3275;
        public const Int32 m_bIsDefusing = 0x38B4;
        public const Int32 m_bIsScoped = 0x38AA;
        public const Int32 m_bSpotted = 0x939;
        public const Int32 m_bSpottedByMask = 0x97C;
        public const Int32 m_clrRender = 0x70;
        public const Int32 m_dwBoneMatrix = 0x2698;
        public const Int32 m_fAccuracyPenalty = 0x32E0;
        public const Int32 m_fFlags = 0x100;
        public const Int32 m_flC4Blow = 0x2980;
        public const Int32 m_flDefuseCountDown = 0x2998;
        public const Int32 m_flDefuseLength = 0x2994;
        public const Int32 m_flFallbackWear = 0x31B0;
        public const Int32 m_flFlashDuration = 0xA32C;
        public const Int32 m_flFlashMaxAlpha = 0xA328;
        public const Int32 m_flNextPrimaryAttack = 0x3208;
        public const Int32 m_flTimerLength = 0x2984;
        public const Int32 m_hActiveWeapon = 0x2EE8;
        public const Int32 m_hMyWeapons = 0x2DE8;
        public const Int32 m_hObserverTarget = 0x3360;
        public const Int32 m_hOwner = 0x29BC;
        public const Int32 m_hOwnerEntity = 0x148;
        public const Int32 m_iAccountID = 0x2FB8;
        public const Int32 m_iClip1 = 0x3234;
        public const Int32 m_iCompetitiveRanking = 0x1A84;
        public const Int32 m_iCompetitiveWins = 0x1B88;
        public const Int32 m_iCrosshairId = 0xB2DC;
        public const Int32 m_iEntityQuality = 0x2F9C;
        public const Int32 m_iFOVStart = 0x31D8;
        public const Int32 m_iGlowIndex = 0xA344;
        public const Int32 m_iHealth = 0xFC;
        public const Int32 m_iItemDefinitionIndex = 0x2F9A;
        public const Int32 m_iItemIDHigh = 0x2FB0;
        public const Int32 m_iObserverMode = 0x334C;
        public const Int32 m_iShotsFired = 0xA2E0;
        public const Int32 m_iState = 0x3228;
        public const Int32 m_iTeamNum = 0xF0;
        public const Int32 m_lifeState = 0x25B;
        public const Int32 m_nFallbackPaintKit = 0x31A8;
        public const Int32 m_nFallbackSeed = 0x31AC;
        public const Int32 m_nFallbackStatTrak = 0x31B4;
        public const Int32 m_nForceBone = 0x267C;
        public const Int32 m_nTickBase = 0x3404;
        public const Int32 m_rgflCoordinateFrame = 0x440;
        public const Int32 m_szCustomName = 0x302C;
        public const Int32 m_szLastPlaceName = 0x3588;
        public const Int32 m_thirdPersonViewAngles = 0x31C8;
        public const Int32 m_vecOrigin = 0x134;
        public const Int32 m_vecVelocity = 0x110;
        public const Int32 m_vecViewOffset = 0x104;
        public const Int32 m_viewPunchAngle = 0x3010;
    }
    public static class signatures
    {
        public const Int32 clientstate_choked_commands = 0x4CB0;
        public const Int32 clientstate_delta_ticks = 0x174;
        public const Int32 clientstate_last_outgoing_command = 0x4CAC;
        public const Int32 clientstate_net_channel = 0x9C;
        public const Int32 convar_name_hash_table = 0x2F0F8;
        public const Int32 dwClientState = 0x589B34;
        public const Int32 dwClientState_GetLocalPlayer = 0x180;
        public const Int32 dwClientState_IsHLTV = 0x4CC8;
        public const Int32 dwClientState_Map = 0x28C;
        public const Int32 dwClientState_MapDirectory = 0x188;
        public const Int32 dwClientState_MaxPlayer = 0x310;
        public const Int32 dwClientState_PlayerInfo = 0x5240;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_ViewAngles = 0x4D10;
        public const Int32 dwEntityList = 0x4C41704;
        public const Int32 dwForceAttack = 0x3082DEC;
        public const Int32 dwForceAttack2 = 0x3082DF8;
        public const Int32 dwForceBackward = 0x3082E40;
        public const Int32 dwForceForward = 0x3082E4C;
        public const Int32 dwForceJump = 0x50E444C;
        public const Int32 dwForceLeft = 0x3082DC8;
        public const Int32 dwForceRight = 0x3082DBC;
        public const Int32 dwGameDir = 0x627C70;
        public const Int32 dwGameRulesProxy = 0x5156794;
        public const Int32 dwGetAllClasses = 0xC8653C;
        public const Int32 dwGlobalVars = 0x589838;
        public const Int32 dwGlowObjectManager = 0x51809B0;
        public const Int32 dwInput = 0x508C3C0;
        public const Int32 dwInterfaceLinkList = 0x85CC34;
        public const Int32 dwLocalPlayer = 0xC648AC;
        public const Int32 dwMouseEnable = 0xC6A278;
        public const Int32 dwMouseEnablePtr = 0xC6A248;
        public const Int32 dwPlayerResource = 0x308117C;
        public const Int32 dwRadarBase = 0x50763EC;
        public const Int32 dwSensitivity = 0xC6A114;
        public const Int32 dwSensitivityPtr = 0xC6A0E8;
        public const Int32 dwSetClanTag = 0x88BD0;
        public const Int32 dwViewMatrix = 0x4C33134;
        public const Int32 dwWeaponTable = 0x508CE5C;
        public const Int32 dwWeaponTableIndex = 0x322C;
        public const Int32 dwYawPtr = 0xC69ED8;
        public const Int32 dwZoomSensitivityRatioPtr = 0xC6EF98;
        public const Int32 dwbSendPackets = 0xD120A;
        public const Int32 dwppDirect3DDevice9 = 0xA3F20;
        public const Int32 interface_engine_cvar = 0x3E9EC;
        public const Int32 m_pStudioHdr = 0x293C;
        public const Int32 m_pitchClassPtr = 0x5076698;
        public const Int32 m_yawClassPtr = 0xC69ED8;
    }
} // namespace hazedumper
