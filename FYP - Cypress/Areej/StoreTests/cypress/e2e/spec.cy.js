describe('visit site', () => {
  it('passes', () => {
    cy.visit('http://automationpractice.com/index.php?controller=my-account')
  })
})