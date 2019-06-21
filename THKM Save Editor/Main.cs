using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using THKM;

namespace THKM_Save_Editor
{
    public partial class Main : Form
    {
        private GlobalGameStatistics.PlayerData _save = null;
        private int _selectedLevel = 1;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please backup your data before changing the save.", "Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        private void Open_Button_Click(object sender, EventArgs e)
        {
            string filename;
            {
                OpenFileDialog ofd = new OpenFileDialog {Filter = "The Hong Kong Massacre Save (*.thkm)|*.thkm"};
                if (Directory.Exists(@"C:\Users\Hirbod\AppData\LocalLow\VRESKI\The Hong Kong Massacre"))
                    ofd.InitialDirectory = @"C:\Users\Hirbod\AppData\LocalLow\VRESKI\The Hong Kong Massacre";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                }
                else
                    return;
            }
            FileStream fs = new FileStream(filename, FileMode.Open);
            try 
            {
                BinaryFormatter formatter = new BinaryFormatter();
                _save = (GlobalGameStatistics.PlayerData) formatter.Deserialize(fs);
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Failed to deserialize save file. Reason: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally 
            {
                fs.Close();
            }
            if (_save == null)
                return;

            GroupBox_Main.Enabled = true;

            #region General stuff
            TXT_Stars.Text = _save.PlayerGamePoints.ToString();
            TXT_Levels_Unlocked.Text = _save.LevelsUnlocked.ToString();
            CB_God_Mode.Checked = _save.DEBUG_Godmode;
            #endregion
            #region Guns
            //Pistol
            CH_Guns_Pistol_Clipsize.Checked = !_save.WeaponObjectIsLocked[4];
            CH_Guns_Pistol_Firerate.Checked = !_save.WeaponObjectIsLocked[5];
            CH_Guns_Pistol_Unlimited.Checked = !_save.WeaponObjectIsLocked[6];
            CH_Guns_Pistol_Speed.Checked = !_save.WeaponObjectIsLocked[7];
            //Shotgun
            CH_Guns_Shotgun_Locked.Checked = !_save.WeaponObjectIsLocked[1];
            CH_Guns_Shotgun_Clipsize.Checked = !_save.WeaponObjectIsLocked[8];
            CH_Guns_Shotgun_Speed.Checked = !_save.WeaponObjectIsLocked[9];
            CH_Guns_Shotgun_Firerate.Checked = !_save.WeaponObjectIsLocked[10];
            CH_Guns_Shotgun_ExtraClip.Checked = !_save.WeaponObjectIsLocked[11];
            //SMG
            CH_Guns_SMG_Locked.Checked = !_save.WeaponObjectIsLocked[2];
            CH_Guns_SMG_Firerate.Checked = !_save.WeaponObjectIsLocked[12];
            CH_Guns_SMG_Clipsize.Checked = !_save.WeaponObjectIsLocked[13];
            CH_Guns_SMG_ExtraClip.Checked = !_save.WeaponObjectIsLocked[14];
            CH_Guns_SMG_Dual.Checked = !_save.WeaponObjectIsLocked[15];
            //Rifle
            CH_Guns_Rifle_Locked.Checked = !_save.WeaponObjectIsLocked[3];
            CH_Guns_Rifle_Firerate.Checked = !_save.WeaponObjectIsLocked[16];
            CH_Guns_Rifle_Clipsize.Checked = !_save.WeaponObjectIsLocked[17];
            CH_Guns_Rifle_Speed.Checked = !_save.WeaponObjectIsLocked[18];
            CH_Guns_Rifle_ExtraClip.Checked = !_save.WeaponObjectIsLocked[19];
            #endregion

            #region Levels
            Level_Aim.Checked =_save.LevelData[0].IsChallengeAimComplete;
            Level_Slowmotion.Checked = _save.LevelData[0].IsChallengeSlowMoComplete;
            Level_Time_Star.Checked = _save.LevelData[0].IsChallengeTimeComplete;
            #endregion
            
        }
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            string filename;
            {
                SaveFileDialog sfd = new SaveFileDialog {Filter = "The Hong Kong Massacre Save (*.thkm)|*.thkm"};
                if (Directory.Exists(@"C:\Users\Hirbod\AppData\LocalLow\VRESKI\The Hong Kong Massacre"))
                    sfd.InitialDirectory = @"C:\Users\Hirbod\AppData\LocalLow\VRESKI\The Hong Kong Massacre";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filename = sfd.FileName;
                }
                else
                    return;
            }
            _save.HasSavedGame = true;
            #region General Stuff
            _save.PlayerGamePoints = int.Parse(TXT_Stars.Text);
            _save.LevelsUnlocked = int.Parse(TXT_Levels_Unlocked.Text);
            _save.DEBUG_Godmode = CB_God_Mode.Checked;
            #endregion
            #region Guns
            //Pistol
            _save.WeaponObjectIsLocked[4] = !CH_Guns_Pistol_Clipsize.Checked;
            _save.WeaponObjectIsLocked[5] = !CH_Guns_Pistol_Firerate.Checked;
            _save.WeaponObjectIsLocked[6] = !CH_Guns_Pistol_Unlimited.Checked;
            _save.WeaponObjectIsLocked[7] = !CH_Guns_Pistol_Speed.Checked;
            //Shotgun
            _save.WeaponObjectIsLocked[1] = !CH_Guns_Shotgun_Locked.Checked;
            _save.WeaponObjectIsLocked[8] = !CH_Guns_Shotgun_Clipsize.Checked;
            _save.WeaponObjectIsLocked[9] = !CH_Guns_Shotgun_Speed.Checked;
            _save.WeaponObjectIsLocked[10] = !CH_Guns_Shotgun_Firerate.Checked;
            _save.WeaponObjectIsLocked[11] = !CH_Guns_Shotgun_ExtraClip.Checked;
            //SMG
            _save.WeaponObjectIsLocked[2] = !CH_Guns_SMG_Locked.Checked;
            _save.WeaponObjectIsLocked[12] = !CH_Guns_SMG_Firerate.Checked;
            _save.WeaponObjectIsLocked[13] = !CH_Guns_SMG_Clipsize.Checked;
            _save.WeaponObjectIsLocked[14] = !CH_Guns_SMG_ExtraClip.Checked;
            _save.WeaponObjectIsLocked[15] = !CH_Guns_SMG_Dual.Checked;
            //Rifle
            _save.WeaponObjectIsLocked[3] = !CH_Guns_Rifle_Locked.Checked;
            _save.WeaponObjectIsLocked[16] = !CH_Guns_Rifle_Firerate.Checked;
            _save.WeaponObjectIsLocked[17] = !CH_Guns_Rifle_Clipsize.Checked;
            _save.WeaponObjectIsLocked[18] = !CH_Guns_Rifle_Speed.Checked;
            _save.WeaponObjectIsLocked[19] = !CH_Guns_Rifle_ExtraClip.Checked;
            #endregion
            #region Levels
            _save.LevelData[_selectedLevel - 1].IsChallengeAimComplete = Level_Aim.Checked;
            _save.LevelData[_selectedLevel - 1].IsChallengeSlowMoComplete = Level_Slowmotion.Checked;
            _save.LevelData[_selectedLevel - 1].IsChallengeTimeComplete = Level_Time_Star.Checked;
            #endregion
            
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                FileStream fileStream1 = File.Create(filename);
                binaryFormatter.Serialize(fileStream1, _save);
                fileStream1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to write save file. Reason: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void BTN_ChangeDiff_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Changing difficulty does not requires any application. Just grab your save file and rename it to \"" +
                "playerSave.thkm\", \"playerSaveEasy.thkm\" or \"playerSaveHard.thkm\" to change the difficulty. " +
                "Then place the file in \"C:\\Users\\Hirbod\\AppData\\LocalLow\\VRESKI\\The Hong Kong Massacre\""
                , "Change Difficulty", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Level_Selector_ValueChanged(object sender, EventArgs e)
        {
            _save.LevelData[_selectedLevel - 1].IsChallengeAimComplete = Level_Aim.Checked;
            _save.LevelData[_selectedLevel - 1].IsChallengeSlowMoComplete = Level_Slowmotion.Checked;
            _save.LevelData[_selectedLevel - 1].IsChallengeTimeComplete = Level_Time_Star.Checked;

            _selectedLevel = (int)Level_Selector.Value;

            Level_Aim.Checked = _save.LevelData[_selectedLevel - 1].IsChallengeAimComplete;
            Level_Slowmotion.Checked = _save.LevelData[_selectedLevel - 1].IsChallengeSlowMoComplete;
            Level_Time_Star.Checked = _save.LevelData[_selectedLevel - 1].IsChallengeTimeComplete;
        }
    }
}
