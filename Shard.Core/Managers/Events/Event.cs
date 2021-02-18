// <copyright file="Event.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using System;
using System.Collections.Generic;

namespace Shard.Core.Managers.Events
{
    /// <summary>
    /// Generic <see cref="EventBase"/>.
    /// </summary>
    /// <typeparam name="TEventarguments">Arguments type.</typeparam>
    public class Event<TEventarguments> : EventBase
    {
        private readonly List<Action<TEventarguments>> handlers = new List<Action<TEventarguments>>();

        /// <summary>
        /// Add event subscription.
        /// </summary>
        /// <param name="handler">Publish event handler.</param>
        public void Subscribe(Action<TEventarguments> handler)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            handlers.Add(handler);
        }

        /// <summary>
        /// Remove subsription handler.
        /// </summary>
        /// <param name="handler">Event handler.</param>
        public void Unsubscribe(Action<TEventarguments> handler)
        {
            if (handler is null)
            {
                throw new ArgumentNullException(nameof(handler));
            }

            handlers.Remove(handler);
        }

        /// <summary>
        /// Invokes all subsribed handlers.
        /// </summary>
        /// <param name="arguments">Event arguments.</param>
        public void Publish(TEventarguments arguments)
        {
            handlers.ForEach(handler => handler.Invoke(arguments));
        }
    }
}
