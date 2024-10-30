using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_30_a_exceptions_enums_strings.models
{
    public static class EnumDriver
    {
        public static void Run()
        {
            OrderDemo();
            CallHandleLight();
            ExplictValuesDemo();
            CustomStartingValueDemo();
            DayOfWeekDemo();
            Console.WriteLine("EnumDriver");
        }

        public static void DayOfWeekDemo()
        {
            Console.WriteLine($"Today is {DayOfWeek.Wednesday} : {(int)DayOfWeek.Wednesday}");
        }

        public static void CustomStartingValueDemo()
        {
            Console.WriteLine($"Severity is {SeverityLevel.Critical} : and it is Level {(int)SeverityLevel.Critical}");
        }

        public static void ExplictValuesDemo()
        {
            Console.WriteLine($"{StatusCode.Ok}:{(int)StatusCode.Ok}");
            Console.WriteLine($"{StatusCode.NotFound}:{(int)StatusCode.NotFound}");
            Console.WriteLine($"{StatusCode.InternalServerError}:{(int)StatusCode.InternalServerError}");
        }
        public static void CallHandleLight()
        {
            HandleLight(LightState.Unknown);
            Console.WriteLine($"Traffic light indicates: {HandleLight(LightState.Green)}");
            Console.WriteLine($"Traffic light indicates: {HandleLight(LightState.Unknown)}");
        }

        public static string HandleLight(LightState state)
        {
            switch (state)
            {
                case
                    LightState.Red:
                    Console.WriteLine("Stop"); break;
                case
                    LightState.Yellow:
                    Console.WriteLine("Proceed with Caution"); break;
                case
                    LightState.Green:
                    Console.WriteLine("Go"); break;
                default:
                    Console.WriteLine("Unknown"); break;
            }

            Console.WriteLine(state switch
            {
                LightState.Red => "Stop",
                LightState.Yellow => "Proceed with Caution",
                LightState.Green => "Go",
                _ => "Unknown"
            });

            string message = state switch
            {
                LightState.Red => "Stop",
                LightState.Yellow => "Proceed with Caution",
                LightState.Green => "Go",
                _ => "Unknown"
            };

            return message;


        }

        public static void OrderDemo()
        {
            Order myOrder = new Order();

            var status = Order.OrderStatus.Pending;
        }

    }
}
