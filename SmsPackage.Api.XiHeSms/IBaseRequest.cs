namespace SmsPackage.Api.XiHeSms
{
    /// <summary>
    /// 统一接口
    /// </summary>
    public interface IBaseRequest
    {
        /// <summary>
        /// 机构id
        /// </summary>
        string OrgId { get; set; }

        /// <summary>
        /// 令牌
        /// </summary>
        string Token { get; set; }

        /// <summary>
        /// Unix时间戳(单位:秒)
        /// </summary>
        string TimeStamp { get; set; }
    }
}
