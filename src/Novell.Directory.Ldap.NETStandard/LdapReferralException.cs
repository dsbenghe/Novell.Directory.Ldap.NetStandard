/******************************************************************************
* The MIT License
* Copyright (c) 2003 Novell Inc.  www.novell.com
* 
* Permission is hereby granted, free of charge, to any person obtaining  a copy
* of this software and associated documentation files (the Software), to deal
* in the Software without restriction, including  without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
* copies of the Software, and to  permit persons to whom the Software is 
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in 
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED AS IS, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*******************************************************************************/
//
// Novell.Directory.Ldap.LdapReferralException.cs
//
// Author:
//   Sunil Kumar (Sunilk@novell.com)
//
// (C) 2003 Novell, Inc (http://www.novell.com)
//

using System;
using Novell.Directory.Ldap.Utilclass;

namespace Novell.Directory.Ldap
{
    /// <summary>
    ///     Thrown when a server returns a referral and when a referral has not
    ///     been followed.  It contains a list of URL strings corresponding
    ///     to the referrals or search continuation references received on an Ldap
    ///     operation.
    /// </summary>
    public class LdapReferralException : LdapException
    {
        /// <summary>
        ///     Sets a referral that could not be processed
        /// </summary>
        /// <param name="url">
        ///     The referral URL that could not be processed.
        /// </param>
        public virtual string FailedReferral
        {
            /* Gets the referral that could not be processed.  If multiple referrals
            * could not be processed, the method returns one of them.
            *
            * @return the referral that could not be followed.
            */
            get { return failedReferral; }

            set { failedReferral = value; }
        }

        private string failedReferral;
        private string[] referrals;

        /// <summary> Constructs a default exception with no specific error information.</summary>
        public LdapReferralException()
        {
        }

        /// <summary>
        ///     Constructs a default exception with a specified string as additional
        ///     information.
        ///     This form is used for lower-level errors.
        /// </summary>
        /// <param name="message">
        ///     The additional error information.
        /// </param>
        public LdapReferralException(string message) : base(message, REFERRAL, null)
        {
        }

        /// <summary>
        ///     Constructs a default exception with a specified string as additional
        ///     information.
        ///     This form is used for lower-level errors.
        /// </summary>
        /// <param name="arguments">
        ///     The modifying arguments to be included in the
        ///     message string.
        /// </param>
        /// <param name="message">
        ///     The additional error information.
        /// </param>
        public LdapReferralException(string message, object[] arguments) : base(message, arguments, REFERRAL, null)
        {
        }

        /// <summary>
        ///     Constructs a default exception with a specified string as additional
        ///     information and an exception that indicates a failure to follow a
        ///     referral. This excepiton applies only to synchronous operations and
        ///     is thrown only on receipt of a referral when the referral was not
        ///     followed.
        /// </summary>
        /// <param name="message">
        ///     The additional error information.
        /// </param>
        /// <param name="rootException">
        ///     An exception which caused referral following to fail.
        /// </param>
        public LdapReferralException(string message, Exception rootException)
            : base(message, REFERRAL, null, rootException)
        {
        }

        /// <summary>
        ///     Constructs a default exception with a specified string as additional
        ///     information and an exception that indicates a failure to follow a
        ///     referral. This excepiton applies only to synchronous operations and
        ///     is thrown only on receipt of a referral when the referral was not
        ///     followed.
        /// </summary>
        /// <param name="message">
        ///     The additional error information.
        /// </param>
        /// <param name="arguments">
        ///     The modifying arguments to be included in the
        ///     message string.
        /// </param>
        /// <param name="rootException">
        ///     An exception which caused referral following to fail.
        /// </param>
        public LdapReferralException(string message, object[] arguments, Exception rootException)
            : base(message, arguments, REFERRAL, null, rootException)
        {
        }

        /// <summary>
        ///     Constructs an exception with a specified error string, result code, and
        ///     an error message from the server.
        /// </summary>
        /// <param name="message">
        ///     The additional error information.
        /// </param>
        /// <param name="resultCode">
        ///     The result code returned.
        /// </param>
        /// <param name="serverMessage">
        ///     Error message specifying additional information
        ///     from the server.
        /// </param>
        public LdapReferralException(string message, int resultCode, string serverMessage)
            : base(message, resultCode, serverMessage)
        {
        }

        /// <summary>
        ///     Constructs an exception with a specified error string, result code, and
        ///     an error message from the server.
        /// </summary>
        /// <param name="message">
        ///     The additional error information.
        /// </param>
        /// <param name="arguments">
        ///     The modifying arguments to be included in the
        ///     message string.
        /// </param>
        /// <param name="resultCode">
        ///     The result code returned.
        /// </param>
        /// <param name="serverMessage">
        ///     Error message specifying additional information
        ///     from the server.
        /// </param>
        public LdapReferralException(string message, object[] arguments, int resultCode, string serverMessage)
            : base(message, arguments, resultCode, serverMessage)
        {
        }

        /// <summary>
        ///     Constructs an exception with a specified error string, result code,
        ///     an error message from the server, and an exception that indicates
        ///     a failure to follow a referral.
        /// </summary>
        /// <param name="message">
        ///     The additional error information.
        /// </param>
        /// <param name="resultCode">
        ///     The result code returned.
        /// </param>
        /// <param name="serverMessage">
        ///     Error message specifying additional information
        ///     from the server.
        /// </param>
        public LdapReferralException(string message, int resultCode, string serverMessage, Exception rootException)
            : base(message, resultCode, serverMessage, rootException)
        {
        }

        /// <summary>
        ///     Constructs an exception with a specified error string, result code,
        ///     an error message from the server, and an exception that indicates
        ///     a failure to follow a referral.
        /// </summary>
        /// <param name="message">
        ///     The additional error information.
        /// </param>
        /// <param name="arguments">
        ///     The modifying arguments to be included in the
        ///     message string.
        /// </param>
        /// <param name="resultCode">
        ///     The result code returned.
        /// </param>
        /// <param name="serverMessage">
        ///     Error message specifying additional information
        ///     from the server.
        /// </param>
        public LdapReferralException(string message, object[] arguments, int resultCode, string serverMessage,
            Exception rootException) : base(message, arguments, resultCode, serverMessage, rootException)
        {
        }

        /// <summary>
        ///     Gets the list of referral URLs (Ldap URLs to other servers) returned by
        ///     the Ldap server.
        ///     The referral list may include URLs of a type other than ones for an Ldap
        ///     server (for example, a referral URL other than ldap://something).
        /// </summary>
        /// <returns>
        ///     The list of URLs that comprise this referral
        /// </returns>
        public virtual string[] getReferrals()
        {
            return referrals;
        }

        /// <summary>
        ///     Sets the list of referrals
        /// </summary>
        /// <param name="urls">
        ///     the list of referrals returned by the Ldap server in a
        ///     single response.
        /// </param>
        internal virtual void setReferrals(string[] urls)
        {
            referrals = urls;
        }

        /// <summary>
        ///     returns a string of information about the exception and the
        ///     the nested exceptions, if any.
        /// </summary>
        public override string ToString
        {
            get
            {
                string msg, tmsg;

                // Format the basic exception information
                msg = getExceptionString("LdapReferralException");

                // Add failed referral information
                if ((object)failedReferral != null)
                {
                    tmsg = ResourcesHandler.getMessage("FAILED_REFERRAL",
                        new object[] { "LdapReferralException", failedReferral });
                    // If found no string from resource file, use a default string
                    if (tmsg.ToUpper().Equals("SERVER_MSG".ToUpper()))
                    {
                        tmsg = "LdapReferralException: Failed Referral: " + failedReferral;
                    }
                    msg = msg + '\n' + tmsg;
                }

                // Add referral information, display all the referrals in the list
                if (referrals != null)
                {
                    for (var i = 0; i < referrals.Length; i++)
                    {
                        tmsg = ResourcesHandler.getMessage("REFERRAL_ITEM",
                            new object[] { "LdapReferralException", referrals[i] });
                        // If found no string from resource file, use a default string
                        if (tmsg.ToUpper().Equals("SERVER_MSG".ToUpper()))
                        {
                            tmsg = "LdapReferralException: Referral: " + referrals[i];
                        }
                        msg = msg + '\n' + tmsg;
                    }
                }
                return msg;
            }
        }
    }
}