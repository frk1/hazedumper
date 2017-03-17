using System;

// Offsets timestamp
// Thu, 16 Mar 2017 01:05:07 +0100

namespace hazedumper
{
    public static class netvars
    {
        public const Int32 m_ArmorValue = 0xAA04;
        public const Int32 m_Collision = 0x318;
        public const Int32 m_CollisionGroup = 0x470;
        public const Int32 m_Local = 0x2FAC;
        public const Int32 m_MoveType = 0x258;
        public const Int32 m_OriginalOwnerXuidHigh = 0x316C;
        public const Int32 m_OriginalOwnerXuidLow = 0x3168;
        public const Int32 m_aimPunchAngle = 0x301C;
        public const Int32 m_aimPunchAngleVel = 0x3028;
        public const Int32 m_bGunGameImmunity = 0x38B0;
        public const Int32 m_bHasDefuser = 0xAA14;
        public const Int32 m_bHasHelmet = 0xA9FC;
        public const Int32 m_bInReload = 0x3245;
        public const Int32 m_bIsDefusing = 0x38A4;
        public const Int32 m_bIsScoped = 0x389C;
        public const Int32 m_bSpotted = 0x939;
        public const Int32 m_bSpottedByMask = 0x97C;
        public const Int32 m_dwBoneMatrix = 0x2698;
        public const Int32 m_fAccuracyPenalty = 0x32C0;
        public const Int32 m_fFlags = 0x100;
        public const Int32 m_flFallbackWear = 0x3178;
        public const Int32 m_flFlashDuration = 0xA308;
        public const Int32 m_flFlashMaxAlpha = 0xA304;
        public const Int32 m_flNextPrimaryAttack = 0x31D8;
        public const Int32 m_hActiveWeapon = 0x2EE8;
        public const Int32 m_hMyWeapons = 0x2DE8;
        public const Int32 m_hObserverTarget = 0x3380;
        public const Int32 m_hOwner = 0x29BC;
        public const Int32 m_hOwnerEntity = 0x148;
        public const Int32 m_iAccountID = 0x2FA8;
        public const Int32 m_iClip1 = 0x3204;
        public const Int32 m_iCompetitiveRanking = 0x1A44;
        public const Int32 m_iCompetitiveWins = 0x1B48;
        public const Int32 m_iCrosshairId = 0xAA70;
        public const Int32 m_iEntityQuality = 0x2F8C;
        public const Int32 m_iFOVStart = 0x31D8;
        public const Int32 m_iGlowIndex = 0xA320;
        public const Int32 m_iHealth = 0xFC;
        public const Int32 m_iItemDefinitionIndex = 0x2F88;
        public const Int32 m_iItemIDHigh = 0x2FA0;
        public const Int32 m_iObserverMode = 0x336C;
        public const Int32 m_iShotsFired = 0xA2C0;
        public const Int32 m_iState = 0x31F8;
        public const Int32 m_iTeamNum = 0xF0;
        public const Int32 m_lifeState = 0x25B;
        public const Int32 m_nFallbackPaintKit = 0x3170;
        public const Int32 m_nFallbackSeed = 0x3174;
        public const Int32 m_nFallbackStatTrak = 0x317C;
        public const Int32 m_nForceBone = 0x267C;
        public const Int32 m_nTickBase = 0x3424;
        public const Int32 m_rgflCoordinateFrame = 0x440;
        public const Int32 m_szCustomName = 0x301C;
        public const Int32 m_szLastPlaceName = 0x35A8;
        public const Int32 m_vecOrigin = 0x134;
        public const Int32 m_vecVelocity = 0x110;
        public const Int32 m_vecViewOffset = 0x104;
        public const Int32 m_viewPunchAngle = 0x3010;
    }
    public static class signatures
    {
        public const Int32 dwClientState = 0x5CA524;
        public const Int32 dwClientState_GetLocalPlayer = 0x178;
        public const Int32 dwClientState_Map = 0x284;
        public const Int32 dwClientState_MapDirectory = 0x180;
        public const Int32 dwClientState_MaxPlayer = 0x308;
        public const Int32 dwClientState_PlayerInfo = 0x523C;
        public const Int32 dwClientState_State = 0x100;
        public const Int32 dwClientState_ViewAngles = 0x4D0C;
        public const Int32 dwEntityList = 0x4ACF844;
        public const Int32 dwForceAttack = 0x2F0F800;
        public const Int32 dwForceAttack2 = 0x2F0F7F4;
        public const Int32 dwForceBackward = 0x2F0F83C;
        public const Int32 dwForceForward = 0x2F0F818;
        public const Int32 dwForceJump = 0x4F66400;
        public const Int32 dwForceLeft = 0x2F0F830;
        public const Int32 dwForceRight = 0x2F0F854;
        public const Int32 dwGameDir = 0x6692E8;
        public const Int32 dwGameRulesProxy = 0x2F0DA9C;
        public const Int32 dwGetAllClasses = 0x2F0DB50;
        public const Int32 dwGlobalVars = 0xAA03A0;
        public const Int32 dwGlowObjectManager = 0x4FEA32C;
        public const Int32 dwInput = 0x4F1A340;
        public const Int32 dwInterfaceLinkList = 0x72A594;
        public const Int32 dwLocalPlayer = 0xAAC6EC;
        public const Int32 dwMouseEnable = 0xAB1F50;
        public const Int32 dwMouseEnablePtr = 0xAB1F20;
        public const Int32 dwPlayerResource = 0x2F0DA54;
        public const Int32 dwRadarBase = 0x4F0454C;
        public const Int32 dwSensitivity = 0xAB1EF4;
        public const Int32 dwSensitivityPtr = 0xAB1EC8;
        public const Int32 dwViewMatrix = 0x4AC13E4;
        public const Int32 dwWeaponTable = 0x4F169AC;
        public const Int32 dwWeaponTableIndex = 0x3270;
        public const Int32 dwYawPtr = 0xAB1DC0;
        public const Int32 dwZoomSensitivityRatioPtr = 0xAB6BD0;
        public const Int32 dwbSendPackets = 0xE46AA;
        public const Int32 dwppDirect3DDevice9 = 0x99960;
        public const Int32 dwSetClanTag = 0x9CEC0;
        public const Int32 m_pStudioHdr = 0x293C;
    }
} // namespace hazedumper
