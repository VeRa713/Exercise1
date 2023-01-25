using Exercise1.Models;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 2 instances of MobilePhone
            SimCard myMobileSim = new SimCard("myMobileSim09987654321", "Globe");
            SimCard yourMobileSim = new SimCard("yourMobileSim09123456789", "Globe");

            MobilePhone myMobile = new MobilePhone(myMobileSim, "BRAND", "COLOR", "MODEL");
            MobilePhone yourMobile = new MobilePhone(yourMobileSim, "BRAND", "COLOR", "MODEL");

            // 2 instances of SmartPhone
            SimCard mySmartSim = new SimCard("mySmartSim09963852741", "Smart");
            SimCard yourSmartSim = new SimCard("yourSmartSim09741852963", "Smart");

            SmartPhone mySmartPhone = new SmartPhone("MS Teams", mySmartSim, "Samsung", "BoraPurple", "S22 Ultra");
            SmartPhone yourSmartPhone = new SmartPhone("Zoom", yourSmartSim, "Samsung", "Lilac", "Flip Z");

            // MobilePhone -> MobilePhone
            Console.WriteLine("\n==== MOBILE TO MOBILE ====");
            myMobile.Call(yourMobile);
            myMobile.Call("099999999");

            // SmartPhone -> SmartPhone
            Console.WriteLine("\n==== SMARTPHONE TO SMARTPHONE ====");
            mySmartPhone.CallFromBrowser(yourSmartPhone);
            mySmartPhone.Call("9999999");

            Console.WriteLine("\n==== SMARTPHONE TO UNKNOWN NUMBER ====");
            mySmartPhone.CallFromBrowser("unknownNumber09512357468");

            Console.WriteLine("\n==== CHANGE NUMBER ====");
            SimCard newSim = new SimCard("NEWSim0917364825", "Smart");
            myMobile.SwapSimCard(newSim);
            Console.WriteLine("Your new number is: " + myMobile.GetPhoneNumber());

            //Add applications to Smartphone
            Console.WriteLine("\n==== ADD APPLICATION ====");
            
            App newApp = new App("Discord", 94.50f);
            App newApp2 = new App("Some App", 1.50f);
            mySmartPhone.AddApplication(newApp);
            mySmartPhone.AddApplication(newApp2);

            //Display total size of applications
            Console.WriteLine("\nTotal Memory Consumed: "+  mySmartPhone.GetTotalSize());

            //Display the smartPhone
            mySmartPhone.displayInfo(mySmartPhone);
        }
    }
}