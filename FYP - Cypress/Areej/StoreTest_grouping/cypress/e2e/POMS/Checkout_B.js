export class checkout {
  click() {
    //summary tab will be selected
    cy.get(".step_current > span").should(
      "have.css",
      "border-color",
      "rgb(115, 202, 119) rgb(116, 199, 118) rgb(116, 193, 117)"
    );
  }
}
