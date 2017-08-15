var mongodb = require("mongodb");

//server api :http://mongodb.github.io/node-mongodb-native/2.2/api/Server.html

var host ="127.0.0.1";
var port = 27017;
var options ={
    poolSize:5,
}

var mongo_server = new mongodb.Server(host,port,options);


console.log(mongo_server)

console.log(mongo_server.connections())