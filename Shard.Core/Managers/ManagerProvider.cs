// <copyright file="ManagerProvider.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Concurrent;
using Shard.Interfaces.Managers;

namespace Shard.Core.Managers
{
    /// <summary>
    /// Provides a container for all available managers.
    /// </summary>
    public class ManagerProvider
    {
        private readonly ConcurrentDictionary<Type, Func<IManager>> managers = new ConcurrentDictionary<Type, Func<IManager>>();

        /// <summary>
        /// Register an instance of a singletone manager.
        /// </summary>
        /// <typeparam name="T"><see cref="IManager"/> implementation.</typeparam>
        /// <param name="managerInstance">Singletone instance to register.</param>
        public void Register<T>(T managerInstance) where T : IManager
        {
            if (!managers.TryAdd(typeof(T), () => managerInstance))
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Gets manager by the specified type.
        /// </summary>
        /// <typeparam name="T">Type to resolve.</typeparam>
        /// <returns>Founded <see cref="IManager"/>.</returns>
        public T Get<T>() where T : IManager => (T)managers[typeof(T)].Invoke();
    }
}
