# StockService
Application will display simulated stock prices ticking.

1) In order to run this demo, Open Visual Studio 2019 as Admin, then open the solution from folder "StockTickerHost/StockTickerHost.sln". Make sure "StockLibraryHost" project is set as a StartUp Project and then press start the service.

2) To start Client,
    i) Open another Visual Studio 2019, then open the solution from folder "Client/StockTickerClient.sln" and then press start. Verify host window is displaying the prices for "Stock2"

    ii) To create second client with "Stock1", either create new instance by Ctrl+F5 or Open another Visual Studio 2019, then open the    solution from folder "Client/StockTickerClient.sln" then modify config filie for below key:
 
    key="stockName" value="Stock1"

   then press start to see same host window is displaying the prices for Stock1 as well.

3) This way we can create multiple clients provided we have service for those stock.
