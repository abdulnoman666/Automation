namespace UITestAutomation
{
    internal partial class CompanySettings
    {
        public void AssertUIControlsOnCompanySettingsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add Credit Days":
                        WaitForWebElementDisplayed(ProvisionalCreditDays_Field);
                        FluentWaitForWebElement(ProvisionalCreditDays_Field);
                        break;
                    case "Add Audit Start":
                        FluentWaitForWebElement(AuditStart_Field);
                        break;
                    case "Audit End":
                        WaitForWebElementDisplayed(AuditEnd_Field);
                        FluentWaitForWebElement(AuditEnd_Field);
                        break;
                    case "Daily GL Cut Off":
                        FluentWaitForWebElement(DailyGLCutOffTime_Field);
                        break;
                    case "Post on Saturdays":
                        FluentWaitForWebElement(PostOnSaturdays_CheckBox);
                        break;
                    case "Post 7 Days":
                        FluentWaitForWebElement(Post7DaysaWeek_CheckBox);
                        break;
                    case "Statement Date":
                        FluentWaitForWebElement(StatementDate_Field);
                        break;
                    case "Last Business Date":
                        FluentWaitForWebElement(UseLastBusinessDate_Field);
                        break;
                    case "Update Settings":
                        FluentWaitForWebElement(UpdateSettings_Field);
                        break;
                    case "Hide Address 2":
                        FluentWaitForWebElement(HideAddress2_CheckBox);
                        break;
                    case "Hide Address 3":
                        FluentWaitForWebElement(HideAddress3_CheckBox);
                        break;
                    case "Hide Address 4":
                        FluentWaitForWebElement(HideAddress4_CheckBox);
                        break;
                    case "Hide City":
                        FluentWaitForWebElement(HideCity_CheckBox);
                        break;
                    case "Hide State":
                        FluentWaitForWebElement(HideState_CheckBox);
                        break;
                    case "Hide Zip":
                        FluentWaitForWebElement(HideZip_CheckBox);
                        break;
                    case "Enable Task":
                        FluentWaitForWebElement(EnableTask_Field);
                        break;
                    case "Display Task Configuration":
                        FluentWaitForWebElement(DisplayTaskConfigurationandSections_CheckBox);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                }
            }
        }
    }
}
