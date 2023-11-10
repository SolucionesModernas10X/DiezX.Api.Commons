﻿//
//  Copyright 2022  Soluciones Modernas 10x
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

namespace DiezX.Api.Commons.Utils
{
    /// <summary>
    ///  Utilidad para colecciones
    /// </summary>
    public static class CollectionUtil
    {

        /// <summary>
        /// Valida si una lista de tipo T no está vacía o nula
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsEmpty<T>(List<T> list)
        {
            return !list?.Any() ?? true;
        }

        /// <summary>
        /// Valida si una lista genérica no está vacía o nula
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsEmpty<T>(IList<T> list)
        {
            return !list?.Any() ?? true;
        }

        /// <summary>
        /// Valida si una lista enumerable no está vacía o nula
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool IsEmpty<T>(IEnumerable<T> list)
        {
            return !list?.Any() ?? true;
        }

    }

}
