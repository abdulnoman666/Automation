export class proceed_cchkbtn {
  c = ".cart_navigation > .button > span";
  click() {
    cy.get(this.c).click();

    //correct delivery address and update btn
    cy.get("#address_delivery").should(
      "contain.text",
      "Your delivery addressarshi amirDK 534 Rawalpindi Rawalpindi, Pennsylvania 46300United States1234567"
    );
    cy.get("#address_delivery > .address_update").should("be.visible");

    //correct invoice address and update btn
    cy.get("#address_invoice").should(
      "contain.text",
      "Your billing addressarshi amirDK 534 Rawalpindi Rawalpindi, Pennsylvania 46300United States1234567Update"
    );
    cy.get("#address_invoice > .address_update").should("be.visible");
    //checkbox is checked
    cy.get("#addressesAreEquals").should("be.checked");
    //cy.get("select#id_address_delivery.address_select.form-control").should(
    //   "be.selected" );
  }
}
