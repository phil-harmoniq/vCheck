namespace vCheck.Lib
{
    public static class ApiUrlBuilder
    {
        public static string PackageByID(string id) =>
            string.Format(UrlTemplates.PackageByID, id);
    }
}