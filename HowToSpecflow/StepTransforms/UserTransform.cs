using HowToSpecflow.Models;
using System;
using TechTalk.SpecFlow;

namespace HowToSpecflow.StepTransforms
{
    [Binding]
    internal sealed class UserTransform
    {
        [StepArgumentTransformation(@"(User\d+)")]
        public User GetUser(string userText)
        {
            return userText switch
            {
                "User1" => User.User1,
                "User2" => User.User2,
                _ => throw new NotImplementedException($"User '{userText}' is not implemented. Please do it, or use other user")
            };
        }       
    }
}
