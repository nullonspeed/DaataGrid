
using DataLayerLib;

namespace MVVM_Lib
{
	
    public class HospitalViewModel: ObservableObject
    {
        public HospitalDBContext? DB { get; set; }
        public HospitalViewModel Init(HospitalDBContext newBD)
		{
			DB = newBD;
			Patients = DB.Patients.ToList();

			return this;
		}
		private List<Patient> patients;

		public List<Patient> Patients
		{
			get { return patients; }
			set { patients = value;
			RaisePropertyChangedEvent(nameof(Patients));
			}
		}

		private Patient? selectedPatient;

		public Patient? SelectedPatient
		{
			get { return selectedPatient; }
			set { selectedPatient = value;
		
			RaisePropertyChangedEvent(nameof(SelectedPatient));
			}
		}


	}

}
