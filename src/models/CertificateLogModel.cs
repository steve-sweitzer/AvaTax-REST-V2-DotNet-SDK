using System;
using System.Collections.Generic;
using Newtonsoft.Json;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2023 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Jonathan Wenger <jonathan.wenger@avalara.com>
 * @author Sachin Baijal <sachin.baijal@avalara.com>
 * Swagger name: AvaTaxClient
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// The certificate log for a customer. This is exposed in the URL's `$includes`.
    /// </summary>
    public class CertificateLogModel
    {
        /// <summary>
        /// The unique ID number of this log entry.
        /// </summary>
        public Int64? id { get; set; }

        /// <summary>
        /// The unique ID number of this certificate.
        /// </summary>
        public Int64? certificateId { get; set; }

        /// <summary>
        /// The name of this account.
        /// </summary>
        public String account { get; set; }

        /// <summary>
        /// The log entry description.
        /// </summary>
        public String entry { get; set; }

        /// <summary>
        /// The date/time when this certificate log was created.
        /// </summary>
        public DateTime? created { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}
