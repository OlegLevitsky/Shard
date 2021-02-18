// <copyright file="EventManager.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;
using Shard.Interfaces.Managers;

namespace Shard.Core.Managers.Events
{
    /// <summary>
    /// Provides available <see cref="EventBase"/> events.
    /// </summary>
    public class EventManager : IManager
    {
        private Dictionary<Type, EventBase> events = new Dictionary<Type, EventBase>();

        /// <summary>
        /// Get event instance.
        /// </summary>
        /// <typeparam name="T">Type of desired event.</typeparam>
        /// <returns>New or existing <see cref="EventBase"/>.</returns>
        public T GetEvent<T>() where T : EventBase, new()
        {
            var key = typeof(T);

            if (events.TryGetValue(key, out EventBase existingEvent))
            {
                return (T)existingEvent;
            }

            var newEvent = new T();
            events[key] = newEvent;
            return newEvent;
        }
    }
}
