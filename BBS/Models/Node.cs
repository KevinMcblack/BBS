using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BBS.Models
{
    public enum IsParent
    {
        [Display(Name = "父版块")]
        Parent,
        [Display(Name = "子版块")]
        Child
    }
    public class Node
    {
        public string NodeId { get; set; }
        [Display(Name = "版块名")]
        public string Name { get; set; }
        [Display(Name = "用户Id")]
        public string UserId { get; set; }
        [Display(Name = "是否父版块")]
        public IsParent IsParent { get; set; }
        [Display(Name = "父版块Id")]
        public string ParentId { get; set; }

         //public string ParentName { get; set; }

        [Display(Name = "新增时间")]
        public DateTime AddTime { get; set; }

        public User User { get; set; }
        public ICollection<NodeRecord> NodeRecords { get; set; }
    }
}
