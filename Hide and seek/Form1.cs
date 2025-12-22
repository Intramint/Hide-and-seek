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
        public void startCountdown()
        {
            startGameButton.Visible = false;
            countdownTicks = 0;
            countdownTimer.Enabled = true;
        }


        private Player player;
        private Game game;
        private Opponent opponent;
        private Random opponentRNG;


        private void gameEnd()
        {
            showEndScreen();
            goHereButton.Visible = false;
            searchRoomButton.Visible = false;
            goThroughDoorButton.Visible = false;
            exitsComboBox.Visible = false;
            startGameButton.Visible = true;
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


        private void waitWithDisabledControls(int milliseconds)
        {
            toggleControls(false);
            toggleControlsTimer.Interval = milliseconds;
            toggleControlsTimer.Enabled = true;
        }


        private void toggleControls(bool toggle)
        {
            goHereButton.Enabled = toggle;
            searchRoomButton.Enabled = toggle;
            goThroughDoorButton.Enabled = toggle;
            startGameButton.Enabled = toggle;
            exitsComboBox.Enabled = toggle;
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
            updateForm();
        }


        private void searchRoomButton_Click(object sender, EventArgs e)
        {
            if (player.SearchCurrentRoom(opponent))
            {
                gameEnd();
            }
            else
            {
                descriptionTextBox.Text = "Nikogo tu nie ma";
                waitWithDisabledControls(1000);
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
            countdownTicks++;
            descriptionTextBox.Text = countdownTicks + "...";
            if (countdownTicks >= 10)
            {
                descriptionTextBox.Text = "Szukam!";
                if (countdownTicks == 11)
                {
                    goHereButton.Visible = true;
                    exitsComboBox.Visible = true;
                    updateForm();
                    countdownTimer.Enabled = false;
                }
            }
        }

        private bool secondTick = false;
        private void toggleControlsTimer_Tick(object sender, EventArgs e)
        {
            if (secondTick)
            {
                toggleControlsTimer.Enabled = false;
                toggleControls(true);
                secondTick = false;
                updateForm();
            }
            secondTick = true;
        }
    }
}
