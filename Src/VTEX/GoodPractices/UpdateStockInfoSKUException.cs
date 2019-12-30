﻿// ***********************************************************************
// Assembly         : IntegracaoService.VTEX
// Author           : Guilherme Branco Stracini
// Created          : 13/04/2017
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 13/04/2017
// ***********************************************************************
// <copyright file="UpdateStockInfoSKUException.cs" company="Guilherme Branco Stracini ME">
//     © 2011-2019 Guilherme Branco Stracini, All Rights Reserved
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace VTEX.GoodPractices
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class UpdateStockInfoSKUException. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="Exception" />

    [Serializable]
    public class UpdateStockInfoSKUException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStockInfoSKUException"/> class.
        /// </summary>
        /// <param name="skuId">The sku identifier.</param>
        /// <param name="innerException">The inner exception.</param>
        public UpdateStockInfoSKUException(int skuId, Exception innerException)
            : base(string.Format(Resources.UpdateStockInfoSKUException, skuId), innerException)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStockInfoSKUException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        protected UpdateStockInfoSKUException(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
