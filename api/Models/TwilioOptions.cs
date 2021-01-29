namespace api.Models
{
    public record TwilioOptions
    {
        public const string OPTIONS_VALUE = "Values:Twilio";

        public string AccountSid {get;set;}
        public string AuthToken {get;set;}
        public string PhoneNumber {get;set;}
    }
}