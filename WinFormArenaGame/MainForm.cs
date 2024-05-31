using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace WinFormArenaGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Hero hero1, hero2;

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbFirstHero;
            if (args.Attacker==hero1)
                tbFirstHero = leftTextBox;//tb=text box 
            else
                tbFirstHero = rightTextBox;

            tbFirstHero.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;

            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)//btn=button
        {
            lbWinner.Text = "";//lb=label
            rightTextBox.Text = "";
            leftTextBox.Text = "";
            lbWinner.Visible = false;

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = hero1,
                HeroB = hero2,
                NotificationsCallBack = gameNotification
            };

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;
        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbAssassin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)//first hero change 
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: //assasin
                    hero1 = new Assassin("Assassin", 50, 90, new Dagger("Dagger"));
                    break;

                case 1: //knight
                    hero1 = new Knight("Knight", 53, 77, new Sword("Sword"));
                    break;

                case 2://fairy
                    hero1 = new Fairy("Fairy", 38, 76, new Wings("Wings"));
                    break;

                case 3://unicorn
                    hero1 = new Unicorn("Unicorn", 63, 100, new Star("Star"));
                    break;
                case 4://wizard
                    hero1 = new Wizard("Wizard", 47, 94, new Wand("Wand"));
                    break;

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//second hero change 
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0: //assasin
                    hero2 = new Assassin("Assassin", 50, 90, new Dagger("Dagger"));
                    break;

                case 1: //knight
                    hero2 = new Knight("Knight", 53, 77, new Sword("Sword"));
                    break;

                case 2://fairy
                    hero2 = new Fairy("Fairy", 38, 76, new Wings("Wings"));
                    break;

                case 3://unicorn
                    hero2 = new Unicorn("Unicorn", 63, 100, new Star("Star"));
                    break;
                case 4://wizard
                    hero2 = new Wizard("Wizard", 47, 94, new Wand("Wand"));
                    break;
            }
        }

        




    }
}