#pragma once
#include <cstddef>

// 2018-07-07 20:43:47.733435700 UTC

namespace hazedumper {
namespace netvars {
constexpr ::std::ptrdiff_t m_ArmorValue = 0xB24C;
constexpr ::std::ptrdiff_t m_Collision = 0x318;
constexpr ::std::ptrdiff_t m_CollisionGroup = 0x470;
constexpr ::std::ptrdiff_t m_Local = 0x2FAC;
constexpr ::std::ptrdiff_t m_MoveType = 0x258;
constexpr ::std::ptrdiff_t m_OriginalOwnerXuidHigh = 0x31A4;
constexpr ::std::ptrdiff_t m_OriginalOwnerXuidLow = 0x31A0;
constexpr ::std::ptrdiff_t m_aimPunchAngle = 0x301C;
constexpr ::std::ptrdiff_t m_aimPunchAngleVel = 0x3028;
constexpr ::std::ptrdiff_t m_bGunGameImmunity = 0x38A4;
constexpr ::std::ptrdiff_t m_bHasDefuser = 0xB25C;
constexpr ::std::ptrdiff_t m_bHasHelmet = 0xB240;
constexpr ::std::ptrdiff_t m_bInReload = 0x3275;
constexpr ::std::ptrdiff_t m_bIsDefusing = 0x3898;
constexpr ::std::ptrdiff_t m_bIsScoped = 0x388E;
constexpr ::std::ptrdiff_t m_bSpotted = 0x939;
constexpr ::std::ptrdiff_t m_bSpottedByMask = 0x97C;
constexpr ::std::ptrdiff_t m_clrRender = 0x70;
constexpr ::std::ptrdiff_t m_dwBoneMatrix = 0x2698;
constexpr ::std::ptrdiff_t m_fAccuracyPenalty = 0x32E0;
constexpr ::std::ptrdiff_t m_fFlags = 0x100;
constexpr ::std::ptrdiff_t m_flFallbackWear = 0x31B0;
constexpr ::std::ptrdiff_t m_flFlashDuration = 0xA308;
constexpr ::std::ptrdiff_t m_flFlashMaxAlpha = 0xA304;
constexpr ::std::ptrdiff_t m_flNextPrimaryAttack = 0x3208;
constexpr ::std::ptrdiff_t m_hActiveWeapon = 0x2EE8;
constexpr ::std::ptrdiff_t m_hMyWeapons = 0x2DE8;
constexpr ::std::ptrdiff_t m_hObserverTarget = 0x3360;
constexpr ::std::ptrdiff_t m_hOwner = 0x29BC;
constexpr ::std::ptrdiff_t m_hOwnerEntity = 0x148;
constexpr ::std::ptrdiff_t m_iAccountID = 0x2FB8;
constexpr ::std::ptrdiff_t m_iClip1 = 0x3234;
constexpr ::std::ptrdiff_t m_iCompetitiveRanking = 0x1A84;
constexpr ::std::ptrdiff_t m_iCompetitiveWins = 0x1B88;
constexpr ::std::ptrdiff_t m_iCrosshairId = 0xB2B8;
constexpr ::std::ptrdiff_t m_iEntityQuality = 0x2F9C;
constexpr ::std::ptrdiff_t m_iFOVStart = 0x31D8;
constexpr ::std::ptrdiff_t m_iGlowIndex = 0xA320;
constexpr ::std::ptrdiff_t m_iHealth = 0xFC;
constexpr ::std::ptrdiff_t m_iItemDefinitionIndex = 0x2F9A;
constexpr ::std::ptrdiff_t m_iItemIDHigh = 0x2FB0;
constexpr ::std::ptrdiff_t m_iObserverMode = 0x334C;
constexpr ::std::ptrdiff_t m_iShotsFired = 0xA2C0;
constexpr ::std::ptrdiff_t m_iState = 0x3228;
constexpr ::std::ptrdiff_t m_iTeamNum = 0xF0;
constexpr ::std::ptrdiff_t m_lifeState = 0x25B;
constexpr ::std::ptrdiff_t m_nFallbackPaintKit = 0x31A8;
constexpr ::std::ptrdiff_t m_nFallbackSeed = 0x31AC;
constexpr ::std::ptrdiff_t m_nFallbackStatTrak = 0x31B4;
constexpr ::std::ptrdiff_t m_nForceBone = 0x267C;
constexpr ::std::ptrdiff_t m_nTickBase = 0x3404;
constexpr ::std::ptrdiff_t m_rgflCoordinateFrame = 0x440;
constexpr ::std::ptrdiff_t m_szCustomName = 0x302C;
constexpr ::std::ptrdiff_t m_szLastPlaceName = 0x3588;
constexpr ::std::ptrdiff_t m_thirdPersonViewAngles = 0x31C8;
constexpr ::std::ptrdiff_t m_vecOrigin = 0x134;
constexpr ::std::ptrdiff_t m_vecVelocity = 0x110;
constexpr ::std::ptrdiff_t m_vecViewOffset = 0x104;
constexpr ::std::ptrdiff_t m_viewPunchAngle = 0x3010;
} // namespace netvars
namespace signatures {
constexpr ::std::ptrdiff_t dwClientState = 0x586A74;
constexpr ::std::ptrdiff_t dwClientState_GetLocalPlayer = 0x180;
constexpr ::std::ptrdiff_t dwClientState_IsHLTV = 0x4CC8;
constexpr ::std::ptrdiff_t dwClientState_Map = 0x28C;
constexpr ::std::ptrdiff_t dwClientState_MapDirectory = 0x188;
constexpr ::std::ptrdiff_t dwClientState_MaxPlayer = 0x310;
constexpr ::std::ptrdiff_t dwClientState_PlayerInfo = 0x5240;
constexpr ::std::ptrdiff_t dwClientState_State = 0x108;
constexpr ::std::ptrdiff_t dwClientState_ViewAngles = 0x4D10;
constexpr ::std::ptrdiff_t dwEntityList = 0x4A913B4;
constexpr ::std::ptrdiff_t dwForceAttack = 0x2ED3750;
constexpr ::std::ptrdiff_t dwForceAttack2 = 0x2ED375C;
constexpr ::std::ptrdiff_t dwForceBackward = 0x2ED3774;
constexpr ::std::ptrdiff_t dwForceForward = 0x2ED3768;
constexpr ::std::ptrdiff_t dwForceJump = 0x4F2B890;
constexpr ::std::ptrdiff_t dwForceLeft = 0x2ED3714;
constexpr ::std::ptrdiff_t dwForceRight = 0x2ED3720;
constexpr ::std::ptrdiff_t dwGameDir = 0x624BE8;
constexpr ::std::ptrdiff_t dwGameRulesProxy = 0x4F95C2C;
constexpr ::std::ptrdiff_t dwGetAllClasses = 0xADAAB4;
constexpr ::std::ptrdiff_t dwGlobalVars = 0x586778;
constexpr ::std::ptrdiff_t dwGlowObjectManager = 0x4FC0ED0;
constexpr ::std::ptrdiff_t dwInput = 0x4EDC030;
constexpr ::std::ptrdiff_t dwInterfaceLinkList = 0x6EF4E4;
constexpr ::std::ptrdiff_t dwLocalPlayer = 0xAB5D3C;
constexpr ::std::ptrdiff_t dwMouseEnable = 0xABB6B0;
constexpr ::std::ptrdiff_t dwMouseEnablePtr = 0xABB680;
constexpr ::std::ptrdiff_t dwPlayerResource = 0x2ED1A8C;
constexpr ::std::ptrdiff_t dwRadarBase = 0x4EC609C;
constexpr ::std::ptrdiff_t dwSensitivity = 0xABB54C;
constexpr ::std::ptrdiff_t dwSensitivityPtr = 0xABB520;
constexpr ::std::ptrdiff_t dwSetClanTag = 0x88680;
constexpr ::std::ptrdiff_t dwViewMatrix = 0x4A82DE4;
constexpr ::std::ptrdiff_t dwWeaponTable = 0x4EDCACC;
constexpr ::std::ptrdiff_t dwWeaponTableIndex = 0x322C;
constexpr ::std::ptrdiff_t dwYawPtr = 0xABB310;
constexpr ::std::ptrdiff_t dwZoomSensitivityRatioPtr = 0xAC03D0;
constexpr ::std::ptrdiff_t dwbSendPackets = 0xD06EA;
constexpr ::std::ptrdiff_t dwppDirect3DDevice9 = 0xA2F20;
constexpr ::std::ptrdiff_t m_pStudioHdr = 0x293C;
constexpr ::std::ptrdiff_t m_pitchClassPtr = 0x4EC6348;
constexpr ::std::ptrdiff_t m_yawClassPtr = 0xABB310;
} // namespace signatures
} // namespace hazedumper
