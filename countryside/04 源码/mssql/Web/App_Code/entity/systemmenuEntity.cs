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
//             Created Time： 2012/12/31 12:29:19
// -------------------------------------------------------------
namespace BusinessEntity
{
    using System;
    using System.Collections;
    using System.Data;
    using PersistenceLayer;
    
    
    /// <summary>
    /// 实体systemmenuEntity，对应表systemmenu
    /// </summary>
    [Serializable()]
    public sealed class systemmenuEntity : EntityObject
    {
        
        /// <summary>
        /// 对应表字段AutoID
        /// </summary>
        private int m_AutoID = 0;
        
        /// <summary>
        /// 对应表字段CustomerID
        /// </summary>
        private int m_CustomerID = 0;
        
        /// <summary>
        /// 对应表字段Title
        /// </summary>
        private string m_Title = string.Empty;
        
        /// <summary>
        /// 对应表字段MenuUrl
        /// </summary>
        private string m_MenuUrl = string.Empty;
        
        /// <summary>
        /// 对应表字段Alt
        /// </summary>
        private string m_Alt = string.Empty;
        
        /// <summary>
        /// 对应表字段IsSuperAdmin
        /// </summary>
        private byte m_IsSuperAdmin = 0;
        
        /// <summary>
        /// 对应表字段IsTopMenu
        /// </summary>
        private int m_IsTopMenu = 0;
        
        /// <summary>
        /// 对应表字段TopMenuID
        /// </summary>
        private int m_TopMenuID = 0;
        
        /// <summary>
        /// 对应表字段ParentId
        /// </summary>
        private int m_ParentId = 0;
        
        /// <summary>
        /// 对应表字段Status
        /// </summary>
        private byte m_Status = 0;
        
        /// <summary>
        /// 对应表字段OrderValue
        /// </summary>
        private int m_OrderValue = 0;
        
        /// <summary>
        /// 对应表字段Remark
        /// </summary>
        private string m_Remark = string.Empty;

        /// <summary>
        /// 对应表字段MenuType
        /// </summary>
        private string m_MenuType = string.Empty;
        /// <summary>
        /// 对应表字段CreatorID
        /// </summary>
        private int m_CreatorID = 0;
        
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
        public systemmenuEntity()
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
        /// 属性Title，对应数据库字段Title
        /// </summary>
        public string Title
        {
            get
            {
                return this.m_Title;
            }
            set
            {
                this.m_Title = value;
            }
        }
        
        /// <summary>
        /// 属性MenuUrl，对应数据库字段MenuUrl
        /// </summary>
        public string MenuUrl
        {
            get
            {
                return this.m_MenuUrl;
            }
            set
            {
                this.m_MenuUrl = value;
            }
        }
        /// <summary>
        /// 属性MenuType，对应数据库字段MenuType
        /// </summary>
        public string MenuType
        {
            get
            {
                return this.m_MenuType;
            }
            set
            {
                this.m_MenuType = value;
            }
        }
        /// <summary>
        /// 属性Alt，对应数据库字段Alt
        /// </summary>
        public string Alt
        {
            get
            {
                return this.m_Alt;
            }
            set
            {
                this.m_Alt = value;
            }
        }
        
        /// <summary>
        /// 属性IsSuperAdmin，对应数据库字段IsSuperAdmin
        /// </summary>
        public byte IsSuperAdmin
        {
            get
            {
                return this.m_IsSuperAdmin;
            }
            set
            {
                this.m_IsSuperAdmin = value;
            }
        }
        
        /// <summary>
        /// 属性IsTopMenu，对应数据库字段IsTopMenu
        /// </summary>
        public int IsTopMenu
        {
            get
            {
                return this.m_IsTopMenu;
            }
            set
            {
                this.m_IsTopMenu = value;
            }
        }
        
        /// <summary>
        /// 属性TopMenuID，对应数据库字段TopMenuID
        /// </summary>
        public int TopMenuID
        {
            get
            {
                return this.m_TopMenuID;
            }
            set
            {
                this.m_TopMenuID = value;
            }
        }
        
        /// <summary>
        /// 属性ParentId，对应数据库字段ParentId
        /// </summary>
        public int ParentId
        {
            get
            {
                return this.m_ParentId;
            }
            set
            {
                this.m_ParentId = value;
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
        /// 属性Remark，对应数据库字段Remark
        /// </summary>
        public string Remark
        {
            get
            {
                return this.m_Remark;
            }
            set
            {
                this.m_Remark = value;
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
        public static systemmenuEntity GetEntityByPrimaryKey(int AutoID)
        {
            systemmenuEntity obj = new systemmenuEntity();
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
            if ((obj == null) || !(obj is systemmenuEntity))
            {
                return false;
            }
            systemmenuEntity tmpObj = (systemmenuEntity)obj;
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
            /// 表字段CustomerID
            /// </summary>
            public const string CustomerID = "CustomerID";
            
            /// <summary>
            /// 表字段Title
            /// </summary>
            public const string Title = "Title";
            
            /// <summary>
            /// 表字段MenuUrl
            /// </summary>
            public const string MenuUrl = "MenuUrl";
            
            /// <summary>
            /// 表字段Alt
            /// </summary>
            public const string Alt = "Alt";

            /// <summary>
            /// 表字段MenuType
            /// </summary>
            public const string MenuType = "MenuType";
            /// <summary>
            /// 表字段IsSuperAdmin
            /// </summary>
            public const string IsSuperAdmin = "IsSuperAdmin";
            
            /// <summary>
            /// 表字段IsTopMenu
            /// </summary>
            public const string IsTopMenu = "IsTopMenu";
            
            /// <summary>
            /// 表字段TopMenuID
            /// </summary>
            public const string TopMenuID = "TopMenuID";
            
            /// <summary>
            /// 表字段ParentId
            /// </summary>
            public const string ParentId = "ParentId";
            
            /// <summary>
            /// 表字段Status
            /// </summary>
            public const string Status = "Status";
            
            /// <summary>
            /// 表字段OrderValue
            /// </summary>
            public const string OrderValue = "OrderValue";
            
            /// <summary>
            /// 表字段Remark
            /// </summary>
            public const string Remark = "Remark";
            
            /// <summary>
            /// 表字段CreatorID
            /// </summary>
            public const string CreatorID = "CreatorID";
            
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
