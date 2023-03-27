Feature: Login

User will enter the username,password and click login button 

@login
Scenario: login_app
	Given User goes to DisputeDev Web Application
	And   User enters "abdul@finboa.com" in Username field on Login Page
	And   User enters "Password@4" in Password field on Login Page
	And   User clicks on Login button on Login Page
	And   User enters OTP on the Login Verification dialog
	When  User clicks on the Authenicate button on Login Verification dialog
	Then  User sholud be able to see Dashboard in Application
	    



 

   

