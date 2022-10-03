/// <reference types = "cypress"/>
/// <reference types="cypress-downloadfile"/>
it("file upload", () => {
  cy.visit("https://trytestingthis.netlify.app/");
  cy.get("#myfile").attachFile("fyp work.PNG");
});

it("Download file", () => {
  cy.downloadFile(
    "https://upload.wikimedia.org/wikipedia/en/a/a9/Example.jpg",
    "mydownloads",
    "example.jpg"
  );
});
