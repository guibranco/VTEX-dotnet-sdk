﻿// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="EntityExtensions.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Extensions
{
    using System;
    using DataEntities;

    /// <summary>
    /// The entity extensions class.
    /// </summary>
    public static class EntityExtensions
    {
        /// <summary>
        /// Gets the name of the data entity.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>System.String.</returns>
        public static string GetDataEntityName(this Type type)
        {
            return type.GetCustomAttributes(typeof(DataEntityNameAttribute), true)
                       is DataEntityNameAttribute[] attributes && attributes.Length == 1
                ? attributes[0].EntityName
                : type.Name.ToUpper().Substring(0, 2);
        }
    }
}
