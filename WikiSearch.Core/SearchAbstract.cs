using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WikiSearch.DAL;


namespace WikiSearch.Core
{

    public class SearchAbstract
    {
        internal _XPaths xPaths = new _XPaths();
        internal bool Find(string path, IWebDriver driver, int time)
        {
            bool flag = false;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    driver.FindElement(By.XPath((path)));
                    flag = true;
                    Task.Delay(time);
                    break;
                }
                catch (Exception)
                {
                    Task.Delay(time);
                    if (i == 9)
                    {

                    }
                }

            }

            return flag;
        }

    }
}
