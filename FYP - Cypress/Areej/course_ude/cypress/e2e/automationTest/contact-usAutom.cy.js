/// <reference types="cypress" />

describe("Test Contact Us form via Automation Test Store", () => {
    it("Should be able to submit a successful submission via contact us form", () => {
        cy.visit("https://www.automationteststore.com/");
        // cy.xpath("//[contains(@href, 'contact')]").click();
        cy.get("a[href$='contact']").click();
        cy.get('#ContactUsFrm_first_name').type("Areej")
        cy.get('#ContactUsFrm_email').type("iamareej6@gmail.com")
        cy.get('#ContactUsFrm_email').should('have.attr', 'name', 'email')
        cy.get('#ContactUsFrm_enquiry').type("i dont really have any enquiry")
        cy.get("button[title='Submit']").click();
        cy.get('.mb40 > :nth-child(3)').should('have.text','Your enquiry has been successfully sent to the store owner!')
   //console.log("Test has completed");
   cy.log("Test has completed!")
    });
})