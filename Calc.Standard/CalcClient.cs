/*
 * Calc.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using Calc.Standard.Controllers;
using Calc.Standard.Http.Client;
using Calc.Standard.Utilities;

namespace Calc.Standard
{
    public partial class CalcClient
    {

        /// <summary>
        /// Singleton access to SimpleCalculator controller
        /// </summary>
        public SimpleCalculatorController SimpleCalculator
        {
            get
            {
                return SimpleCalculatorController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public CalcClient() { }
        #endregion
    }
}