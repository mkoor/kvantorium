//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kvantorium
{
    using System;
    using System.Collections.Generic;
    
    public partial class award_table
    {
        public int id_award { get; set; }
        public string name { get; set; }
        public Nullable<int> id_participant { get; set; }
        public Nullable<int> id_subdivision { get; set; }
        public Nullable<int> id_direction { get; set; }
        public Nullable<int> id_level_ev { get; set; }
        public string year { get; set; }
        public string result { get; set; }
        public Nullable<int> id_mentor { get; set; }
    
        public virtual direction_table direction_table { get; set; }
        public virtual level_table level_table { get; set; }
        public virtual mentor_table mentor_table { get; set; }
        public virtual participant_table participant_table { get; set; }
        public virtual subdivision_table subdivision_table { get; set; }
    }
}
