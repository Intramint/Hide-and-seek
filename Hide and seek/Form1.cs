namespace Hide_and_seek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            opponentRNG = new Random();

        }


        private int countdownTicks;
        public void startCountdown() //call on button click
        {
            startGameButton.Visible = false; //should also disable controls and enable at endCountdown
            countdownTicks = 0;
            countdownTimer.Enabled = true;
        }

        public void endCountdown()
        {
            descriptionTextBox.Text = "Szukam!";
            WaitWithDisabledControls(500);

            updateForm();
        }


        private Player player;
        private Game game;
        private Opponent opponent;
        private Random opponentRNG;


        private void gameEnd()
        {
            showEndScreen();
            goHereButton.Enabled = false;
            searchRoomButton.Enabled = false;
            goThroughDoorButton.Enabled = false;
            exitsComboBox.Enabled = false;
        }


        private void showEndScreen()
        {
            IHidingPlace searchedLocation = player.CurrentLocation as IHidingPlace;
            descriptionTextBox.Text = $"Znalaz³eœ mnie {searchedLocation.HidingPlace} w {player.CurrentLocation.Name}! Zajê³o ci to {player.ActionCounter} ruchów.";
        }


        private void updateForm()
        {
            exitsComboBox.Items.Clear();

            foreach (Location location in player.CurrentLocation.Exits)
                exitsComboBox.Items.Add(location.Name);
            exitsComboBox.SelectedIndex = 0;
            descriptionTextBox.Text = player.CurrentLocation.Description;


            if (player.CurrentLocation is IHasExteriorDoor)
                goThroughDoorButton.Visible = true;
            else
                goThroughDoorButton.Visible = false;


            if (player.CurrentLocation is IHidingPlace)
            {
                searchRoomButton.Visible = true;
                IHidingPlace searchedLocation = player.CurrentLocation as IHidingPlace;
                searchRoomButton.Text = "SprawdŸ " + searchedLocation.HidingPlace;
            }
            else
                searchRoomButton.Visible = false;
        }


        private void WaitWithDisabledControls(int milliseconds) //change to use timer
        {
            toggleControls(false);
            toggleControlsTimer.Interval = milliseconds;
            toggleControlsTimer.Enabled = true;
            timer1_Tick
            toggleControls(true);
        }


        private void toggleControls(bool toggle)
        {
            goHereButton.Enabled = toggle;
            searchRoomButton.Enabled = toggle;
            goThroughDoorButton.Enabled = toggle;
            startGameButton.Enabled = toggle;
            exitsComboBox.Enabled = toggle;
            descriptionTextBox.Enabled = toggle;
        }


        ///
        /// Buttons
        ///


        private void goHereButton_Click(object sender, EventArgs e)
        {
            Location exit = player.CurrentLocation.Exits[exitsComboBox.SelectedIndex];
            player.MoveTo(exit);
            updateForm();
        }


        private void goThroughDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor destination = player.CurrentLocation as IHasExteriorDoor;
            player.MoveTo(destination.DoorLocation);
        }


        private void searchRoomButton_Click(object sender, EventArgs e)
        {
            if (opponent.hiddenHere(player.CurrentLocation))
                gameEnd();
            else
            {
                string description = descriptionTextBox.Text;
                descriptionTextBox.Text = "Nikogo tu nie ma";
                WaitWithDisabledControls(1000);
                descriptionTextBox.Text = description;
            }
        }


        private void startGameButton_Click(object sender, EventArgs e)
        {
            game = new Game(opponentRNG);
            opponent = game.Opponent;
            player = game.Player;
            game.Start();
            startCountdown();
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        { 
            descriptionTextBox.Text = countdownTicks + "...";
            if (countdownTicks >= 10)
                endCountdown();
        }
    }
}
