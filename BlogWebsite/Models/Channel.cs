﻿using System;
using System.Collections.Generic;

namespace BlogWebsite.Models
{
    public partial class Channel
    {
        public Channel()
        {
            Files = new HashSet<Files>();
            RelationShip = new HashSet<RelationShip>();
        }

        public string CId { get; set; }
        public string COwnerId { get; set; }
        public string CName { get; set; }
        public int? CFollowers { get; set; }
        public int? CTotalWatch { get; set; }

        public Users COwner { get; set; }
        public ICollection<Files> Files { get; set; }
        public ICollection<RelationShip> RelationShip { get; set; }
    }
}
