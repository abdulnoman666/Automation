namespace UITestAutomation
{
    internal partial class Brands
    {
        public void AssertUIControlsOnBrandsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " New Case":
                        FluentWaitForWebElement(AddNewCaseBrand);
                        break;
                    case " Delete Brand":
                        FluentWaitForWebElement(DeleteBrand);
                        break;
                    case " Edit Brand":
                        FluentWaitForWebElement(EditBrand);
                        break;
                    case " Refresh":
                        FluentWaitForWebElement(RefreshIcon);
                        break;
                    case " Action":
                        FluentWaitForWebElement(ActionField);
                        break;
                    case " Brand Name":
                        FluentWaitForWebElement(BrandNameField);
                        break;
                    case " Email":
                        FluentWaitForWebElement(EmailField);
                        break;
                    case " Address":
                        FluentWaitForWebElement(AddressField);
                        break;
                    case " City":
                        FluentWaitForWebElement(CityField);
                        break;
                    case " State":
                        FluentWaitForWebElement(StateField);
                        break;
                    case " Zip":
                        FluentWaitForWebElement(ZipField);
                        break;
                    case " Phone":
                        FluentWaitForWebElement(PhoneField);
                        break;
                    case " Fax":
                        FluentWaitForWebElement(FaxField);
                        break;
                    case " Charter":
                        FluentWaitForWebElement(CharterField);
                        break;
                    case " Logo":
                        FluentWaitForWebElement(SelectLogoFileField);
                        break;
                }
            }
        }

        public void AssertFieldsonAddBrandsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case " Select Logo File":
                        FluentWaitForWebElement(SelectLogoFile);
                        break;
                    case " Brand Name ":
                        FluentWaitForWebElement(BrandName);
                        break;
                    case " Charter ":
                        FluentWaitForWebElement(Charter);
                        break;
                    case " Email":
                        FluentWaitForWebElement(Email);
                        break;
                    case " Address":
                        FluentWaitForWebElement(Address);
                        break;
                    case " City":
                        FluentWaitForWebElement(City);
                        break;
                    case " State":
                        FluentWaitForWebElement(State);
                        break;
                    case " Zip":
                        FluentWaitForWebElement(Zip);
                        break;
                    case " Phone":
                        FluentWaitForWebElement(Phone);
                        break;
                    case " Fax":
                        FluentWaitForWebElement(Fax);
                        break;
                    case " Save":
                        FluentWaitForWebElement(SaveButton);
                        break;
                    case " Close":
                        FluentWaitForWebElement(CloseButton);
                        break;
                    case " Cross":
                        FluentWaitForWebElement(CrossButton);
                        break;
                }
            }
        }
    }
}
