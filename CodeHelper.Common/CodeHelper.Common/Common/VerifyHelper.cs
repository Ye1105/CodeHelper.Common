namespace CodeHelper.Common.Validator
{
    public static class VerifyHelper
    {
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
            return regex();
        }
    }
}
