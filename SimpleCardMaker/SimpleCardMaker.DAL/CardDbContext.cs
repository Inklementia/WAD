﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCardMaker.DAL.DBO;

namespace SimpleCardMaker.DAL
{
    public class CardDbContext : DbContext
    {
        public CardDbContext(DbContextOptions<CardDbContext> options) : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
    }
}
