# MyFirstNugetApp

## 介绍
将工作中用到了上海助通、上海联麓 2个短信公司的api接口，封装上传到nuget上


## 代码结构
1. SmsPackage.Api.Lianlu  => 封装请求联麓短信接口的服务拓展方法
2. SmsPackage.Api.Mas     => 封装请求中国移动云MAS的服务拓展方法
3. SmsPackage.Api.Zhutong => 封装请求上海助通短信接口的服务拓展方法
4. SmsPackage.Model       => 定义了各个厂家接口的请求参数、返回参数等
5. SmsPackage.Service     => 实际的发送业务方法
6. SmsPackage.Test        => 测试类库，当前已经应用了nuget上的包

## Nuget包信息
### 1. [smsapi.cmcc.mas](https://www.nuget.org/packages/smsapi.cmcc.mas/)
### 2. [smsapi.zhutong](https://www.nuget.org/packages/smsapi.zhutong/)
### 3. [smsapi.lianlu](https://www.nuget.org/packages/smsapi.lianlu/)