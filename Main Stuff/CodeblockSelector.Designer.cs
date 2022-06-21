
namespace FNAF_Engine_Reborn.Main_Stuff
{
    partial class CodeblockSelector
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("On Engine Start");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("On Engine Loop");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("On Engine End");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("When time is [] AM");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("On Night Start");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("On Night Loop");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("On Night Break");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("On Night End");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("When power goes up");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("When power goes down");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("When power runs out");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("When event [] called");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("When any event called");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("When time passes by 1 hour");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("When [value] Changed");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("When power is at []%");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Game Loop", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Timer equals []ms");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Every []ms");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Custom Timer Completed");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Timers", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("On key press");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("User clicks with [] button");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("On camera switch");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("On mask");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("On input []");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Player", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("On AI Changed");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Loop over animatronics");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("On []\'s First move");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("On move");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Animatronics", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("When [] animation finished");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Custom Function");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Advanced", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Light [] is []");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Door [] is []");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Office", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Compare general values");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Set [] to []");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Special Conditions", new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Engine");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Sound");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Game Control");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Keyboard and Mouse");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Player");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Office");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeblockSelector));
            this.Events = new System.Windows.Forms.TreeView();
            this.Actions = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Events
            // 
            this.Events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Events.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.Events.ForeColor = System.Drawing.SystemColors.Window;
            this.Events.ItemHeight = 35;
            this.Events.LineColor = System.Drawing.Color.Red;
            this.Events.Location = new System.Drawing.Point(12, 9);
            this.Events.Name = "Events";
            treeNode1.Name = "On Engine Start";
            treeNode1.Text = "On Engine Start";
            treeNode2.Name = "On Engine Loop";
            treeNode2.Text = "On Engine Loop";
            treeNode3.Name = "On Engine End";
            treeNode3.Text = "On Engine End";
            treeNode4.Name = "When time is [] AM";
            treeNode4.Text = "When time is [] AM";
            treeNode5.Name = "On Night Start";
            treeNode5.Text = "On Night Start";
            treeNode6.Name = "On Night Loop";
            treeNode6.Text = "On Night Loop";
            treeNode7.Name = "On Night Break";
            treeNode7.Text = "On Night Break";
            treeNode8.Name = "On Night End";
            treeNode8.Text = "On Night End";
            treeNode9.Name = "When power goes up";
            treeNode9.Text = "When power goes up";
            treeNode10.Name = "When power goes down";
            treeNode10.Text = "When power goes down";
            treeNode11.Name = "When power runs out";
            treeNode11.Text = "When power runs out";
            treeNode12.Name = "When event [] called";
            treeNode12.Text = "When event [] called";
            treeNode13.Name = "When any event called";
            treeNode13.Text = "When any event called";
            treeNode14.Name = "When time passes by 1 hour";
            treeNode14.Text = "When time passes by 1 hour";
            treeNode15.Name = "When [value] Changed";
            treeNode15.Text = "When [value] Changed";
            treeNode16.Name = "When power is at []%";
            treeNode16.Text = "When power is at []%";
            treeNode17.Name = "Game Loop";
            treeNode17.Text = "Game Loop";
            treeNode18.Name = "Timer equals []ms";
            treeNode18.Text = "Timer equals []ms";
            treeNode19.Name = "Every []ms";
            treeNode19.Text = "Every []ms";
            treeNode20.Name = "Custom Timer Completed";
            treeNode20.Text = "Custom Timer Completed";
            treeNode21.Name = "Timers";
            treeNode21.Text = "Timers";
            treeNode22.Name = "On key press";
            treeNode22.Text = "On key press";
            treeNode23.Name = "User clicks with [] button";
            treeNode23.Text = "User clicks with [] button";
            treeNode24.Name = "On camera switch";
            treeNode24.Text = "On camera switch";
            treeNode25.Name = "On mask";
            treeNode25.Text = "On mask";
            treeNode26.Name = "On input []";
            treeNode26.Text = "On input []";
            treeNode27.Name = "Player";
            treeNode27.Text = "Player";
            treeNode28.Name = "On AI Changed";
            treeNode28.Text = "On AI Changed";
            treeNode29.Name = "Loop over animatronics";
            treeNode29.Text = "Loop over animatronics";
            treeNode30.Name = "On []\'s First move";
            treeNode30.Text = "On []\'s First move";
            treeNode31.Name = "On move";
            treeNode31.Text = "On move";
            treeNode32.Name = "Animatronics";
            treeNode32.Text = "Animatronics";
            treeNode33.Name = "When [] animation finished";
            treeNode33.Text = "When [] animation finished";
            treeNode34.Name = "Custom Function";
            treeNode34.Text = "Custom Function";
            treeNode35.Name = "Advanced";
            treeNode35.Text = "Advanced";
            treeNode36.Name = "Light [] is []";
            treeNode36.Text = "Light [] is []";
            treeNode37.Name = "Door [] is []";
            treeNode37.Text = "Door [] is []";
            treeNode38.Name = "Office";
            treeNode38.Text = "Office";
            this.Events.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode21,
            treeNode27,
            treeNode32,
            treeNode35,
            treeNode38});
            this.Events.Size = new System.Drawing.Size(461, 477);
            this.Events.TabIndex = 42;
            // 
            // Actions
            // 
            this.Actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Actions.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.Actions.ForeColor = System.Drawing.SystemColors.Window;
            this.Actions.ItemHeight = 35;
            this.Actions.LineColor = System.Drawing.Color.Red;
            this.Actions.Location = new System.Drawing.Point(12, 10);
            this.Actions.Name = "Actions";
            treeNode39.Name = "Compare general values";
            treeNode39.Text = "Compare general values";
            treeNode40.Name = "Set [] to []";
            treeNode40.Text = "Set [] to []";
            treeNode41.Name = "Special Conditions";
            treeNode41.Text = "Special Conditions";
            treeNode42.Name = "Engine";
            treeNode42.Text = "Engine";
            treeNode43.Name = "Sound";
            treeNode43.Text = "Sound";
            treeNode44.Name = "Game Control";
            treeNode44.Text = "Game Control";
            treeNode45.Name = "Keyboard and Mouse";
            treeNode45.Text = "Keyboard and Mouse";
            treeNode46.Name = "Player";
            treeNode46.Text = "Player";
            treeNode47.Name = "Office";
            treeNode47.Text = "Office";
            this.Actions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47});
            this.Actions.Size = new System.Drawing.Size(461, 477);
            this.Actions.TabIndex = 43;
            // 
            // CodeblockSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(485, 501);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.Events);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeblockSelector";
            this.Text = "CodeblockSelector";
            this.Load += new System.EventHandler(this.CodeblockSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Events;
        private System.Windows.Forms.TreeView Actions;
    }
}