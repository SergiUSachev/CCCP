//В нашей великой стране Арстоцка произошла амнистия!
//Всех людей, заключенных за преступление "Антиправительственное", следует исключить из списка заключенных.
//Есть список заключенных, каждый заключенный состоит из полей: ФИО, преступление.
//Вывести список до амнистии и после. 

using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CCCP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Prisoner> prisoners = new List<Prisoner>
			{
				new Prisoner("Роман Ползунок", "Политическая"),
				new Prisoner("Владимир Красносолнышко", "Убийство"),
				new Prisoner("Роман Сконём", "Кража"),
				new Prisoner("Семён Шмидт", "Национальность"),
				new Prisoner("Витёк Косой", "Политическая"),
				new Prisoner("Йоу Собаки", "Политическая"),
				new Prisoner("Я НарутоУзумаки", "Ванадлизм"),
			};

			var filteredPrisoner = from Prisoner prisoner in prisoners
								   where prisoner.Crime != "Политическая"
								   select prisoner;

			List<Prisoner> leftInPrison = new List<Prisoner>();

			foreach (var prisoner in filteredPrisoner)
			{
				leftInPrison.Add(prisoner);
			}

			Console.WriteLine("Список заключенных до помилования");
			Info(prisoners);
			Console.WriteLine("Список заключенных после помилования");
			Info(leftInPrison);

		}

		static void Info(List<Prisoner> prisoners)
		{
			foreach (var prisoner in prisoners)
			{
				Console.WriteLine(prisoner.FullName, " ", prisoner.Crime);
			}
		}
	}
	class Prisoner
	{
		public Prisoner(string fullName, string crime)
		{
			FullName=fullName;
			Crime=crime;
		}	

		public string FullName { get; private set; } 
		public string Crime { get; private set; }
	}

}