namespace FAMLineCreater
{
	partial class ValueUserControl
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
			this.lineWidthLabel = new System.Windows.Forms.Label();
			this.pixelLabel = new System.Windows.Forms.Label();
			this.lineWidthTextBox = new System.Windows.Forms.TextBox();
			this.baseTableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// baseTableLayoutPanel
			// 
			this.baseTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.baseTableLayoutPanel.ColumnCount = 4;
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
			this.baseTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.baseTableLayoutPanel.Controls.Add(this.titleLabel, 0, 0);
			this.baseTableLayoutPanel.Controls.Add(this.lineWidthLabel, 1, 0);
			this.baseTableLayoutPanel.Controls.Add(this.pixelLabel, 3, 0);
			this.baseTableLayoutPanel.Controls.Add(this.lineWidthTextBox, 2, 0);
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
			// lineWidthLabel
			// 
			this.lineWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lineWidthLabel.AutoSize = true;
			this.lineWidthLabel.Location = new System.Drawing.Point(91, 8);
			this.lineWidthLabel.Name = "lineWidthLabel";
			this.lineWidthLabel.Size = new System.Drawing.Size(104, 12);
			this.lineWidthLabel.TabIndex = 1;
			this.lineWidthLabel.Text = "Line Width";
			this.lineWidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pixelLabel
			// 
			this.pixelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.pixelLabel.AutoSize = true;
			this.pixelLabel.Location = new System.Drawing.Point(498, 8);
			this.pixelLabel.Name = "pixelLabel";
			this.pixelLabel.Size = new System.Drawing.Size(50, 12);
			this.pixelLabel.TabIndex = 2;
			this.pixelLabel.Text = "pixel";
			this.pixelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lineWidthTextBox
			// 
			this.lineWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lineWidthTextBox.Location = new System.Drawing.Point(201, 3);
			this.lineWidthTextBox.Name = "lineWidthTextBox";
			this.lineWidthTextBox.Size = new System.Drawing.Size(291, 22);
			this.lineWidthTextBox.TabIndex = 4;
			// 
			// ValueUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.baseTableLayoutPanel);
			this.Name = "ValueUserControl";
			this.Size = new System.Drawing.Size(557, 35);
			this.baseTableLayoutPanel.ResumeLayout(false);
			this.baseTableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel baseTableLayoutPanel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label lineWidthLabel;
		private System.Windows.Forms.Label pixelLabel;
		private System.Windows.Forms.TextBox lineWidthTextBox;
	}
}
