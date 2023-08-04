namespace EcommerceAPI.Comunes.Classes.Helpers.General
{
    public interface ICifradoHelper
    {
        string EncryptString(string plainText);
        string DecryptString(string cipherText);
    }
}
