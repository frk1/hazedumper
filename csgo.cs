using System;

// 2018-05-04 22:45:26.205584200 UTC

namespace hazedumper
{
    public static class netvars
    {
        public const Int32 m_ArmorValue = 0xB238;
        public const Int32 m_Collision = 0x318;
        public const Int32 m_CollisionGroup = 0x470;
        public const Int32 m_Local = 0x2FAC;
        public const Int32 m_MoveType = 0x258;
        public const Int32 m_OriginalOwnerXuidHigh = 0x316C;
        public const Int32 m_OriginalOwnerXuidLow = 0x3168;
        public const Int32 m_aimPunchAngle = 0x301C;
        public const Int32 m_aimPunchAngleVel = 0x3028;
        public const Int32 m_bGunGameImmunity = 0x3894;
        public const Int32 m_bHasDefuser = 0xB248;
        public const Int32 m_bHasHelmet = 0xB22C;
        public const Int32 m_bInReload = 0x3245;
        public const Int32 m_bIsDefusing = 0x3888;
        public const Int32 m_bIsScoped = 0x387E;
        public const Int32 m_bSpotted = 0x939;
        public const Int32 m_bSpottedByMask = 0x97C;
        public const Int32 m_clrRender = 0x70;
        public const Int32 m_dwBoneMatrix = 0x2698;
        public const Int32 m_fAccuracyPenalty = 0x32B0;
        public const Int32 m_fFlags = 0x100;
        public const Int32 m_flFallbackWear = 0x3178;
        public const Int32 m_flFlashDuration = 0xA2F8;
        public const Int32 m_flFlashMaxAlpha = 0xA2F4;
        public const Int32 m_flNextPrimaryAttack = 0x31D8;
        public const Int32 m_hActiveWeapon = 0x2EE8;
        public const Int32 m_hMyWeapons = 0x2DE8;
        public const Int32 m_hObserverTarget = 0x3360;
        public const Int32 m_hOwner = 0x29BC;
        public const Int32 m_hOwnerEntity = 0x148;
        public const Int32 m_iAccountID = 0x2FA8;
        public const Int32 m_iClip1 = 0x3204;
        public const Int32 m_iCompetitiveRanking = 0x1A44;
        public const Int32 m_iCompetitiveWins = 0x1B48;
        public const Int32 m_iCrosshairId = 0xB2A4;
        public const Int32 m_iEntityQuality = 0x2F8C;
        public const Int32 m_iFOVStart = 0x31D8;
        public const Int32 m_iGlowIndex = 0xA310;
        public const Int32 m_iHealth = 0xFC;
        public const Int32 m_iItemDefinitionIndex = 0x2F88;
        public const Int32 m_iItemIDHigh = 0x2FA0;
        public const Int32 m_iObserverMode = 0x334C;
        public const Int32 m_iShotsFired = 0xA2B0;
        public const Int32 m_iState = 0x31F8;
        public const Int32 m_iTeamNum = 0xF0;
        public const Int32 m_lifeState = 0x25B;
        public const Int32 m_nFallbackPaintKit = 0x3170;
        public const Int32 m_nFallbackSeed = 0x3174;
        public const Int32 m_nFallbackStatTrak = 0x317C;
        public const Int32 m_nForceBone = 0x267C;
        public const Int32 m_nTickBase = 0x3404;
        public const Int32 m_rgflCoordinateFrame = 0x440;
        public const Int32 m_szCustomName = 0x301C;
        public const Int32 m_szLastPlaceName = 0x3588;
        public const Int32 m_thirdPersonViewAngles = 0x31C8;
        public const Int32 m_vecOrigin = 0x134;
        public const Int32 m_vecVelocity = 0x110;
        public const Int32 m_vecViewOffset = 0x104;
        public const Int32 m_viewPunchAngle = 0x3010;
    }
    public static class signatures
    {
        public const Int32 dwClientState = 0x57E854;
        public const Int32 dwClientState_GetLocalPlayer = 0x180;
        public const Int32 dwClientState_IsHLTV = 0x4CC8;
        public const Int32 dwClientState_Map = 0x28C;
        public const Int32 dwClientState_MapDirectory = 0x188;
        public const Int32 dwClientState_MaxPlayer = 0x310;
        public const Int32 dwClientState_PlayerInfo = 0x5240;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_ViewAngles = 0x4D10;
        public const Int32 dwEntityList = 0x4A8246C;
        public const Int32 dwForceAttack = 0x2EC47F8;
        public const Int32 dwForceAttack2 = 0x2EC4804;
        public const Int32 dwForceBackward = 0x2EC47E0;
        public const Int32 dwForceForward = 0x2EC4834;
        public const Int32 dwForceJump = 0x4F1970C;
        public const Int32 dwForceLeft = 0x2EC47EC;
        public const Int32 dwForceRight = 0x2EC47C8;
        public const Int32 dwGameDir = 0x61C870;
        public const Int32 dwGameRulesProxy = 0x4F83A54;
        public const Int32 dwGetAllClasses = 0xACC26C;
        public const Int32 dwGlobalVars = 0x57E558;
        public const Int32 dwGlowObjectManager = 0x4F9F800;
        public const Int32 dwInput = 0x4ECD050;
        public const Int32 dwInterfaceLinkList = 0x6E4014;
        public const Int32 dwLocalPlayer = 0xAA7AB4;
        public const Int32 dwMouseEnable = 0xAAD318;
        public const Int32 dwMouseEnablePtr = 0xAAD2E8;
        public const Int32 dwPlayerResource = 0x2EC2B4C;
        public const Int32 dwRadarBase = 0x4EB7154;
        public const Int32 dwSensitivity = 0xAAD1B4;
        public const Int32 dwSensitivityPtr = 0xAAD188;
        public const Int32 dwSetClanTag = 0x87060;
        public const Int32 dwViewMatrix = 0x4A73E84;
        public const Int32 dwWeaponTable = 0x4ECDC4C;
        public const Int32 dwWeaponTableIndex = 0x31FC;
        public const Int32 dwYawPtr = 0xAACF78;
        public const Int32 dwZoomSensitivityRatioPtr = 0xAB1FE0;
        public const Int32 dwbSendPackets = 0xCD55A;
        public const Int32 dwppDirect3DDevice9 = 0xA1F40;
        public const Int32 m_pStudioHdr = 0x293C;
        public const Int32 m_pitchClassPtr = 0x4EB7400;
        public const Int32 m_yawClassPtr = 0xAACF78;
    }
} // namespace hazedumper
