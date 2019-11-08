// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Covenant.API.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CapturedHashCredential
    {
        /// <summary>
        /// Initializes a new instance of the CapturedHashCredential class.
        /// </summary>
        public CapturedHashCredential()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapturedHashCredential class.
        /// </summary>
        /// <param name="hashCredentialType">Possible values include: 'ntlm',
        /// 'lm', 'shA1'</param>
        /// <param name="type">Possible values include: 'password', 'hash',
        /// 'ticket'</param>
        public CapturedHashCredential(HashType? hashCredentialType = default(HashType?), string hash = default(string), int? id = default(int?), CredentialType? type = default(CredentialType?), string domain = default(string), string username = default(string))
        {
            HashCredentialType = hashCredentialType;
            Hash = hash;
            Id = id;
            Type = type;
            Domain = domain;
            Username = username;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'ntlm', 'lm', 'shA1'
        /// </summary>
        [JsonProperty(PropertyName = "hashCredentialType")]
        public HashType? HashCredentialType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hash")]
        public string Hash { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'password', 'hash', 'ticket'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public CredentialType? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

    }
}
