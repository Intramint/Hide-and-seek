using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hide_and_seek
{
    internal class Game
    {
        public Game(Random opponentRNG) {
            initializeWorld(opponentRNG);
                       
            for (int i = 0; i < 10; i++)
            {
                Opponent.Move();
            }
            while (Opponent.MyLocation is not IHidingPlace)
                Opponent.Move();
        }

       

      

        public Opponent Opponent { get; private set;  }
        public Player Player { get; private set; }
        public Location StartingLocation { get; private set; }
        public int ActionCounter { get; private set; }
        private void initializeWorld(Random opponentRNG)
        {
            RoomWithDoor livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "dębowe drzwi z mosiężną klamką", "za kanapą");
            RoomWithDoor kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztućce", "drzwi rozsuwane", "w szafce");
            Room diningRoom = new Room("Jadalnia", "kryształowy żyrandol");
            OutsideWithDoor frontYard = new OutsideWithDoor("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką", "w krzakach");
            OutsideWithDoor backYard = new OutsideWithDoor("Podwórko za domem", true, "drzwi rozsuwane", "na drzewie");
            OutsideWithHidingPlace garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
            Room stairs = new Room("Schody", "drewnianą poręcz");
            RoomWithHidingPlace hallway = new RoomWithHidingPlace("Korytarz na górze", "obraz z psem", "w szafie ściennej");
            RoomWithHidingPlace bigBedroom = new RoomWithHidingPlace("Duża sypialnia", "portret", "pod łóżkiem");
            RoomWithHidingPlace smallBedroom = new RoomWithHidingPlace("Mała sypialnia", "pamiątkę z wakacji", "pod łóżkiem");
            Room bathroom = new Room("Łazienka", "lustro z ozdabianą ramką");
            OutsideWithHidingPlace driveway = new OutsideWithHidingPlace("Droga dojazdowa", false, "w garażu");


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

            StartingLocation = frontYard;
            Player = new Player(StartingLocation);
            Opponent = new Opponent(StartingLocation, opponentRNG);
        }


        public void Start()
        {
            for (int i = 1; i <= 10; i++)
            {
                Opponent.Move();
            }
            while (Opponent.MyLocation is not IHidingPlace)
                Opponent.Move();
        }


    }
}
