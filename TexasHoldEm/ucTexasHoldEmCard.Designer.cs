
namespace TexasHoldEm
{
	partial class ucTexasHoldEmCard
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbUseCard = new System.Windows.Forms.CheckBox();
			this.lblCard = new System.Windows.Forms.Label();
			this.rbHeart = new System.Windows.Forms.RadioButton();
			this.rbDiamond = new System.Windows.Forms.RadioButton();
			this.rbSpade = new System.Windows.Forms.RadioButton();
			this.rbClub = new System.Windows.Forms.RadioButton();
			this.listRank = new System.Windows.Forms.ListBox();
			this.panelCard = new System.Windows.Forms.Panel();
			this.panelCard.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbUseCard
			// 
			this.cbUseCard.AutoSize = true;
			this.cbUseCard.Location = new System.Drawing.Point(9, 47);
			this.cbUseCard.Name = "cbUseCard";
			this.cbUseCard.Size = new System.Drawing.Size(106, 29);
			this.cbUseCard.TabIndex = 0;
			this.cbUseCard.Text = "Use card";
			this.cbUseCard.UseVisualStyleBackColor = true;
			this.cbUseCard.CheckedChanged += new System.EventHandler(this.cbUseCard_CheckedChanged);
			// 
			// lblCard
			// 
			this.lblCard.AutoSize = true;
			this.lblCard.Location = new System.Drawing.Point(16, 13);
			this.lblCard.Name = "lblCard";
			this.lblCard.Size = new System.Drawing.Size(59, 25);
			this.lblCard.TabIndex = 1;
			this.lblCard.Text = "label1";
			// 
			// rbHeart
			// 
			this.rbHeart.AutoSize = true;
			this.rbHeart.Checked = true;
			this.rbHeart.Location = new System.Drawing.Point(3, 7);
			this.rbHeart.Name = "rbHeart";
			this.rbHeart.Size = new System.Drawing.Size(80, 29);
			this.rbHeart.TabIndex = 2;
			this.rbHeart.TabStop = true;
			this.rbHeart.Text = "Heart";
			this.rbHeart.UseVisualStyleBackColor = true;
			// 
			// rbDiamond
			// 
			this.rbDiamond.AutoSize = true;
			this.rbDiamond.Location = new System.Drawing.Point(3, 42);
			this.rbDiamond.Name = "rbDiamond";
			this.rbDiamond.Size = new System.Drawing.Size(111, 29);
			this.rbDiamond.TabIndex = 3;
			this.rbDiamond.Text = "Diamond";
			this.rbDiamond.UseVisualStyleBackColor = true;
			// 
			// rbSpade
			// 
			this.rbSpade.AutoSize = true;
			this.rbSpade.Location = new System.Drawing.Point(3, 77);
			this.rbSpade.Name = "rbSpade";
			this.rbSpade.Size = new System.Drawing.Size(87, 29);
			this.rbSpade.TabIndex = 4;
			this.rbSpade.Text = "Spade";
			this.rbSpade.UseVisualStyleBackColor = true;
			// 
			// rbClub
			// 
			this.rbClub.AutoSize = true;
			this.rbClub.Location = new System.Drawing.Point(3, 112);
			this.rbClub.Name = "rbClub";
			this.rbClub.Size = new System.Drawing.Size(73, 29);
			this.rbClub.TabIndex = 5;
			this.rbClub.Text = "Club";
			this.rbClub.UseVisualStyleBackColor = true;
			// 
			// listRank
			// 
			this.listRank.FormattingEnabled = true;
			this.listRank.ItemHeight = 25;
			this.listRank.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "Jack",
            "Qeen",
            "King",
            "Ace"});
			this.listRank.Location = new System.Drawing.Point(3, 147);
			this.listRank.Name = "listRank";
			this.listRank.Size = new System.Drawing.Size(111, 329);
			this.listRank.TabIndex = 6;
			// 
			// panelCard
			// 
			this.panelCard.Controls.Add(this.listRank);
			this.panelCard.Controls.Add(this.rbClub);
			this.panelCard.Controls.Add(this.rbHeart);
			this.panelCard.Controls.Add(this.rbSpade);
			this.panelCard.Controls.Add(this.rbDiamond);
			this.panelCard.Location = new System.Drawing.Point(9, 82);
			this.panelCard.Name = "panelCard";
			this.panelCard.Size = new System.Drawing.Size(135, 495);
			this.panelCard.TabIndex = 7;
			this.panelCard.Visible = false;
			// 
			// ucTexasHoldEmCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelCard);
			this.Controls.Add(this.lblCard);
			this.Controls.Add(this.cbUseCard);
			this.Name = "ucTexasHoldEmCard";
			this.Size = new System.Drawing.Size(161, 619);
			this.panelCard.ResumeLayout(false);
			this.panelCard.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbUseCard;
		private System.Windows.Forms.Label lblCard;
		private System.Windows.Forms.RadioButton rbHeart;
		private System.Windows.Forms.RadioButton rbDiamond;
		private System.Windows.Forms.RadioButton rbSpade;
		private System.Windows.Forms.RadioButton rbClub;
		private System.Windows.Forms.ListBox listRank;
		private System.Windows.Forms.Panel panelCard;
	}
}
