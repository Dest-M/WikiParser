using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WikiSearch.DAL;


namespace WikiSearch.Core
{
    public class ParaSearch : SearchAbstract
    {
        string returnPara = "";


        public string ReturnPara(IWebDriver driver)
        {
            bool flag = false;
            bool flag_;
            flag_ = Find("//img[@src='/static/images/icons/wikipedia.png']", driver, 1200);
            if (flag_)
            {
                //for (int i = 0; i < xPaths.paraPath.Count; i++)
                //{
                    flag = Find(/*xPaths.paraPath[i]*/ "//table[@class='infobox vcard']/following-sibling::p[1]", driver, 100);
                    if (flag)
                    {
                        returnPara = driver.FindElement(By.XPath((/*xPaths.paraPath[i]*/ "//table[@class='infobox vcard']/following-sibling::p[1]"))).Text;
                        return returnPara;
                    }
                //}
            }
            if (!flag || !flag_)
            {
                ////            THROW ILOGGER EXCEPTION HERE
            }
            return "XPath Error";
        }
    }
}
