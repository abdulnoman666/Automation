export class pay_bank {
  click() {
    cy.get(".bankwire").click();

    //Total amount as shown on Shipping tab.
    cy.get("#amount").should("contain.text", "$58.50").and("be.visible");

    //We allow the following currency to be sent via bank wire: Dollar
    cy.get(":nth-child(4) > b")
      .should("contain.text", "Dollar")
      .and("be.visible");

    //  Bank wire account information will be displayed on the next page.
    //  Please confirm your order by clicking "I confirm my order.".
    cy.get(".box > :nth-child(5)").should("be.visible");
  }
}
