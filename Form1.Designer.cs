﻿namespace GetVerIfix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picBuildsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangerZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPicBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBuildsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.lblFixBuild = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnChoose.Location = new System.Drawing.Point(12, 27);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(309, 23);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "choose *.grf file";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 26F);
            this.lblVersion.Location = new System.Drawing.Point(131, 83);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 41);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(12, 53);
            this.lblPath.MaximumSize = new System.Drawing.Size(309, 50);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(309, 30);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Нажми на кнопку выше, чтобы выбрать картинку *.grf";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.picBuildsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.dangerZoneToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // picBuildsToolStripMenuItem
            // 
            this.picBuildsToolStripMenuItem.Name = "picBuildsToolStripMenuItem";
            this.picBuildsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.picBuildsToolStripMenuItem.Text = "pic builds";
            this.picBuildsToolStripMenuItem.Click += new System.EventHandler(this.picBuildsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::GetVerIfix.Properties.Resources.github_mark;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "git";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dangerZoneToolStripMenuItem
            // 
            this.dangerZoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPicBuildToolStripMenuItem});
            this.dangerZoneToolStripMenuItem.Name = "dangerZoneToolStripMenuItem";
            this.dangerZoneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dangerZoneToolStripMenuItem.Text = "danger zone";
            // 
            // setPicBuildToolStripMenuItem
            // 
            this.setPicBuildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.picBuildsComboBox});
            this.setPicBuildToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.setPicBuildToolStripMenuItem.Name = "setPicBuildToolStripMenuItem";
            this.setPicBuildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setPicBuildToolStripMenuItem.Text = "set pic build";
            // 
            // picBuildsComboBox
            // 
            this.picBuildsComboBox.Name = "picBuildsComboBox";
            this.picBuildsComboBox.Size = new System.Drawing.Size(121, 23);
            this.picBuildsComboBox.SelectedIndexChanged += new System.EventHandler(this.picBuildsComboBox_SelectedIndexChanged);
            // 
            // lblFixBuild
            // 
            this.lblFixBuild.AutoSize = true;
            this.lblFixBuild.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lblFixBuild.Location = new System.Drawing.Point(109, 124);
            this.lblFixBuild.Name = "lblFixBuild";
            this.lblFixBuild.Size = new System.Drawing.Size(0, 13);
            this.lblFixBuild.TabIndex = 4;
            this.lblFixBuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 117);
            this.label1.TabIndex = 5;
            this.label1.Text = "5179 = 3.0;\r\n5717 = 3.5;\r\n6192 = 4.0;\r\n6491 = 4.5;\r\n6846 = 5.1;\r\n10179 = 5.5;\r\n10" +
    "383 = 5.8;\r\n10843 = 5.9;\r\n11109 = 6.0;";
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(436, 24);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(15, 117);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "<";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 145);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFixBuild);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iFIX version";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblFixBuild;
        private System.Windows.Forms.ToolStripMenuItem picBuildsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.ToolStripMenuItem dangerZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPicBuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox picBuildsComboBox;
    }
}

