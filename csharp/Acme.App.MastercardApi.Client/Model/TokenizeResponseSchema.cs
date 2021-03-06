/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously. <br> __Authentication__ Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of: <br> 1 . A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore. <br> 2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>  An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java) <br>  __Encryption__<br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS. <br> __Additional Encryption of Sensitive Data__ In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>  Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 
 *
 * The version of the OpenAPI document: 1.2.10
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Acme.App.MastercardApi.Client.Client.OpenAPIDateConverter;

namespace Acme.App.MastercardApi.Client.Model
{
    /// <summary>
    /// TokenizeResponseSchema
    /// </summary>
    [DataContract]
    public partial class TokenizeResponseSchema :  IEquatable<TokenizeResponseSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponseSchema" /> class.
        /// </summary>
        /// <param name="responseHost">The MasterCard host that originated the request. Future calls in the same conversation may be routed to this host.  .</param>
        /// <param name="responseId">Unique identifier for the response. .</param>
        /// <param name="decision">The tokenization decision for this digitization request. Must be either APPROVED (Digitization request was approved), DECLINED (Digitization request was declined) OR REQUIRE_ADDITIONAL_AUTHENTICATION Digitization request was approved but optionally requires additional authentication. One or more Authentication methods may be provided). .</param>
        /// <param name="authenticationMethods">authenticationMethods.</param>
        /// <param name="tokenUniqueReference">The unique reference allocated to the new Token. Serves as a unique identifier for all subsequent queries or management functions relating to this Token. Provided if the decision was APPROVED or REQUIRE_ADDITIONAL_AUTHENTICATION.    __Max Length:64__ .</param>
        /// <param name="panUniqueReference">The unique reference allocated to the Account Primary Account Number. Provided if the decision was APPROVED or REQUIRE_ADDITIONAL_AUTHENTICATION.  __Max Length:64__ .</param>
        /// <param name="productConfig">productConfig.</param>
        /// <param name="tokenInfo">tokenInfo.</param>
        /// <param name="tokenDetail">tokenDetail.</param>
        public TokenizeResponseSchema(string responseHost = default(string), string responseId = default(string), string decision = default(string), List<AuthenticationMethods> authenticationMethods = default(List<AuthenticationMethods>), string tokenUniqueReference = default(string), string panUniqueReference = default(string), ProductConfig productConfig = default(ProductConfig), TokenInfo tokenInfo = default(TokenInfo), TokenDetail tokenDetail = default(TokenDetail))
        {
            this.ResponseHost = responseHost;
            this.ResponseId = responseId;
            this.Decision = decision;
            this.AuthenticationMethods = authenticationMethods;
            this.TokenUniqueReference = tokenUniqueReference;
            this.PanUniqueReference = panUniqueReference;
            this.ProductConfig = productConfig;
            this.TokenInfo = tokenInfo;
            this.TokenDetail = tokenDetail;
        }
        
        /// <summary>
        /// The MasterCard host that originated the request. Future calls in the same conversation may be routed to this host.  
        /// </summary>
        /// <value>The MasterCard host that originated the request. Future calls in the same conversation may be routed to this host.  </value>
        [DataMember(Name="responseHost", EmitDefaultValue=false)]
        public string ResponseHost { get; set; }

        /// <summary>
        /// Unique identifier for the response. 
        /// </summary>
        /// <value>Unique identifier for the response. </value>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public string ResponseId { get; set; }

        /// <summary>
        /// The tokenization decision for this digitization request. Must be either APPROVED (Digitization request was approved), DECLINED (Digitization request was declined) OR REQUIRE_ADDITIONAL_AUTHENTICATION Digitization request was approved but optionally requires additional authentication. One or more Authentication methods may be provided). 
        /// </summary>
        /// <value>The tokenization decision for this digitization request. Must be either APPROVED (Digitization request was approved), DECLINED (Digitization request was declined) OR REQUIRE_ADDITIONAL_AUTHENTICATION Digitization request was approved but optionally requires additional authentication. One or more Authentication methods may be provided). </value>
        [DataMember(Name="decision", EmitDefaultValue=false)]
        public string Decision { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationMethods
        /// </summary>
        [DataMember(Name="authenticationMethods", EmitDefaultValue=false)]
        public List<AuthenticationMethods> AuthenticationMethods { get; set; }

        /// <summary>
        /// The unique reference allocated to the new Token. Serves as a unique identifier for all subsequent queries or management functions relating to this Token. Provided if the decision was APPROVED or REQUIRE_ADDITIONAL_AUTHENTICATION.    __Max Length:64__ 
        /// </summary>
        /// <value>The unique reference allocated to the new Token. Serves as a unique identifier for all subsequent queries or management functions relating to this Token. Provided if the decision was APPROVED or REQUIRE_ADDITIONAL_AUTHENTICATION.    __Max Length:64__ </value>
        [DataMember(Name="tokenUniqueReference", EmitDefaultValue=false)]
        public string TokenUniqueReference { get; set; }

        /// <summary>
        /// The unique reference allocated to the Account Primary Account Number. Provided if the decision was APPROVED or REQUIRE_ADDITIONAL_AUTHENTICATION.  __Max Length:64__ 
        /// </summary>
        /// <value>The unique reference allocated to the Account Primary Account Number. Provided if the decision was APPROVED or REQUIRE_ADDITIONAL_AUTHENTICATION.  __Max Length:64__ </value>
        [DataMember(Name="panUniqueReference", EmitDefaultValue=false)]
        public string PanUniqueReference { get; set; }

        /// <summary>
        /// Gets or Sets ProductConfig
        /// </summary>
        [DataMember(Name="productConfig", EmitDefaultValue=false)]
        public ProductConfig ProductConfig { get; set; }

        /// <summary>
        /// Gets or Sets TokenInfo
        /// </summary>
        [DataMember(Name="tokenInfo", EmitDefaultValue=false)]
        public TokenInfo TokenInfo { get; set; }

        /// <summary>
        /// Gets or Sets TokenDetail
        /// </summary>
        [DataMember(Name="tokenDetail", EmitDefaultValue=false)]
        public TokenDetail TokenDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenizeResponseSchema {\n");
            sb.Append("  ResponseHost: ").Append(ResponseHost).Append("\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  Decision: ").Append(Decision).Append("\n");
            sb.Append("  AuthenticationMethods: ").Append(AuthenticationMethods).Append("\n");
            sb.Append("  TokenUniqueReference: ").Append(TokenUniqueReference).Append("\n");
            sb.Append("  PanUniqueReference: ").Append(PanUniqueReference).Append("\n");
            sb.Append("  ProductConfig: ").Append(ProductConfig).Append("\n");
            sb.Append("  TokenInfo: ").Append(TokenInfo).Append("\n");
            sb.Append("  TokenDetail: ").Append(TokenDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as TokenizeResponseSchema);
        }

        /// <summary>
        /// Returns true if TokenizeResponseSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenizeResponseSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenizeResponseSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseHost == input.ResponseHost ||
                    (this.ResponseHost != null &&
                    this.ResponseHost.Equals(input.ResponseHost))
                ) && 
                (
                    this.ResponseId == input.ResponseId ||
                    (this.ResponseId != null &&
                    this.ResponseId.Equals(input.ResponseId))
                ) && 
                (
                    this.Decision == input.Decision ||
                    (this.Decision != null &&
                    this.Decision.Equals(input.Decision))
                ) && 
                (
                    this.AuthenticationMethods == input.AuthenticationMethods ||
                    this.AuthenticationMethods != null &&
                    input.AuthenticationMethods != null &&
                    this.AuthenticationMethods.SequenceEqual(input.AuthenticationMethods)
                ) && 
                (
                    this.TokenUniqueReference == input.TokenUniqueReference ||
                    (this.TokenUniqueReference != null &&
                    this.TokenUniqueReference.Equals(input.TokenUniqueReference))
                ) && 
                (
                    this.PanUniqueReference == input.PanUniqueReference ||
                    (this.PanUniqueReference != null &&
                    this.PanUniqueReference.Equals(input.PanUniqueReference))
                ) && 
                (
                    this.ProductConfig == input.ProductConfig ||
                    (this.ProductConfig != null &&
                    this.ProductConfig.Equals(input.ProductConfig))
                ) && 
                (
                    this.TokenInfo == input.TokenInfo ||
                    (this.TokenInfo != null &&
                    this.TokenInfo.Equals(input.TokenInfo))
                ) && 
                (
                    this.TokenDetail == input.TokenDetail ||
                    (this.TokenDetail != null &&
                    this.TokenDetail.Equals(input.TokenDetail))
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
                if (this.ResponseHost != null)
                    hashCode = hashCode * 59 + this.ResponseHost.GetHashCode();
                if (this.ResponseId != null)
                    hashCode = hashCode * 59 + this.ResponseId.GetHashCode();
                if (this.Decision != null)
                    hashCode = hashCode * 59 + this.Decision.GetHashCode();
                if (this.AuthenticationMethods != null)
                    hashCode = hashCode * 59 + this.AuthenticationMethods.GetHashCode();
                if (this.TokenUniqueReference != null)
                    hashCode = hashCode * 59 + this.TokenUniqueReference.GetHashCode();
                if (this.PanUniqueReference != null)
                    hashCode = hashCode * 59 + this.PanUniqueReference.GetHashCode();
                if (this.ProductConfig != null)
                    hashCode = hashCode * 59 + this.ProductConfig.GetHashCode();
                if (this.TokenInfo != null)
                    hashCode = hashCode * 59 + this.TokenInfo.GetHashCode();
                if (this.TokenDetail != null)
                    hashCode = hashCode * 59 + this.TokenDetail.GetHashCode();
                return hashCode;
            }
        }
    }

}
