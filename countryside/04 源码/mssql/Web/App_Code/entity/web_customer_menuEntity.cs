﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.4971
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// -------------------------------------------------------------
//             Created By： Administrator
//             Created Time： 2013/5/27 16:10:15
// -------------------------------------------------------------
namespace BusinessEntity
{
    using System;
    using System.Collections;
    using System.Data;
    using PersistenceLayer;
    
    
    /// <summary>
    /// 实体web_customer_menuEntity，对应表web_customer_menu
    /// </summary>
    [Serializable()]
    public sealed class web_customer_menuEntity : EntityObject
    {
        
        /// <summary>
        /// 对应表字段AutoID
        /// </summary>
        private int m_AutoID = 0;
        
        /// <summary>
        /// 对应表字段MenuID
        /// </summary>
        private int m_MenuID = 0;
        
        /// <summary>
        /// 对应表字段CustomerID
        /// </summary>
        private int m_CustomerID = 0;
        
        /// <summary>
        /// 对应表字段CreatorID
        /// </summary>
        private int m_CreatorID = 0;
        
        /// <summary>
        /// 对应表字段Status
        /// </summary>
        private byte m_Status = 0;
        
        /// <summary>
        /// 对应表字段OrderValue
        /// </summary>
        private int m_OrderValue = 0;
        
        /// <summary>
        /// 对应表字段CreateDate
        /// </summary>
        private System.DateTime m_CreateDate = DateTime.MinValue;
        
        /// <summary>
        /// 对应表字段Modifier
        /// </summary>
        private int m_Modifier = 0;
        
        /// <summary>
        /// 对应表字段ModifyDate
        /// </summary>
        private System.DateTime m_ModifyDate = DateTime.MinValue;
        
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public web_customer_menuEntity()
        {
        }
        
        /// <summary>
        /// 属性AutoID，对应数据库字段AutoID
        /// </summary>
        public int AutoID
        {
            get
            {
                return this.m_AutoID;
            }
            set
            {
                this.m_AutoID = value;
            }
        }
        
        /// <summary>
        /// 属性MenuID，对应数据库字段MenuID
        /// </summary>
        public int MenuID
        {
            get
            {
                return this.m_MenuID;
            }
            set
            {
                this.m_MenuID = value;
            }
        }
        
        /// <summary>
        /// 属性CustomerID，对应数据库字段CustomerID
        /// </summary>
        public int CustomerID
        {
            get
            {
                return this.m_CustomerID;
            }
            set
            {
                this.m_CustomerID = value;
            }
        }
        
        /// <summary>
        /// 属性CreatorID，对应数据库字段CreatorID
        /// </summary>
        public int CreatorID
        {
            get
            {
                return this.m_CreatorID;
            }
            set
            {
                this.m_CreatorID = value;
            }
        }
        
        /// <summary>
        /// 属性Status，对应数据库字段Status
        /// </summary>
        public byte Status
        {
            get
            {
                return this.m_Status;
            }
            set
            {
                this.m_Status = value;
            }
        }
        
        /// <summary>
        /// 属性OrderValue，对应数据库字段OrderValue
        /// </summary>
        public int OrderValue
        {
            get
            {
                return this.m_OrderValue;
            }
            set
            {
                this.m_OrderValue = value;
            }
        }
        
        /// <summary>
        /// 属性CreateDate，对应数据库字段CreateDate
        /// </summary>
        public System.DateTime CreateDate
        {
            get
            {
                return this.m_CreateDate;
            }
            set
            {
                this.m_CreateDate = value;
            }
        }
        
        /// <summary>
        /// 属性Modifier，对应数据库字段Modifier
        /// </summary>
        public int Modifier
        {
            get
            {
                return this.m_Modifier;
            }
            set
            {
                this.m_Modifier = value;
            }
        }
        
        /// <summary>
        /// 属性ModifyDate，对应数据库字段ModifyDate
        /// </summary>
        public System.DateTime ModifyDate
        {
            get
            {
                return this.m_ModifyDate;
            }
            set
            {
                this.m_ModifyDate = value;
            }
        }
        
        /// <summary>
        /// 静态方法，根据主键来获取实体,如果没有获取到则返回null
        /// </summary>
        public static web_customer_menuEntity GetEntityByPrimaryKey(int AutoID)
        {
            web_customer_menuEntity obj = new web_customer_menuEntity();
            obj.AutoID=AutoID;
            obj.Retrieve();
            if (obj.IsPersistent)
            {
                return obj;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// 重新OnEuqal方法，通过主键来判断
        /// </summary>
        public override bool Equals(object obj)
        {
            if ((obj == null) || !(obj is web_customer_menuEntity))
            {
                return false;
            }
            web_customer_menuEntity tmpObj = (web_customer_menuEntity)obj;
            if ((this.m_AutoID == tmpObj.m_AutoID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// 重新GetHashCode方法，主键的Hash值累积
        /// </summary>
        public override int GetHashCode()
        {
             return this.m_AutoID.GetHashCode();
        }
        
        /// <summary>
        /// 表字段结构，封装了实体对应数据表的所有字段
        /// </summary>
        public struct Columns
        {
            
            /// <summary>
            /// 表字段AutoID
            /// </summary>
            public const string AutoID = "AutoID";
            
            /// <summary>
            /// 表字段MenuID
            /// </summary>
            public const string MenuID = "MenuID";
            
            /// <summary>
            /// 表字段CustomerID
            /// </summary>
            public const string CustomerID = "CustomerID";
            
            /// <summary>
            /// 表字段CreatorID
            /// </summary>
            public const string CreatorID = "CreatorID";
            
            /// <summary>
            /// 表字段Status
            /// </summary>
            public const string Status = "Status";
            
            /// <summary>
            /// 表字段OrderValue
            /// </summary>
            public const string OrderValue = "OrderValue";
            
            /// <summary>
            /// 表字段CreateDate
            /// </summary>
            public const string CreateDate = "CreateDate";
            
            /// <summary>
            /// 表字段Modifier
            /// </summary>
            public const string Modifier = "Modifier";
            
            /// <summary>
            /// 表字段ModifyDate
            /// </summary>
            public const string ModifyDate = "ModifyDate";
        }
    }
}
