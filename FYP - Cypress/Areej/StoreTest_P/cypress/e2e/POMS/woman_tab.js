export class woman_tab {
  item_1 =
    ".last-in-line.first-item-of-tablet-line > .product-container > .right-block > .button-container > .ajax_add_to_cart_button > span";
  item_2 =
    ".last-in-line.last-item-of-tablet-line > .product-container > .right-block > .button-container > .ajax_add_to_cart_button > span";
  c =
    '.sf-menu > :nth-child(1) > [href="http://automationpractice.com/index.php?id_category=3&controller=category"]';
  con = ".continue > span";
  click() {
    cy.get(this.c).click();
  }
  adding_items() {
    cy.get(this.item_1).click();

    //Pop up display about successfully added items
    cy.get(".layer_cart_product").should(
      "contain.text",
      "Product successfully added to your shopping cart"
    );
    //telling that 1 item is in cart
    cy.get("h2 > .ajax_cart_product_txt").should("contain.text", "1");

    cy.get(this.con).click();
    cy.get(this.item_2).click();

    //product desciption is visible
    cy.get(".layer_cart_product_info").should("be.visible");

    //telling product quantity
    cy.get("#layer_cart_product_quantity").should("contain.text", "1");

    //telling that 2 item is in cart
    cy.get("h2 > .ajax_cart_product_txt_s").should("contain.text", "2");

    //display total product and shipping amount
    cy.get(".layer_cart_cart > :nth-child(2)").should("be.visible");
    cy.get(".ajax_block_products_total").should("contain.text", "$56.50");
    // cy.get(":nth-child(2) > .dark").should("contain.text", "Total Products");
    cy.get(".layer_cart_cart > :nth-child(3)")
      .should("be.visible")
      .and("contain.text", "$2.00");
    //grand total amount
    cy.get(".layer_cart_cart > :nth-child(4)").should("be.visible");
    cy.get(":nth-child(4) > .ajax_block_cart_total").should(
      "have.text",
      "$58.50"
    );

    //clicking proceed to checkout button
    cy.get(".button-container > .button-medium > span").click();
  }
}
