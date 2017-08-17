### 1 基础(必选)
* 1，谈谈软件行业的。
```
```
* 2，您理解的游戏行业。
```
```
* 3，您理解游戏服务器开发。
```
```

### 2 游戏服务器基本架构(必选)

### 3 游戏服务器性能指标(必选)
* 1，谈谈您了解的服务器性能指标及对其的理解。
```
```

### 4 语言(必选)
* 1，您熟悉的编程语言，优点缺点。
```
```
* 2，如果你对1问题感觉疑惑,TIOBE Index for August 2017，挑几个你熟悉的谈谈。

|Aug 2017|	Aug 2016|	Change|	Programming Language|	Ratings|	Change|
|:-------|:-------|:-------|:-------|:-------|:-------|
|1|1||Java|12.961%|-6.05%|
|2|2||C|6.477%|-4.83%|
|3|3||C++|5.550%|-0.25%|
|4|4||C#|4.195%|-0.71%|
|5|5||Python|3.692%|-0.71%|
|6|8|change|VisualBasic .NET|2.569%|	+0.05%|
|7|6|change|PHP|2.293%|	-0.88%|
|8|7|change|JavaScript|	2.098%|	-0.61%|
|9|9||Perl|1.995%|-0.52%|
|10|12|change|Ruby|1.965%|-0.31%|
|11|14|change|Swift|1.825%|	-0.16%|
|12|11|change|Delphi/Object Pascal|	1.825%|	-0.45%|
|13|13||Visual Basic|1.809%|-0.24%|
|14|10|change|Assembly language|1.805%|	-0.56%|
|15|17|change|R|1.766%|+0.16%|
|16|20|change|Go|1.645%|+0.37%|
|17|18|change|MATLAB|1.619%|+0.08%|
|18|15|change|Objective-C|1.505%|-0.38%|
|19|22|change|Scratch|1.481%|+0.43%|
|20|26|change|Dart|	1.273%|	+0.30%|

```
```
* 3，在新项目如果根据需求，需要调整当前使用的编程语言以适应当前开发，对此你有什么看法。
```
```

### 5 算法(必选)
* 1，随机算法
概率配置

| 索引 | 概率 | 最大命中次数 | 当前命中次数 | 偏移|
|:---------:|:---------:|:--------:|:---------:|:---------:|
|1|1000|-1|0|true|
|2|1000|-1|0|true|
|3|1000|-1|0|true|
|4|1000|-1|0|true|
|5|1000|-1|0|true|
|6|1000|-1|0|true|
|7|1000|-1|0|true|
|8|1000|-1|0|true|
|9|1000|-1|0|true|
|10|1000|-1|0|true|

		给出合理的随机算法。
		算法复杂度估计。
* 2，棋牌算法
		一副麻将 。
		胡牌。
		复杂度估计。

### 6 网络(可选)
tcp
udp

### 7 数据(可选)

* mysql脚本：

	``` sql
	CREATE TABLE IF NOT EXISTS `ingot_log` (
		`id` bigint(11) NOT NULL AUTO_INCREMENT,
		`user_id` int(11) NOT NULL,
		`event_type` int(11) NOT NULL,
		`from` int(11) NOT NULL DEFAULT 0,
		`to` int(11) NOT NULL DEFAULT 0,
		`change_value` int(11) NOT NULL,
		`now_value` int(11) NOT NULL,
		`last_insert_time` int(11) NOT NULL,
		PRIMARY KEY(`id`)
	) ENGINE=InnoDB AUTO_INCREMENT =1 DEFAULT CHARSET=utf8;
	//
	DROP PROCEDURE IF EXISTS server_update;
	CREATE PROCEDURE server_update()
	BEGIN
		DECLARE result int(4);
		DECLARE uDbName varchar(128);
		select database() into uDbName;
		SET result = 0;
		IF NOT EXISTS (select * from information_schema.columns where table_schema = uDbName and table_name = 'ingot_log' and column_name = 'gtype') THEN
			ALTER TABLE `ingot_log` ADD COLUMN  `gtype` varchar(16) DEFAULT '' AFTER `last_insert_time`;
		END IF;
		IF NOT EXISTS (select * from information_schema.columns where table_schema = uDbName and table_name = 'ingot_log' and column_name = 'platform') THEN
			ALTER TABLE `ingot_log` ADD COLUMN  `platform` varchar(64) DEFAULT '' AFTER `gtype`;
		END IF;
		IF NOT EXISTS (select * from information_schema.columns where table_schema = uDbName and table_name = 'ingot_log' and column_name = 'channel') THEN
			ALTER TABLE `ingot_log` ADD COLUMN  `channel` varchar(64) DEFAULT '' AFTER `platform`;
		END IF;
		SET result = 1;
		SELECT result;
	END;
	//

	CALL server_update();
	//

	DROP PROCEDURE IF EXISTS server_update;
	//

	DROP PROCEDURE IF EXISTS insert_ingot_log;
	CREATE PROCEDURE insert_ingot_log(
		IN in_user_id  int(11),
		IN in_from int(11),
		IN in_to int(11),
		IN in_event_type int(11),
		IN in_value int(11),
		IN in_then_value int(11),
		IN in_gtype varchar(64),
		IN in_platform varchar(64),
		IN in_channel  varchar(64)
	)
	BEGIN
		insert into ingot_log(user_id,`from`,`to`,event_type,change_value,now_value,last_insert_time,gtype,platform,channel) values(in_user_id,in_from,in_to,in_event_type,in_value,in_then_value,unix_timestamp(now()),in_gtype,in_platform,in_channel);
		select * from ingot_log where id = LAST_INSERT_ID();
	END;
	//
	```

* mongo脚本：

	``` shell
	```

* 1，谈谈你认为这些脚本最有可能在处理什么问题。
* 2，结合您以前的开发工作谈谈你理解的关系数据库和非关系数据库。

### 8 架构与设计模式(可选)
* 1，谈谈熟悉的设计模式，及你对其的应用。

### 9 nodejs了解(可选)

### 10 谈谈你的职业规划