namespace CodeHelper.Common
{
    [AttributeUsage(AttributeTargets.All)]
    public class EnumDescriptionAttribute : Attribute
    {
        private string m_strDescription;

        public EnumDescriptionAttribute(string strPrinterName)
        {
            m_strDescription = strPrinterName;
        }

        public string Description
        {
            get { return m_strDescription; }
        }

        /// <summary>
        /// 获取枚举描述
        /// </summary>
        /// <param name="enumObj"></param>
        /// <returns></returns>
        public static string? GetEnumDescription(Enum enumObj)
        {
            System.Reflection.FieldInfo? fieldInfo = enumObj.GetType().GetField(enumObj.ToString());

            try
            {
                object[]? attribArray = fieldInfo?.GetCustomAttributes(false);
                if (attribArray is not null)
                {
                    if (attribArray.Length == 0)
                    {
                        return String.Empty;
                    }
                    else
                    {
                        EnumDescriptionAttribute? attrib = attribArray[0] as EnumDescriptionAttribute;

                        return attrib?.Description;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 通过【描述】获取【枚举值】
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="description"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static T? GetEnumByDescription<T>(string description) where T : Enum
        {
            System.Reflection.FieldInfo[] fields = typeof(T).GetFields();
            foreach (System.Reflection.FieldInfo field in fields)
            {
                object[] objs = field.GetCustomAttributes(typeof(EnumDescriptionAttribute), false);    //获取描述属性
                if (objs.Length > 0 && (objs[0] as EnumDescriptionAttribute)?.Description == description)
                {
                    return (T?)field.GetValue(null);
                }
            }

            throw new ArgumentException(string.Format("{0} 未能找到对应的枚举.", description), "Description");
        }
    }
}