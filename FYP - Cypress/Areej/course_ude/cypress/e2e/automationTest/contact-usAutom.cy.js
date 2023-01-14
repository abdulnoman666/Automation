/// <reference types="cypress" />

describe("Test Contact Us form via Automation Test Store", () => {
    it("Should be able to submit a successful submission via contact us form", () => {
        cy.visit("https://www.automationteststore.com/");
        // cy.xpath("//[contains(@href, 'contact')]").click();
        cy.get("a[href$='contact']").click();
        cy.get('#ContactUsFrm_first_name').type("Areej")
        cy.get('#ContactUsFrm_email').type("iamareej6@gmail.com")
        cy.get('#ContactUsFrm_enquiry').type("i dont really have any enquiry")
        cy.get("button[title='Submit']").click();

    });
})