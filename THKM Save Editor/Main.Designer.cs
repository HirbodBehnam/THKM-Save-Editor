namespace THKM_Save_Editor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Open = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Source = new System.Windows.Forms.Button();
            this.GroupBox_Main = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Level_Aim = new System.Windows.Forms.CheckBox();
            this.Level_Slowmotion = new System.Windows.Forms.CheckBox();
            this.Level_Time_Star = new System.Windows.Forms.CheckBox();
            this.Level_Selector = new System.Windows.Forms.NumericUpDown();
            this.GroupBox_Guns = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CH_Guns_Rifle_ExtraClip = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Rifle_Speed = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Rifle_Clipsize = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Rifle_Firerate = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CH_Guns_SMG_Dual = new System.Windows.Forms.CheckBox();
            this.CH_Guns_SMG_ExtraClip = new System.Windows.Forms.CheckBox();
            this.CH_Guns_SMG_Clipsize = new System.Windows.Forms.CheckBox();
            this.CH_Guns_SMG_Firerate = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CH_Guns_Shotgun_ExtraClip = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Shotgun_Firerate = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Shotgun_Speed = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Shotgun_Clipsize = new System.Windows.Forms.CheckBox();
            this.GroupBox_Guns_Pistol = new System.Windows.Forms.GroupBox();
            this.CH_Guns_Pistol_Speed = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Pistol_Unlimited = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Pistol_Firerate = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Pistol_Clipsize = new System.Windows.Forms.CheckBox();
            this.GroupBox_General = new System.Windows.Forms.GroupBox();
            this.CB_God_Mode = new System.Windows.Forms.CheckBox();
            this.TXT_Levels_Unlocked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Stars = new System.Windows.Forms.TextBox();
            this.LBL_Stars = new System.Windows.Forms.Label();
            this.BTN_About = new System.Windows.Forms.Button();
            this.BTN_ChangeDiff = new System.Windows.Forms.Button();
            this.CH_Guns_Pistol_Locked = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Shotgun_Locked = new System.Windows.Forms.CheckBox();
            this.CH_Guns_SMG_Locked = new System.Windows.Forms.CheckBox();
            this.CH_Guns_Rifle_Locked = new System.Windows.Forms.CheckBox();
            this.GroupBox_Main.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Level_Selector)).BeginInit();
            this.GroupBox_Guns.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GroupBox_Guns_Pistol.SuspendLayout();
            this.GroupBox_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Open
            // 
            this.BTN_Open.Location = new System.Drawing.Point(12, 12);
            this.BTN_Open.Name = "BTN_Open";
            this.BTN_Open.Size = new System.Drawing.Size(75, 23);
            this.BTN_Open.TabIndex = 0;
            this.BTN_Open.Text = "Open";
            this.BTN_Open.UseVisualStyleBackColor = true;
            this.BTN_Open.Click += new System.EventHandler(this.Open_Button_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(93, 12);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(75, 23);
            this.BTN_Save.TabIndex = 1;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Source
            // 
            this.BTN_Source.Location = new System.Drawing.Point(376, 12);
            this.BTN_Source.Name = "BTN_Source";
            this.BTN_Source.Size = new System.Drawing.Size(75, 23);
            this.BTN_Source.TabIndex = 4;
            this.BTN_Source.Text = "Source";
            this.BTN_Source.UseVisualStyleBackColor = true;
            this.BTN_Source.Click += new System.EventHandler(this.BTN_Source_Click);
            // 
            // GroupBox_Main
            // 
            this.GroupBox_Main.Controls.Add(this.groupBox4);
            this.GroupBox_Main.Controls.Add(this.GroupBox_Guns);
            this.GroupBox_Main.Controls.Add(this.GroupBox_General);
            this.GroupBox_Main.Enabled = false;
            this.GroupBox_Main.Location = new System.Drawing.Point(12, 41);
            this.GroupBox_Main.Name = "GroupBox_Main";
            this.GroupBox_Main.Size = new System.Drawing.Size(776, 245);
            this.GroupBox_Main.TabIndex = 3;
            this.GroupBox_Main.TabStop = false;
            this.GroupBox_Main.Text = "Save File";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Level_Aim);
            this.groupBox4.Controls.Add(this.Level_Slowmotion);
            this.groupBox4.Controls.Add(this.Level_Time_Star);
            this.groupBox4.Controls.Add(this.Level_Selector);
            this.groupBox4.Location = new System.Drawing.Point(7, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 125);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Level Editing";
            // 
            // Level_Aim
            // 
            this.Level_Aim.AutoSize = true;
            this.Level_Aim.Location = new System.Drawing.Point(9, 95);
            this.Level_Aim.Name = "Level_Aim";
            this.Level_Aim.Size = new System.Drawing.Size(80, 17);
            this.Level_Aim.TabIndex = 3;
            this.Level_Aim.Text = "Perfect Aim";
            this.Level_Aim.UseVisualStyleBackColor = true;
            // 
            // Level_Slowmotion
            // 
            this.Level_Slowmotion.AutoSize = true;
            this.Level_Slowmotion.Location = new System.Drawing.Point(9, 71);
            this.Level_Slowmotion.Name = "Level_Slowmotion";
            this.Level_Slowmotion.Size = new System.Drawing.Size(102, 17);
            this.Level_Slowmotion.TabIndex = 2;
            this.Level_Slowmotion.Text = "Slowmotion Star";
            this.Level_Slowmotion.UseVisualStyleBackColor = true;
            // 
            // Level_Time_Star
            // 
            this.Level_Time_Star.AutoSize = true;
            this.Level_Time_Star.Location = new System.Drawing.Point(9, 47);
            this.Level_Time_Star.Name = "Level_Time_Star";
            this.Level_Time_Star.Size = new System.Drawing.Size(71, 17);
            this.Level_Time_Star.TabIndex = 1;
            this.Level_Time_Star.Text = "Time Star";
            this.Level_Time_Star.UseVisualStyleBackColor = true;
            // 
            // Level_Selector
            // 
            this.Level_Selector.Location = new System.Drawing.Point(9, 20);
            this.Level_Selector.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.Level_Selector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Level_Selector.Name = "Level_Selector";
            this.Level_Selector.Size = new System.Drawing.Size(156, 20);
            this.Level_Selector.TabIndex = 0;
            this.Level_Selector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Level_Selector.ValueChanged += new System.EventHandler(this.Level_Selector_ValueChanged);
            // 
            // GroupBox_Guns
            // 
            this.GroupBox_Guns.Controls.Add(this.groupBox3);
            this.GroupBox_Guns.Controls.Add(this.groupBox2);
            this.GroupBox_Guns.Controls.Add(this.groupBox1);
            this.GroupBox_Guns.Controls.Add(this.GroupBox_Guns_Pistol);
            this.GroupBox_Guns.Location = new System.Drawing.Point(185, 19);
            this.GroupBox_Guns.Name = "GroupBox_Guns";
            this.GroupBox_Guns.Size = new System.Drawing.Size(585, 171);
            this.GroupBox_Guns.TabIndex = 1;
            this.GroupBox_Guns.TabStop = false;
            this.GroupBox_Guns.Text = "Guns";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CH_Guns_Rifle_Locked);
            this.groupBox3.Controls.Add(this.CH_Guns_Rifle_ExtraClip);
            this.groupBox3.Controls.Add(this.CH_Guns_Rifle_Speed);
            this.groupBox3.Controls.Add(this.CH_Guns_Rifle_Clipsize);
            this.groupBox3.Controls.Add(this.CH_Guns_Rifle_Firerate);
            this.groupBox3.Location = new System.Drawing.Point(436, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 142);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rifle";
            // 
            // CH_Guns_Rifle_ExtraClip
            // 
            this.CH_Guns_Rifle_ExtraClip.AutoSize = true;
            this.CH_Guns_Rifle_ExtraClip.Location = new System.Drawing.Point(7, 92);
            this.CH_Guns_Rifle_ExtraClip.Name = "CH_Guns_Rifle_ExtraClip";
            this.CH_Guns_Rifle_ExtraClip.Size = new System.Drawing.Size(70, 17);
            this.CH_Guns_Rifle_ExtraClip.TabIndex = 3;
            this.CH_Guns_Rifle_ExtraClip.Text = "Extra Clip";
            this.CH_Guns_Rifle_ExtraClip.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Rifle_Speed
            // 
            this.CH_Guns_Rifle_Speed.AutoSize = true;
            this.CH_Guns_Rifle_Speed.Location = new System.Drawing.Point(7, 68);
            this.CH_Guns_Rifle_Speed.Name = "CH_Guns_Rifle_Speed";
            this.CH_Guns_Rifle_Speed.Size = new System.Drawing.Size(119, 17);
            this.CH_Guns_Rifle_Speed.TabIndex = 2;
            this.CH_Guns_Rifle_Speed.Text = "+ Movement Speed";
            this.CH_Guns_Rifle_Speed.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Rifle_Clipsize
            // 
            this.CH_Guns_Rifle_Clipsize.AutoSize = true;
            this.CH_Guns_Rifle_Clipsize.Location = new System.Drawing.Point(7, 44);
            this.CH_Guns_Rifle_Clipsize.Name = "CH_Guns_Rifle_Clipsize";
            this.CH_Guns_Rifle_Clipsize.Size = new System.Drawing.Size(87, 17);
            this.CH_Guns_Rifle_Clipsize.TabIndex = 1;
            this.CH_Guns_Rifle_Clipsize.Text = "+10 Clip Size";
            this.CH_Guns_Rifle_Clipsize.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Rifle_Firerate
            // 
            this.CH_Guns_Rifle_Firerate.AutoSize = true;
            this.CH_Guns_Rifle_Firerate.Location = new System.Drawing.Point(7, 20);
            this.CH_Guns_Rifle_Firerate.Name = "CH_Guns_Rifle_Firerate";
            this.CH_Guns_Rifle_Firerate.Size = new System.Drawing.Size(70, 17);
            this.CH_Guns_Rifle_Firerate.TabIndex = 0;
            this.CH_Guns_Rifle_Firerate.Text = "+ Firerate";
            this.CH_Guns_Rifle_Firerate.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CH_Guns_SMG_Locked);
            this.groupBox2.Controls.Add(this.CH_Guns_SMG_Dual);
            this.groupBox2.Controls.Add(this.CH_Guns_SMG_ExtraClip);
            this.groupBox2.Controls.Add(this.CH_Guns_SMG_Clipsize);
            this.groupBox2.Controls.Add(this.CH_Guns_SMG_Firerate);
            this.groupBox2.Location = new System.Drawing.Point(293, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 142);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SMG";
            // 
            // CH_Guns_SMG_Dual
            // 
            this.CH_Guns_SMG_Dual.AutoSize = true;
            this.CH_Guns_SMG_Dual.Location = new System.Drawing.Point(7, 92);
            this.CH_Guns_SMG_Dual.Name = "CH_Guns_SMG_Dual";
            this.CH_Guns_SMG_Dual.Size = new System.Drawing.Size(78, 17);
            this.CH_Guns_SMG_Dual.TabIndex = 3;
            this.CH_Guns_SMG_Dual.Text = "Dual Wield";
            this.CH_Guns_SMG_Dual.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_SMG_ExtraClip
            // 
            this.CH_Guns_SMG_ExtraClip.AutoSize = true;
            this.CH_Guns_SMG_ExtraClip.Location = new System.Drawing.Point(7, 68);
            this.CH_Guns_SMG_ExtraClip.Name = "CH_Guns_SMG_ExtraClip";
            this.CH_Guns_SMG_ExtraClip.Size = new System.Drawing.Size(70, 17);
            this.CH_Guns_SMG_ExtraClip.TabIndex = 2;
            this.CH_Guns_SMG_ExtraClip.Text = "Extra Clip";
            this.CH_Guns_SMG_ExtraClip.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_SMG_Clipsize
            // 
            this.CH_Guns_SMG_Clipsize.AutoSize = true;
            this.CH_Guns_SMG_Clipsize.Location = new System.Drawing.Point(7, 44);
            this.CH_Guns_SMG_Clipsize.Name = "CH_Guns_SMG_Clipsize";
            this.CH_Guns_SMG_Clipsize.Size = new System.Drawing.Size(87, 17);
            this.CH_Guns_SMG_Clipsize.TabIndex = 1;
            this.CH_Guns_SMG_Clipsize.Text = "+10 Clip Size";
            this.CH_Guns_SMG_Clipsize.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_SMG_Firerate
            // 
            this.CH_Guns_SMG_Firerate.AutoSize = true;
            this.CH_Guns_SMG_Firerate.Location = new System.Drawing.Point(7, 20);
            this.CH_Guns_SMG_Firerate.Name = "CH_Guns_SMG_Firerate";
            this.CH_Guns_SMG_Firerate.Size = new System.Drawing.Size(70, 17);
            this.CH_Guns_SMG_Firerate.TabIndex = 0;
            this.CH_Guns_SMG_Firerate.Text = "+ Firerate";
            this.CH_Guns_SMG_Firerate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CH_Guns_Shotgun_Locked);
            this.groupBox1.Controls.Add(this.CH_Guns_Shotgun_ExtraClip);
            this.groupBox1.Controls.Add(this.CH_Guns_Shotgun_Firerate);
            this.groupBox1.Controls.Add(this.CH_Guns_Shotgun_Speed);
            this.groupBox1.Controls.Add(this.CH_Guns_Shotgun_Clipsize);
            this.groupBox1.Location = new System.Drawing.Point(150, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shotgun";
            // 
            // CH_Guns_Shotgun_ExtraClip
            // 
            this.CH_Guns_Shotgun_ExtraClip.AutoSize = true;
            this.CH_Guns_Shotgun_ExtraClip.Location = new System.Drawing.Point(7, 92);
            this.CH_Guns_Shotgun_ExtraClip.Name = "CH_Guns_Shotgun_ExtraClip";
            this.CH_Guns_Shotgun_ExtraClip.Size = new System.Drawing.Size(70, 17);
            this.CH_Guns_Shotgun_ExtraClip.TabIndex = 3;
            this.CH_Guns_Shotgun_ExtraClip.Text = "Extra Clip";
            this.CH_Guns_Shotgun_ExtraClip.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Shotgun_Firerate
            // 
            this.CH_Guns_Shotgun_Firerate.AutoSize = true;
            this.CH_Guns_Shotgun_Firerate.Location = new System.Drawing.Point(7, 68);
            this.CH_Guns_Shotgun_Firerate.Name = "CH_Guns_Shotgun_Firerate";
            this.CH_Guns_Shotgun_Firerate.Size = new System.Drawing.Size(70, 17);
            this.CH_Guns_Shotgun_Firerate.TabIndex = 2;
            this.CH_Guns_Shotgun_Firerate.Text = "+ Firerate";
            this.CH_Guns_Shotgun_Firerate.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Shotgun_Speed
            // 
            this.CH_Guns_Shotgun_Speed.AutoSize = true;
            this.CH_Guns_Shotgun_Speed.Location = new System.Drawing.Point(7, 44);
            this.CH_Guns_Shotgun_Speed.Name = "CH_Guns_Shotgun_Speed";
            this.CH_Guns_Shotgun_Speed.Size = new System.Drawing.Size(119, 17);
            this.CH_Guns_Shotgun_Speed.TabIndex = 1;
            this.CH_Guns_Shotgun_Speed.Text = "+ Movement Speed";
            this.CH_Guns_Shotgun_Speed.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Shotgun_Clipsize
            // 
            this.CH_Guns_Shotgun_Clipsize.AutoSize = true;
            this.CH_Guns_Shotgun_Clipsize.Location = new System.Drawing.Point(7, 20);
            this.CH_Guns_Shotgun_Clipsize.Name = "CH_Guns_Shotgun_Clipsize";
            this.CH_Guns_Shotgun_Clipsize.Size = new System.Drawing.Size(81, 17);
            this.CH_Guns_Shotgun_Clipsize.TabIndex = 0;
            this.CH_Guns_Shotgun_Clipsize.Text = "+3 Clip Size";
            this.CH_Guns_Shotgun_Clipsize.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Guns_Pistol
            // 
            this.GroupBox_Guns_Pistol.Controls.Add(this.CH_Guns_Pistol_Locked);
            this.GroupBox_Guns_Pistol.Controls.Add(this.CH_Guns_Pistol_Speed);
            this.GroupBox_Guns_Pistol.Controls.Add(this.CH_Guns_Pistol_Unlimited);
            this.GroupBox_Guns_Pistol.Controls.Add(this.CH_Guns_Pistol_Firerate);
            this.GroupBox_Guns_Pistol.Controls.Add(this.CH_Guns_Pistol_Clipsize);
            this.GroupBox_Guns_Pistol.Location = new System.Drawing.Point(7, 17);
            this.GroupBox_Guns_Pistol.Name = "GroupBox_Guns_Pistol";
            this.GroupBox_Guns_Pistol.Size = new System.Drawing.Size(137, 142);
            this.GroupBox_Guns_Pistol.TabIndex = 0;
            this.GroupBox_Guns_Pistol.TabStop = false;
            this.GroupBox_Guns_Pistol.Text = "Pistol";
            // 
            // CH_Guns_Pistol_Speed
            // 
            this.CH_Guns_Pistol_Speed.AutoSize = true;
            this.CH_Guns_Pistol_Speed.Location = new System.Drawing.Point(7, 92);
            this.CH_Guns_Pistol_Speed.Name = "CH_Guns_Pistol_Speed";
            this.CH_Guns_Pistol_Speed.Size = new System.Drawing.Size(119, 17);
            this.CH_Guns_Pistol_Speed.TabIndex = 3;
            this.CH_Guns_Pistol_Speed.Text = "+ Movement Speed";
            this.CH_Guns_Pistol_Speed.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Pistol_Unlimited
            // 
            this.CH_Guns_Pistol_Unlimited.AutoSize = true;
            this.CH_Guns_Pistol_Unlimited.Location = new System.Drawing.Point(7, 68);
            this.CH_Guns_Pistol_Unlimited.Name = "CH_Guns_Pistol_Unlimited";
            this.CH_Guns_Pistol_Unlimited.Size = new System.Drawing.Size(101, 17);
            this.CH_Guns_Pistol_Unlimited.TabIndex = 2;
            this.CH_Guns_Pistol_Unlimited.Text = "Unlimited Ammo";
            this.CH_Guns_Pistol_Unlimited.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Pistol_Firerate
            // 
            this.CH_Guns_Pistol_Firerate.AutoSize = true;
            this.CH_Guns_Pistol_Firerate.Location = new System.Drawing.Point(7, 44);
            this.CH_Guns_Pistol_Firerate.Name = "CH_Guns_Pistol_Firerate";
            this.CH_Guns_Pistol_Firerate.Size = new System.Drawing.Size(70, 17);
            this.CH_Guns_Pistol_Firerate.TabIndex = 1;
            this.CH_Guns_Pistol_Firerate.Text = "+ Firerate";
            this.CH_Guns_Pistol_Firerate.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Pistol_Clipsize
            // 
            this.CH_Guns_Pistol_Clipsize.AutoSize = true;
            this.CH_Guns_Pistol_Clipsize.Location = new System.Drawing.Point(7, 20);
            this.CH_Guns_Pistol_Clipsize.Name = "CH_Guns_Pistol_Clipsize";
            this.CH_Guns_Pistol_Clipsize.Size = new System.Drawing.Size(81, 17);
            this.CH_Guns_Pistol_Clipsize.TabIndex = 0;
            this.CH_Guns_Pistol_Clipsize.Text = "+5 Clip Size";
            this.CH_Guns_Pistol_Clipsize.UseVisualStyleBackColor = true;
            // 
            // GroupBox_General
            // 
            this.GroupBox_General.Controls.Add(this.CB_God_Mode);
            this.GroupBox_General.Controls.Add(this.TXT_Levels_Unlocked);
            this.GroupBox_General.Controls.Add(this.label1);
            this.GroupBox_General.Controls.Add(this.TXT_Stars);
            this.GroupBox_General.Controls.Add(this.LBL_Stars);
            this.GroupBox_General.Location = new System.Drawing.Point(6, 19);
            this.GroupBox_General.Name = "GroupBox_General";
            this.GroupBox_General.Size = new System.Drawing.Size(172, 88);
            this.GroupBox_General.TabIndex = 0;
            this.GroupBox_General.TabStop = false;
            this.GroupBox_General.Text = "General";
            // 
            // CB_God_Mode
            // 
            this.CB_God_Mode.AutoSize = true;
            this.CB_God_Mode.Location = new System.Drawing.Point(10, 63);
            this.CB_God_Mode.Name = "CB_God_Mode";
            this.CB_God_Mode.Size = new System.Drawing.Size(76, 17);
            this.CB_God_Mode.TabIndex = 3;
            this.CB_God_Mode.Text = "God Mode";
            this.CB_God_Mode.UseVisualStyleBackColor = true;
            // 
            // TXT_Levels_Unlocked
            // 
            this.TXT_Levels_Unlocked.Location = new System.Drawing.Point(103, 40);
            this.TXT_Levels_Unlocked.Name = "TXT_Levels_Unlocked";
            this.TXT_Levels_Unlocked.Size = new System.Drawing.Size(63, 20);
            this.TXT_Levels_Unlocked.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Levels Unlocked:";
            // 
            // TXT_Stars
            // 
            this.TXT_Stars.Location = new System.Drawing.Point(47, 17);
            this.TXT_Stars.Name = "TXT_Stars";
            this.TXT_Stars.Size = new System.Drawing.Size(119, 20);
            this.TXT_Stars.TabIndex = 1;
            // 
            // LBL_Stars
            // 
            this.LBL_Stars.AutoSize = true;
            this.LBL_Stars.Location = new System.Drawing.Point(7, 20);
            this.LBL_Stars.Name = "LBL_Stars";
            this.LBL_Stars.Size = new System.Drawing.Size(34, 13);
            this.LBL_Stars.TabIndex = 0;
            this.LBL_Stars.Text = "Stars:";
            // 
            // BTN_About
            // 
            this.BTN_About.Location = new System.Drawing.Point(295, 12);
            this.BTN_About.Name = "BTN_About";
            this.BTN_About.Size = new System.Drawing.Size(75, 23);
            this.BTN_About.TabIndex = 3;
            this.BTN_About.Text = "About";
            this.BTN_About.UseVisualStyleBackColor = true;
            this.BTN_About.Click += new System.EventHandler(this.BTN_About_Click);
            // 
            // BTN_ChangeDiff
            // 
            this.BTN_ChangeDiff.Location = new System.Drawing.Point(174, 12);
            this.BTN_ChangeDiff.Name = "BTN_ChangeDiff";
            this.BTN_ChangeDiff.Size = new System.Drawing.Size(115, 23);
            this.BTN_ChangeDiff.TabIndex = 2;
            this.BTN_ChangeDiff.Text = "Change Difficulty ";
            this.BTN_ChangeDiff.UseVisualStyleBackColor = true;
            this.BTN_ChangeDiff.Click += new System.EventHandler(this.BTN_ChangeDiff_Click);
            // 
            // CH_Guns_Pistol_Locked
            // 
            this.CH_Guns_Pistol_Locked.AutoSize = true;
            this.CH_Guns_Pistol_Locked.Checked = true;
            this.CH_Guns_Pistol_Locked.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CH_Guns_Pistol_Locked.Enabled = false;
            this.CH_Guns_Pistol_Locked.Location = new System.Drawing.Point(7, 116);
            this.CH_Guns_Pistol_Locked.Name = "CH_Guns_Pistol_Locked";
            this.CH_Guns_Pistol_Locked.Size = new System.Drawing.Size(114, 17);
            this.CH_Guns_Pistol_Locked.TabIndex = 4;
            this.CH_Guns_Pistol_Locked.Text = "Weapon Unocked";
            this.CH_Guns_Pistol_Locked.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Shotgun_Locked
            // 
            this.CH_Guns_Shotgun_Locked.AutoSize = true;
            this.CH_Guns_Shotgun_Locked.Location = new System.Drawing.Point(7, 115);
            this.CH_Guns_Shotgun_Locked.Name = "CH_Guns_Shotgun_Locked";
            this.CH_Guns_Shotgun_Locked.Size = new System.Drawing.Size(114, 17);
            this.CH_Guns_Shotgun_Locked.TabIndex = 4;
            this.CH_Guns_Shotgun_Locked.Text = "Weapon Unocked";
            this.CH_Guns_Shotgun_Locked.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_SMG_Locked
            // 
            this.CH_Guns_SMG_Locked.AutoSize = true;
            this.CH_Guns_SMG_Locked.Location = new System.Drawing.Point(7, 115);
            this.CH_Guns_SMG_Locked.Name = "CH_Guns_SMG_Locked";
            this.CH_Guns_SMG_Locked.Size = new System.Drawing.Size(114, 17);
            this.CH_Guns_SMG_Locked.TabIndex = 4;
            this.CH_Guns_SMG_Locked.Text = "Weapon Unocked";
            this.CH_Guns_SMG_Locked.UseVisualStyleBackColor = true;
            // 
            // CH_Guns_Rifle_Locked
            // 
            this.CH_Guns_Rifle_Locked.AutoSize = true;
            this.CH_Guns_Rifle_Locked.Location = new System.Drawing.Point(7, 115);
            this.CH_Guns_Rifle_Locked.Name = "CH_Guns_Rifle_Locked";
            this.CH_Guns_Rifle_Locked.Size = new System.Drawing.Size(114, 17);
            this.CH_Guns_Rifle_Locked.TabIndex = 4;
            this.CH_Guns_Rifle_Locked.Text = "Weapon Unocked";
            this.CH_Guns_Rifle_Locked.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 296);
            this.Controls.Add(this.BTN_ChangeDiff);
            this.Controls.Add(this.BTN_About);
            this.Controls.Add(this.GroupBox_Main);
            this.Controls.Add(this.BTN_Source);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.BTN_Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Hong Kong Massacre Save Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GroupBox_Main.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Level_Selector)).EndInit();
            this.GroupBox_Guns.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox_Guns_Pistol.ResumeLayout(false);
            this.GroupBox_Guns_Pistol.PerformLayout();
            this.GroupBox_General.ResumeLayout(false);
            this.GroupBox_General.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Open;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Source;
        private System.Windows.Forms.GroupBox GroupBox_Main;
        private System.Windows.Forms.Button BTN_About;
        private System.Windows.Forms.GroupBox GroupBox_General;
        private System.Windows.Forms.Label LBL_Stars;
        private System.Windows.Forms.TextBox TXT_Stars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_ChangeDiff;
        private System.Windows.Forms.TextBox TXT_Levels_Unlocked;
        private System.Windows.Forms.CheckBox CB_God_Mode;
        private System.Windows.Forms.GroupBox GroupBox_Guns;
        private System.Windows.Forms.GroupBox GroupBox_Guns_Pistol;
        private System.Windows.Forms.CheckBox CH_Guns_Pistol_Clipsize;
        private System.Windows.Forms.CheckBox CH_Guns_Pistol_Speed;
        private System.Windows.Forms.CheckBox CH_Guns_Pistol_Unlimited;
        private System.Windows.Forms.CheckBox CH_Guns_Pistol_Firerate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CH_Guns_Rifle_ExtraClip;
        private System.Windows.Forms.CheckBox CH_Guns_Rifle_Speed;
        private System.Windows.Forms.CheckBox CH_Guns_Rifle_Clipsize;
        private System.Windows.Forms.CheckBox CH_Guns_Rifle_Firerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CH_Guns_SMG_Dual;
        private System.Windows.Forms.CheckBox CH_Guns_SMG_ExtraClip;
        private System.Windows.Forms.CheckBox CH_Guns_SMG_Clipsize;
        private System.Windows.Forms.CheckBox CH_Guns_SMG_Firerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CH_Guns_Shotgun_ExtraClip;
        private System.Windows.Forms.CheckBox CH_Guns_Shotgun_Firerate;
        private System.Windows.Forms.CheckBox CH_Guns_Shotgun_Speed;
        private System.Windows.Forms.CheckBox CH_Guns_Shotgun_Clipsize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown Level_Selector;
        private System.Windows.Forms.CheckBox Level_Time_Star;
        private System.Windows.Forms.CheckBox Level_Aim;
        private System.Windows.Forms.CheckBox Level_Slowmotion;
        private System.Windows.Forms.CheckBox CH_Guns_Pistol_Locked;
        private System.Windows.Forms.CheckBox CH_Guns_Rifle_Locked;
        private System.Windows.Forms.CheckBox CH_Guns_SMG_Locked;
        private System.Windows.Forms.CheckBox CH_Guns_Shotgun_Locked;
    }
}

