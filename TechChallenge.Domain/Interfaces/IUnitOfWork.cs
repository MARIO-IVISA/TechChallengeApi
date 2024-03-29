﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Domain.Interfaces
{
    /// <summary>
    /// Interface para unidade de trabalho do repositório
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();

        #region Repositorórios
        public ICursoRepository CursoRepository { get; }
        #endregion
    }
}
