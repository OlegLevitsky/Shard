// <copyright file="Environment.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using Shard.Core.Managers;
using Shard.Interfaces.Managers;

namespace Shard.Core
{
    /// <summary>
    /// Provides entire infratructure for all enities.
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// Gets singletone <see cref="Environment"/> instance.
        /// </summary>
        public static Environment Instance { get; internal set; }

        /// <summary>
        /// Gets container for all registered <see cref="IManager"/>.
        /// </summary>
        public ManagerProvider Managers { get; } = new ManagerProvider();
    }
}
