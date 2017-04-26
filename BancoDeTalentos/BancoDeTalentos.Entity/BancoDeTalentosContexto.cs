using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeTalentos.Entity
{
    public class BancoDeTalentosContexto : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mapCandidato = modelBuilder.Entity<Candidato>();
            mapCandidato.Property(x => x.IdCandidato)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mapCandidato.Property(x => x.Nome)
                .IsVariableLength()
                .IsRequired()
                .HasMaxLength(150);
            mapCandidato.Property(x => x.Cpf)
                .IsVariableLength()
                .IsRequired()
                .HasMaxLength(11);
            mapCandidato.Property(x => x.Telefone)
                .IsVariableLength()
                .HasMaxLength(15)
                .IsOptional();
            mapCandidato.Property(x => x.Email)
                .IsVariableLength()
                .IsOptional()
                .HasMaxLength(150);
            mapCandidato.HasKey(x => x.IdCandidato);
            mapCandidato.ToTable("Candidato");

                
        }

        public System.Data.Entity.DbSet<BancoDeTalentos.Candidato> Candidatoes { get; set; }
    }
}
