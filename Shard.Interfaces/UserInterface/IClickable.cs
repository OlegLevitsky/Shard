// <copyright file="IClickable.cs" company="Oleg Levitsky">
// Copyright (c) Oleg Levitsky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace Shard.Interfaces
{
  /// <summary>
  /// Provides element that can handle a mouse click.
  /// </summary>
  public interface IClickable
  {
    /// <summary>
    /// Invokes click.
    /// </summary>
    void Click();
  }
}
