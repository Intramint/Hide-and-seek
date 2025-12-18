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
            OutsideWithHidingPlace garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
            Room stairs = new Room("Schody", "drewniana porêcz");
            RoomWithHidingPlace hallway = new RoomWithHidingPlace("Korytarz na górze", "obraz z psem", "w szafie œciennej");
            RoomWithHidingPlace bigBedroom = new RoomWithHidingPlace("Du¿a sypialnia", "portret", "pod ³ó¿kiem");
            RoomWithHidingPlace smallBedroom = new RoomWithHidingPlace("Ma³a sypialnia", "pami¹tka z wakacji", "pod ³ó¿kiem");
            Room bathroom = new Room("£azienka", "lustro z ozdabian¹ ramk¹");
            OutsideWithHidingPlace driveway = new OutsideWithHidingPlace("Droga dojazdowa", false, "w gara¿u");




            livingRoom.Exits = [diningRoom, stairs];
            kitchen.Exits = [diningRoom];
            diningRoom.Exits = [livingRoom, kitchen];
            frontYard.Exits = [backYard, garden, driveway];
            backYard.Exits = [frontYard, garden, driveway];
            garden.Exits = [frontYard, backYard];
            stairs.Exits = [livingRoom, hallway];
            hallway.Exits = [stairs, bigBedroom, smallBedroom, bathroom];
            bigBedroom.Exits = [hallway];
            smallBedroom.Exits = [hallway];
            bathroom.Exits = [hallway];
            driveway.Exits = [frontYard, backYard];

            backYard.DoorLocation = kitchen;
            kitchen.DoorLocation = backYard;
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;


            Random random = new Random();
            opponent = new Opponent(frontYard, random);
            for (int i = 0; i < 10; i++)
                opponent.Move();
            while (opponent.myLocation is not IHidingPlace)
                opponent.Move();

            moveToANewLocation(livingRoom);

        }

        Location currentLocation { get; set; }
        public Opponent opponent { get; private set; }

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

        public bool Check(Location location)
        {
            if (opponent.myLocation == location)
                return true;
            return false;
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
