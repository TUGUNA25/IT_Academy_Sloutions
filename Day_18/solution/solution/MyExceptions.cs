namespace solution
{
    public class MyExceptions
    {
        public class LessAmountMoneyException : Exception 
        {
            public  LessAmountMoneyException(string message) : base(message)
                {}
        }

        public class NotValidInputMoney: Exception 
        { 
            public NotValidInputMoney(string message) : base(message) 
            {}
            
        }
        public static string GetLastInnerExMessage(Exception ex)
        {
            Exception innerEx = ex;
            while (innerEx.InnerException != null)
            {
                innerEx = innerEx.InnerException;
            }
            return innerEx.Message;
        }

        
        public static string GetAllInnerExMessageTogether(Exception ex, string separator = ",")
        {
            List<string> messages = new List<string>();
            Exception currentEx = ex;

            while (currentEx != null)
            {
                messages.Add(currentEx.Message);
                currentEx = currentEx.InnerException;
            }

            messages.Reverse(); 
            return string.Join(separator, messages);
        }


    }
}
    