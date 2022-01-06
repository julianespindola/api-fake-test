namespace api_fake_test.Class
{
    public class RecordFake
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public bool Active { get; set; }

        public RecordFake()
        {
            Id = Guid.NewGuid();
            Name = "Name of record";
            Active = true;
        }

        public RecordFake(string name, bool active)
        {
            Id = Guid.NewGuid();
            Name = name;
            Active = active;
        }

        public static object GetOneRecord()
        {
            return new RecordFake();
        }

        public static List<object> GetAnyRecords(int numberOfRecordsToGenerate)
        {
            var listOfRecords = new List<object>();
            for (int i = 0; i < numberOfRecordsToGenerate; i++)
            {
                listOfRecords.Add(new RecordFake($"Name of record {i}", true));
            }
            return listOfRecords;
        }
    }
}