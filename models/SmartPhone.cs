namespace Exercise1.Models
{
    public class SmartPhone : MobilePhone
    {
        public string Browser { get; set; }
        public List<App> Applications { get; set; }

        public SmartPhone(string browser, SimCard simCard, string brand, string color, string model) : base(simCard, brand, color, model)
        {
            this.Browser = browser;
        }

        public void CallFromBrowser(string phoneNumber){
            Console.WriteLine("Calling from [browser]");
        }

        public void CallFromBrowser(MobilePhone mobilePhone){
            //call Call(MobilePhone mobilePhone) - invoke parent
            base.Call(mobilePhone);
        }

        public void AddApplication(App app){
            //add application to the list
        }

        public int GetTotalSize(){
            return Applications.Count();
        }

        //add other methods
    }
}