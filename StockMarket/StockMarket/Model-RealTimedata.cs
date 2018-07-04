using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization;

namespace StockExchangeMarket
{
    public class RealTimedata : StockMarket
    {
        private List<Company> StockCompanies = new List<Company>();
        private TcpClient connection;
        NetworkStream ioStream;
        private string client;
        private string session;
        public RealTimedata(TcpClient connection, string client, string session)
        {
            this.client = client;
            ioStream = connection.GetStream();
            this.session = session;
            this.connection = connection;
            new Thread(new ThreadStart(Notify)).Start();
        }

        public void addCompany(String symbol, String _name, double price)
        {
           Company _company = new Company(symbol, _name, price, this);
           StockCompanies.Add(_company);
        }

        public List<Company> getCompanies()
        {
            return StockCompanies;
        }
    }
}
