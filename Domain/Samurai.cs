﻿using System;
using System.Collections.Generic;
using System.Text;

namespace testDbProject.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Quote> Quotes { get; set; }
        public Clan Clan { get; set; }
    }
}
