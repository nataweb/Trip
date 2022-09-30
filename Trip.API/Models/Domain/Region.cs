namespace Trip.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public double Area { get; set; }

        public double Lon { get; set; }

        public double Lang { get; set; }

        public string Population { get; set; }

        //navigation property
        public IEnumerable<Walk> Walks { get; set; }
    }
}
