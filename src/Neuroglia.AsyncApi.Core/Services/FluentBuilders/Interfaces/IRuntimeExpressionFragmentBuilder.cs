﻿/*
 * Copyright © 2021 Neuroglia SPRL. All rights reserved.
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using Neuroglia.AsyncApi.Models;

namespace Neuroglia.AsyncApi.Services.FluentBuilders
{
    /// <summary>
    /// Defines the fundamentals of a service used to build <see cref="RuntimeExpression"/> fragments
    /// </summary>
    public interface IRuntimeExpressionFragmentBuilder
    {

        /// <summary>
        /// Configures the source's path referenced by the <see cref="RuntimeExpression"/>'s fragment
        /// </summary>
        /// <param name="path">The source's path referenced by the <see cref="RuntimeExpression"/>'s fragment</param>
        void At(string path);

    }

}
