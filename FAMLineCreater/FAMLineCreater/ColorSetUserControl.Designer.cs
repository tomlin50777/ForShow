namespace FAMLineCreater
{
	partial class ColorSetUserControl
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

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.baseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.titleLabel = new System.Windows.Forms.Label();
			this.rLabel = new System.Windows.Forms.Label();
			this.gLabel = new System.Windows.Forms.Label();
			this.bLabel = new System.Windows.Forms.Label();
			this.rTextBox = new System.Windows.Forms.TextBox();
			this.gTextBox = new System.Windows.Forms.TextBox();
			this.bTextBox = new System.Windows.Forms.TextBox();
			this.baseTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// baseTableLayoutPanel
			// 
			this.baseTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.baseTableLayoutPanel.ColumnCount = 7;
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
			this.baseTableLayoutPanel.Controls.Add(this.bTextBox, 6, 0);
			this.baseTableLayoutPanel.Controls.Add(this.gTextBox, 4, 0);
			this.baseTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
			this.baseTableLayoutPanel.Controls.Add(this.rLabel, 1, 0);
			this.baseTableLayoutPanel.Controls.Add(this.gLabel, 3, 0);
			this.baseTableLayoutPanel.Controls.Add(this.bLabel, 5, 0);
			this.baseTableLayoutPanel.Controls.Add(this.rTextBox, 2, 0);
			this.baseTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
			this.baseTableLayoutPanel.Name = "baseTableLayoutPanel";
			this.baseTableLayoutPanel.RowCount = 1;
			this.baseTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.baseTableLayoutPanel.Size = new System.Drawing.Size(551, 29);
			this.baseTableLayoutPanel.TabIndex = 0;
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(3, 8);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(82, 12);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "title";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rLabel
			// 
			this.rLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.rLabel.AutoSize = true;
			this.rLabel.Location = new System.Drawing.Point(91, 8);
			this.rLabel.Name = "rLabel";
			this.rLabel.Size = new System.Drawing.Size(21, 12);
			this.rLabel.TabIndex = 1;
			this.rLabel.Text = "R";
			this.rLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gLabel
			// 
			this.gLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gLabel.AutoSize = true;
			this.gLabel.Location = new System.Drawing.Point(244, 8);
			this.gLabel.Name = "gLabel";
			this.gLabel.Size = new System.Drawing.Size(21, 12);
			this.gLabel.TabIndex = 2;
			this.gLabel.Text = "G";
			this.gLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// bLabel
			// 
			this.bLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.bLabel.AutoSize = true;
			this.bLabel.Location = new System.Drawing.Point(397, 8);
			this.bLabel.Name = "bLabel";
			this.bLabel.Size = new System.Drawing.Size(21, 12);
			this.bLabel.TabIndex = 3;
			this.bLabel.Text = "B";
			this.bLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rTextBox
			// 
			this.rTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rTextBox.Location = new System.Drawing.Point(118, 3);
			this.rTextBox.Name = "rTextBox";
			this.rTextBox.Size = new System.Drawing.Size(120, 22);
			this.rTextBox.TabIndex = 4;
			// 
			// gTextBox
			// 
			this.gTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gTextBox.Location = new System.Drawing.Point(271, 3);
			this.gTextBox.Name = "gTextBox";
			this.gTextBox.Size = new System.Drawing.Size(120, 22);
			this.gTextBox.TabIndex = 5;
			// 
			// bTextBox
			// 
			this.bTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bTextBox.Location = new System.Drawing.Point(424, 3);
			this.bTextBox.Name = "bTextBox";
			this.bTextBox.Size = new System.Drawing.Size(124, 22);
			this.bTextBox.TabIndex = 6;
			// 
			// ColorSetUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.baseTableLayoutPanel);
			this.Name = "ColorSetUserControl";
			this.Size = new System.Drawing.Size(557, 35);
			this.baseTableLayoutPanel.ResumeLayout(false);
			this.baseTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel baseTableLayoutPanel;
		private System.Windows.Forms.TextBox bTextBox;
		private System.Windows.Forms.TextBox gTextBox;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label rLabel;
		private System.Windows.Forms.Label gLabel;
		private System.Windows.Forms.Label bLabel;
		private System.Windows.Forms.TextBox rTextBox;
	}
}
