﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.Domain;

namespace TableOrder.Repository
{
    public class TableOrderMainRepository
    {
        private readonly AppDbContext _context;

        public TableOrderMainRepository()
        {
            _context = AppDbContext.Instance;
        }

        public void InsertOrder(List<MenuEntity> cart)
        {

        }

        public List<MenuEntity> GetAllMenus()
        {
            return _context.Menus.ToList();
        }
    }
}
