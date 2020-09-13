using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class PropertyContainer : IPropertyContainer
    {
        private Dictionary<string, string> propertyContainer = new Dictionary<string, string>();
        public void AddProperty(string propertyName, string value)
        {
            propertyContainer.Add(propertyName, value);
        }

        public void DeleteProperty(string propertyName)
        {
            propertyContainer.Remove(propertyName);
        }

        public string GetProperty(string propertyName)
        {
            return propertyContainer[propertyName] ?? null;
        }

        public void SetProperty(string propertyName, string value)
        {
            if (propertyContainer.ContainsKey(propertyName))
            {
                propertyContainer[propertyName] = value;
            }
            else
            {
                throw new Exception($"Key: {propertyName} does not exist !");
            }
            
        }
    }
}
