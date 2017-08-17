### 1，基础(必选)
* 1，谈谈软件行业的。
* 2，您理解的游戏行业。
* 3，您理解游戏服务器开发。

### 2，游戏服务器基本架构(必选)

### 3，游戏服务器性能指标(必选)
* 1，谈谈您了解的服务器性能指标及对其的理解。

### 4，语言(必选)
* 1，您熟悉的编程语言，优点缺点。
* 2，如果你对1问题感觉疑惑,这里有一副2017年编程语言排行，挑几个你熟悉的谈谈。
* 3，在新项目如果根据需求，需要调整当前使用的编程语言以适应当前开发，对此你有什么看法。

### 5，算法(必选)
* 1，随机算法
	* 随机概率配置

		给出合理的随机算法。
		算法复杂度估计。
* 2，棋牌算法
		一副麻将 。
		胡牌。
		复杂度估计。

### 6，网络(可选)
tcp
udp

### 7，数据(可选)

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

### 8，架构与设计模式(可选)
* 1，谈谈熟悉的设计模式，及你对其的应用。

### 9，nodejs了解(可选)

### 10，简单谈谈对此面试的看法。

* 是否合理。
* 目的能否达到。