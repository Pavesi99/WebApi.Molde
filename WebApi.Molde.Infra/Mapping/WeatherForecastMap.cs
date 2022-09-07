using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Molde.Domain.Models;

namespace WebApi.Molde.Infra.Mapping
{
    public class WeatherForecastMap : IEntityTypeConfiguration<WeatherForecast>
    {
        public void Configure(EntityTypeBuilder<WeatherForecast> builder)
        {
            //Aqui é possivel mapear a tabela em casaos de banco de dados relacionais, definir quais propiedades 
            //representao quais colunas e configurações de cada propriedade no banco.

            // Mapear tabelas em casos onde se utiliza bancos de dados relacionais
            //builder.ToTable("NomeDaTabela");

            // Nesse caso a propriedade Summary representa a coluna sumario no banco de dados.No fim é 
            // especificado que essa coluna é obrigatoria.
            //builder.Property(x => x.Summary).HasColumnName("sumario").IsRequired();

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Summary).IsRequired();

        }
    }
}
