using Microsoft.AspNetCore.Http;

namespace CodeHelper.Common
{
    public static class RequestHelper
    {
        /// <summary>
        /// 判定 HttpRequest 是否是 Ajax 请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            string? header = request.Headers["X-Requested-With"];
            return "XMLHttpRequest".Equals(header);
        }

    }
}
