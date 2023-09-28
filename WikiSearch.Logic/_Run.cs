using OpenQA.Selenium;
using WikiSearch.Core;

namespace WikiSearch.Logic
{
    public class RunSearch
    {
        TitleSearch titleSearch = new TitleSearch();
        ParaSearch paraSearch = new ParaSearch();
        public string _run(IWebDriver driver, string SearchPrompt)
        {
            string text= "Error";
            try
            {
                titleSearch.EnterSearchbox(driver, SearchPrompt);
                text = paraSearch.ReturnPara(driver);
            }
            catch
            {
                // I LOGGER EXCEPTION
            }
            return text;
        }

    }
}