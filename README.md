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

