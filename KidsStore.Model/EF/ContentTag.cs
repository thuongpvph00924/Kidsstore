namespace KidsStore.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContentTag")]
    public partial class ContentTag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ContentID { get; set; }

        [StringLength(50)]
        public string TagID { get; set; }
    }
}
