//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HONGLI.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_PolicyHolder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdCardType { get; set; }
        public string IdCard { get; set; }
        public string IdCardFacePicUrl { get; set; }
        public string IdCardBackPicUrl { get; set; }
        public string OrganizationCode { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    }
}
