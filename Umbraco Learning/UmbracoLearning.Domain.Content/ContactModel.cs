
using System.ComponentModel.DataAnnotations;

namespace Umbraco_Learning.UmbracoLearning.Domain.Content
{
    public class ContactModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string Message { get; set; }

    }
}