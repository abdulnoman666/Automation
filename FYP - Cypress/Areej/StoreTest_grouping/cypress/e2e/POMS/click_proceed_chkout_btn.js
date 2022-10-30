export class click_chkout_btn {
  c = ".cart_navigation > .button > span";
  click() {
    cy.get(this.c).click();
    //shipping will display
    cy.get(".step_current > span").should("be.visible");
    //shipping option will dsplay
    cy.get(".delivery_options_address").should("be.visible");
    //shipping amount will display
    cy.get("td.delivery_option_price > .delivery_option_price").should(
      "be.visible"
    );
  }
}
