//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ws_service
{
    using System;
    using System.Collections.Generic;
    
    public partial class note
    {
        public int id { get; set; }
        public string subject { get; set; }
        public int notes { get; set; }
    
        public virtual student student { get; set; }
    }
}