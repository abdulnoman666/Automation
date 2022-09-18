import { MainPage } from "./Pages/MainPage"



describe('List Creation', () => {

    const mainPage = new MainPage()

    it('Go to Application', () => {
      mainPage.GoToAppURL('http://localhost:3030')
    })

    it('Add A List', () => {
        
        mainPage.AssertNewListTextField()

        mainPage.EnterValueInNewListTextField('List 2')

        mainPage.AssertAddNewListButton()

        mainPage.ClickAddNewListButton()
      })

      it('Remove A List', () => {

        mainPage.AssertListDeleteButton()

        mainPage.RemoveList()
      })

      it('Add A Item List', () => {
        
        mainPage.AssertNewListItemTextField()

        mainPage.AssertNewListItemTextFieldVisible()

        mainPage.EnterValueListItemTextField('List Item')

        mainPage.ClickAddNewListItemButton()
      })

      it('Complete Item List', () => {

        mainPage.AssertListItemCheckboxVisible()

        mainPage.CompleteListItemCheckbox()
      })

      it('In-Complete Item List', () => {

        mainPage.AssertDeleteListItemVisible()

        mainPage.ClickDeleteListItemOption()
      })
  })