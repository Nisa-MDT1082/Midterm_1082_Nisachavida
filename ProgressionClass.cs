public class ProgressionClass{
		public static void CheckParticipant(string name, string surname, Company.Account acc)
		{
			string dictionaryKeys = name + surname;

			if (Company.RegisteredData.ParticipantDictionary.ContainsKey(dictionaryKeys))
			{
				Console.WriteLine("User is already registered. Please try again.");

				RecieveInput.RecieveName(acc);
			}
		}

		public static void CheckParticipantEmail(string email, Company.Account acc)
		{
			foreach (var item in Company.RegisteredData.ParticipantDictionary)
			{
				if (item.Value.accEmail == email || email == "exit")
				{
					Console.WriteLine("Invalid email. Please try again.");

					RecieveInput.RecieveEmail(acc);
				}
				break;
			}
		}

		public static void CheckParticipantPassword(string password, string cfpassword, Company.Account acc)
		{
			if (password == cfpassword) return;
			else
			{
				Console.WriteLine("Mismatched password. Please try again.");
				RecieveInput.RecievePassword(acc);
			}

		}

		public static void CheckNameTitle(string title, Company.Account acc)
        {
			if (title == "Mrs" || title == "Miss" || title == "Ms") return;

			else
			{
				Console.Write("Please input only  Mrs / Miss / Mr");
				RecieveInput.RecieveTitle(acc);
			}
        }

		public static void VerifyEmailandPassword(string email ,string password)
        {
			if(email != "exit")
            {
				if (!Company.RegisteredData.RegisteredDictionary.ContainsKey(email))
				{
					Console.WriteLine("Incorrect Email or Password. Please try again");
					Menu.DisplayLogin();
				}
				else
				{
					string pss = Company.RegisteredData.RegisteredDictionary[email].accCfPassword;

					if (password != pss)
					{
						Console.WriteLine("Incorrect Email or Password. Please try again");
						Menu.DisplayLogin();
					}
				}
            }
            else
            {
				Menu.DisplayMainMenu();
			}
        }
	}
