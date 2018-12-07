# 基于ASP.NET 创建的学生系统
### 运行的方法
启动本机的sql server服务，修改配置文件dev20170602StuSys/dev20170602StuSys/Web.config中的
```xml
  <configuration>
    <configSections>
      <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
      <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework,   Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
    </configSections>
    <connectionStrings>
      <add name="DBManage" connectionString="Data Source=.; Initial Catalog=StuSystem;Integrated Security=SSPI"     providerName="System.Data.SqlClient" />
   </connectionStrings>
```  

中Data Source为服务器的IP地址，其中.代表本机的IP，如果在本机启动sql server的服务，则不需要修改本机的配置，注意数据库的名称相对应即可。
