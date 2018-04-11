using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexam
{
    class Program
    {
        static void Main(string[] args)
        {
          

            DraftManager draftManager = new DraftManager();
            List<string> input;
           
            while (draftManager.shutdown!=true)
            {
                input = Console.ReadLine().Split(' ').ToList();

                switch (input[0])
                {
                    case "RegisterHarvester":
                        try
                        {
                            Console.WriteLine(draftManager.RegisterHarvester(input));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "RegisterProvider":
                        try
                        {
                            Console.WriteLine(draftManager.RegisterProvider(input));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Check":
                        try
                        {
                            Console.WriteLine(draftManager.Check(input));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Day":
                        Console.WriteLine(draftManager.Day());
                        break;
                    case "Mode":
                        Console.WriteLine(draftManager.Mode(input));
                        break;
                    case "Shutdown":
                        Console.WriteLine(draftManager.Shutdown());
                        break;

                }
            }

        }
    }
}
