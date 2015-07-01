﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace MyFluentBootstrap.Models
{
    /// <summary></summary>
    [Serializable]
    [DataObject]
    [Description("")]
    [BindIndex("sqlite_master_PK_t_product", true, "ProductID")]
    [BindTable("t_product", Description = "", ConnName = "product_conn", DbType = DatabaseType.SQLite)]
    public partial class Product : IProduct
    {
        #region 属性
        private Int32 _ProductID;
        /// <summary></summary>
        [DisplayName("ProductID")]
        [Description("")]
        [DataObjectField(true, true, false, 8)]
        [BindColumn(1, "ProductID", "", null, "integer", 19, 0, false)]
        public virtual Int32 ProductID
        {
            get { return _ProductID; }
            set { if (OnPropertyChanging(__.ProductID, value)) { _ProductID = value; OnPropertyChanged(__.ProductID); } }
        }

        private String _ProductName;
        /// <summary></summary>
        [DisplayName("ProductName")]
        [Description("")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(2, "ProductName", "", null, "nvarchar(50)", 0, 0, true)]
        public virtual String ProductName
        {
            get { return _ProductName; }
            set { if (OnPropertyChanging(__.ProductName, value)) { _ProductName = value; OnPropertyChanged(__.ProductName); } }
        }

        private Double _DisplayPrice;
        /// <summary></summary>
        [DisplayName("DisplayPrice")]
        [Description("")]
        [DataObjectField(false, false, true, 8)]
        [BindColumn(3, "DisplayPrice", "", null, "float", 8, 2, false)]
        public virtual Double DisplayPrice
        {
            get { return _DisplayPrice; }
            set { if (OnPropertyChanging(__.DisplayPrice, value)) { _DisplayPrice = value; OnPropertyChanged(__.DisplayPrice); } }
        }

        private String _PicImgs;
        /// <summary></summary>
        [DisplayName("PicImgs")]
        [Description("")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn(4, "PicImgs", "", null, "varchar(100)", 0, 0, false)]
        public virtual String PicImgs
        {
            get { return _PicImgs; }
            set { if (OnPropertyChanging(__.PicImgs, value)) { _PicImgs = value; OnPropertyChanged(__.PicImgs); } }
        }

        private DateTime _AddTime;
        /// <summary></summary>
        [DisplayName("AddTime")]
        [Description("")]
        [DataObjectField(false, false, true, 8)]
        [BindColumn(5, "AddTime", "", null, "datetime", 0, 0, false)]
        public virtual DateTime AddTime
        {
            get { return _AddTime; }
            set { if (OnPropertyChanging(__.AddTime, value)) { _AddTime = value; OnPropertyChanged(__.AddTime); } }
        }

        private DateTime _LastUpdateTime;
        /// <summary></summary>
        [DisplayName("LastUpdateTime")]
        [Description("")]
        [DataObjectField(false, false, true, 8)]
        [BindColumn(6, "LastUpdateTime", "", null, "datetime", 0, 0, false)]
        public virtual DateTime LastUpdateTime
        {
            get { return _LastUpdateTime; }
            set { if (OnPropertyChanging(__.LastUpdateTime, value)) { _LastUpdateTime = value; OnPropertyChanged(__.LastUpdateTime); } }
        }
        #endregion

        #region 获取/设置 字段值
        /// <summary>
        /// 获取/设置 字段值。
        /// 一个索引，基类使用反射实现。
        /// 派生实体类可重写该索引，以避免反射带来的性能损耗
        /// </summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case __.ProductID : return _ProductID;
                    case __.ProductName : return _ProductName;
                    case __.DisplayPrice : return _DisplayPrice;
                    case __.PicImgs : return _PicImgs;
                    case __.AddTime : return _AddTime;
                    case __.LastUpdateTime : return _LastUpdateTime;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.ProductID : _ProductID = Convert.ToInt32(value); break;
                    case __.ProductName : _ProductName = Convert.ToString(value); break;
                    case __.DisplayPrice : _DisplayPrice = Convert.ToDouble(value); break;
                    case __.PicImgs : _PicImgs = Convert.ToString(value); break;
                    case __.AddTime : _AddTime = Convert.ToDateTime(value); break;
                    case __.LastUpdateTime : _LastUpdateTime = Convert.ToDateTime(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得字段信息的快捷方式</summary>
        public class _
        {
            ///<summary></summary>
            public static readonly Field ProductID = FindByName(__.ProductID);

            ///<summary></summary>
            public static readonly Field ProductName = FindByName(__.ProductName);

            ///<summary></summary>
            public static readonly Field DisplayPrice = FindByName(__.DisplayPrice);

            ///<summary></summary>
            public static readonly Field PicImgs = FindByName(__.PicImgs);

            ///<summary></summary>
            public static readonly Field AddTime = FindByName(__.AddTime);

            ///<summary></summary>
            public static readonly Field LastUpdateTime = FindByName(__.LastUpdateTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得字段名称的快捷方式</summary>
        class __
        {
            ///<summary></summary>
            public const String ProductID = "ProductID";

            ///<summary></summary>
            public const String ProductName = "ProductName";

            ///<summary></summary>
            public const String DisplayPrice = "DisplayPrice";

            ///<summary></summary>
            public const String PicImgs = "PicImgs";

            ///<summary></summary>
            public const String AddTime = "AddTime";

            ///<summary></summary>
            public const String LastUpdateTime = "LastUpdateTime";

        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IProduct
    {
        #region 属性
        /// <summary></summary>
        Int32 ProductID { get; set; }

        /// <summary></summary>
        String ProductName { get; set; }

        /// <summary></summary>
        Double DisplayPrice { get; set; }

        /// <summary></summary>
        String PicImgs { get; set; }

        /// <summary></summary>
        DateTime AddTime { get; set; }

        /// <summary></summary>
        DateTime LastUpdateTime { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值。</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}