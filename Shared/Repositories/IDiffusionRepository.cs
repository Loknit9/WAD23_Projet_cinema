﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Repositories
{
    public interface IDiffusionRepository<TEntity> : ICRUDRepository<TEntity, int> where TEntity : class
    {
        public IEnumerable<TEntity> GetByCinemaPlace(int id_cinemaPlace);
        public IEnumerable<TEntity> GetByMovie(int id_movie);


    }
}
