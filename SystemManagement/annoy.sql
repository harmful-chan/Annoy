SHOW DATABASES;

USE annoy;
SHOW TABLES;

CREATE TABLE T_User_Register_Info(
	Id INT(4) NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT '主键', 
	RegisterAccount  VARCHAR(20) NOT NULL COMMENT "账号",
	RegisterPassword VARCHAR(20) NOT NULL COMMENT "密码",
	ReginterDate     DATETIME    NOT NULL COMMENT "注册时间",
	RegisterStatus   VARCHAR(10) NOT NULL COMMENT "注册状态");
	
CREATE TABLE T_User_Login_Info(
	Id INT(4) NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT '主键', 
	LoginAccount   VARCHAR(20) NOT NULL COMMENT "登录账号",
	LoginDateStart DATETIME    NOT NULL COMMENT "登录起始时间", 
	LoginDateEnd   DATETIME    NOT NULL COMMENT "登录结束时间",
	LoginStatus    VARCHAR(10) NOT NULL COMMENT "登录状态");

CREATE TABLE T_Terminal_Equipment_Info(
	Id INT(4) NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT '主键', 
	RegisterAccount         VARCHAR(20) NOT NULL COMMENT "注册账号",
	TerminalMasterMAC       VARCHAR(20) NOT NULL COMMENT "网卡MAC地址", 
	TerminalMasterIP        VARCHAR(20) NOT NULL COMMENT "网卡IP地址",
	TerminalMasterStatus    VARCHAR(10) NOT NULL COMMENT "状态信息");
	TerminalEquipmentAmount INT(10)     NOT NULL COMMENT "终端设备数量",
	TerminalEquipmentDetail TEXT        NOT NULL COMMENT "终端设备详细信息");	
	
CREATE TABLE T_Mobile_Equipment_Info(
	Id INT(4) NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT '主键', 
	RegisterAccount       VARCHAR(20) NOT NULL COMMENT "注册账号",
	MobileEquipmentMAC    VARCHAR(20) NOT NULL COMMENT "网卡MAC地址",
	MobileEquipmentIP     VARCHAR(20) NOT NULL COMMENT "网卡IP地址",
	MobileEquipmentStatus VARCHAR(10) NOT NULL COMMENT "状态信息");