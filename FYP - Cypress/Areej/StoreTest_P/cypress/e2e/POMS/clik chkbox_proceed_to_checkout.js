export class click_ckeckbox {
  c = ".cart_navigation > .button > span";
  click() {
    cy.get("#cgv").click();
    cy.get(this.c).click();

    //Payment Tab displays
    cy.get("#step_end > span").should("be.visible");

    //Product colum displays image of the selected product.

    // cy.get("#product_3_13_0_755067 > .cart_product > a > img").should(
    //   'be.visible'
    // );

    //Description column displays Select product description with correct size and color.
    // cy.contains("Description").should(
    //   "have.class",
    //   "#product_3_13_0_755067 > .cart_description > .product-name > a"
    // );

    cy.get(
      "#product_3_13_0_755067 > .cart_description > :nth-child(3) > a"
    ).should("contain.text", "Color : Orange, Size : S");

    //Avail column displays availability of the selected product.
    cy.get("#product_3_13_0_755067 > .cart_avail > .label").should(
      "contain.text",
      "In stock"
    );

    //Unit price will display price of one unit of selected
    cy.get("#product_3_13_0_755067 > .cart_unit").should(
      "contain.text",
      "$26.00"
    );

    //Qty column will display correct quantity.
    cy.get("#product_3_13_0_755067 > .cart_quantity").should(
      "contain.text",
      "1"
    );

    //Total will display Total amout my muliplying Unit and Qty
    // let p = cy
    //   .get("#total_product_price_3_13_755067")
    //   .should("contain.text", "$26.00");
    // let q = cy
    //   .get("#product_3_13_0_755067 > .cart_quantity > span")
    //   .should("contain.text", "1");
    // let total = parseInt(p) * parseInt(q);
    // cy.log(total);
    // cy.get("#total_product_price_3_13_755067").should("eq", total);

    //Total Products will displays amount showing up in Total Column.
    let tp = cy.get("#total_product").should("contain.text", "$56.50");

    // Total Shipping will dispay amount showed up on Shipping tab.
    let sh = cy.get("#total_shipping").should("contain.text", "$2.00");

    // Tax amount will show up.
    // let tx = cy.get("#total_tax").should("contain.text", "$0.00");

    //Grand Total will show up by adding Total Products, Total Shipping and Tax.
    // cy.get("#total_price_container").then((tp, sh) => {
    //   let sum;
    //   let a = parseFloat(tp);
    //   let b = parseFloat(sh);
    //   // c = parseFloat(tx);
    //   function sm(a, b) {
    //     return (sum = a + b);
    //   }
    //   let total = sm();
    //   cy.log("total : " + total);
    //expect(total).to.equal(58.5);
    // });
  }
}
