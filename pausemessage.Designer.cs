
namespace test22
{
    partial class pausemessage
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
            this.RESUM = new System.Windows.Forms.Button();
            this.pausetxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RESUM
            // 
            this.RESUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.RESUM.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESUM.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RESUM.Location = new System.Drawing.Point(407, 267);
            this.RESUM.Name = "RESUM";
            this.RESUM.Size = new System.Drawing.Size(142, 64);
            this.RESUM.TabIndex = 0;
            this.RESUM.Text = "RESUME";
            this.RESUM.UseVisualStyleBackColor = false;
            // 
            // pausetxt
            // 
            this.pausetxt.AutoSize = true;
            this.pausetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pausetxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pausetxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausetxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pausetxt.Location = new System.Drawing.Point(97, 156);
            this.pausetxt.Name = "pausetxt";
            this.pausetxt.Size = new System.Drawing.Size(778, 34);
            this.pausetxt.TabIndex = 1;
            this.pausetxt.Text = "THE GAME WAS PASUED . TAP RESUME TO CONTINUE";
            // 
            // pausemessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 379);
            this.Controls.Add(this.pausetxt);
            this.Controls.Add(this.RESUM);
            this.Name = "pausemessage";
            this.Text = "pausemessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RESUM;
        private System.Windows.Forms.Label pausetxt;
    }
}