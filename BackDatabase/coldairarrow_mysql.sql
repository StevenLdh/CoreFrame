/*
Navicat MySQL Data Transfer

Source Server         : myhost
Source Server Version : 50712
Source Host           : 127.0.0.1:3306
Source Database       : coldairarrow

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2019-06-01 15:50:40
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for base_appsecret
-- ----------------------------
DROP TABLE IF EXISTS `base_appsecret`;
CREATE TABLE `base_appsecret` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '主键',
  `AppId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '应用Id',
  `AppSecret` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '应用密钥',
  `AppName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '应用名',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='应用密钥';

-- ----------------------------
-- Records of base_appsecret
-- ----------------------------
INSERT INTO `base_appsecret` VALUES ('039e41170bc72-b89139b1-f3f4-430e-aed7-36b193d256dc', 'AppAdmi', '7344a9c5-4f8c-4725-bde5-3fb99716f457', '超级权限');
INSERT INTO `base_appsecret` VALUES ('039ee16a67666-296b97f8-c0b0-4bce-8fcc-4403b9f3564d', 'AppXM', '111111111', '小明');

-- ----------------------------
-- Table structure for base_databaselink
-- ----------------------------
DROP TABLE IF EXISTS `base_databaselink`;
CREATE TABLE `base_databaselink` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '主键',
  `LinkName` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '连接名',
  `ConnectionStr` varchar(1000) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '连接字符串',
  `DbType` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '数据库类型',
  `SortNum` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '排序编号',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='数据库连接';

-- ----------------------------
-- Records of base_databaselink
-- ----------------------------

-- ----------------------------
-- Table structure for base_permissionappid
-- ----------------------------
DROP TABLE IF EXISTS `base_permissionappid`;
CREATE TABLE `base_permissionappid` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '主键',
  `AppId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT 'AppId',
  `PermissionValue` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '权限值',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='AppId权限表';

-- ----------------------------
-- Records of base_permissionappid
-- ----------------------------
INSERT INTO `base_permissionappid` VALUES ('039e4082caa0a-4b9fb0cf-05f3-4287-a5b4-c8004a21627c', 'AppTest', 'sysuser.manage');
INSERT INTO `base_permissionappid` VALUES ('039e4082caa0a-61c9c1c6-9f27-48a1-b002-ad69eece2fba', 'AppTest', 'sysrole.search');
INSERT INTO `base_permissionappid` VALUES ('039e4082caa0a-a13df201-5f8b-4178-8823-72709c75d30d', 'AppTest', 'sysuser.search');
INSERT INTO `base_permissionappid` VALUES ('039e4082caa0a-c10ea62d-290d-4a74-bb0d-74d4891b5fb9', 'AppTest', 'sysrole.manage');
INSERT INTO `base_permissionappid` VALUES ('039ee16a5e521-af54ae67-d511-4dfe-9077-478bdd972264', 'AppAdmi', 'sysuser.search');

-- ----------------------------
-- Table structure for base_permissionrole
-- ----------------------------
DROP TABLE IF EXISTS `base_permissionrole`;
CREATE TABLE `base_permissionrole` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '主键',
  `RoleId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '角色主键Id',
  `PermissionValue` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '权限值',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='角色权限表';

-- ----------------------------
-- Records of base_permissionrole
-- ----------------------------
INSERT INTO `base_permissionrole` VALUES ('039e40813d768-8f112ee0-ab06-40de-bea6-84d08585929a', '039e3de2a728b-95a8888c-5b3c-42e7-a983-379e7f0cefc4', 'sysrole.search');
INSERT INTO `base_permissionrole` VALUES ('039e40813d768-c302de76-116c-49ec-881d-64c21ef23f25', '039e3de2a728b-95a8888c-5b3c-42e7-a983-379e7f0cefc4', 'sysuser.search');
INSERT INTO `base_permissionrole` VALUES ('039e4082682ad-73a3c09d-02bc-4976-9261-bc54d503d4b3', '039e3de2a5724-492ec4b1-848f-4214-8df5-05ddeffa3e3e', 'sysrole.search');
INSERT INTO `base_permissionrole` VALUES ('039e4082682ad-b69b58c3-ece5-4798-9af4-67d87f6fec57', '039e3de2a5724-492ec4b1-848f-4214-8df5-05ddeffa3e3e', 'sysuser.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116b5bdc-19705d4a-67b0-4653-b8d3-01b33ea95dfd', '039e4116b3565-6ba14a24-ac04-4c42-bd7f-37205a6687d8', 'sysuser.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116b5bdd-1744d3c5-d8a9-4ca8-b674-8a29b63f3579', '039e4116b3565-6ba14a24-ac04-4c42-bd7f-37205a6687d8', 'appsecret.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116b5bdd-859268b8-7d41-47f7-b4a0-9c1723fdd8b4', '039e4116b3565-6ba14a24-ac04-4c42-bd7f-37205a6687d8', 'sysrole.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116b5bdd-a1bc3b7c-2e70-4bb6-880e-78ba1ff96ef0', '039e4116b3565-6ba14a24-ac04-4c42-bd7f-37205a6687d8', 'buildcode.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116b5bdd-bd389b48-8646-44cb-aaf6-1ad63e290b31', '039e4116b3565-6ba14a24-ac04-4c42-bd7f-37205a6687d8', 'databaseLink.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116b7175-0a86c2f0-2814-4e7d-8168-5a4a4eb045ab', '039e4116b4700-0f37d7f4-41b5-4a17-b0fb-67654ff44185', 'sysuser.manage');
INSERT INTO `base_permissionrole` VALUES ('039e4116b7175-2f158fb9-8231-422a-9aac-58071e7f8634', '039e4116b4700-0f37d7f4-41b5-4a17-b0fb-67654ff44185', 'sysrole.manage');
INSERT INTO `base_permissionrole` VALUES ('039e4116b7175-fdbcad8b-fbbb-4414-9df5-b63fdf00f84e', '039e4116b4700-0f37d7f4-41b5-4a17-b0fb-67654ff44185', 'appsecret.manage');
INSERT INTO `base_permissionrole` VALUES ('039e4116c54e5-173754c2-e902-4988-b50f-b883d8455db1', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', 'appsecret.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116c54e5-6485672f-8a64-4e1d-9929-b0e7349c364b', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', 'sysuser.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116c54e5-722409a9-e42c-49f5-be03-eb625518eb7b', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', 'appsecret.manage');
INSERT INTO `base_permissionrole` VALUES ('039e4116c54e5-75c3fcd4-4fa9-4954-8479-7d6f167bd491', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', 'sysrole.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116c54e5-980eea1a-800b-4436-bd2a-3f4e12baa049', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', 'databaseLink.search');
INSERT INTO `base_permissionrole` VALUES ('039e4116c54e5-aa682996-32a1-4a6c-b641-4c4d380e94c0', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', 'sysuser.manage');
INSERT INTO `base_permissionrole` VALUES ('039e4116c54e5-ac1b4d9c-1823-44e1-b8bc-fe4221446b62', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', 'sysrole.manage');
INSERT INTO `base_permissionrole` VALUES ('039e4116c54e5-d61e0d12-dc36-4e51-8ba5-856bdd0dba4b', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', 'buildcode.search');
INSERT INTO `base_permissionrole` VALUES ('039ee16a297ed-699d7664-949c-43bd-aab7-48a3b1c714da', '039e4630ba5a1-72a1d684-e3e8-4391-b38a-ad393e85b5b8', 'sysuser.search');
INSERT INTO `base_permissionrole` VALUES ('039ee16a2981b-23264d39-b5dc-43af-90b1-3de1a454caa1', '039e4630ba5a1-72a1d684-e3e8-4391-b38a-ad393e85b5b8', 'sysrole.manage');
INSERT INTO `base_permissionrole` VALUES ('039ee16a2981b-79d6a08d-fab8-4755-9a53-09a9b42161dd', '039e4630ba5a1-72a1d684-e3e8-4391-b38a-ad393e85b5b8', 'sysuser.manage');
INSERT INTO `base_permissionrole` VALUES ('039ee16a2981b-c3f74cf9-b8be-4f1f-8df4-86d8ca95e4ae', '039e4630ba5a1-72a1d684-e3e8-4391-b38a-ad393e85b5b8', 'sysrole.search');

-- ----------------------------
-- Table structure for base_permissionuser
-- ----------------------------
DROP TABLE IF EXISTS `base_permissionuser`;
CREATE TABLE `base_permissionuser` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '主键',
  `UserId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '用户主键Id',
  `PermissionValue` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '权限',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='用户权限表';

-- ----------------------------
-- Records of base_permissionuser
-- ----------------------------
INSERT INTO `base_permissionuser` VALUES ('039ee167ba3b0-6592d19e-b3e6-4e4d-a8bc-6a7367e839d6', '039e3e3891eea-a67a61c4-adae-49fb-9fa3-50f3d54eabc3', 'sysuser.search');

-- ----------------------------
-- Table structure for base_syslog
-- ----------------------------
DROP TABLE IF EXISTS `base_syslog`;
CREATE TABLE `base_syslog` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '主键',
  `LogType` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '日志类型',
  `LogContent` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '日志内容',
  `OpUserName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '操作员用户名',
  `OpTime` datetime DEFAULT NULL COMMENT '日志记录时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='系统日志表';

-- ----------------------------
-- Records of base_syslog
-- ----------------------------

-- ----------------------------
-- Table structure for base_sysrole
-- ----------------------------
DROP TABLE IF EXISTS `base_sysrole`;
CREATE TABLE `base_sysrole` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '代理主键',
  `RoleId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '逻辑主键，角色Id',
  `RoleName` varchar(50) CHARACTER SET utf8 DEFAULT NULL COMMENT '角色名',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='系统角色';

-- ----------------------------
-- Records of base_sysrole
-- ----------------------------
INSERT INTO `base_sysrole` VALUES ('039e3de2a3a7c-e35bc1a8-7e42-44a2-9881-7d1d6768ab72', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7', '超级管理员');
INSERT INTO `base_sysrole` VALUES ('039e4630ba5a1-31320968-d1dd-4275-ae71-a06da0731a2b', '039e4630ba5a1-72a1d684-e3e8-4391-b38a-ad393e85b5b8', '管理员');

-- ----------------------------
-- Table structure for base_unittest
-- ----------------------------
DROP TABLE IF EXISTS `base_unittest`;
CREATE TABLE `base_unittest` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '单元测试主键',
  `UserId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '用户ID',
  `UserName` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '用户名称',
  `Age` int(11) DEFAULT NULL COMMENT '年龄',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='单元测试表';

-- ----------------------------
-- Records of base_unittest
-- ----------------------------
INSERT INTO `base_unittest` VALUES ('10', null, null, null);
INSERT INTO `base_unittest` VALUES ('143b8b04-d389-43b3-b606-2c211c4d5886', '1', 'a821dc69-660e-4ccc-bb5f-1a017d5ba04a', null);
INSERT INTO `base_unittest` VALUES ('6ff20fd0-675c-436a-aa4f-ef4964fcf191', '2', 'cd099bdc-95cc-445b-9a01-5f1c97b65721', null);

-- ----------------------------
-- Table structure for base_user
-- ----------------------------
DROP TABLE IF EXISTS `base_user`;
CREATE TABLE `base_user` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '代理主键',
  `UserId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '用户Id,逻辑主键',
  `UserName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '用户名',
  `Password` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '密码',
  `RealName` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '真实姓名',
  `Sex` int(11) DEFAULT NULL COMMENT '性别(1为男，0为女)',
  `Birthday` date DEFAULT NULL COMMENT '出生日期',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='用户表';

-- ----------------------------
-- Records of base_user
-- ----------------------------
INSERT INTO `base_user` VALUES ('039e3e3891eea-1e885eb2-75a3-4f82-bb9a-570d717f2af4', '039e3e3891eea-a67a61c4-adae-49fb-9fa3-50f3d54eabc3', 'xiaoming', 'e10adc3949ba59abbe56e057f20f883e', '小明', '0', '1901-01-01');
INSERT INTO `base_user` VALUES ('039e40811175f-af4ebd3b-4908-4f9e-8075-31859b8aede0', '039e40811175f-dbed6ef5-f06a-4512-9b40-ecfa2c7925f9', 'xiaohua', 'e10adc3949ba59abbe56e057f20f883e', '小花', '0', '1901-01-01');
INSERT INTO `base_user` VALUES ('2e9a9876-469e-42b3-b631-48e866723eeb', 'Admin', 'Admin', 'e10adc3949ba59abbe56e057f20f883e', '超级管理员', '1', '1901-01-01');

-- ----------------------------
-- Table structure for base_userrolemap
-- ----------------------------
DROP TABLE IF EXISTS `base_userrolemap`;
CREATE TABLE `base_userrolemap` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '角色映射Id',
  `UserId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '名称ID',
  `RoleId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '角色ID',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='角色映射';

-- ----------------------------
-- Records of base_userrolemap
-- ----------------------------
INSERT INTO `base_userrolemap` VALUES ('039E7867D8D17-DDF7060D-10BA-4641-8605-24FB4DE4F446', 'Admin', '039e3de2a3a7c-b3a0d714-922a-4cb7-a412-69eefd4d3ac7');

-- ----------------------------
-- Table structure for dev_project
-- ----------------------------
DROP TABLE IF EXISTS `dev_project`;
CREATE TABLE `dev_project` (
  `Id` varchar(50) COLLATE utf8_unicode_ci NOT NULL COMMENT '项目Id',
  `ProjectId` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '项目名',
  `ProjectName` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL COMMENT '项目表',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci COMMENT='项目';

-- ----------------------------
-- Records of dev_project
-- ----------------------------
