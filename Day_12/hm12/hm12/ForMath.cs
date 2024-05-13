namespace hm12
{
    // rodesac maqvs araswori info defaultad vabruneb -1s radgan exceptionebi jer ar gviswavlia
    public enum Statuses
    {
        PowMustBeaPositiveOrZero,
        Success,
        NumbersMustBeaDifferent
    }
    public static class ForMath
    {


        public static double Pow(double num1, double num2, out Statuses status)
        {
            double answer = 1;
            if (num2 < 0)
            {
                status = Statuses.PowMustBeaPositiveOrZero;
                answer = -1;
                return answer;
            }
            for (int i = 0; i < num2; i++)
            {
                answer = answer * num1;
            }
            status = Statuses.Success;
            return answer;


        }

        public static double Min(double num1, double num2, out Statuses status)
        {
            double answer = 0;
            if (num1 < num2)
            {
                answer = num1;
                status = Statuses.Success;
            }
            else if (num2 < num1)
            {
                answer = num2;
                status = Statuses.Success;
            }
            else
            {
                status = Statuses.NumbersMustBeaDifferent;
                answer = -1;
                return answer;
            }
            return answer;
        }

        public static double Max(double num1, double num2, out Statuses status)
        {
            double answer = 0;
            if (num1 > num2)
            {
                answer = num1;
                status = Statuses.Success;
            }
            if (num2 > num1)
            {
                answer = num2;
                status = Statuses.Success;
            }
            else
            {
                status = Statuses.NumbersMustBeaDifferent;
            }
            answer = -1;
            return answer;

        }
    }




}
