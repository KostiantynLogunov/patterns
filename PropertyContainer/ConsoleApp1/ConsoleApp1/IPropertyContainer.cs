namespace ConsoleApp1
{
    interface IPropertyContainer
    {
        void AddProperty(string propertyName, string value);
        void DeleteProperty(string propertyName);
        string GetProperty(string propertyName);
        void SetProperty(string propertyName, string value);
    }
}
