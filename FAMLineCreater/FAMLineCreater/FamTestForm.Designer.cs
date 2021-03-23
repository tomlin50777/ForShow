namespace FAMLineCreater
{
	partial class FamTestForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.testButton = new System.Windows.Forms.Button();
			this.famLineCreatorTestButton = new System.Windows.Forms.Button();
			this.imageTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.buttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.baseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.settingTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.mappingValueUserControl = new FAMLineCreater.ValueUserControl();
			this.judgeColorSetUserControl = new FAMLineCreater.ColorSetUserControl();
			this.mappingColorSetUserControl = new FAMLineCreater.ColorSetUserControl();
			this.endColorSetUserControl = new FAMLineCreater.ColorSetUserControl();
			this.judgeValueUserControl = new FAMLineCreater.ValueUserControl();
			this.offsetValueUserControl = new FAMLineCreater.ValueUserControl();
			this.dashTypeListBox = new System.Windows.Forms.ListBox();
			this.imageTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.buttonTableLayoutPanel.SuspendLayout();
			this.baseTableLayoutPanel.SuspendLayout();
			this.settingTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// testButton
			// 
			this.testButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.testButton.Location = new System.Drawing.Point(3, 3);
			this.testButton.Name = "testButton";
			this.testButton.Size = new System.Drawing.Size(217, 22);
			this.testButton.TabIndex = 0;
			this.testButton.Text = "TestDataCreate";
			this.testButton.UseVisualStyleBackColor = true;
			this.testButton.Click += new System.EventHandler(this.TestButton_Click);
			// 
			// famLineCreatorTestButton
			// 
			this.famLineCreatorTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.famLineCreatorTestButton.Location = new System.Drawing.Point(226, 3);
			this.famLineCreatorTestButton.Name = "famLineCreatorTestButton";
			this.famLineCreatorTestButton.Size = new System.Drawing.Size(217, 22);
			this.famLineCreatorTestButton.TabIndex = 1;
			this.famLineCreatorTestButton.Text = "FamTest";
			this.famLineCreatorTestButton.UseVisualStyleBackColor = true;
			this.famLineCreatorTestButton.Click += new System.EventHandler(this.FamLineCreatorTestButton_Click);
			// 
			// imageTableLayoutPanel
			// 
			this.imageTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imageTableLayoutPanel.ColumnCount = 1;
			this.imageTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.imageTableLayoutPanel.Controls.Add(this.pictureBox, 0, 0);
			this.imageTableLayoutPanel.Controls.Add(this.buttonTableLayoutPanel, 0, 1);
			this.imageTableLayoutPanel.Location = new System.Drawing.Point(460, 3);
			this.imageTableLayoutPanel.Name = "imageTableLayoutPanel";
			this.imageTableLayoutPanel.RowCount = 2;
			this.imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
			this.imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.imageTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.imageTableLayoutPanel.Size = new System.Drawing.Size(452, 675);
			this.imageTableLayoutPanel.TabIndex = 2;
			// 
			// pictureBox
			// 
			this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox.Location = new System.Drawing.Point(3, 3);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(446, 635);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// buttonTableLayoutPanel
			// 
			this.buttonTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonTableLayoutPanel.ColumnCount = 2;
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.buttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.buttonTableLayoutPanel.Controls.Add(this.testButton, 0, 0);
			this.buttonTableLayoutPanel.Controls.Add(this.famLineCreatorTestButton, 1, 0);
			this.buttonTableLayoutPanel.Location = new System.Drawing.Point(3, 644);
			this.buttonTableLayoutPanel.Name = "buttonTableLayoutPanel";
			this.buttonTableLayoutPanel.RowCount = 1;
			this.buttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.buttonTableLayoutPanel.Size = new System.Drawing.Size(446, 28);
			this.buttonTableLayoutPanel.TabIndex = 0;
			// 
			// baseTableLayoutPanel
			// 
			this.baseTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.baseTableLayoutPanel.ColumnCount = 2;
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.baseTableLayoutPanel.Controls.Add(this.imageTableLayoutPanel, 1, 0);
			this.baseTableLayoutPanel.Controls.Add(this.settingTableLayoutPanel, 0, 0);
			this.baseTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
			this.baseTableLayoutPanel.Name = "baseTableLayoutPanel";
			this.baseTableLayoutPanel.RowCount = 1;
			this.baseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.baseTableLayoutPanel.Size = new System.Drawing.Size(915, 681);
			this.baseTableLayoutPanel.TabIndex = 3;
			// 
			// settingTableLayoutPanel
			// 
			this.settingTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingTableLayoutPanel.ColumnCount = 1;
			this.settingTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.settingTableLayoutPanel.Controls.Add(this.offsetValueUserControl, 0, 6);
			this.settingTableLayoutPanel.Controls.Add(this.mappingValueUserControl, 0, 4);
			this.settingTableLayoutPanel.Controls.Add(this.richTextBox, 0, 0);
			this.settingTableLayoutPanel.Controls.Add(this.judgeColorSetUserControl, 0, 1);
			this.settingTableLayoutPanel.Controls.Add(this.mappingColorSetUserControl, 0, 3);
			this.settingTableLayoutPanel.Controls.Add(this.endColorSetUserControl, 0, 5);
			this.settingTableLayoutPanel.Controls.Add(this.judgeValueUserControl, 0, 2);
			this.settingTableLayoutPanel.Controls.Add(this.dashTypeListBox, 0, 7);
			this.settingTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.settingTableLayoutPanel.Name = "settingTableLayoutPanel";
			this.settingTableLayoutPanel.RowCount = 8;
			this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
			this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
			this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
			this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
			this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
			this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
			this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
			this.settingTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
			this.settingTableLayoutPanel.Size = new System.Drawing.Size(451, 675);
			this.settingTableLayoutPanel.TabIndex = 3;
			// 
			// richTextBox1
			// 
			this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox.Location = new System.Drawing.Point(3, 3);
			this.richTextBox.Name = "richTextBox1";
			this.richTextBox.Size = new System.Drawing.Size(445, 338);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			// 
			// mappingValueUserControl
			// 
			this.mappingValueUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mappingValueUserControl.Location = new System.Drawing.Point(3, 488);
			this.mappingValueUserControl.Name = "mappingValueUserControl";
			this.mappingValueUserControl.Size = new System.Drawing.Size(445, 41);
			this.mappingValueUserControl.TabIndex = 5;
			// 
			// judgeColorSetUserControl
			// 
			this.judgeColorSetUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.judgeColorSetUserControl.Location = new System.Drawing.Point(3, 347);
			this.judgeColorSetUserControl.Name = "judgeColorSetUserControl";
			this.judgeColorSetUserControl.Size = new System.Drawing.Size(445, 41);
			this.judgeColorSetUserControl.TabIndex = 1;
			// 
			// mappingColorSetUserControl
			// 
			this.mappingColorSetUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mappingColorSetUserControl.Location = new System.Drawing.Point(3, 441);
			this.mappingColorSetUserControl.Name = "mappingColorSetUserControl";
			this.mappingColorSetUserControl.Size = new System.Drawing.Size(445, 41);
			this.mappingColorSetUserControl.TabIndex = 2;
			// 
			// endColorSetUserControl
			// 
			this.endColorSetUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.endColorSetUserControl.Location = new System.Drawing.Point(3, 535);
			this.endColorSetUserControl.Name = "endColorSetUserControl";
			this.endColorSetUserControl.Size = new System.Drawing.Size(445, 41);
			this.endColorSetUserControl.TabIndex = 3;
			// 
			// judgeValueUserControl
			// 
			this.judgeValueUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.judgeValueUserControl.Location = new System.Drawing.Point(3, 394);
			this.judgeValueUserControl.Name = "judgeValueUserControl";
			this.judgeValueUserControl.Size = new System.Drawing.Size(445, 41);
			this.judgeValueUserControl.TabIndex = 4;
			// 
			// offsetValueUserControl
			// 
			this.offsetValueUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.offsetValueUserControl.Location = new System.Drawing.Point(3, 582);
			this.offsetValueUserControl.Name = "offsetValueUserControl";
			this.offsetValueUserControl.Size = new System.Drawing.Size(445, 41);
			this.offsetValueUserControl.TabIndex = 6;
			// 
			// dashTypeListBox
			// 
			this.dashTypeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dashTypeListBox.FormattingEnabled = true;
			this.dashTypeListBox.ItemHeight = 12;
			this.dashTypeListBox.Location = new System.Drawing.Point(3, 629);
			this.dashTypeListBox.Name = "dashTypeListBox";
			this.dashTypeListBox.Size = new System.Drawing.Size(445, 40);
			this.dashTypeListBox.TabIndex = 7;
			// 
			// FamTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 705);
			this.Controls.Add(this.baseTableLayoutPanel);
			this.Name = "FamTestForm";
			this.Text = "FamTestForm";
			this.imageTableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.buttonTableLayoutPanel.ResumeLayout(false);
			this.baseTableLayoutPanel.ResumeLayout(false);
			this.settingTableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button testButton;
		private System.Windows.Forms.Button famLineCreatorTestButton;
		private System.Windows.Forms.TableLayoutPanel imageTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel buttonTableLayoutPanel;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TableLayoutPanel baseTableLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel settingTableLayoutPanel;
		private System.Windows.Forms.RichTextBox richTextBox;
		private ColorSetUserControl judgeColorSetUserControl;
		private ColorSetUserControl mappingColorSetUserControl;
		private ColorSetUserControl endColorSetUserControl;
		private ValueUserControl mappingValueUserControl;
		private ValueUserControl judgeValueUserControl;
		private ValueUserControl offsetValueUserControl;
		private System.Windows.Forms.ListBox dashTypeListBox;
	}
}

