namespace Cipher {
	partial class CipherForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.caesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trithemiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.huckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(12, 31);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(541, 267);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Simple of text to Encrypt";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.Filter = "Text Document|*.txt";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "txt";
			this.openFileDialog1.Filter = "Text Document|*.txt";
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encryptToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(566, 28);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
			this.exportToolStripMenuItem.Text = "Load";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// encryptToolStripMenuItem
			// 
			this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caesarToolStripMenuItem,
            this.trithemiusToolStripMenuItem});
			this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
			this.encryptToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
			this.encryptToolStripMenuItem.Text = "Cipher";
			// 
			// caesarToolStripMenuItem
			// 
			this.caesarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem1,
            this.decryptToolStripMenuItem,
            this.hackToolStripMenuItem});
			this.caesarToolStripMenuItem.Name = "caesarToolStripMenuItem";
			this.caesarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.caesarToolStripMenuItem.Text = "Caesar";
			// 
			// encryptToolStripMenuItem1
			// 
			this.encryptToolStripMenuItem1.Name = "encryptToolStripMenuItem1";
			this.encryptToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
			this.encryptToolStripMenuItem1.Text = "Encrypt";
			this.encryptToolStripMenuItem1.Click += new System.EventHandler(this.encryptToolStripMenuItem1_Click);
			// 
			// decryptToolStripMenuItem
			// 
			this.decryptToolStripMenuItem.Name = "decryptToolStripMenuItem";
			this.decryptToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
			this.decryptToolStripMenuItem.Text = "Decrypt";
			this.decryptToolStripMenuItem.Click += new System.EventHandler(this.decryptToolStripMenuItem_Click);
			// 
			// hackToolStripMenuItem
			// 
			this.hackToolStripMenuItem.Name = "hackToolStripMenuItem";
			this.hackToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
			this.hackToolStripMenuItem.Text = "Hack";
			this.hackToolStripMenuItem.Click += new System.EventHandler(this.hackToolStripMenuItem_Click);
			// 
			// trithemiusToolStripMenuItem
			// 
			this.trithemiusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem2,
            this.decryptToolStripMenuItem1,
            this.huckToolStripMenuItem});
			this.trithemiusToolStripMenuItem.Name = "trithemiusToolStripMenuItem";
			this.trithemiusToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.trithemiusToolStripMenuItem.Text = "Trithemius";
			// 
			// encryptToolStripMenuItem2
			// 
			this.encryptToolStripMenuItem2.Name = "encryptToolStripMenuItem2";
			this.encryptToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
			this.encryptToolStripMenuItem2.Text = "Encrypt";
			this.encryptToolStripMenuItem2.Click += new System.EventHandler(this.encryptToolStripMenuItem2_Click);
			// 
			// decryptToolStripMenuItem1
			// 
			this.decryptToolStripMenuItem1.Name = "decryptToolStripMenuItem1";
			this.decryptToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
			this.decryptToolStripMenuItem1.Text = "Decrypt";
			this.decryptToolStripMenuItem1.Click += new System.EventHandler(this.decryptToolStripMenuItem1_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// huckToolStripMenuItem
			// 
			this.huckToolStripMenuItem.Name = "huckToolStripMenuItem";
			this.huckToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.huckToolStripMenuItem.Text = "Huck";
			this.huckToolStripMenuItem.Click += new System.EventHandler(this.huckToolStripMenuItem_Click);
			// 
			// CipherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(566, 313);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "CipherForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cipher - Gorodetskiy";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem caesarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trithemiusToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem huckToolStripMenuItem;
	}
}

