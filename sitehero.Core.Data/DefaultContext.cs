using Microsoft.EntityFrameworkCore;
using sitehero.Core.Data.Models;
using System.Data.Entity;

public class DefaultContext : Microsoft.EntityFrameworkCore.DbContext
{
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        #region Propriétés
        public Microsoft.EntityFrameworkCore.DbSet<Aventure> Aventure {get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Paragraphe> Paragraphe{get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Question> Question { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Reponse> Reponse { get; set; }
    #endregion
}

