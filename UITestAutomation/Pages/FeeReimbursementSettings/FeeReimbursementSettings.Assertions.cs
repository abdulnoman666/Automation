using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestAutomation.Pages.FeeReimbursementSettings
{
    internal partial class FeeReimbursementSettings
    {
        public void AssertUIControlsOnFeeReimbursementSettingsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Add Settings":
                        FluentWaitForWebElement(AddFeeReimbursementSettings_Button);
                        break;
                    case "Delete Settings":
                        FluentWaitForWebElement(DeleteFeeReimbursementSettings_Button);
                        break;
                    case "Edit Settings":
                        FluentWaitForWebElement(EditFeeReimbursementSettings_Button);
                        break;

                }
            }
        }
        public void AssertFieldssOnAddFeeReimbursementSettingsPage(Table table)
        {
            foreach (var item in table.Rows)
            {
                switch (item[0].Trim())
                {
                    case "Refrence":
                        FluentWaitForWebElement(Reference_Field);
                        break;
                    case "Description":
                        FluentWaitForWebElement(Description_Field);
                        break;
                    case "Auto Generate GL":
                        FluentWaitForWebElement(AutoGenerateGL_CheckBox);
                        break;
                    case "Auto Fee GL Refrence":
                        FluentWaitForWebElement(AutoFeeGLReference_DropDown);
                        break;
                    case "Show On Dispute Form":
                        FluentWaitForWebElement(ShowOnDisputeForm_CheckBox);
                        break;
                    case "Create Disputes":
                        FluentWaitForWebElement(CreateDisputes_CheckBox);
                        break;
                    case "Inclue In Claims Total":
                        FluentWaitForWebElement(IncludeInClaimTotal_CheckBox);
                        break;
                    case "Save":
                        FluentWaitForWebElement(Save_Button);
                        break;
                    case "Close":
                        FluentWaitForWebElement(Close_Button);
                        break;
                }
            }
        }
    }
}