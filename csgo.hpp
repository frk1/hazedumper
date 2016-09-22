#pragma once
#include <cstddef>

// Offsets timestamp
// Thu, 22 Sep 2016 10:23:57 +0200

namespace hazedumper {
namespace netvars {
constexpr ::std::ptrdiff_t m_ArmorValue = 0xA9E8;
constexpr ::std::ptrdiff_t m_Collision = 0x318;
constexpr ::std::ptrdiff_t m_CollisionGroup = 0x470;
constexpr ::std::ptrdiff_t m_Local = 0x2FB0;
constexpr ::std::ptrdiff_t m_MoveType = 0x258;
constexpr ::std::ptrdiff_t m_OriginalOwnerXuidHigh = 0x3164;
constexpr ::std::ptrdiff_t m_OriginalOwnerXuidLow = 0x3160;
constexpr ::std::ptrdiff_t m_aimPunchAngle = 0x3020;
constexpr ::std::ptrdiff_t m_aimPunchAngleVel = 0x302C;
constexpr ::std::ptrdiff_t m_bGunGameImmunity = 0x38A0;
constexpr ::std::ptrdiff_t m_bHasDefuser = 0xA9F8;
constexpr ::std::ptrdiff_t m_bHasHelmet = 0xA9E0;
constexpr ::std::ptrdiff_t m_bInReload = 0x3235;
constexpr ::std::ptrdiff_t m_bIsDefusing = 0x3894;
constexpr ::std::ptrdiff_t m_bIsScoped = 0x388C;
constexpr ::std::ptrdiff_t m_bSpotted = 0x939;
constexpr ::std::ptrdiff_t m_bSpottedByMask = 0x97C;
constexpr ::std::ptrdiff_t m_dwBoneMatrix = 0x2698;
constexpr ::std::ptrdiff_t m_fAccuracyPenalty = 0x32B0;
constexpr ::std::ptrdiff_t m_fFlags = 0x100;
constexpr ::std::ptrdiff_t m_flFallbackWear = 0x3170;
constexpr ::std::ptrdiff_t m_flFlashDuration = 0xA2F8;
constexpr ::std::ptrdiff_t m_flFlashMaxAlpha = 0xA2F4;
constexpr ::std::ptrdiff_t m_flNextPrimaryAttack = 0x31C8;
constexpr ::std::ptrdiff_t m_hActiveWeapon = 0x2EE8;
constexpr ::std::ptrdiff_t m_hMyWeapons = 0x2DE8;
constexpr ::std::ptrdiff_t m_hOwner = 0x29BC;
constexpr ::std::ptrdiff_t m_hOwnerEntity = 0x148;
constexpr ::std::ptrdiff_t m_iAccountID = 0x2FA8;
constexpr ::std::ptrdiff_t m_iClip1 = 0x31F4;
constexpr ::std::ptrdiff_t m_iCompetitiveRanking = 0x1A44;
constexpr ::std::ptrdiff_t m_iCompetitiveWins = 0x1B48;
constexpr ::std::ptrdiff_t m_iCrosshairId = 0xAA44;
constexpr ::std::ptrdiff_t m_iEntityQuality = 0x2F8C;
constexpr ::std::ptrdiff_t m_iFOVStart = 0x31D4;
constexpr ::std::ptrdiff_t m_iGlowIndex = 0xA310;
constexpr ::std::ptrdiff_t m_iHealth = 0xFC;
constexpr ::std::ptrdiff_t m_iItemDefinitionIndex = 0x2F88;
constexpr ::std::ptrdiff_t m_iItemIDHigh = 0x2FA0;
constexpr ::std::ptrdiff_t m_iShotsFired = 0xA2B0;
constexpr ::std::ptrdiff_t m_iState = 0x31E8;
constexpr ::std::ptrdiff_t m_iTeamNum = 0xF0;
constexpr ::std::ptrdiff_t m_lifeState = 0x25B;
constexpr ::std::ptrdiff_t m_nFallbackPaintKit = 0x3168;
constexpr ::std::ptrdiff_t m_nFallbackSeed = 0x316C;
constexpr ::std::ptrdiff_t m_nFallbackStatTrak = 0x3174;
constexpr ::std::ptrdiff_t m_nForceBone = 0x267C;
constexpr ::std::ptrdiff_t m_nTickBase = 0x341C;
constexpr ::std::ptrdiff_t m_rgflCoordinateFrame = 0x440;
constexpr ::std::ptrdiff_t m_szCustomName = 0x301C;
constexpr ::std::ptrdiff_t m_szLastPlaceName = 0x35A0;
constexpr ::std::ptrdiff_t m_vecOrigin = 0x134;
constexpr ::std::ptrdiff_t m_vecVelocity = 0x110;
constexpr ::std::ptrdiff_t m_vecViewOffset = 0x104;
constexpr ::std::ptrdiff_t m_viewPunchAngle = 0x3014;
} // namespace netvars
namespace signatures {
constexpr ::std::ptrdiff_t dwClientState = 0x5BB2D4;
constexpr ::std::ptrdiff_t dwClientState_GetLocalPlayer = 0x178;
constexpr ::std::ptrdiff_t dwClientState_Map = 0x284;
constexpr ::std::ptrdiff_t dwClientState_MapDirectory = 0x180;
constexpr ::std::ptrdiff_t dwClientState_MaxPlayer = 0x308;
constexpr ::std::ptrdiff_t dwClientState_PlayerInfo = 0x523C;
constexpr ::std::ptrdiff_t dwClientState_State = 0x100;
constexpr ::std::ptrdiff_t dwClientState_ViewAngles = 0x4D0C;
constexpr ::std::ptrdiff_t dwEntityList = 0x4A58F14;
constexpr ::std::ptrdiff_t dwForceAttack = 0x2E98F7C;
constexpr ::std::ptrdiff_t dwForceJump = 0x4EEE3C4;
constexpr ::std::ptrdiff_t dwGameDir = 0x659798;
constexpr ::std::ptrdiff_t dwGlobalVars = 0xA2F364;
constexpr ::std::ptrdiff_t dwGlowObjectManager = 0x4F6EC24;
constexpr ::std::ptrdiff_t dwInput = 0x4EA3A20;
constexpr ::std::ptrdiff_t dwLocalPlayer = 0xA3B43C;
constexpr ::std::ptrdiff_t dwPlayerResource = 0x2E9718C;
constexpr ::std::ptrdiff_t dwRadarBase = 0x4E8DC3C;
constexpr ::std::ptrdiff_t dwSensitivity = 0xA40C44;
constexpr ::std::ptrdiff_t dwSensitivityPtr = 0xA40C18;
constexpr ::std::ptrdiff_t dwViewMatrix = 0x4A4AAB4;
constexpr ::std::ptrdiff_t dwWeaponTable = 0x4EA009C;
constexpr ::std::ptrdiff_t dwWeaponTableIndex = 0x3260;
constexpr ::std::ptrdiff_t dwZoomSensitivityRatioPtr = 0xA45920;
constexpr ::std::ptrdiff_t dwbSendPackets = 0xE164A;
constexpr ::std::ptrdiff_t m_pStudioHdr = 0x293C;
} // namespace signatures
} // namespace hazedumper
