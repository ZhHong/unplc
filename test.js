function show_me_score(three){

    var a ={
        score:{1:6,2:6,3:6},
        boom_index:[1,2,3],
        boom_score:0
    }
    
    var b ={
        score:{0:-6,2:6,3:6},
        boom_index:[2,3],
        boom_score:0
    }
    
    var c ={
        score:{0:-6,1:-6,3:6},
        boom_index:[3],
        boom_score:0
    }
    
    var d ={
        score:{0:-6,1:-6,2:-6},
        boom_index:[],
        boom_score:0
    }
    
    var score ={}
    
    score[0] =a
    score[1] =b
    score[2] =c
    score[3] =d

    var pc_num = Object.keys(score).length -1;

    if(pc_num == 1) {three = false}; 

    if(three){
        for(var uid in score){
            var sobj = score[uid];
            if(sobj.boom_index.length){
                var times = Math.pow(2,sobj.boom_index.length)
                for(var i=0;i<sobj.boom_index.length;++i){
                    var idx = sobj.boom_index[i];
                    sobj.score[idx] *= times;
                    score[idx].score[uid] *= times;
                }
            }
        }
    }else{
        for(var uid in score){
            var sobj = score[uid];
            if(sobj.boom_index.length){
                var times =2;
                if(sobj.boom_index.length == pc_num){
                    times *=2;
                }
                for(var i=0;i<sobj.boom_index.length;++i){
                    var idx = sobj.boom_index[i];
                    sobj.score[idx] *= times;
                    score[idx].score[uid] *= times;
                }
            }
        }
    }

    return score
}

function sum_score(score){
    var v ={}
    for(var idex in score){
        v[idex] = 0;
        for(var xx in score[idex].score){
            v[idex] += score[idex].score[xx]
        }
    }
    return v;
}
console.log("double show me score ====>",JSON.stringify(sum_score(show_me_score(false),null,2)))
console.log("three  show me score ====>",JSON.stringify(sum_score(show_me_score(true),null,2)))