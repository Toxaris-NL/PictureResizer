using System.IO;

namespace PictureResizer
{
    public static class support
    {
        public static string CreateTargetFilename(string originalName)
        {
            return Path.GetDirectoryName(originalName) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(originalName) + "_new" + Path.GetExtension(originalName);
        }

        public static bool ValidInteger(string value, out string errorMessage)
        {
            if (value.Length == 0)
            {
                errorMessage = "Value is required";
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(value, "[^0-9]"))
            {
                errorMessage = "Please enter only numbers";
                return false;
            }
            else
            {
                errorMessage = string.Empty;
                return true;
            }
        }
    }
}