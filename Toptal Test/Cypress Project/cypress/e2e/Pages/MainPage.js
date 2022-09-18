export class MainPage {

    //#region  elements
    getNewListTextField(){
        return cy.get('.Header > .mb-3 > .form-control')
    }

    getAddNewListButton(){
        return cy.contains('Add')
    }

    getDeleteListButton(){
        return cy.get(':nth-child(2) > .card > .card-header > .btn')
    }

    getNewListItemTextField(){
        return cy.get(':nth-child(1) > .card > .list-group > .AddToDoListItem > .mb-3 > .form-control')
    }

    getAddNewListItemButton(){
        return cy.get(':nth-child(1) > .card > .list-group > .AddToDoListItem > .mb-3 > .input-group-append > .btn')
    }

    getListItemCheckbox(){
        return cy.get(':nth-child(3) > .form-check > .form-check-input')
    }

    getDeleteListItemOption(){
        return cy.get(':nth-child(3) > .DeleteItem')
    }
//#endregion

//#region Actions
    GoToAppURL(url){
        cy.visit(url)
    }

    AssertNewListTextField(){
        this.getNewListTextField()
        .should('have.attr', 'placeholder', 'New list')
    }

    EnterValueInNewListTextField(value) {
        this.getNewListTextField().type(value)
    }

    AssertAddNewListButton(){
        this.getAddNewListButton()
        .should('have.attr', 'type','button')
    }

    ClickAddNewListButton(){
        this.getAddNewListButton().click()
    }

    AssertListDeleteButton(){
        this.getDeleteListButton()
        .should('have.attr', 'type', 'button')

        this.getDeleteListButton()
        .contains('X')
    }

    RemoveList(){
        this.getDeleteListButton().click()
    }

    AssertNewListItemTextField(){
        this.getNewListItemTextField()
        .should('have.attr', 'placeholder', 'New item')
    }

    AssertNewListItemTextFieldVisible(){
        this.getAddNewListItemButton()
        .should('be.visible')
    }

    EnterValueListItemTextField(value){
        this.getNewListItemTextField().type(value)
    }

    ClickAddNewListItemButton() {
        this.getAddNewListItemButton().click()
    }

    AssertListItemCheckboxVisible(){
        this.getListItemCheckbox()
        .should('be.visible')
    }

    CompleteListItemCheckbox() {
        this.getListItemCheckbox().check()

        cy.wait(6000)
    }

    AssertDeleteListItemVisible(){
        this.getDeleteListItemOption()
        .should('be.visible')
    }

    ClickDeleteListItemOption() {
        this.getDeleteListItemOption().click()
    }
    //#endregion
    }