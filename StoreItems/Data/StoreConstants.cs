using GTLoginComponents.Repo;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json;
using static StubSite.StoreItems.Pages.ConnectReturn;
using static System.Net.WebRequestMethods;

namespace StubSite.StoreItems.Data
{
    public class StoreConstants
    {
        public static string BaseUri => true ? "https://localhost:7018/" : "https://stripeproxy.gurleytech.com/";
        public static string UserEmail { get; set; } = "";
        public static int MaxQuantity { get; set; } = 10;
        public static bool AllowPromoCodes { get; set; } = true;
        public static List<SaleItem> CartItems { get; set; } = new List<SaleItem>();

        public static async Task ClearCookieAsync(IJSRuntime jsRuntime, string name)
        {
            var test = await jsRuntime.InvokeAsync<object>("StoreClearCookie", name);
        }
        public static async Task WriteCookieAsync(IJSRuntime jsRuntime, string name, string value, double days)
        {
            var test = await jsRuntime.InvokeAsync<object>("StoreWriteCookie", name, value, days);
        }
        public static async Task<string> ReadCookies(IJSRuntime jsRuntime, string CookieName)
        {
            string response;
            try
            {
                response = await jsRuntime.InvokeAsync<string>("StoreReadCookie", CookieName);
            }
            catch (Exception e)
            {
                response = null;
            }

            return response;
        }
        public static async Task<T> SendPostAPICall<T>(HttpClient Http, string url, object value = null)
        {
            if (!string.IsNullOrEmpty(GTSAPIHandler.Token))
            {
                Http.DefaultRequestHeaders.Clear();
                Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GTSAPIHandler.Token);
            }
            else
                GTSAPIHandler.TokenInvalidated = true;

            HttpResponseMessage response = await Http.PostAsJsonAsync(url, value);

            var result = await response.Content.ReadFromJsonAsync<T>();
            return result;
        }
        public static async Task<T> SendPostAPICallNoToken<T>(HttpClient Http, string url, object value = null)
        {
            Http.DefaultRequestHeaders.Clear();
            HttpResponseMessage response = response = await Http.PostAsJsonAsync(url, value);

            var result = await response.Content.ReadFromJsonAsync<T>();
            return result;
        }
        public static async Task<T> SendUploadImage<T>(HttpClient Http, string url, MultipartFormDataContent multipartContent)
        {
            if (!string.IsNullOrEmpty(GTSAPIHandler.Token))
            {
                Http.DefaultRequestHeaders.Clear();
                Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GTSAPIHandler.Token);
            }
            else
                GTSAPIHandler.TokenInvalidated = true;

            var response = await Http.PostAsync(url, multipartContent);
            var result = await response.Content.ReadFromJsonAsync<T>();
            return result;
        }
        public static async Task<T> SendGetAPICall<T>(HttpClient Http, string url)
        {
            if (!string.IsNullOrEmpty(GTSAPIHandler.Token))
            {
                Http.DefaultRequestHeaders.Clear();
                Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GTSAPIHandler.Token);
            }
            else
                GTSAPIHandler.TokenInvalidated = true;

            return await Http.GetFromJsonAsync<T>(url);
        }

        public static async Task<T> SendDeleteAPICall<T>(HttpClient Http, string url)
        {
            if (!string.IsNullOrEmpty(GTSAPIHandler.Token))
            {
                Http.DefaultRequestHeaders.Clear();
                Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GTSAPIHandler.Token);
            }
            else
                GTSAPIHandler.TokenInvalidated = true;

            return await Http.DeleteFromJsonAsync<T>(url);
        }

        public static async Task<T> SendGetAPICallNoToken<T>(HttpClient Http, string url)
        {
            Http.DefaultRequestHeaders.Clear();
            return await Http.GetFromJsonAsync<T>(url);
        }

        public static string Pretty(double num)
        {
            string retStr = num.ToString("C", CultureInfo.CurrentCulture);

            if (Math.Round(num, 2) == 0)
                num = 0;

            return num.ToString("C", CultureInfo.CurrentCulture);
        }
        public static string Pretty(decimal num)
        {
            num = Math.Truncate(num * 100) / 100;
            string retStr = num.ToString("C", CultureInfo.CurrentCulture);

            if (Math.Round(num, 2) == 0)
                num = 0;

            return num.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
