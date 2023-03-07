using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TexasHoldEm
{
	public partial class ucTexasHoldEmCard : UserControl
	{
		public ucTexasHoldEmCard()
		{
			InitializeComponent();
		}

		public void SetUpCard(int cardnumber, int left, int top) {
			this.lblCard.Text = $"Card {cardnumber}";
			this.Left = left;
			this.Top = top;
			this.cbUseCard.Checked = false;
			this.rbHeart.Checked = true;
			this.rbDiamond.Checked = false;
			this.rbSpade.Checked = false;
			this.rbClub.Checked = false;
			this.listRank.SelectedIndex = 0;
			this.panelCard.Visible = false;
			this.Visible = true;
			this.Width = 110;
			this.Height = 580;
		}

		public void ActiveCard(bool status) {
			if (status != cbUseCard.Checked) cbUseCard.Checked = !cbUseCard.Checked;
		}

		public Syslib.Games.Card.PlayCard GetPlayCard() {
			Syslib.Games.Card.PlayCard result = null;
			if (this.cbUseCard.Checked) {
				if (rbHeart.Checked) result = new Syslib.Games.Card.PlayCardHeart(listRank.SelectedIndex + 2);
				else if (rbDiamond.Checked) result = new Syslib.Games.Card.PlayCardDiamond(listRank.SelectedIndex + 2);
				else if (rbSpade.Checked) result = new Syslib.Games.Card.PlayCardSpade(listRank.SelectedIndex + 2);
				else if (rbClub.Checked) result = new Syslib.Games.Card.PlayCardClub(listRank.SelectedIndex + 2);
			}
			return result;
		}

		private void cbUseCard_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cbUseCard.Checked) this.panelCard.Visible = true;
			else this.panelCard.Visible = false;
		}
	}
}
