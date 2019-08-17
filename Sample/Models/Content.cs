using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        /// <summary>
        /// 状态 1正常 0删除
        /// </summary>
        public int status { get; set; }

        public DateTime addTime { get; set; }

        public DateTime modifyTime { get; set; }

    }
}
