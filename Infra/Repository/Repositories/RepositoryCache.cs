using Domain.Interfaces.InterfaceUsuario;
using Entities;
using Infra.Configuration;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository.Repositories
{
    public class RepositoryCache : RepositoryGenerics<Cache>, ICache
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryCache()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<Cache> Recente()
        {
            using (var data = new ContextBase(_OptionsBuilder))
            {
                var dataAtual = DateTime.Now;
                var result = await data.Cache.OrderByDescending(a => a.Date).FirstOrDefaultAsync();
                
                return result.Date.Subtract(dataAtual).Hours > 3 ?null : result;
            }            
        }
    }
}
