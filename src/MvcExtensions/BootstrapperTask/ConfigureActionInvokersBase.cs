﻿#region Copyright
// Copyright (c) 2009 - 2010, Kazi Manzur Rashid <kazimanzurrashid@gmail.com>.
// This source is subject to the Microsoft Public License. 
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL. 
// All other rights reserved.
#endregion

namespace MvcExtensions
{
    using System.Web.Mvc;

    /// <summary>
    /// Defines a class to configure <seealso cref="IActionInvoker"/> for <see cref="Controller"/>.
    /// </summary>
    public abstract class ConfigureActionInvokersBase : BootstrapperTask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureActionInvokersBase"/> class.
        /// </summary>
        /// <param name="registry">The registry.</param>
        protected ConfigureActionInvokersBase(IActionInvokerRegistry registry)
        {
            Invariant.IsNotNull(registry, "registry");

            Registry = registry;
        }

        /// <summary>
        /// Gets the registry.
        /// </summary>
        /// <value>The registry.</value>
        public IActionInvokerRegistry Registry
        {
            get;
            private set;
        }

        /// <summary>
        /// Executes the task.
        /// </summary>
        /// <returns></returns>
        public override TaskContinuation Execute()
        {
            Configure();

            return TaskContinuation.Continue;
        }

        /// <summary>
        /// Configures the action invokers.
        /// </summary>
        protected abstract void Configure();
    }
}