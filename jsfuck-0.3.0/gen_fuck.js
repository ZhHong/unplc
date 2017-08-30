var lib = require("./jsfuck.js");


var file_list = {
    './plan.js':'plan_en'
}

var fs = require('fs');
for(var f in file_list){
    var data = fs.readFileSync(f,"utf8");
    var output = lib.JSFuck.encode(data,false);
    // var fwrite = fs.createWriteStream(file_list[f]);
    // fwrite.write(output);
    // fwrite.end();
    var unencode = eval(output);
    console.log(unencode);
}