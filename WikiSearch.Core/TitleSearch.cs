using OpenQA.Selenium;
using WikiSearch.DAL;

namespace WikiSearch.Core
{
    public class TitleSearch : SearchAbstract
    {
        public bool EnterSearchbox(IWebDriver driver, string searchPrompt)
        {
            bool flag = false;

            flag = Find(xPaths.searchBoxPath, driver, 1200);
            if (flag)
            {
                driver.FindElement(By.XPath(xPaths.searchBoxPath)).SendKeys(searchPrompt + "\n");
                return flag;
            }

            if (!flag)
            {
                ////            THROW ILOGGER EXCEPTION HERE
            }
            return flag;
        }
    }
}