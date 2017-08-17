var mongo_client = require('mongodb').MongoClient
var DB_CONN_STR = 'mongodb://localhost:27017/test'

mongo_client.connect(DB_CONN_STR,function(err,db){
    
});