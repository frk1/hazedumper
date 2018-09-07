#pragma once
#include <cstdint>

// 2018-09-07 16:32:45.138051600 UTC

namespace hazedumper {
constexpr ::std::int64_t timestamp = 1536337965;
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
constexpr ::std::ptrdiff_t m_flC4Blow = 0x2980;
constexpr ::std::ptrdiff_t m_flDefuseCountDown = 0x2998;
constexpr ::std::ptrdiff_t m_flDefuseLength = 0x2994;
constexpr ::std::ptrdiff_t m_flFallbackWear = 0x31B0;
constexpr ::std::ptrdiff_t m_flFlashDuration = 0xA308;
constexpr ::std::ptrdiff_t m_flFlashMaxAlpha = 0xA304;
constexpr ::std::ptrdiff_t m_flNextPrimaryAttack = 0x3208;
constexpr ::std::ptrdiff_t m_flTimerLength = 0x2984;
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
constexpr ::std::ptrdiff_t dwClientState = 0x588A74;
constexpr ::std::ptrdiff_t dwClientState_GetLocalPlayer = 0x180;
constexpr ::std::ptrdiff_t dwClientState_IsHLTV = 0x4CC8;
constexpr ::std::ptrdiff_t dwClientState_Map = 0x28C;
constexpr ::std::ptrdiff_t dwClientState_MapDirectory = 0x188;
constexpr ::std::ptrdiff_t dwClientState_MaxPlayer = 0x310;
constexpr ::std::ptrdiff_t dwClientState_PlayerInfo = 0x5240;
constexpr ::std::ptrdiff_t dwClientState_State = 0x108;
constexpr ::std::ptrdiff_t dwClientState_ViewAngles = 0x4D10;
constexpr ::std::ptrdiff_t dwEntityList = 0x4C3E194;
constexpr ::std::ptrdiff_t dwForceAttack = 0x307F888;
constexpr ::std::ptrdiff_t dwForceAttack2 = 0x307F894;
constexpr ::std::ptrdiff_t dwForceBackward = 0x307F8DC;
constexpr ::std::ptrdiff_t dwForceForward = 0x307F8B8;
constexpr ::std::ptrdiff_t dwForceJump = 0x50E0E58;
constexpr ::std::ptrdiff_t dwForceLeft = 0x307F8D0;
constexpr ::std::ptrdiff_t dwForceRight = 0x307F858;
constexpr ::std::ptrdiff_t dwGameDir = 0x626CF0;
constexpr ::std::ptrdiff_t dwGameRulesProxy = 0x5153174;
constexpr ::std::ptrdiff_t dwGetAllClasses = 0xC833A4;
constexpr ::std::ptrdiff_t dwGlobalVars = 0x588778;
constexpr ::std::ptrdiff_t dwGlowObjectManager = 0x517D4B0;
constexpr ::std::ptrdiff_t dwInput = 0x5088E10;
constexpr ::std::ptrdiff_t dwInterfaceLinkList = 0x85A754;
constexpr ::std::ptrdiff_t dwLocalPlayer = 0xC6187C;
constexpr ::std::ptrdiff_t dwMouseEnable = 0xC67248;
constexpr ::std::ptrdiff_t dwMouseEnablePtr = 0xC67218;
constexpr ::std::ptrdiff_t dwPlayerResource = 0x307DC0C;
constexpr ::std::ptrdiff_t dwRadarBase = 0x5072E7C;
constexpr ::std::ptrdiff_t dwSensitivity = 0xC670E4;
constexpr ::std::ptrdiff_t dwSensitivityPtr = 0xC670B8;
constexpr ::std::ptrdiff_t dwSetClanTag = 0x886E0;
constexpr ::std::ptrdiff_t dwViewMatrix = 0x4C2FBC4;
constexpr ::std::ptrdiff_t dwWeaponTable = 0x50898B0;
constexpr ::std::ptrdiff_t dwWeaponTableIndex = 0x322C;
constexpr ::std::ptrdiff_t dwYawPtr = 0xC66EA8;
constexpr ::std::ptrdiff_t dwZoomSensitivityRatioPtr = 0xC6BF68;
constexpr ::std::ptrdiff_t dwbSendPackets = 0xD096A;
constexpr ::std::ptrdiff_t dwppDirect3DDevice9 = 0xA2F20;
constexpr ::std::ptrdiff_t m_pStudioHdr = 0x293C;
constexpr ::std::ptrdiff_t m_pitchClassPtr = 0x5073128;
constexpr ::std::ptrdiff_t m_yawClassPtr = 0xC66EA8;
} // namespace signatures
} // namespace hazedumper
