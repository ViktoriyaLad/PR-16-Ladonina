﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR_16_Ladonina.ApplicationData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AlisaEntities1 : DbContext
    {
        private static AlisaEntities1 _context;
        public AlisaEntities1()
            : base("name=AlisaEntities1")
        {
        }
        public static AlisaEntities1 GetContext()
        {
            if (_context == null)
                _context = new AlisaEntities1();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tovar> Tovar { get; set; }
    }
}
