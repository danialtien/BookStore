# E-commerce Application

Building a Book Store application.

## Functionality
- Build applications for shopping and management book store market using ASP.NET core apply MVC
model.
- Authentication and Authorization in ASP .NET Core.
- Google and Facebook Authentication/Login and Email notifications
- Stripe Payment Integrations
- Deploying website on Microsoft Azure
- Tech stack: C#.NET, Razor pages, HTML, CSS, JavaScript, Bootstrap, Stripe, Azure

## Progress and note

### 01. Get Started
### 02. Category CRUD Operations
### 03. Razor Project
### 04. N-Tier Architecture
### 05. Repository Pattern

### 06. Product CRUD
- Using DataAnotation from System.ComponentModel contributing to create Product model such as: [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#diff-4af00b3e061916c4e05cfe2777b917cf2c7260a98a1e4295f73b78f7baaaaa47)
- Using ModelBuider in ApplicationDBContext to create Seed Data [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#diff-25ebbce75971d53bb7d1035375caf103514c923272fd0258b65fa08751a1d9e8)
- Convert a Category into IEnumerable of SelectListItem using Projection [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#r125385428)
- ViewBag transfer temporary data which does not have properties to store, from Controller to View. Using ViewBag.Key = Value in Controller, using ViewBag.Key to retrieve data in View Page
- ViewData similar to ViewBag except ViewData must be type cast before use, and Key of ViewData and ViewBag must not match. Syntax ViewData["Category"] = CategoryList; and Cast Type in View page before use
- TempData
- ![](image.png)
- ViewModel is a specific for a view. Using ViewModel to tranfer data from Controller to View [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#diff-6f162dccee31550e8016359b5438d27c0f3b522c996586ac2c341a61444c0af6)
- File Upload Input in a form contain enctype="multipart/form-data", input contain type="file", using IFormFile for getting file in controller [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#r125384532)
- Using tinymce Editor [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#r125384854)
- Using IWebHostEnvironment which is the builtin function in .NET to access root folder.[HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#r125384532)
- Loading Navigation Properties using Include [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#diff-4ce819e22fdf2aab0dc75db8e9a7921c62b8474ff0a0513b540cc16c84d7b839)
- Using datatables.net plugin to search, pagination, view data table using ajax to custom column of table [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#diff-cbad95f37a7fe446afef055a47e10eda303e6c669bc39741fd8d091685baf1e7)
- Using sweetalert2.github.io for alert or confirmation popups [HERE](https://github.com/danialtien/BookStore/commit/9fba4551adac1b2786c7c308ca4b5e4a281df311#r125385847)

### 07. Home and Detail Page
- Home page and Details UI [HERE](https://github.com/danialtien/BookStore/commit/3fdcfab5ea33549b632fe87f56d64f99e44d2340)

### 08. Identity in .NET core
- .NET team handle registration, login, logout, authentication,... thanks to Scaffold Identity. Implement IdentityDBContext and add configuration base.OnModelCreating(modelBuilder) in Application DB Context [HERE](https://github.com/danialtien/BookStore/commit/372978f23c91642227366f85986302e207c2197b)
- Using CLI to generate Scaffold Identity : dotnet aspnet-codegenerator identity -dc BookStore.DataAccess.Data.ApplicationDbContext [HERE](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-7.0&tabs=netcore-cli)
- Add migration IdentityTables
- Extend [Identity User](https://github.com/danialtien/BookStore/commit/60d5e5282a78ea4ce793590e8dfdf7e7b27eced7#diff-ffa02e7fab824eb624b7ac41140316ad343aa2d026e41c2266794840c2435f84) and add more columns. In AspNetUser table, contains **Discriminator** column to define whether a user is **Application User** or **Identity User**  [HERE](https://github.com/danialtien/BookStore/commit/60d5e5282a78ea4ce793590e8dfdf7e7b27eced7#r125543401)
- To use Razor page in ASP.NET MVC need to addRazorPages and MapRazorPages in Program.cs [HERE](https://github.com/danialtien/BookStore/commit/60d5e5282a78ea4ce793590e8dfdf7e7b27eced7#diff-a1f630a45ec160b214a5b20d7658cef299880584ee273734176276fc6e3a01cb)
- Create AspNetRole(Admin, Customer, Company, Employee) if not exist [HERE](https://github.com/danialtien/BookStore/commit/60d5e5282a78ea4ce793590e8dfdf7e7b27eced7#diff-d85b3ee1c5dede79ac18239b78b090d950cd6a6582ab852857c4b612842e81d0). Fixed Invalid of [IEmailSender Error](https://github.com/danialtien/BookStore/commit/60d5e5282a78ea4ce793590e8dfdf7e7b27eced7#r125542697)
- [Assign Role on Registration](https://github.com/danialtien/BookStore/commit/8ba3b468ff3947c94f57c81aca9ee00f34b32e03#diff-d85b3ee1c5dede79ac18239b78b090d950cd6a6582ab852857c4b612842e81d0). IUserTwoFactorTokenProvider Error occur when Register and Add Role to User, because does not contain Default Token Value. [Fixed](https://github.com/danialtien/BookStore/commit/8ba3b468ff3947c94f57c81aca9ee00f34b32e03#r125581922)
- [Authorization](https://github.com/danialtien/BookStore/commit/8ba3b468ff3947c94f57c81aca9ee00f34b32e03#diff-abdf624dec6f2dbed3b90a3ec51cea2a7f8292a38cfe0ea4c9a2993cee239716). [Configure Application Cookie](https://github.com/danialtien/BookStore/commit/8ba3b468ff3947c94f57c81aca9ee00f34b32e03#r125581993)
- Update Register UI [Form]()
- Add [ManageNav]() user Profile

### 09. Company CRUD



[HELPER.md](https://www.markdownguide.org/basic-syntax)

### Contact me via tientung2029901@gmail.com or tiendoit20@gmail.com
#### Copyright &#169; 2023 danialtien

