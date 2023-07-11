
namespace FNAF_Engine_Reborn
{
    partial class Compiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compiler));
            label2 = new System.Windows.Forms.Label();
            Compiling_Progress = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(21, 5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(249, 25);
            label2.TabIndex = 3;
            label2.Text = "Compiling your FE:R Game";
            // 
            // Compiling_Progress
            // 
            Compiling_Progress.Location = new System.Drawing.Point(21, 31);
            Compiling_Progress.Name = "Compiling_Progress";
            Compiling_Progress.Size = new System.Drawing.Size(249, 23);
            Compiling_Progress.TabIndex = 5;
            // 
            // Compiler
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(291, 63);
            Controls.Add(Compiling_Progress);
            Controls.Add(label2);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Compiler";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Compiler";
            Load += Compiler_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Compiling_Progress;
    }
}