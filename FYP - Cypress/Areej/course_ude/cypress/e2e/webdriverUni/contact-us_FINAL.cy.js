/// <reference types="cypress" />

describe("Test Contact Us form via WebdriverUni", () => {
    it.only("Should be able to submit a successful submission via contact us form", () => {
        //cypress code
        cy.visit("http://www.webdriveruniversity.com/Contact-Us/contactus.html");
        //cy.get('#contact-us').click() 
        cy.document().should('have.property','charset').and('eq', 'UTF-8')
        cy.title().should('have.string', 'WebDriver | Contact Us')
      //cy.title().should('include', 'WebDriver | Contact Us')
      cy.url().should('include', 'contactus')
        cy.get('[name="first_name"]').type("areej")
        cy.get('[name="last_name"]').type("Fatima")
        cy.get('[name="email"]').type("iamareej6@gmail.com")
        cy.get('textarea.feedback-input').type("today is january 13, 2023, 1 day since i started this udemy course")
        cy.get('[type="submit"]').click()
        cy.get('h1').should('have.text', 'Thank You for your Message!')
    });

    it("Should not be able to submit a successful submission via contact us form as all fields are required", () => {
       cy.visit("http://www.webdriveruniversity.com/Contact-Us/contactus.html");
       cy.get('[name="first_name"]').type("areej")
       cy.get('[name="last_name"]').type("Fatima")
       cy.get('textarea.feedback-input').type("today is january 13, 2023, 1 day since i started this udemy course")
       cy.get('[type="submit"]').click()
       cy.get('body').contains('Error: all fields are required')
    });
})