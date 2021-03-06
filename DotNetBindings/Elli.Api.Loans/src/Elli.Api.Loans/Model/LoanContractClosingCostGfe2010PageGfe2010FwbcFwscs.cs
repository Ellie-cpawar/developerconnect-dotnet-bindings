/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs :  IEquatable<LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Fwbc
        /// </summary>
        [DataMember(Name="fwbc", EmitDefaultValue=false)]
        public string Fwbc { get; set; }

        /// <summary>
        /// Gets or Sets Fwsc
        /// </summary>
        [DataMember(Name="fwsc", EmitDefaultValue=false)]
        public string Fwsc { get; set; }

        /// <summary>
        /// Gets or Sets Gfe2010FwbcFwscIndex
        /// </summary>
        [DataMember(Name="gfe2010FwbcFwscIndex", EmitDefaultValue=false)]
        public int? Gfe2010FwbcFwscIndex { get; set; }

        /// <summary>
        /// Gets or Sets LineLetter
        /// </summary>
        [DataMember(Name="lineLetter", EmitDefaultValue=false)]
        public string LineLetter { get; set; }

        /// <summary>
        /// Gets or Sets LineNumber
        /// </summary>
        [DataMember(Name="lineNumber", EmitDefaultValue=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Fwbc: ").Append(Fwbc).Append("\n");
            sb.Append("  Fwsc: ").Append(Fwsc).Append("\n");
            sb.Append("  Gfe2010FwbcFwscIndex: ").Append(Gfe2010FwbcFwscIndex).Append("\n");
            sb.Append("  LineLetter: ").Append(LineLetter).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs);
        }

        /// <summary>
        /// Returns true if LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Fwbc == input.Fwbc ||
                    (this.Fwbc != null &&
                    this.Fwbc.Equals(input.Fwbc))
                ) && 
                (
                    this.Fwsc == input.Fwsc ||
                    (this.Fwsc != null &&
                    this.Fwsc.Equals(input.Fwsc))
                ) && 
                (
                    this.Gfe2010FwbcFwscIndex == input.Gfe2010FwbcFwscIndex ||
                    (this.Gfe2010FwbcFwscIndex != null &&
                    this.Gfe2010FwbcFwscIndex.Equals(input.Gfe2010FwbcFwscIndex))
                ) && 
                (
                    this.LineLetter == input.LineLetter ||
                    (this.LineLetter != null &&
                    this.LineLetter.Equals(input.LineLetter))
                ) && 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Fwbc != null)
                    hashCode = hashCode * 59 + this.Fwbc.GetHashCode();
                if (this.Fwsc != null)
                    hashCode = hashCode * 59 + this.Fwsc.GetHashCode();
                if (this.Gfe2010FwbcFwscIndex != null)
                    hashCode = hashCode * 59 + this.Gfe2010FwbcFwscIndex.GetHashCode();
                if (this.LineLetter != null)
                    hashCode = hashCode * 59 + this.LineLetter.GetHashCode();
                if (this.LineNumber != null)
                    hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
