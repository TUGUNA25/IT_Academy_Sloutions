namespace solution
{
    public class MyExceptions
    {

        public class NotValidInput: Exception { 
            public NotValidInput(string message) : base(message) { }
        }

        public class NotValidCountry : Exception {
            public NotValidCountry(string message) : base(message) { }
        }

        public class NotValidCity : Exception
        {
            public NotValidCity(string message) : base(message) { }
        }
        
        public class InstanceDontExist : Exception
        {
            public InstanceDontExist(string message) : base(message) { }
        }
        public static void Logger(string error) {
            string logFilePath = @"C:\Users\Lenovo\Documents\TBC\Day_20\solution\solution\Logs.txt";
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {error}");
            }

            Console.WriteLine("An error occurred. Please check the log file for details.");

        }
    }
}
