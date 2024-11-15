class CheckoutPage {

    checkoutOrder() {
        /**
         * TODO: implement the method so that it actually fills the form and completes the order.
         */
        cy.get('h2.complete-header')
            .should('be.visible')
            .should('have.text', 'Thank you for your order!')
    }
}

export default CheckoutPage