using System;
using System.Windows.Forms;
using Syslib.Games.Card.TexasHoldEm;

namespace TexasHoldEm
{
	public partial class TexasHoldEm : Form
	{
		public TexasHoldEm()
		{
			InitializeComponent();
			SetUpTexasHoldEm();
		}

		void SetUpTexasHoldEm() {

			this.TexasAi = new TexasHoldEmAi();
			this.TexasRank = new TexasHoldEmRankOn5Cards();
			this.gamecardcount = 7;
			this.gameplayers = 8;
			this.gamelearnplayrounds = 1000;
			this.gameroundsplayed = 0;
			this.Cards = new ucTexasHoldEmCard[gamecardcount];

		}



		private void TexasHoldEm_Load(object sender, EventArgs e)
		{
			this.UpdateContent();
			int leftposition = 0;
			for (int i = 0; i < this.gamecardcount; i++)
			{
				this.Cards[i] = new ucTexasHoldEmCard();
				this.Cards[i].SetUpCard(cardnumber: i + 1, left:leftposition, top: 0);
				leftposition += 120;
				this.Controls.Add(this.Cards[i]);
			}
			this.panelLearn.Left = leftposition;
			this.Width = leftposition + this.panelLearn.Width + 60;
			this.Height = this.Cards[0].Height + 60;

			this.lblDbId.Text = $"Id: ???";
			this.lblRankName.Text = $"";
			this.lblDbPlayed.Text = $"Played ???";
			this.lblDbWin.Text = $"Win ???";
			this.lblDbRate.Text = $"Rate ??? %";
			this.UpdateContent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.TexasAi.Learn(this.gamelearnplayrounds, this.gameplayers);
			this.gameroundsplayed += this.gamelearnplayrounds;
			this.UpdateContent();
		}

		void UpdateContent() 
		{
			this.lblDbCount.Text = $"Entries in Db: {this.TexasAi.Count}";
			this.lblPlayedCount.Text = $"Played rounds: {this.gameroundsplayed}";
			this.lblPlayers.Text = $"Players: {this.gameplayers}";
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			Syslib.Games.Card.PlayCards playercards = new Syslib.Games.Card.PlayCards();
			Syslib.Games.Card.PlayCards commoncards = new Syslib.Games.Card.PlayCards();
			Syslib.Games.Card.PlayCards handcards = new Syslib.Games.Card.PlayCards();
			for (int i = 0; i < 2; i++) {
				var card = this.Cards[i].GetPlayCard();
				if (card != null) playercards.Add(card);
			}
			for (int i = 2; i < 7; i++)
			{
				var card = this.Cards[i].GetPlayCard();
				if (card != null) commoncards.Add(card);
			}
			handcards.Add(playercards).Add(commoncards);
			handcards.RankCards(this.TexasRank);

			var id = this.TexasAi.AskId(this.gameplayers, playercards, commoncards);
			var played = this.TexasAi.AskPlayed(this.gameplayers, playercards, commoncards);
			var win = this.TexasAi.AskWin(this.gameplayers, playercards, commoncards);
			var rate = this.TexasAi.AskRate(this.gameplayers, playercards, commoncards);


			this.lblDbId.Text = $"Id: {Syslib.Hex.FromInt(id)}";
			this.lblRankName.Text = handcards.RankSignature.Name;

			this.lblDbPlayed.Text = $"Played {played}";
			this.lblDbWin.Text = $"Win {win}";
			if (played > 0) this.lblDbRate.Text = $"Rate {rate} %";
			else this.lblDbRate.Text = $"Rate {rate} % ???";
			this.UpdateContent();
		}
	}
}
