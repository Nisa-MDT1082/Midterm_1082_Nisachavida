public class ReserveSeat
    {
		public static Company.Account thisaccount = Menu.thisccount;
		public static List<string> prefredSeat = new List<string>();

		public static string Seat;
      
		public static void DisplayPreferedSeats()
        {
            Console.WriteLine("Prefer seats : " + Seat);
        }

		public static void OnResreveSeat()
        {
			Console.WriteLine("Reserve Seat");
			DisplayPreferedSeats();
			Console.WriteLine("Plaese enter your seat number (example A1 or B5) #Please type in Upper letter");
			string seat = Console.ReadLine();

			VerifySeat(seat);

			Console.Write("Please enter checkout to checkout");
			Console.ReadLine();
        }

		public static void OnSelecSeats()
        {
			DisplayPreferedSeats();
			Console.WriteLine("Plaese enter your seat number");
			string seat = Console.ReadLine();
			VerifySeat(seat);
		}

		public static void VerifySeat(string seatnumber)
        {
			if (seatnumber != "exit")
            {
                if (seatnumber != "checkout")
                {
					if(seatnumber.Contains("A"))
					{
						if (thisaccount.participantType == "student")
						{
							Console.WriteLine("Cannot book. Please try again");
							OnSelecSeats();
						}
						else
						{
							if (!Company.RegisteredData.ReservedSeats.Contains(seatnumber))
							{
								if (prefredSeat.Contains(seatnumber))
								{
									Console.WriteLine("Already book. Please try again");
									OnSelecSeats();
								}
                                else
                                {
									Seat += " " + seatnumber;
									prefredSeat.Add(seatnumber);
									OnSelecSeats();
								}
							}
                            else
                            {
								Console.WriteLine("Already book. Please try again");
								OnSelecSeats();
							}
						}
					}
					else
					{
						Seat += " " + seatnumber;
						prefredSeat.Add(seatnumber);
						OnSelecSeats();
					}
                }
                else
                {
					CheckOuts.allSeat = prefredSeat;
					CheckOuts.DisPlayCheckOutMenu();
				}
            }
            else
            {
				prefredSeat.Clear();
				Menu.DisplayMainMenu();
            }
        }
    }