using System;
using System.Collections.Generic;
using System.Reflection;

namespace DomainNotification.Domain.Errors
{
    public abstract class ErrorLevel : IComparable
    {
        public static ErrorLevel Error = new ErrorLevel("Error");
        public static ErrorLevel Warning = new CardType(2, "Visa");
        public static ErrorLevel Information = new CardType(3, "MasterCard");

        public string Description { get; }

        protected ErrorLevel()
        {
        }

        protected ErrorLevel(string description)
        {
            Description = description;
        }

        public override string ToString()
        {
            return Description;
        }

        public static IEnumerable<T> GetAll<T>() where T : ErrorLevel, new()
        {
            var type = typeof(T);
            var fields = type.GetTypeInfo().GetFields(BindingFlags.Public |
                                                      BindingFlags.Static |
                                                      BindingFlags.DeclaredOnly);
            foreach (var info in fields)
            {
                var instance = new T();
                var locatedValue = info.GetValue(instance) as T;
                if (locatedValue != null)
                {
                    yield return locatedValue;
                }
            }
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as ErrorLevel;
            if (otherValue == null)
            {
                return false;
            }
            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Description.Equals(otherValue.Description);
            return typeMatches && valueMatches;
        }

        public int CompareTo(object other)
        {
            return string.Compare(Description, ((ErrorLevel)other).Description, StringComparison.Ordinal);
        }
    }
}