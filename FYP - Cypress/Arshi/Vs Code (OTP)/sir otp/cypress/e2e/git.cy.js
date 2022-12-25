///<reference types= 'cypress'/>
import { login } from "./POM/login";
const log = new login();

describe("OTP", () => {
  it("Login with OTP", () => {
    cy.visit("https://disputedev.azurewebsites.net/#/login");
    log.username("abdul@finboa.com");
    log.password("Password@3");

    log.click();
    cy.wait(10000);
  });
});
