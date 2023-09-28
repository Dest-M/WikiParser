namespace WikiSearch.DAL
{
    public class _XPaths
    {
        public List<string> paraPath = new List<string>() { @"//table[@class='infobox']/following-sibling::p[1]\", //basic
                                                            "//table[@class='infobox vcard']/following-sibling::p[1]", //person
                                                            "//table[contains(@class,'infobox vcard')]/following-sibling::p[1]",//Bands
                                                            "(//figure[@typeof='mw:File/Thumb']/following-sibling::p)[1]",
                                                            "//div[text()='Video game series']/following-sibling::p",
                                                            "//div[text()='Video game series']/following-sibling::p",
                                                            "//table[@class='infobox vevent']/following-sibling::p[1]",

                                                            "//table[contains(@class,'infobox ib-country')]/following-sibling::p[1]", //country
                                                            "//table[contains(@class,'infobox ib-settlement')]/following-sibling::p[1]", //city
                                                            "//table[contains(@class,'infobox biography')]/following-sibling::p[1]" //biography
        };
        public string searchBoxPath = @"//input[@type='search']";
    }
}