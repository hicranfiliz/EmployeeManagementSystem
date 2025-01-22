
using Microsoft.AspNetCore.Components.Authorization;

namespace ClientLibrary.Helpers;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    // bir sayfadan digerine gecildiginde kimlik dogrulamasinin yapilip yapilmadigi kontrol edilecek.
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        throw new NotImplementedException();
    }
}
