namespace CodeHelper.Common
{
    /// <summary>
    /// 常用正则表达式
    /// </summary>
    public static class Rgx
    {
        /// <summary>
        /// 手机号正则
        /// </summary>
        public static readonly (string, string) RGX_PHONE = (@"^1[3456789]\d{9}$", "手机号正则");

        /// <summary>
        /// 特殊字符
        /// </summary>
        public static readonly (string, string) RGX_SPECIAL_CHARACTER = (@"^[a-zA-Z0-9_\u4e00-\u9fa5\\s·]+$", "特殊字符");

        /// <summary>
        /// 字符以"_"开头或结尾
        /// </summary>
        public static readonly (string, string) RGX_UNDERLING = (@"(^_)|(__)|(_+$)", "字符以\"_\"开头或结尾");

        /// <summary>
        /// 全是数字
        /// </summary>
        public static readonly (string, string) RGX_NUMBER = (@"^\d+$", "全是数字");

        /// <summary>
        /// 6-12 位密码长度
        /// </summary>
        public static readonly (string, string) RGX_PASSWORD_LENGTH = (@"^[\S]{6,12}$", "6-12 位密码长度");
    }
}
