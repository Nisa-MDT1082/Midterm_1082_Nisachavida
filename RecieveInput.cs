public class RecieveInput
	{
		public static void RecieveTitle(Company.Account acc)
        {
			Console.WriteLine("Enter your name title : ");
			string title = Console.ReadLine();

			ProgressionClass.CheckNameTitle(title,acc);

			acc.accTitle = title;
		}

		public static void RecieveName(Company.Account acc)
		{
			Console.Write("Enter your name : ");
			string name = Console.ReadLine();

			RecieveSurname(name,acc);
		}

		public static void RecieveSurname(string name, Company.Account acc)
		{
			Console.Write("Enter your surname : ");
			string surname = Console.ReadLine();

			ProgressionClass.CheckParticipant(name,surname,acc);

			acc.accName = name;
			acc.accSurname = surname;
		}

		public static void RecieveAge(Company.Account acc)
		{
			Console.Write("Enter your age : ");
			int age = int.Parse(Console.ReadLine());

			acc.accAge = age;
		}

		public static void RecieveEmail(Company.Account acc)
		{
			Console.Write("Enter your email : ");
			string email = Console.ReadLine();

			ProgressionClass.CheckParticipantEmail(email,acc);

			acc.accEmail = email;

		}

		public static void RecieveStudentId(Company.Account acc)
		{
			Console.Write("Enter your StudentId : ");
			string id = Console.ReadLine();

			acc.accStudentId = id;

		}

		public static void RecievePassword(Company.Account acc)
		{
			Console.Write("Enter your password : ");
			string password = Console.ReadLine();

			RecieveCfPassword(password, acc);

		}

		public static void RecieveCfPassword(string password, Company.Account acc)
		{
			Console.Write("Confirme your password : ");
			string cfpassword = Console.ReadLine();

			ProgressionClass.CheckParticipantPassword(password, cfpassword,acc);

			acc.accPassword = password;
			acc.accCfPassword = cfpassword;

		}
	}