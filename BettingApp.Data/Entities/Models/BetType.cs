﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BettingApp.Data.Entities.Models
{
    public class BetType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public ICollection<BetOffer> BetOffers { get; set; }
    }
}
