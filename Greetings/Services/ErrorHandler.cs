using Greetings.Helpers;
using Greetings.Models;
using Windows.Storage;

namespace Greetings.Services
{
    public static class ErrorHandler
    {
        public static async void Log(string errorMessage)
        {
            ErrorModel error = new ErrorModel(errorMessage);
            await ApplicationData.Current.LocalFolder.SaveErrorAsync(error);
        }
    }
}