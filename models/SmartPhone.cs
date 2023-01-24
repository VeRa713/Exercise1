namespace Exercise1.Models
{
    public class SmartPhone : MobilePhone
    {
        public string Browser { get; set; }
        private List<App> applications;

        public SmartPhone(string browser, SimCard simCard, string brand, string color, string model) : base(simCard, brand, color, model)
        {
            this.Browser = browser;
            this.applications = new List<App>();
        }

        public void CallFromBrowser(string phoneNumber){
            Console.WriteLine(this.GetPhoneNumber() + " is calling " + phoneNumber + " from " + this.Browser);
        } 

        public void CallFromBrowser(MobilePhone mobilePhone){
            //call Call(MobilePhone mobilePhone) - invoke parent
            base.Call(mobilePhone);
        }

        public void AddApplication(App app){
            this.applications.Add(app);
        }

        public float GetTotalSize(){
            float totalSize = 0;

            foreach(App app in applications){
                totalSize = totalSize + app.Size;
            }

            return totalSize;
        }

        //add other methods
    }
}