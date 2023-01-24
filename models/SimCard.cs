namespace Exercise1.Models
{
    public class SimCard
    {
        public string PhoneNumber { get; set; }
        public string Network { get; set; }

        public SimCard(string pNum, string network)
        {
            this.PhoneNumber = pNum;
            this.Network = network;
        }

        //Add methods here
    }
}