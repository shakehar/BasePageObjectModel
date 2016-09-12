﻿using BasePageObjectModel;
using OpenQA.Selenium;

namespace TestPageObjectModel
{
	public class HomePage : NunitBasePage
	{
		public HomePage(IWebDriver driver) : base(driver)
		{
			SetPageUrl("/");
		}

		public string GetTitle()
		{
			return WebDriver.FindElement(By.Id("title")).Text;
		}

		public void ClickSecondPageLink()
		{
			WebDriver.FindElement(By.Id("secondPageLink")).Click();
		}
	}
}