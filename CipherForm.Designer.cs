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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CipherForm));
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
			this.huckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xOREncriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.knapsackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.generateKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.decrypttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.encryptToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.decryptToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(12, 31);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(541, 267);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = resources.GetString("textBox1.Text");
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
            this.trithemiusToolStripMenuItem,
            this.xOREncriptionToolStripMenuItem,
            this.bookToolStripMenuItem,
            this.knapsackToolStripMenuItem,
            this.dESToolStripMenuItem});
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
			this.encryptToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
			this.encryptToolStripMenuItem2.Text = "Encrypt";
			this.encryptToolStripMenuItem2.Click += new System.EventHandler(this.encryptToolStripMenuItem2_Click);
			// 
			// decryptToolStripMenuItem1
			// 
			this.decryptToolStripMenuItem1.Name = "decryptToolStripMenuItem1";
			this.decryptToolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
			this.decryptToolStripMenuItem1.Text = "Decrypt";
			this.decryptToolStripMenuItem1.Click += new System.EventHandler(this.decryptToolStripMenuItem1_Click);
			// 
			// huckToolStripMenuItem
			// 
			this.huckToolStripMenuItem.Name = "huckToolStripMenuItem";
			this.huckToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
			this.huckToolStripMenuItem.Text = "Huck";
			this.huckToolStripMenuItem.Click += new System.EventHandler(this.huckToolStripMenuItem_Click);
			// 
			// xOREncriptionToolStripMenuItem
			// 
			this.xOREncriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem3,
            this.decryptToolStripMenuItem2});
			this.xOREncriptionToolStripMenuItem.Name = "xOREncriptionToolStripMenuItem";
			this.xOREncriptionToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.xOREncriptionToolStripMenuItem.Text = "XOR";
			// 
			// encryptToolStripMenuItem3
			// 
			this.encryptToolStripMenuItem3.Name = "encryptToolStripMenuItem3";
			this.encryptToolStripMenuItem3.Size = new System.Drawing.Size(136, 26);
			this.encryptToolStripMenuItem3.Text = "Encrypt";
			this.encryptToolStripMenuItem3.Click += new System.EventHandler(this.encryptToolStripMenuItem3_Click);
			// 
			// decryptToolStripMenuItem2
			// 
			this.decryptToolStripMenuItem2.Name = "decryptToolStripMenuItem2";
			this.decryptToolStripMenuItem2.Size = new System.Drawing.Size(136, 26);
			this.decryptToolStripMenuItem2.Text = "Decrypt";
			this.decryptToolStripMenuItem2.Click += new System.EventHandler(this.decryptToolStripMenuItem2_Click);
			// 
			// bookToolStripMenuItem
			// 
			this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem4,
            this.decryptToolStripMenuItem3});
			this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
			this.bookToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.bookToolStripMenuItem.Text = "Book";
			// 
			// encryptToolStripMenuItem4
			// 
			this.encryptToolStripMenuItem4.Name = "encryptToolStripMenuItem4";
			this.encryptToolStripMenuItem4.Size = new System.Drawing.Size(136, 26);
			this.encryptToolStripMenuItem4.Text = "Encrypt";
			this.encryptToolStripMenuItem4.Click += new System.EventHandler(this.encryptToolStripMenuItem4_Click);
			// 
			// decryptToolStripMenuItem3
			// 
			this.decryptToolStripMenuItem3.Name = "decryptToolStripMenuItem3";
			this.decryptToolStripMenuItem3.Size = new System.Drawing.Size(136, 26);
			this.decryptToolStripMenuItem3.Text = "Decrypt";
			this.decryptToolStripMenuItem3.Click += new System.EventHandler(this.decryptToolStripMenuItem3_Click);
			// 
			// knapsackToolStripMenuItem
			// 
			this.knapsackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem5,
            this.decryptToolStripMenuItem4,
            this.generateKeysToolStripMenuItem});
			this.knapsackToolStripMenuItem.Name = "knapsackToolStripMenuItem";
			this.knapsackToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.knapsackToolStripMenuItem.Text = "Knapsack";
			// 
			// encryptToolStripMenuItem5
			// 
			this.encryptToolStripMenuItem5.Name = "encryptToolStripMenuItem5";
			this.encryptToolStripMenuItem5.Size = new System.Drawing.Size(176, 26);
			this.encryptToolStripMenuItem5.Text = "Encrypt";
			this.encryptToolStripMenuItem5.Click += new System.EventHandler(this.encryptToolStripMenuItem5_Click);
			// 
			// decryptToolStripMenuItem4
			// 
			this.decryptToolStripMenuItem4.Name = "decryptToolStripMenuItem4";
			this.decryptToolStripMenuItem4.Size = new System.Drawing.Size(176, 26);
			this.decryptToolStripMenuItem4.Text = "Decrypt";
			this.decryptToolStripMenuItem4.Click += new System.EventHandler(this.decryptToolStripMenuItem4_Click);
			// 
			// generateKeysToolStripMenuItem
			// 
			this.generateKeysToolStripMenuItem.Name = "generateKeysToolStripMenuItem";
			this.generateKeysToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
			this.generateKeysToolStripMenuItem.Text = "Generate keys";
			this.generateKeysToolStripMenuItem.Click += new System.EventHandler(this.generateKeysToolStripMenuItem_Click);
			// 
			// dESToolStripMenuItem
			// 
			this.dESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem6,
            this.decryptToolStripMenuItem5,
            this.aESToolStripMenuItem});
			this.dESToolStripMenuItem.Name = "dESToolStripMenuItem";
			this.dESToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.dESToolStripMenuItem.Text = "Native";
			// 
			// encryptToolStripMenuItem6
			// 
			this.encryptToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem7,
            this.decrypttToolStripMenuItem});
			this.encryptToolStripMenuItem6.Name = "encryptToolStripMenuItem6";
			this.encryptToolStripMenuItem6.Size = new System.Drawing.Size(216, 26);
			this.encryptToolStripMenuItem6.Text = "DES";
			// 
			// encryptToolStripMenuItem7
			// 
			this.encryptToolStripMenuItem7.Name = "encryptToolStripMenuItem7";
			this.encryptToolStripMenuItem7.Size = new System.Drawing.Size(216, 26);
			this.encryptToolStripMenuItem7.Text = "Encrypt";
			this.encryptToolStripMenuItem7.Click += new System.EventHandler(this.encryptToolStripMenuItem7_Click);
			// 
			// decrypttToolStripMenuItem
			// 
			this.decrypttToolStripMenuItem.Name = "decrypttToolStripMenuItem";
			this.decrypttToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.decrypttToolStripMenuItem.Text = "Decrypt";
			this.decrypttToolStripMenuItem.Click += new System.EventHandler(this.decrypttToolStripMenuItem_Click);
			// 
			// decryptToolStripMenuItem5
			// 
			this.decryptToolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem8,
            this.decryptToolStripMenuItem6});
			this.decryptToolStripMenuItem5.Name = "decryptToolStripMenuItem5";
			this.decryptToolStripMenuItem5.Size = new System.Drawing.Size(216, 26);
			this.decryptToolStripMenuItem5.Text = "TripleDES";
			// 
			// encryptToolStripMenuItem8
			// 
			this.encryptToolStripMenuItem8.Name = "encryptToolStripMenuItem8";
			this.encryptToolStripMenuItem8.Size = new System.Drawing.Size(216, 26);
			this.encryptToolStripMenuItem8.Text = "Encrypt";
			this.encryptToolStripMenuItem8.Click += new System.EventHandler(this.encryptToolStripMenuItem8_Click);
			// 
			// decryptToolStripMenuItem6
			// 
			this.decryptToolStripMenuItem6.Name = "decryptToolStripMenuItem6";
			this.decryptToolStripMenuItem6.Size = new System.Drawing.Size(216, 26);
			this.decryptToolStripMenuItem6.Text = "Decrypt";
			this.decryptToolStripMenuItem6.Click += new System.EventHandler(this.decryptToolStripMenuItem6_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// aESToolStripMenuItem
			// 
			this.aESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem9,
            this.decryptToolStripMenuItem7});
			this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
			this.aESToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.aESToolStripMenuItem.Text = "AES";
			// 
			// encryptToolStripMenuItem9
			// 
			this.encryptToolStripMenuItem9.Name = "encryptToolStripMenuItem9";
			this.encryptToolStripMenuItem9.Size = new System.Drawing.Size(216, 26);
			this.encryptToolStripMenuItem9.Text = "Encrypt";
			this.encryptToolStripMenuItem9.Click += new System.EventHandler(this.encryptToolStripMenuItem9_Click);
			// 
			// decryptToolStripMenuItem7
			// 
			this.decryptToolStripMenuItem7.Name = "decryptToolStripMenuItem7";
			this.decryptToolStripMenuItem7.Size = new System.Drawing.Size(216, 26);
			this.decryptToolStripMenuItem7.Text = "Decrypt";
			this.decryptToolStripMenuItem7.Click += new System.EventHandler(this.decryptToolStripMenuItem7_Click);
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
			this.KeyPreview = true;
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
		private System.Windows.Forms.ToolStripMenuItem xOREncriptionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem knapsackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem generateKeysToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem decrypttToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem decryptToolStripMenuItem7;
	}
}

