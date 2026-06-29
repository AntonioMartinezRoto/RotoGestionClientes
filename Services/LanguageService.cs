using System.Globalization;

namespace RotoGestionClientes;

public static class LanguageService
{
    public static string CurrentLanguage { get; private set; } = "ES";

    public static void SetLanguage(string language)
    {
        CurrentLanguage = language;

        var culture = language.ToUpper() switch
        {
            "PT" => new CultureInfo("pt-PT"),
            _ => new CultureInfo("es-ES")
        };

        Thread.CurrentThread.CurrentCulture = culture;
        Thread.CurrentThread.CurrentUICulture = culture;

        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
    }
}