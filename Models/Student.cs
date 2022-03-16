namespace TE19DWEBAPIKURS.Models
{
    public class Student
    {
        public int Id {get; set;} = 1;

        public string Name {get; set;} = "Elias";

        public int Age {get; set;} = 18;

        public StudentEnergy EnergyStudent {get; set;} = StudentEnergy.Xlnt;
        public StudentClass ClassStudent {get; set;} = StudentClass.TE19D;
    }
}