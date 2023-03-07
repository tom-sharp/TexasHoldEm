

namespace TexasHoldEm
{

	partial class TexasHoldEm
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
			this.panelLearn = new System.Windows.Forms.Panel();
			this.btnCheck = new System.Windows.Forms.Button();
			this.lblPlayers = new System.Windows.Forms.Label();
			this.lblDbId = new System.Windows.Forms.Label();
			this.lblDbRate = new System.Windows.Forms.Label();
			this.lblDbWin = new System.Windows.Forms.Label();
			this.lblDbPlayed = new System.Windows.Forms.Label();
			this.lblPlayedCount = new System.Windows.Forms.Label();
			this.btnPlayGames = new System.Windows.Forms.Button();
			this.lblDbCount = new System.Windows.Forms.Label();
			this.lblRankName = new System.Windows.Forms.Label();
			this.panelLearn.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelLearn
			// 
			this.panelLearn.Controls.Add(this.lblRankName);
			this.panelLearn.Controls.Add(this.btnCheck);
			this.panelLearn.Controls.Add(this.lblPlayers);
			this.panelLearn.Controls.Add(this.lblDbId);
			this.panelLearn.Controls.Add(this.lblDbRate);
			this.panelLearn.Controls.Add(this.lblDbWin);
			this.panelLearn.Controls.Add(this.lblDbPlayed);
			this.panelLearn.Controls.Add(this.lblPlayedCount);
			this.panelLearn.Controls.Add(this.btnPlayGames);
			this.panelLearn.Controls.Add(this.lblDbCount);
			this.panelLearn.Location = new System.Drawing.Point(636, 12);
			this.panelLearn.Name = "panelLearn";
			this.panelLearn.Size = new System.Drawing.Size(191, 474);
			this.panelLearn.TabIndex = 0;
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(3, 219);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(126, 43);
			this.btnCheck.TabIndex = 8;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// lblPlayers
			// 
			this.lblPlayers.AutoSize = true;
			this.lblPlayers.Location = new System.Drawing.Point(3, 145);
			this.lblPlayers.Name = "lblPlayers";
			this.lblPlayers.Size = new System.Drawing.Size(68, 25);
			this.lblPlayers.TabIndex = 7;
			this.lblPlayers.Text = "players";
			// 
			// lblDbId
			// 
			this.lblDbId.AutoSize = true;
			this.lblDbId.Location = new System.Drawing.Point(3, 283);
			this.lblDbId.Name = "lblDbId";
			this.lblDbId.Size = new System.Drawing.Size(52, 25);
			this.lblDbId.TabIndex = 6;
			this.lblDbId.Text = "DbId";
			// 
			// lblDbRate
			// 
			this.lblDbRate.AutoSize = true;
			this.lblDbRate.Location = new System.Drawing.Point(3, 422);
			this.lblDbRate.Name = "lblDbRate";
			this.lblDbRate.Size = new System.Drawing.Size(71, 25);
			this.lblDbRate.TabIndex = 5;
			this.lblDbRate.Text = "DbRate";
			// 
			// lblDbWin
			// 
			this.lblDbWin.AutoSize = true;
			this.lblDbWin.Location = new System.Drawing.Point(3, 386);
			this.lblDbWin.Name = "lblDbWin";
			this.lblDbWin.Size = new System.Drawing.Size(67, 25);
			this.lblDbWin.TabIndex = 4;
			this.lblDbWin.Text = "DbWin";
			// 
			// lblDbPlayed
			// 
			this.lblDbPlayed.AutoSize = true;
			this.lblDbPlayed.Location = new System.Drawing.Point(3, 351);
			this.lblDbPlayed.Name = "lblDbPlayed";
			this.lblDbPlayed.Size = new System.Drawing.Size(88, 25);
			this.lblDbPlayed.TabIndex = 3;
			this.lblDbPlayed.Text = "DbPlayed";
			// 
			// lblPlayedCount
			// 
			this.lblPlayedCount.AutoSize = true;
			this.lblPlayedCount.Location = new System.Drawing.Point(3, 109);
			this.lblPlayedCount.Name = "lblPlayedCount";
			this.lblPlayedCount.Size = new System.Drawing.Size(126, 25);
			this.lblPlayedCount.TabIndex = 2;
			this.lblPlayedCount.Text = "played rounds";
			// 
			// btnPlayGames
			// 
			this.btnPlayGames.Location = new System.Drawing.Point(3, 15);
			this.btnPlayGames.Name = "btnPlayGames";
			this.btnPlayGames.Size = new System.Drawing.Size(130, 44);
			this.btnPlayGames.TabIndex = 1;
			this.btnPlayGames.Text = "Play";
			this.btnPlayGames.UseVisualStyleBackColor = true;
			this.btnPlayGames.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblDbCount
			// 
			this.lblDbCount.AutoSize = true;
			this.lblDbCount.Location = new System.Drawing.Point(3, 72);
			this.lblDbCount.Name = "lblDbCount";
			this.lblDbCount.Size = new System.Drawing.Size(91, 25);
			this.lblDbCount.TabIndex = 0;
			this.lblDbCount.Text = "db entries";
			// 
			// lblRankName
			// 
			this.lblRankName.AutoSize = true;
			this.lblRankName.Location = new System.Drawing.Point(3, 308);
			this.lblRankName.Name = "lblRankName";
			this.lblRankName.Size = new System.Drawing.Size(46, 25);
			this.lblRankName.TabIndex = 9;
			this.lblRankName.Text = "rank";
			// 
			// TexasHoldEm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 527);
			this.Controls.Add(this.panelLearn);
			this.Name = "TexasHoldEm";
			this.Text = "TexasHoldEm";
			this.Load += new System.EventHandler(this.TexasHoldEm_Load);
			this.panelLearn.ResumeLayout(false);
			this.panelLearn.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		Syslib.Games.Card.TexasHoldEm.TexasHoldEmAi TexasAi;
		Syslib.Games.Card.TexasHoldEm.TexasHoldEmRankOn5Cards TexasRank;
		ucTexasHoldEmCard[] Cards;
		int gamecardcount;
		int gameplayers;
		int gamelearnplayrounds;
		int gameroundsplayed;

		private System.Windows.Forms.Panel panelLearn;
		private System.Windows.Forms.Label lblDbCount;
		private System.Windows.Forms.Button btnPlayGames;
		private System.Windows.Forms.Label lblPlayedCount;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label lblPlayers;
		private System.Windows.Forms.Label lblDbId;
		private System.Windows.Forms.Label lblDbRate;
		private System.Windows.Forms.Label lblDbWin;
		private System.Windows.Forms.Label lblDbPlayed;
		private System.Windows.Forms.Label lblRankName;
	}
}