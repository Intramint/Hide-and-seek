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
            RoomWithDoor livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dêbowe drzwi z mosiê¿n¹ klamk¹");
            RoomWithDoor kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztuæce", "drzwi zasuwane");
            Room diningRoom = new Room("Jadalnia", "kryszta³owy ¿yrandol");
            OutsideWithDoor frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dêbowe drzwi z mosiê¿n¹ klamk¹");
            OutsideWithDoor backYard = new OutsideWithDoor("Podwórko za domem", true, "drzwi zasuwane");
            Outside garden = new Outside("Ogród", false);

            livingRoom.Exits = [diningRoom];
            livingRoom.DoorLocation = frontYard;
            kitchen.Exits = [livingRoom]; 
            kitchen.DoorLocation = backYard;
            diningRoom.Exits = [livingRoom, kitchen];
            frontYard.Exits = [backYard, garden];
            frontYard.DoorLocation = livingRoom;
            backYard.Exits = [frontYard, garden];
            backYard.DoorLocation = kitchen;
            garden.Exits = [frontYard, backYard];
        }
    }
}
