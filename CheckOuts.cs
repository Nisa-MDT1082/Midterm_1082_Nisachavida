public class CheckOuts{
		public static Company.Account thisacc = Menu.thisccount;
		public static List<string> allSeat;
		public static string seatA;
		public static string seatB;

		public static double CalculatePrice(int seatQty, string participantType)
        {
			double value = 0;

		    double studentprice = 1200.5f;
			double generalprice = 5235.25f;

			if(participantType == "student")
            {
				value = seatQty * studentprice;
            }
            else
            {
				value = seatQty * generalprice;
			}

			return value;
        }

		public static void SplitSeat(List<string> seats)
        {
            foreach (var item in seats)
            {
                if (item.Contains("A"))
                {
					seatA += " " + item;
				}
                else
                {
					seatB += " " + item;
				}
            }
        }

		public static void DisPlayCheckOutMenu()
        {
			Console.Clear();

			SplitSeat(allSeat);

            Console.WriteLine("****** CheckOut Menu ******");
            Console.WriteLine("Prefre Seats type A : " + seatA);
			Console.WriteLine("Prefre Seats type B : " + seatB);
			Console.WriteLine(allSeat.Count + " Seats" + "Total price : " + CalculatePrice(allSeat.Count, thisacc.participantType)) ;

			DisplayCheckOutMenu();
		}

		public static void DisplayCheckOutMenu()
        {
			string payment;

            Console.WriteLine("1. Pay by Bank.");
			Console.WriteLine("2. Pay by Credit card.");
			Console.WriteLine("0. Cancle.");
            Console.WriteLine("****************************");
            Console.Write(""); 
			payment = Console.ReadLine();
			CheckOutMenupayment(payment);

		}

		public static void CheckOutMenupayment(string payment) 
        {
            switch (payment)
            {
                default:
                    Console.WriteLine("Invalid type. Please try again.");
					DisPlayCheckOutMenu();

					break;

				case "1":
					thisacc.ispaybyBank = true;
					Bank();
					ConfirmedReserve();
					ReserveResult.DisplayReserveResult();
					break;

				case "2":
					CreditCard();
					ConfirmedReserve();
					ReserveResult.DisplayReserveResult();
					break;

				case "0":

					Console.Clear();
					allSeat.Clear();
					Menu.DisplayMainMenu();

					break;
			}
        }

		public static void Bank()
        {
            Console.Write("Please enter Bank holder name : ");
			string bankHolder = Console.ReadLine();
            Console.Write("Please enter Bank account     : ");
			string bankAcc = Console.ReadLine();

			Menu.thisccount.mybank.bankHolder = bankHolder;
			Menu.thisccount.mybank.bankAcc = bankAcc;
		}

		public static void CreditCard()
		{
			Console.Write("Please enter Card holder name : ");
			string cardHolder = Console.ReadLine();
			Console.Write("Please enter Card number      : ");
			string cardNO = Console.ReadLine();
			Console.Write("Please enter Card expire date : ");
			string expDate = Console.ReadLine();
			Console.Write("Please enter CVV              : ");
			string CVV = Console.ReadLine();

			Menu.thisccount.mycreditcard.cardHolder = cardHolder;
			Menu.thisccount.mycreditcard.cardNO = cardNO;
			Menu.thisccount.mycreditcard.expDate = expDate;
			Menu.thisccount.mycreditcard.CVV = CVV;
		}

		public static void ConfirmedReserve()
        {
            foreach (var item in allSeat)
            {
				Company.RegisteredData.ReservedSeats.Add(item);
				thisacc.ReserveredSeats.Add(item);

			}
        }
	}