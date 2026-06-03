using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace StubSite.StoreItems.Data
{
    public class OnboardingConstants
    {
        public static async Task<bool> CheckStatus(string email, NavigationManager NavMan, IJSRuntime jsRuntime, HttpClient Http)
        {
            string tokenStr = await StoreConstants.ReadCookies(jsRuntime, "TOKEN");
            if (!string.IsNullOrEmpty(tokenStr))
            {
                StoreConstants.UserEmail = email;

                try
                {
                    var response = await StoreConstants.SendGetAPICall<AccountStatusResponse>(Http, $"{StoreConstants.BaseUri}api/stripe/account-status");
                    if (response != null)
                    {
                        return response.ChargesEnabled && response.DetailsSubmitted;
                    }
                }
                catch
                {
                    // fallback: assume incomplete
                    return false;
                }
            }
            else
                NavMan.NavigateTo("account");

            return false;
        }

        public static async Task<AccountStatusResponse> CheckReasonStatus(NavigationManager NavMan, HttpClient Http)
        {
            AccountStatusResponse response = new AccountStatusResponse();
            response.Reason = "Token not set";

            try
            {
                var TempResponse = await StoreConstants.SendGetAPICall<AccountStatusResponse>(Http, $"{StoreConstants.BaseUri}api/stripe/account-status");
                if (TempResponse != null)
                {
                    return TempResponse;
                }
            }
            catch
            {
                // fallback: assume incomplete
                response.Reason = "Unable to access API";
            }

            return response;
        }
        public static async Task<string> GenerateOnboardingLink(NavigationManager NavMan, HttpClient Http)
        {
            OnboardingLinkResponse result = await StoreConstants.SendPostAPICall<OnboardingLinkResponse>(Http, $"{StoreConstants.BaseUri}api/stripe/reauth-link", new
            {
                Email = "none",
                RefreshUrl = NavMan.BaseUri + $"reauth?Email={StoreConstants.UserEmail}",
                ReturnUrl = NavMan.BaseUri + $"connect/return?Email={StoreConstants.UserEmail}"
            });

            if (result?.Url != null)
            {
                return result.Url;
            }

            return "";
        }
    }
    public class AccountStatusResponse
    {
        public bool Success { get; set; }
        public bool ChargesEnabled { get; set; }
        public bool DetailsSubmitted { get; set; }
        public string Reason { get; set; }
        public bool FullySetup => ChargesEnabled && DetailsSubmitted;
    }

    public class OnboardingLinkResponse
    {
        public bool Success { get; set; }
        public string Reason { get; set; }
        public string Url { get; set; }
    }
}
