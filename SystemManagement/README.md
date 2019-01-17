## 数据库设计

#### 用户信息
+ T_User_Register_Info 
	+ RegisterAccount varchar(20) 账号
	+ RegisterPassword varchar(20) 密码
	+ ReginterDate datetime 注册时间.
	+ RegisterStatus varchar(10) 注册状态

+ T_User_Login_Info
	+ LoginAccount varchar(20) 登录账号
	+ LoginDateStart datatime 登录起始时间 
	+ LoginDateEnd datetime 登录结束时间
	+ LoginStatus varchar(10) 登录状态

#### 设备信息
+ T_Terminal_Equipment_Info
	+ RegisterAccount varchar(20) 注册账号
	+ TerminalMasterMAC varchar(20) 网卡MAC地址
	+ TerminalMasterIP varchar(20) 网卡IP地址
	+ TerminalMasterStatus varchar(10) 状态信息
	+ TerminalEquipmentAmount int(10) 终端设备数量
	+ TerminalEquipmentDetail text 终端设备详细信息

+ T_Mobile_Equipment_Info
	+ RegisterAccount varchar(20) 注册账号
	+ MobileEquipmentMAC varchar(20) 网卡MAC地址
	+ MobileEquipmentIP varchar(20) 网卡IP地址
	+ MobileEquipmentStatus varchar(10) 状态信息



## 需求
+ 用户信息管理 包括：
	+ 用户注册信息
	+ 设备运行信息
	+ 用户操作信息
