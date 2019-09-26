using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKProCloudMusic
{
    /// <summary>
    /// 功能描述    ：DKSet  
    /// 创 建 者    ：劉亞坤
    /// 创建日期    ：2019/9/25 14:12:19 
    /// 最后修改者  ：劉亞坤
    /// 最后修改日期：2019/9/25 14:12:19 
    /// </summary>
    public class DKSet
    {
        /// <summary>
        /// 开机自启
        /// </summary>
        public bool AutoStart { get; set; } = false;

        /// <summary>
        /// 启动后自动执行脚本
        /// </summary>
        public bool AutoExecute { get; set; } = false;

        /// <summary>
        /// 是否自动后最小化
        /// </summary>
        public bool StartWithMini { get; set; } = false;

        /// <summary>
        /// 1代理,2hosts
        /// </summary>
        public int Mode { get; set; } = 2;
    }
}
