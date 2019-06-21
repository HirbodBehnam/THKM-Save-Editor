using System;

namespace THKM
{
    public class GlobalGameStatistics
    {
        [Serializable]
        public class LevelStats
        {
            public int LevelIndex;
            public int TimesPlayed;
            public bool LevelCompleted;
            public int TimesCleared;
            public float TimeComplete;
            public float BestTime;
            public float TotalTime;
            public int TimesLevelRestarted;
            public int TimesDied;
            public float TimeSlowmotion;
            public int BulletsFired;
            public int BulletsMissed;
            public int EnemiesKilled;
            public int TimesReloadedWeapon;
            public int TimesWeaponDroped;
            public int WeaponUsed;
            public int TimesDived;
            public int DoorsShoot;
            public int WindowsShoot;
            public bool IsChallengeTimeComplete;
            public bool IsChallengeSlowMoComplete;
            public bool IsChallengeAimComplete;
        }

        [Serializable]
        public class PlayerData
        {
            public GlobalGameStatistics.LevelStats[] LevelData = new GlobalGameStatistics.LevelStats[35];

            public bool[] WeaponObjectIsLocked = new bool[20]
            {
                false,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true,
                true
            };

            public WeaponUpgradeStatus WeaponUpgradeStatusPistol = new WeaponUpgradeStatus();
            public WeaponUpgradeStatus WeaponUpgradeStatusShotGun = new WeaponUpgradeStatus();
            public WeaponUpgradeStatus WeaponUpgradeStatusSMG = new WeaponUpgradeStatus();
            public WeaponUpgradeStatus WeaponUpgradeStatusRifle = new WeaponUpgradeStatus();
            public float SETTINGDifficulty;
            public float SETTINGAimSensitivity;
            public float SETTINGMusicVolume;
            public float SETTINGSoundVolume;
            public float SETTINGGammaBrightness;
            public bool DEBUG_Godmode;
            public bool HasSavedGame;
            public bool HasShowedTutorial01;
            public bool HasShowedTutorial02;
            public bool HasShowedTutorial03;
            public bool HasShowedTutorial04;
            public int LevelsUnlocked;
            public int PlayerGamePoints;
            public int GlobalTimesDied;
            public float GlobalTimeSlowmotion;
            public int GlobalBulletsFired;
            public int GlobalEnemiesKilled;
            public int GlobalTimesReloadedWeapon;
            public int GlobalTimesWeaponDroped;
            public int GlobalWeaponUsed;
            public int GlobalDoorsShoot;
            public int GlobalWindowsShoot;
            public int GlobalTimesDived;
            public float GlobalTotalGameTime;
            public bool Trophy01Complete;
            public bool Trophy02Complete;
            public bool Trophy03Complete;
            public bool Trophy04Complete;
            public bool Trophy05Complete;
            public bool Trophy06Complete;
            public bool Trophy07Complete;
            public bool Trophy08Complete;
            public bool Trophy09Complete;
            public bool Trophy10Complete;
            public bool Trophy11Complete;
            public bool Trophy12Complete;
            public bool Trophy13Complete;
            public bool Trophy14Complete;
            public bool Trophy15Complete;
            public bool Trophy16Complete;
            public bool Trophy17Complete;
            public bool Trophy18Complete;
            public bool Trophy19Complete;
            public bool Trophy20Complete;

            public PlayerData(float volume)
            {
                this.SETTINGMusicVolume = volume;
            }
        }
    }

    [Serializable]
    public class WeaponUpgradeStatus
    {
        public bool IsFireRateUpgraded;
        public bool IsClipSizeUpgraded;
        public bool IsExtraAmmoUpgraded;
        public bool IsUnlimitedAmmoUpgraded;
        public bool IsDualWeaponUpgraded;
        public bool IsReloadSpeedUpgraded;
    }
}