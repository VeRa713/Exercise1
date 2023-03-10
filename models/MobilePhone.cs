namespace Exercise1.Models
{
    public class MobilePhone
    {
        public SimCard SimCard { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public MobilePhone(SimCard simCard, string brand, string color, string model)
        {
            this.SimCard = simCard;
            this.Brand = brand;
            this.Color = color;
            this.Model = model;
        }

        public string GetPhoneNumber()
        {
            return this.SimCard.PhoneNumber;
        }

        public string GetNetwork()
        {
            return this.SimCard.Network;
        }


        public void SwapSimCard(SimCard simCard)
        {
            SimCard.setNewNumber(simCard.PhoneNumber);
        }

        public void Call(string phoneNumber)
        {
            Console.WriteLine("Calling [" + phoneNumber + "] from [" + this.SimCard.PhoneNumber + "]");
        }

        public void Call(MobilePhone mobilePhone){
            Console.WriteLine("Calling [" + mobilePhone.GetPhoneNumber() + "] from [" + this.GetPhoneNumber() + "]");
        }
    }
}