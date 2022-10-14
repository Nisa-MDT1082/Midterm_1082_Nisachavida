public class Menu
    {
		public static Company.Account thisccount;

		public static void DisplayMainMenu()
        {
			string programpayment;

			Console.Clear();
			Console.WriteLine("******** Menu ********"); 
			Console.WriteLine("Please Input Number"); 
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("****************************");
            Console.Write("");
			programpayment = Console.ReadLine();

			OnSelectedMenu(programpayment);

		}

		public static void DisplayLogin()
        {
			Console.Write("Please enter your Email : ");
			string email = Console.ReadLine();
			Console.Write("Please enter your Password : ");
			string password = Console.ReadLine();

			ProgressionClass.VerifyEmailandPassword(email, password);
			thisccount = Company.RegisteredData.GetAccByEmail(email);
			OnloginSuccess();

		}

		public static void OnSelectedMenu(string programpayment)
        {
            switch (programpayment)
            {
                default:
                    break;

				case "1":
					Console.Clear();
					Console.WriteLine("****** Register Menu ******");
					Console.WriteLine("Please Input Number"); //adjust to whatever u want
                    Console.WriteLine("1. Register in general");
                    Console.WriteLine("2. Register in student");
                    Console.WriteLine("****************************");
                    Console.Write("");

					Company.Account newAccount = new Company.Account();

					programpayment = Console.ReadLine();

					if (programpayment == "1") // general
					{
						RecieveInput.RecieveTitle(newAccount);
						RecieveInput.RecieveName(newAccount);

						RecieveInput.RecieveAge(newAccount);
						RecieveInput.RecieveEmail(newAccount);
						RecieveInput.RecievePassword(newAccount);

						newAccount.participantType = "general";

					}
					if (programpayment == "2") //student 
					{
						RecieveInput.RecieveTitle(newAccount);
						RecieveInput.RecieveName(newAccount);

						RecieveInput.RecieveAge(newAccount);
						RecieveInput.RecieveEmail(newAccount);
						RecieveInput.RecieveStudentId(newAccount);
						RecieveInput.RecievePassword(newAccount);

						newAccount.participantType = "student";

					}

					Company.RegisteredData.ParticipantDictionary.Add(newAccount.accName + newAccount.accSurname, newAccount);
					Company.RegisteredData.RegisteredDictionary.Add(newAccount.accEmail, newAccount);

					Console.Clear();
					DisplayMainMenu();
					break;

				case "2":
					DisplayLogin();
					break;
			}

		}

		public static void OnloginSuccess() /////// not done
        {
			string payment;
			
			Console.Clear();
            Console.WriteLine("************************");
            Console.WriteLine("Please Input Number");
            Console.WriteLine("1. Reserve Seat");
			Console.WriteLine("2. Check reserve status");
			Console.WriteLine("0. Logout 0");
            Console.WriteLine("****************************");
            Console.Write("");

			payment = Console.ReadLine();

            switch (payment)
            {
                default:
                    break;

				case "1":
					ReserveSeat.OnResreveSeat();
					break;
				case "2":
					ReserveResult.DisplayReserveResult();
					break;
				case "0":
					ReserveSeat.OnResreveSeat();
					break;
			}
		}
    }