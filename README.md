<h1 align="center"><p>🦓 CodeHelper.Common</p>
</h1>

<div align="center"> 
<p> CodeHelper.Common 是一个封装常用帮助类的 Nuget 包 😼</p>
</div>

###  :zap: HTTP 响应状态码 

> [MDN HTTP 项目状态码描述](https://developer.mozilla.org/zh-CN/docs/Web/HTTP/Status#%E4%BF%A1%E6%81%AF%E5%93%8D%E5%BA%94)

+ 枚举 **HttpStatus**

  ```c#
  //eg：客户端错误：400
  HttpStatus.BAD_REQUEST
  ```

### :zap: ExpressionExtend 

> `Expression<Function<T,bool>>`  的 **与** 、**或**、**非** 扩展 

```c#
 Expression<Func<T, bool>> expression = x => true;
 // and
 expression = expression.And(x => x.Prop >= xxx);
 // Or
 expression = expression.Or(x => x.Prop >= xxx);
 // Not
 expression = expression.Not(x => x.Prop >= xxx);
```

### :zap: JsonHelper 

> `Newtonsoft.Json` 简单封装

```c#
//object -> string
JsonHelper.SerObj()

//string -> object
JsonHelper.DesObj()

//string => T
JsonHelper.DesObj<T>()

//JArray -> string
JsonHelper.SerJArray()

//string => dictionary
JsonHelper.ToDic<TKey, TValue>
```

### :zap: Md5Helper

> MD5 加密

```c#
//加密方法
Md5Helper.MD5(string)
```

### :zap: VerifyHelper

> 通用正则校验方式封装

+ 常用 **正则规则** 以 `Tuple`  的形式存放在 `CodeHelper.Common.Rgx`  文件中 , 

```c#
//eg:
public static readonly (string, string) RGX_PHONE = (@"^1[3456789]\d{9}$", "手机号规范");
```

+ 方法声明

```c#
/// <summary>
/// 正则校验
/// </summary>
/// <param name="text">需要校验的文本</param>
/// <param name="pattern">regex正则表达式列表 
/// <para>(string,string), eg: (@"^1[3456789]\d{9}$", "手机号正则")</para> 
/// <para>item1:regex </para>
/// <para>item2:regex描述</para>
/// </param>
/// <param name="regex">自定义Func校验text是否满足pattern </param>
/// <returns></returns>
/// <exception cref="ArgumentNullException"></exception>
public static (bool, string) RegexVerify(this string text, IEnumerable<(string, string)> pattern, Func<(bool, string)> regex)
{
if (string.IsNullOrWhiteSpace(text)) throw new ArgumentNullException(nameof(text));
if (pattern == null) throw new ArgumentNullException(nameof(pattern));
return regex.Invoke();
}
```

+  方法调用

```c#
//eg:手机格式校验
//1.自定义正则校验规则，可以是一个或者多个
var phonePatterns = new[] { Rgx.RGX_PHONE };
//2.调用校验方法
var phoneVerify = phone.RegexVerify(phonePatterns, () =>
    {
	  //3.遍历匹配全部规则
      foreach (var pattern in phonePatterns)
         {
          if (Regex.IsMatch(phone, pattern.Item1))
            return (true, "");
          else
            return (false, pattern.Item2);
         }
       return (true, "");
    }
);
```



 