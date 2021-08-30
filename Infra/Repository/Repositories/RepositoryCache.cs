using Domain.Interfaces.InterfaceUsuario;
using Entities;
using Infra.Configuration;
using Infra.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.Repositories
{
    public class RepositoryCache : RepositoryGenerics<Cache>, ICache
    {
        private readonly DbContextOptions<ContextBase> _optionsbuilder;
        public RepositoryCache()
        {
            _optionsbuilder = new DbContextOptions<ContextBase>();
        }
    }
}
