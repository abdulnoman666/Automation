Feature: LoginF

User will enter the username, password and click login button

@Login

Scenario: login_app
Given User open the browser and Enters url
When User Enter "abdul@finboa.com" in Username
And "Password@4" in Password field
Then Clicks Login button


Scenario: authenticate_login
Given Popup window appears
When Otp will be entered
Then Clicks Authenticate button