class Program
{
    static async Task Main(string[] args)
    {
        CancellationTokenSource x = new CancellationTokenSource();
        var token = x.Token;

        for (int i = 1; i < 11; i++)
        {
            int j = 0;
            int index = i;
            Task.Run( () =>
            {
                using (StreamWriter writer = new StreamWriter($"{index}.txt.txt", append: false))
                {
                    while (!x.IsCancellationRequested) {
                        writer.WriteLine($"Task{j}");
                        j++;
                        Task.Delay(j * 10000);
                    }
                }
            });
        }

        await Task.Run(() =>
        {
            Console.Write("Give Me a X If You Want To Stop Procees: ");
            string input = Console.ReadLine();
            if (input == "x")
            {
                x.Cancel();
            }
        });
    }
}
