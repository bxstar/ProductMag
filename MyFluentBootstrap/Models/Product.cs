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
        /// <summary>编号，主键</summary>
        [DisplayName("编号，主键")]
        [Description("编号，主键")]
        [DataObjectField(true, true, false, 8)]
        [BindColumn(1, "ProductID", "编号，主键", null, "integer", 19, 0, false)]
        public virtual Int32 ProductID
        {
            get { return _ProductID; }
            set { if (OnPropertyChanging(__.ProductID, value)) { _ProductID = value; OnPropertyChanged(__.ProductID); } }
        }

        private String _ProductName;
        /// <summary>产品名称</summary>
        [DisplayName("产品名称")]
        [Description("产品名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(2, "ProductName", "产品名称", null, "nvarchar(50)", 0, 0, true)]
        public virtual String ProductName
        {
            get { return _ProductName; }
            set { if (OnPropertyChanging(__.ProductName, value)) { _ProductName = value; OnPropertyChanged(__.ProductName); } }
        }

        private String _ProductType;
        /// <summary>产品类型，前刹车片，后刹车片等</summary>
        [DisplayName("产品类型，前刹车片，后刹车片等")]
        [Description("产品类型，前刹车片，后刹车片等")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(3, "ProductType", "产品类型，前刹车片，后刹车片等", null, "nvarchar(50)", 0, 0, true)]
        public virtual String ProductType
        {
            get { return _ProductType; }
            set { if (OnPropertyChanging(__.ProductType, value)) { _ProductType = value; OnPropertyChanged(__.ProductType); } }
        }

        private String _PicImgs;
        /// <summary>产品主图</summary>
        [DisplayName("产品主图")]
        [Description("产品主图")]
        [DataObjectField(false, false, true, 2147483647)]
        [BindColumn(4, "PicImgs", "产品主图", null, "varchar(2147483647)", 100, 0, false)]
        public virtual String PicImgs
        {
            get { return _PicImgs; }
            set { if (OnPropertyChanging(__.PicImgs, value)) { _PicImgs = value; OnPropertyChanged(__.PicImgs); } }
        }

        private String _SuitCar;
        /// <summary>适用车型</summary>
        [DisplayName("适用车型")]
        [Description("适用车型")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(5, "SuitCar", "适用车型", null, "nvarchar(50)", 0, 0, true)]
        public virtual String SuitCar
        {
            get { return _SuitCar; }
            set { if (OnPropertyChanging(__.SuitCar, value)) { _SuitCar = value; OnPropertyChanged(__.SuitCar); } }
        }

        private String _CarXingHao;
        /// <summary>汽车型号</summary>
        [DisplayName("汽车型号")]
        [Description("汽车型号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn(6, "CarXingHao", "汽车型号", null, "nvarchar(50)", 0, 0, true)]
        public virtual String CarXingHao
        {
            get { return _CarXingHao; }
            set { if (OnPropertyChanging(__.CarXingHao, value)) { _CarXingHao = value; OnPropertyChanged(__.CarXingHao); } }
        }

        private String _PaiLiang;
        /// <summary>汽车排量</summary>
        [DisplayName("汽车排量")]
        [Description("汽车排量")]
        [DataObjectField(false, false, true, 2147483647)]
        [BindColumn(7, "PaiLiang", "汽车排量", null, "varchar(2147483647)", 10, 0, false)]
        public virtual String PaiLiang
        {
            get { return _PaiLiang; }
            set { if (OnPropertyChanging(__.PaiLiang, value)) { _PaiLiang = value; OnPropertyChanged(__.PaiLiang); } }
        }

        private String _FactoryYear;
        /// <summary>出厂年份</summary>
        [DisplayName("出厂年份")]
        [Description("出厂年份")]
        [DataObjectField(false, false, true, 2147483647)]
        [BindColumn(10, "FactoryYear", "出厂年份", null, "varchar(2147483647)", 10, 0, false)]
        public virtual String FactoryYear
        {
            get { return _FactoryYear; }
            set { if (OnPropertyChanging(__.FactoryYear, value)) { _FactoryYear = value; OnPropertyChanged(__.FactoryYear); } }
        }

        private Double _DisplayPrice;
        /// <summary>显示价格</summary>
        [DisplayName("显示价格")]
        [Description("显示价格")]
        [DataObjectField(false, false, true, 8)]
        [BindColumn(8, "DisplayPrice", "显示价格", null, "float", 8, 2, false)]
        public virtual Double DisplayPrice
        {
            get { return _DisplayPrice; }
            set { if (OnPropertyChanging(__.DisplayPrice, value)) { _DisplayPrice = value; OnPropertyChanged(__.DisplayPrice); } }
        }

        private Int64 _Stock;
        /// <summary>库存</summary>
        [DisplayName("库存")]
        [Description("库存")]
        [DataObjectField(false, false, true, 8)]
        [BindColumn(9, "Stock", "库存", null, "integer", 19, 0, false)]
        public virtual Int64 Stock
        {
            get { return _Stock; }
            set { if (OnPropertyChanging(__.Stock, value)) { _Stock = value; OnPropertyChanged(__.Stock); } }
        }

        private String _Content;
        /// <summary>产品详情</summary>
        [DisplayName("产品详情")]
        [Description("产品详情")]
        [DataObjectField(false, false, true, 4000)]
        [BindColumn(11, "Content", "产品详情", null, "nvarchar(4000)", 0, 0, true)]
        public virtual String Content
        {
            get { return _Content; }
            set { if (OnPropertyChanging(__.Content, value)) { _Content = value; OnPropertyChanged(__.Content); } }
        }

        private DateTime _AddTime;
        /// <summary>录入时间</summary>
        [DisplayName("录入时间")]
        [Description("录入时间")]
        [DataObjectField(false, false, true, 8)]
        [BindColumn(12, "AddTime", "录入时间", null, "datetime", 0, 0, false)]
        public virtual DateTime AddTime
        {
            get { return _AddTime; }
            set { if (OnPropertyChanging(__.AddTime, value)) { _AddTime = value; OnPropertyChanged(__.AddTime); } }
        }

        private DateTime _LastUpdateTime;
        /// <summary>最后修改时间</summary>
        [DisplayName("最后修改时间")]
        [Description("最后修改时间")]
        [DataObjectField(false, false, true, 8)]
        [BindColumn(13, "LastUpdateTime", "最后修改时间", null, "datetime", 0, 0, false)]
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
                    case __.ProductType : return _ProductType;
                    case __.PicImgs : return _PicImgs;
                    case __.SuitCar : return _SuitCar;
                    case __.CarXingHao : return _CarXingHao;
                    case __.PaiLiang : return _PaiLiang;
                    case __.FactoryYear : return _FactoryYear;
                    case __.DisplayPrice : return _DisplayPrice;
                    case __.Stock : return _Stock;
                    case __.Content : return _Content;
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
                    case __.ProductType : _ProductType = Convert.ToString(value); break;
                    case __.PicImgs : _PicImgs = Convert.ToString(value); break;
                    case __.SuitCar : _SuitCar = Convert.ToString(value); break;
                    case __.CarXingHao : _CarXingHao = Convert.ToString(value); break;
                    case __.PaiLiang : _PaiLiang = Convert.ToString(value); break;
                    case __.FactoryYear : _FactoryYear = Convert.ToString(value); break;
                    case __.DisplayPrice : _DisplayPrice = Convert.ToDouble(value); break;
                    case __.Stock : _Stock = Convert.ToInt64(value); break;
                    case __.Content : _Content = Convert.ToString(value); break;
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
            ///<summary>编号，主键</summary>
            public static readonly Field ProductID = FindByName(__.ProductID);

            ///<summary>产品名称</summary>
            public static readonly Field ProductName = FindByName(__.ProductName);

            ///<summary>产品类型，前刹车片，后刹车片等</summary>
            public static readonly Field ProductType = FindByName(__.ProductType);

            ///<summary>产品主图</summary>
            public static readonly Field PicImgs = FindByName(__.PicImgs);

            ///<summary>适用车型</summary>
            public static readonly Field SuitCar = FindByName(__.SuitCar);

            ///<summary>汽车型号</summary>
            public static readonly Field CarXingHao = FindByName(__.CarXingHao);

            ///<summary>汽车排量</summary>
            public static readonly Field PaiLiang = FindByName(__.PaiLiang);

            ///<summary>出厂年份</summary>
            public static readonly Field FactoryYear = FindByName(__.FactoryYear);

            ///<summary>显示价格</summary>
            public static readonly Field DisplayPrice = FindByName(__.DisplayPrice);

            ///<summary>库存</summary>
            public static readonly Field Stock = FindByName(__.Stock);

            ///<summary>产品详情</summary>
            public static readonly Field Content = FindByName(__.Content);

            ///<summary>录入时间</summary>
            public static readonly Field AddTime = FindByName(__.AddTime);

            ///<summary>最后修改时间</summary>
            public static readonly Field LastUpdateTime = FindByName(__.LastUpdateTime);

            static Field FindByName(String name) { return Meta.Table.FindByName(name); }
        }

        /// <summary>取得字段名称的快捷方式</summary>
        class __
        {
            ///<summary>编号，主键</summary>
            public const String ProductID = "ProductID";

            ///<summary>产品名称</summary>
            public const String ProductName = "ProductName";

            ///<summary>产品类型，前刹车片，后刹车片等</summary>
            public const String ProductType = "ProductType";

            ///<summary>产品主图</summary>
            public const String PicImgs = "PicImgs";

            ///<summary>适用车型</summary>
            public const String SuitCar = "SuitCar";

            ///<summary>汽车型号</summary>
            public const String CarXingHao = "CarXingHao";

            ///<summary>汽车排量</summary>
            public const String PaiLiang = "PaiLiang";

            ///<summary>出厂年份</summary>
            public const String FactoryYear = "FactoryYear";

            ///<summary>显示价格</summary>
            public const String DisplayPrice = "DisplayPrice";

            ///<summary>库存</summary>
            public const String Stock = "Stock";

            ///<summary>产品详情</summary>
            public const String Content = "Content";

            ///<summary>录入时间</summary>
            public const String AddTime = "AddTime";

            ///<summary>最后修改时间</summary>
            public const String LastUpdateTime = "LastUpdateTime";

        }
        #endregion
    }

    /// <summary>接口</summary>
    public partial interface IProduct
    {
        #region 属性
        /// <summary>编号，主键</summary>
        Int32 ProductID { get; set; }

        /// <summary>产品名称</summary>
        String ProductName { get; set; }

        /// <summary>产品类型，前刹车片，后刹车片等</summary>
        String ProductType { get; set; }

        /// <summary>产品主图</summary>
        String PicImgs { get; set; }

        /// <summary>适用车型</summary>
        String SuitCar { get; set; }

        /// <summary>汽车型号</summary>
        String CarXingHao { get; set; }

        /// <summary>汽车排量</summary>
        String PaiLiang { get; set; }

        /// <summary>出厂年份</summary>
        String FactoryYear { get; set; }

        /// <summary>显示价格</summary>
        Double DisplayPrice { get; set; }

        /// <summary>库存</summary>
        Int64 Stock { get; set; }

        /// <summary>产品详情</summary>
        String Content { get; set; }

        /// <summary>录入时间</summary>
        DateTime AddTime { get; set; }

        /// <summary>最后修改时间</summary>
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