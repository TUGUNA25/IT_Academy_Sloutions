
using static solution.MyExceptions;

namespace solution
{
    public class DebitIban : IBAN
    {
        public double Balance = 0;
        public DebitIban(int accountcode) : base(accountcode)
        {
        }

        public override void DepositingMoney(double money)
        {
            if (money < 0)
            {
                throw new NotValidInputMoney("");
            }
            else
            {
                Balance = Balance + money;
                Console.WriteLine($"deposite  is complete on acc:{AccountCode} new balance {Balance}");
            }
        }

        public override void WithdrawMoney(double money)
        {
            if (money > Balance)
            {
                throw new LessAmountMoneyException("Invalid Transaction You Dont have Enough Money");
            }
            if (money < 0)
            {
                throw new NotValidInputMoney("Invalid Transaction Money Should Be More Than 0");
            }
            Balance = Balance - money;
            Console.WriteLine($"withdraw is complete on acc:{AccountCode} money left in your balance: {Math.Round(Balance, 2)}");
        }
    }
}
