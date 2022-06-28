using HowToSpecflow.Models;
using System;
using TechTalk.SpecFlow;

namespace HowToSpecflow.StepTransforms
{
    [Binding]
    internal sealed class NullTransform
    {
        [StepArgumentTransformation(@"(null)")]
        public User GetNullUser(string text)
        {
            return null;
        }

        [StepArgumentTransformation(@"(null)")]
        public int? GetNullInt(string text)
        {
            return null;
        }

        [StepArgumentTransformation(@"(null)")]
        public DateTime? GetNullDateTime(string text)
        {
            return null;
        }

        [StepArgumentTransformation(@"(null)")]
        public object GetNullString(string text)
        {
            return null;
        }
    }
}
