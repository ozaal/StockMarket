'use strict';
const net = require('net');
const PORT = 8000;
const ADDRESS = '127.0.0.1';

var sessionCount = 0;
var SSeq = 0;


function User(username, socket, ClientSeq) {
    this.username = username;
    this.socket = socket;
    this.ClientSeq = ClientSeq;
    this.session = sessionCount++
}

function Order(size, price) {
    this.size = size;
    this.price = price;
    this.dateTime = Date.now();
}

function Company(symbol, name, price) {
    this.symbol = symbol;
    this.name = name;
    this.price = price;
    this.buyOrders = [];
    this.sellOrders = [];
    this.current = 0;
    this.close = 0;
    this.trans = [];

var users = []; 
var StockData = {
    stockCompanies: [
        new Company("MSFT", "Microsoft Corporation", 46.13),
        new Company("AAPL", "Apple Inc.", 105.22),
        new Company("FB", "Facebook, Inc.", 80.67)
    ]
};

let server = net.createServer(UserConnection);
server.listen(PORT, ADDRESS);

function notifyClients() {
    users.forEach((client) => {
        client.socket.write(JSON.stringify({
            header: {
                verb: "Notify",
                protocol: "SME/TCP-1.0",
                status: "OK"
            },
            SSeq: SSeq++
        }));
    });
}

function response(socket, cseq, session) {
    console.log('Server respond:');
    console.log("SME/TCP-1.0 OK\nCSeq: " + cseq + ", Session: " + session);
    socket.write(JSON.stringify({
        header: {
            protocol: "SME/TCP-1.0",
            status: "OK"
        },
        CSeq: cseq,
        session: session
    }));
}
function dataConnection(socket, cseq, session, data) {
    console.log('Server respond:');
    console.log("SME/TCP-1.0 OK\nCSeq: " + cseq + ", Session: " + session + ", Data: " + data);
    socket.write(JSON.stringify({
        header: {
            protocol: "SME/TCP-1.0",
            status: "OK"
        },
        CSeq: cseq,
        session: session,
        Data: data
    }));
}

function UserConnection(socket) {
    socket.pipe(socket);
    var thisUser;
    var authenticated = false;
    socket.on('data', function (data) {
        var marketData;
        try {
            marketData = JSON.parse(data.toString());
        }
    if (marketData.header.protocol == "SME/TCP-1.0") {
            if (marketData.header.verb == "Register") {
                if (!marketData.ID || !marketData.CSeq) {
                    disconnectSocket(socket);
                }
                else {
                    authenticated = true;
                    console.log("\n" + marketData.ID + " requests:");
                    let newUser = new User(marketData.ID, socket, marketData.CSeq);
                    thisUser = newUser;
                    users.push(newUser);
                    let userRequest = marketData.header.verb + " SME/TCP-1.0\nID: " + marketData.ID + ", CSeq: " + marketData.CSeq + "\n";
                    console.log(userRequest);
                    response(socket, newUser.ClientSeq, newUser.session);
                }
            }
            else if (marketData.header.verb == "Unregister") {
                if (!marketData.ID || !marketData.CSeq || !marketData.session || !authenticated) {
                    disconnectSocket(socket);
                }
                else {
                    console.log("\n" + marketData.ID + " requests:");
                    let userRequest = marketData.header.verb + " SME/TCP-1.0\nID: " + marketData.ID + ", CSeq: " + marketData.CSeq + ", Session: " + marketData.session + "\n";
                    let userToRemove = users.findIndex((user) => {
                        return user.session == marketData.session;
                    });
                    if (userToRemove == -1) {
                        console.log(userRequest);
                        disconnectSocket(socket);
                    }
                    else {
                        users.splice(userToRemove, 1);
                        console.log(userRequest);
                        response(socket, marketData.CSeq, marketData.session);
                        console.log("\n" + marketData.ID + " has closed their session\n")
                        socket.destroy();
                    }
                }
            }

            else if (marketData.header.verb == "List Sell Orders") {
                if (!marketData.ID || !marketData.CSeq || !marketData.session || !authenticated) {
                    disconnectSocket(socket);
                }
                else {
                    console.log("\n" + marketData.ID + " requests:");
                    let userRequest = marketData.header.verb + " SME/TCP-1.0\nID: " + marketData.ID + ", CSeq: " + marketData.CSeq + ", Session: " + marketData.session + "\n";
                    console.log(userRequest);

                    var sellOrders = {
                        companies: {}
                    };
                    StockData.stockCompanies.forEach((company) => {
                        sellOrders.companies[company.symbol] = company.sellOrders;
                    });
                    dataConnection(socket, marketData.CSeq, marketData.session, JSON.stringify(sellOrders.companies));
                }
            }
            else if (marketData.header.verb == "List Buy Orders") {
                if (!marketData.ID || !marketData.CSeq || !marketData.session || !authenticated) {
                    disconnectSocket(socket);
                }
                else {
                    console.log("\n" + marketData.ID + " requests:");
                    let userRequest = marketData.header.verb + " SME/TCP-1.0\nID: " + marketData.ID + ", CSeq: " + marketData.CSeq + ", Session: " + marketData.session + "\n";
                    console.log(userRequest);
                    var buyOrders = {
                        companies: {}
                    };
                    StockData.stockCompanies.forEach((company) => {
                        buyOrders.companies[company.symbol] = company.buyOrders;
                    });
                    dataConnection(socket, marketData.CSeq, marketData.session, JSON.stringify(buyOrders.companies));
                }
            }

            else if (marketData.header.verb == "List Companies") {
                if (!marketData.ID || !marketData.CSeq || !marketData.session || !authenticated) {
                    disconnectSocket(socket);
                }
                else {
                    console.log("\n" + marketData.ID + " requests:");
                    let userRequest = marketData.header.verb + " SME/TCP-1.0\nID: " + marketData.ID + ", CSeq: " + marketData.CSeq + ", Session: " + marketData.session + "\n";
                    console.log(userRequest);
                    dataConnection(socket, marketData.CSeq, marketData.session, JSON.stringify(StockData));
                }
            }
            else if (marketData.header.verb == "Sell Order") {
                if (!marketData.Data.company || !marketData.Data.order) {
                    disconnectSocket(socket);
                }
                else {
                    console.log("\n" + marketData.ID + " requests:");
                    let userRequest = marketData.header.verb + " SME/TCP-1.0\nID: " + marketData.ID + ", CSeq: " + marketData.CSeq + ", Session: " + marketData.session + ", Data: " + JSON.stringify(marketData.Data) + "\n";
                    console.log(userRequest);

                    StockData.stockCompanies.forEach((company) => {
                        if (marketData.Data.company == company.symbol) {
                            if (company.buyOrders.length > 0) {
                                var stock;
                                company.buyOrders.some((order) => {

                                    if (order.price >= marketData.Data.order.price) {
                                        if (order.size == marketData.Data.order.size) {
                                            stock = new Order(marketData.Data.order.size, marketData.Data.order.price);
                                            company.trans.push(stock);
                                            let orderToDelete = company.buyOrders.indexOf(order);
                                            company.current = marketData.Data.order.price;
                                            return true;
                                        }
                                        else if (order.size > marketData.Data.order.size) {
                                            var remainingSize = order.size - marketData.Data.order.size;
                                            stock = new Order(marketData.Data.order.size, marketData.Data.order.price);
                                            company.trans.push(stock);
                                            order.size = remainingSize;
                                            company.current = marketData.Data.order.price;
                                            return true;
                                        }
                                        else if (order.size < marketData.Data.order.size) {
                                            var remainingSize = marketData.Data.order.size - order.size;
                                            stock = new Order(marketData.Data.order.size, marketData.Data.order.price);
                                            company.trans.push(stock);
                                            order.size = remainingSize;
                                            company.current = marketData.Data.order.price;
                                            let orderToDelete = company.buyOrders.indexOf(order);
                                            company.sellOrders.push(new Order(remainingSize, marketData.Data.order.price));
                                            let sortedSell = company.sellOrders.sort((a, b) => { return a.price - b.price; });
                                            company.sellOrders = sortedSell;
                                            return true;
                                        }
                                    }
                                    else {
                                        company.sellOrders.push(new Order(marketData.Data.order.size, marketData.Data.order.price));
                                        let sortedSellOrders = company.sellOrders.sort((a, b) => { return a.price - b.price; });
                                        company.sellOrders = sortedSellOrders;
                                        return true;
                                    }
                                });
                            }
                        }
                    });
                    response(socket, marketData.CSeq, marketData.session);
                    notifyClients();
                }
            }
            else if (marketData.header.verb == "Buy Order") {
                if (!marketData.ID || !marketData.CSeq || !marketData.session || !authenticated || !marketData.Data) {
                    disconnectSocket(socket);
                }
                else {
                    if (!marketData.Data.company || !marketData.Data.order) {
                        disconnectSocket(socket);
                    }
                    else {
                        console.log("\n" + marketData.ID + " requests:");
                        let userRequest = marketData.header.verb + " SME/TCP-1.0\nID: " + marketData.ID + ", CSeq: " + marketData.CSeq + ", Session: " + marketData.session + ", Data: " + JSON.stringify(marketData.Data) + "\n";
                        console.log(userRequest);

                        StockData.stockCompanies.forEach((company) => {
                            if (marketData.Data.company == company.symbol) {
                                if (company.sellOrders.length > 0) {
                                    var sale;
                                    company.sellOrders.some((order) => {
                                        if (order.price < marketData.Data.order.price) {
                                            if (order.size == marketData.Data.order.size) {
                                                sale = new Order(marketData.Data.order.size, marketData.Data.order.price);
                                                company.trans.push(sale);
                                                let orderToDelete = company.sellOrders.indexOf(order);
                                                company.sellOrders.splice(orderToDelete, 1);
                                                company.current = marketData.Data.order.price;
                                                return true;
                                            }
                                            else if (order.size > marketData.Data.order.size) {
                                                var remainingSize = order.size - marketData.Data.order.size;
                                                sale = new Order(marketData.Data.order.size, marketData.Data.order.price);
                                                company.trans.push(sale);
                                                order.size = remainingSize;
                                                company.current = marketData.Data.order.price;
                                                return true;
                                            }
                                            else if (order.size < marketData.Data.order.size) {
                                                var remainingSize = marketData.Data.order.size - order.size;
                                                sale = new Order(marketData.Data.order.size, marketData.Data.order.price);
                                                company.trans.push(sale);
                                                order.size = remainingSize;
                                                company.current = marketData.Data.order.price;
                                                let orderToDelete = company.sellOrders.indexOf(order);
                                                company.buyOrders.push(new Order(remainingSize, marketData.Data.order.price));
                                                let sortedBuyOrders = company.buyOrders.sort((a, b) => { return b.price - a.price; });
                                                company.buyOrders = sortedBuyOrders;
                                                return true;
                                            }
                                        }
                                    });
                                }
                            }
                        });
                        response(socket, marketData.CSeq, marketData.session);
                        notifyClients();
                    }
                }
            }
            else { disconnectSocket(socket); }
        }
        else { disconnectSocket(socket); }
    });
}