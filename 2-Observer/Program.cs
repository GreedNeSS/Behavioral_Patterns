using _2_Observer.Implementations;

Stock stock = new Stock();
Broker broker = new Broker("Аристарх Монетович", stock);
Bank bank = new Bank("Сбер", stock);

stock.Market();
stock.Market();
broker.StopTrade();
stock.Market();
stock.Market();

Console.ReadLine();