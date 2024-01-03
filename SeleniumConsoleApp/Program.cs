using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

string symbol = "SBIN";
string exchange = "nse";

string pageSource = string.Empty;
ChromeOptions options = new ChromeOptions();
var service = ChromeDriverService.CreateDefaultService();
//service.HideCommandPromptWindow = true;
//service.SuppressInitialDiagnosticInformation = true;
using (IWebDriver driver = new ChromeDriver(service, options))
{
    string url = string.Format("https://www.google.com/search?q={0}+{1}+stock+price+live", symbol.Replace("&", "%26"), exchange);
    driver.Navigate().GoToUrl(url);
    pageSource = driver.PageSource;
    driver.Close();
}
//Console.WriteLine(pageSource);