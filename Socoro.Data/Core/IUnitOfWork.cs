﻿using System;
using Socoro.Model.Core;

namespace Socoro.Data.Core
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        IRepository<T> GetEntityRepository<T>() where T : class, IIdentifier;
        R GetCustomRepository<R>() where R : class;
        void RegisterEntityRepository<E>(IRepository<E> repository) where E : class, IIdentifier;
        void RegisterCustomRepository<R>(R repository) where R : class;
    }
}
