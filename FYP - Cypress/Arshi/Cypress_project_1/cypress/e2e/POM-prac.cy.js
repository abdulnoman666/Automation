/// <reference types = "cypress"/>
import { prac_page } from "./pages/prac_page";
const prac = new prac_page();
it("pom", () => {
  cy.visit("http://testphp.vulnweb.com/login.php");
  prac.user("test");
  prac.pass("test");
  prac.click();
  //   cy.get(":nth-child(1) > :nth-child(2) > input").type("test");
  //   cy.get(":nth-child(2) > :nth-child(2) > input").type("test");
  //   cy.get(":nth-child(3) > td > input").click();
});
