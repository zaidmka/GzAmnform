using System.ComponentModel.DataAnnotations;


namespace GzAmnform.Models
{
    public class Form
    {
		[Key]
		public int id { get; set; }

		public Guid UUID { get; set; }


		[Required(ErrorMessage = "DID is required")]
		public int did { get; set; }

		[Required(ErrorMessage = "Document number is required")]
		public int? doc_no { get; set; }

		[Required(ErrorMessage = "id number is required")]
		[TwelveDigit(ErrorMessage = "The ID number must be exactly 12 digits")]

		public long? id_number { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string name { get; set; } = string.Empty;

		[Required(ErrorMessage = "Entity is required")]
		public string entity { get; set; } = string.Empty;

		[Required(ErrorMessage = "Father's work is required")]
		public string father_work { get; set; } = string.Empty;

		[Required(ErrorMessage = "old Father's work is required")]
		public string father_work_old { get; set; } = string.Empty;

		[Required(ErrorMessage = "Mother's name is required")]
		public string mother_name { get; set; } = string.Empty;

		[Required(ErrorMessage = "Mother's work is required")]
		public string mother_work { get; set; } = string.Empty;

		[Required(ErrorMessage = "Wife's name is required")]
		public string wife_name { get; set; } = string.Empty;

		[Required(ErrorMessage = "Wife's work is required")]
		public string wife_work { get; set; } = string.Empty;

		[Required(ErrorMessage = "Badge color is required")]
		public string bagde_color { get; set; } = string.Empty;

		public DateTime actiondate { get; set; }

		[Required(ErrorMessage = "Username is required")]
		public string username { get; set; } = string.Empty;

		[Required(ErrorMessage = "birth-Place is required")]
		public string birth_place { get; set; } = string.Empty;

		[Required(ErrorMessage = "new_place_duration is required")]
		public string new_place_duration { get; set; } = string.Empty;

		[Required(ErrorMessage = "old_place_duration")]
		public string old_place_duration { get; set; } = string.Empty;

		[Required(ErrorMessage = "old_key_place is required")]
		public string old_key_place { get; set; } = string.Empty;

		[Required(ErrorMessage = "place_type is required")]
		public string place_type { get; set; } = string.Empty;

		[Required(ErrorMessage = "birthdate is required")]
		public DateOnly birthdate { get; set; }

		[Required(ErrorMessage = "State is required")]
		public string state { get; set; } = string.Empty;

		[Required(ErrorMessage = "Nationalism is required")]
		public string nationalism { get; set; } = string.Empty;

		[Required(ErrorMessage = "Religion is required")]
		public string religion { get; set; } = string.Empty;

		[Required(ErrorMessage = "Place govern is required")]
		public string place_govern { get; set; } = string.Empty;

		[Required(ErrorMessage = "City is required")]
		public string place_city { get; set; } = string.Empty;

		[Required(ErrorMessage = "Mhala is required")]
		public string place_mhala { get; set; } = string.Empty;

		[Required(ErrorMessage = "Zuqaq is required")]
		public string place_zuqaq { get; set; } = string.Empty;

		[Required(ErrorMessage = "Dar is required")]
		public string place_dar { get; set; } = string.Empty;

		[Required(ErrorMessage = "Point is required")]
		public string place_point { get; set; } = string.Empty;

		[Required(ErrorMessage = "Phone 1 is required")]
		[TenDigitStartsWithSeven(ErrorMessage = "رقم الهاتف يجب ان يكون 10 مراتب بدون صفر")]

		public long? phone1 { get; set; }

		[Required(ErrorMessage = "Phone 2 is required")]
		public string phone2 { get; set; }

		[Required(ErrorMessage = "Work place is required")]
		public string work_place { get; set; } = string.Empty;

		[Required(ErrorMessage = "Second work place is required")]
		public string work_place2 { get; set; } = string.Empty;

		[Required(ErrorMessage = "Work duration is required")]
		public string work_duration { get; set; } = string.Empty;

		[Required(ErrorMessage = "Second Work duration is required")]
		public string work_duration2 { get; set; } = string.Empty;

		[Required(ErrorMessage = "Study is required")]
		public string study { get; set; } = string.Empty;

		[Required(ErrorMessage = "grad_year is required")]

		public DateOnly grad_year { get; set; }

		[Required(ErrorMessage = "old_place is required")]

		public string old_place { get; set; } = string.Empty;
		public string? passport_no { get; set; } = string.Empty;

		[Required(ErrorMessage = "a1 is required")]
		public string a1 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a2 is required")]
		public string a2 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a3 is required")]
		public string a3 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a4 is required")]
		public string a4 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a5 is required")]
		public string a5 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a6 is required")]
		public string a6 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a7 is required")]
		public string a7 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a8 is required")]
		public string a8 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a9 is required")]
		public string a9 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a10 is required")]
		public string a10 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a11 is required")]
		public string a11 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a12 is required")]
		public string a12 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a13 is required")]
		public string a13 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a14 is required")]
		public string a14 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a15 is required")]
		public string a15 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a16 is required")]
		public string a16 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a17 is required")]
		public string a17 { get; set; } = string.Empty;

		[Required(ErrorMessage = "a18 is required")]
		public string a18 { get; set; } = string.Empty;
		public bool deleted { get; set; } = false;
		public List<RelativeInfo> Relatives { get; set; } = new();
		public List<SonsInfo> Sons { get; set; } = new();
		public List<TravelInfo> Travels { get; set; } = new();


	}
	public class RelativeInfo
	{
		public string Name { get; set; }
		public DateOnly? BirthDate { get; set; }
		public string Job { get; set; }
	}
	public class SonsInfo
	{
		public string Name { get; set; }
		public DateOnly? BirthDate { get; set; }
		public string Job { get; set; }
	}
	public class TravelInfo
	{
		public string CountryName { get; set; }
		public DateOnly? TravelDate { get; set; }
		public int TravelCount { get; set; }
        public string TravelDuration { get; set; }
        public string TravelPorpose { get; set; }
    }
}
