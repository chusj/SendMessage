namespace SmsPackage.Model
{
    /// <summary>
    /// 云MAS响应
    /// </summary>
    public class MasResponse
    {
        /// <summary>
        /// 响应状态
        /// </summary>
        public string Rspcod { get; set; }

        /// <summary>
        /// 消息批次号
        /// </summary>
        public string MgsGroup { get; set; }

        /// <summary>
        /// 数据校验结果
        /// </summary>
        public bool Success { get; set; }
    }
}
