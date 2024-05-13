using solution;

try
{
    User user1 = new User("giorgi", "ugulava");
    user1[0] = new CreditIban(48484848);
    user1[1] = new DebitIban(1212121);
    user1[0].DepositingMoney(23);
    user1[0].WithdrawMoney(27);
    user1[1].DepositingMoney(20);
    user1[1].WithdrawMoney(22);
}
catch (Exception ex)
{
    string lastInnerExMessage = MyExceptions.GetLastInnerExMessage(ex);
    string allInnerExMessages = MyExceptions.GetAllInnerExMessageTogether(ex);

    Console.WriteLine($"Last Inner Exception Message: {lastInnerExMessage}");
    Console.WriteLine($"All Inner Exception Messages Together: {allInnerExMessages}");
}





