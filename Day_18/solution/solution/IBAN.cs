namespace solution
{
    public  class IBAN
    {
        
        public int AccountCode;

        public IBAN(int accountcode)
        {
            this.AccountCode = accountcode;
        }

        public virtual void DepositingMoney(double money) { }
        
        public virtual void WithdrawMoney(double money) { }

    }
}
