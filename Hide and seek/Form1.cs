namespace Hide_and_seek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateObjects();
        }

        private void CreateObjects()
        {
            RoomWithDoor livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dêbowe drzwi z mosiê¿n¹ klamk¹", "za kanap¹");
            RoomWithDoor kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztuæce", "drzwi rozsuwane", "w szafce");
            Room diningRoom = new Room("Jadalnia", "kryszta³owy ¿yrandol");
            OutsideWithDoor frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dêbowe drzwi z mosiê¿n¹ klamk¹", "w krzakach");
            OutsideWithDoor backYard = new OutsideWithDoor("Podwórko za domem", true, "drzwi rozsuwane", "na drzewie");
            Outside garden = new Outside("Ogród", false);

            livingRoom.Exits = [diningRoom];
            livingRoom.DoorLocation = frontYard;

            kitchen.Exits = [diningRoom];
            kitchen.DoorLocation = backYard;

            diningRoom.Exits = [livingRoom, kitchen];

            frontYard.Exits = [backYard, garden];
            frontYard.DoorLocation = livingRoom;

            backYard.Exits = [frontYard, garden];
            backYard.DoorLocation = kitchen;

            garden.Exits = [frontYard, backYard];

            moveToANewLocation(livingRoom);

        }

        Location currentLocation { get; set; }

        private void moveToANewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            exitsComboBox.Items.Clear();
            foreach (Location location in currentLocation.Exits)
            {
                exitsComboBox.Items.Add(location.Name);
            }
            exitsComboBox.SelectedIndex = 0;
            descriptionTextBox.Text = currentLocation.Description;

            if (currentLocation is IHasExteriorDoor)
                goThroughDoorButton.Visible = true;
            else
                goThroughDoorButton.Visible = false;

        }

        private void goHereButton_Click(object sender, EventArgs e)
        {
            moveToANewLocation(currentLocation.Exits[exitsComboBox.SelectedIndex]);
        }

        private void goThroughDoorButton_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor destination = currentLocation as IHasExteriorDoor;
            moveToANewLocation(destination.DoorLocation);
        }
    }
}
