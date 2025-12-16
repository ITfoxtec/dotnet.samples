# FoxIDs .NET Samples

This repository contains .NET samples used in FoxIDs blog posts, demos, and conference talks. Each sample illustrates a specific scenario for integrating .NET applications or APIs with [FoxIDs](https://www.foxids.com), including OpenID Connect, OAuth 2.0, SAML 2.0, and passwordless authentication.

The examples are intended as lightweight, easy-to-understand reference implementations that you can copy, run, or adapt for your own projects.

## Samples

### ASP.NET Core Passwordless Authentication with FoxIDs (Email OTP)
Folder: [WebAppPasswordLessEmail](WebAppPasswordLessEmail)  
This sample demonstrates how to authenticate users in an ASP.NET Core application using FoxIDs with OpenID Connect and a passwordless flow based on one-time codes sent via email.  
A detailed walkthrough is available in the Medium article: 
**[Passwordless Authentication in ASP.NET Core with FoxIDs and Email-based OTP](https://medium.com/@anders.revsgaard/passwordless-authentication-in-asp-net-core-with-foxids-and-email-based-otp-c8b85c1c80cd)**.

Key features:
- Email-based OTP login flow  
- OpenID Connect integration with FoxIDs  
- Minimal Razor Pages app (works similarly in MVC or Blazor)  
- Runs locally on https://localhost:7283  

## Get Started

1. Create a free FoxIDs tenant: https://www.foxids.com  
2. Set up an environment  
3. Open any sample in Visual Studio or with the .NET CLI  
4. Follow the README inside each sample folder  

## Documentation

Full documentation is available at: https://www.foxids.com/docs
