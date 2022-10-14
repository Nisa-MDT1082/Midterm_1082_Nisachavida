public class ReserveResult
    {
		public static Company.Account thisacc = Menu.thisccount;

		public static void DisplayReserveResult()
        {
			Console.Clear();

			if(thisacc.ReserveredSeats.Count <= 0)
                Console.WriteLine("Please book ypur seat first.");
            else
            {
				Console.WriteLine("Participant type : " + thisacc.participantType);
				Console.WriteLine("Reserved Seat TypeA : " + CheckOuts.seatA);
				Console.WriteLine("Reserved Seat TypeB : " + CheckOuts.seatB);
				Console.WriteLine(CheckOuts.allSeat.Count + " Seats" + "Total price : " + CheckOuts.CalculatePrice(CheckOuts.allSeat.Count, thisacc.participantType));


				if (thisacc.ispaybyBank)
				{
					Console.WriteLine("Pay by Bank");
					Console.WriteLine("Bank holder Name : " + thisacc.mybank.bankHolder);
					Console.WriteLine("Bank Account : " + thisacc.mybank.bankAcc);
				}
				else
				{
					Console.WriteLine("******* Pay by CreditCard *******");
					Console.WriteLine("CreditCard holder Name : " + thisacc.mycreditcard.cardHolder);
					Console.WriteLine("CreditCard Number      : " + thisacc.mycreditcard.cardNO);
					Console.WriteLine("CreditCard expire date : " + thisacc.mycreditcard.expDate);
					Console.WriteLine("CreditCard CVV         : " + thisacc.mycreditcard.CVV);
				}
			}
            

			Console.WriteLine("*** Please enter 'Any' to continue ***");
			Console.ReadLine();

			Menu.DisplayMainMenu();

		}

		public static void CheckOut()
        {
			Console.WriteLine("*** Please enter 'Any' to continue ***");
			string payment = Console.ReadLine();

			if(payment != "checkout")
            {
				CheckOut();

			}
		}
    }