using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFluentBootstrap.Models
{
    /// <summary>
    /// 分页实体，有些属性我写成了虚的， 这样可以根据不同的需要去重写便于扩展
    /// </summary>
    public class BasePageModel
    {
        public string SearchKeyWord { get; set; }

        /// <summary>
        /// 构造函数，指定分页ActionName
        /// </summary>
        /// <param name="actionName">点击分页是指向 Action 的名字</param>
        public BasePageModel(string actionName)
        {
            ActionName = actionName;
        }

        /// <summary>
        ///点击分页是指向 Action 的名字 根据具体需要而定
        /// </summary>
        public string ActionName { get; set; }

        public int TotalCount { get; set; }

        public int CurrentIndex { get; set; }

        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((double)TotalCount / (double)PageSize);
            }
        }

        /// <summary>
        /// 根据需要具体而定PageSize
        /// </summary>
        public virtual int PageSize
        {
            get { return 50; }
        }

        /// <summary>
        ///根据需要具体而定 分页显示最大的页数 
        /// </summary>
        public virtual int DisplayMaxPages
        {
            get
            {
                return 10;
            }
        }

        public bool IsHasPrePage
        {
            get
            {
                return CurrentIndex != 1;
            }
        }

        public bool IsHasNextPage
        {
            get
            {
                return CurrentIndex != TotalPages;
            }
        }
    }
}