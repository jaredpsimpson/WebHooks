﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace P112.WebHooks.Pandora
{
    /// <summary>
    /// Describes one or more event notifications received from a party supporting WebHooks generated by the ASP.NET Custom 
    /// WebHooks module. 
    /// </summary>
    public class CustomNotifications
    {
        private readonly IDictionary<string, string> _properties = new Dictionary<string, string>();
        private readonly List<IDictionary<string, object>> _notifications = new List<IDictionary<string, object>>();

        /// <summary>
        /// Gets or sets the unique ID of this WebHook message.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the number of times this message has been attempted to be delivered.
        /// </summary>
        public int Attempt { get; set; }

        /// <summary>
        /// Gets the set of additional properties included in this WebHook message.
        /// </summary>
        public IDictionary<string, string> Properties
        {
            get
            {
                return _properties;
            }
        }

        /// <summary>
        /// Gets the collection of notifications included in this WebHook message. Each notification
        /// is represented as a <see cref="Dictionary{TKey, TValue}"/> where <c>TKey</c> is a property
        /// name and <c>TValue</c> is the value of that property. For each notification, the Action 
        /// can be found using the key <c>Action</c>.
        /// </summary>
        public ICollection<IDictionary<string, object>> Notifications
        {
            get
            {
                return _notifications;
            }
        }
    }
}