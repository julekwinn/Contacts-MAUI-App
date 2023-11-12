# Contacts.Maui Application Documentation

## 1. Introduction

Contacts.Maui is a cross-platform mobile application built with .NET MAUI. Its main features include:

- Viewing a list of contacts
- Adding new contacts
- Editing existing contacts
- Deleting contacts
  

![Mai2](https://github.com/julekwinn/Contacts-MAUI-App/assets/126665165/f3341348-9e36-401f-b358-c7499129648a)


## 2. Technologies Used 🚀

The application leverages the following technologies:

- **.NET MAUI:** Cross-platform framework for building native apps.
- **C#:** Programming language for application logic.
- **XAML:** Markup language for defining the UI.
- **Microsoft.Maui.CommunityToolkit:** Toolkit providing additional controls and utilities.

## 3. Application Structure 🛠️

The application is structured into the following components:

- **Models:** Define the data structure for contacts and manage the contact collection.
- **Views:** Define UI components for displaying and interacting with contacts.
- **ViewModels:** Handle the logic and behavior of UI components.
- **AppShell:** Main application shell registering routes for navigation.
- **MauiProgram:** Configure the MauiApp and register additional services.

## 4. Getting Started 📱

To run the Contacts.Maui application:

1. Ensure the .NET MAUI development environment is set up.
2. Clone the repository.
3. Open the solution in Visual Studio or your preferred IDE.
4. Build and run the application on your chosen platform.

## 5. Contact Repository 📄

The `ContactRepository` class manages the collection of contacts and provides methods for:

- Retrieving contacts
- Updating contact information
- Adding new contacts
- Deleting existing contacts

It serves as the data source for the application.

## 6. Views and Controls 📱

### ContactControl

The `ContactControl` is a custom control used for adding and editing contact information. It includes fields for name, email, phone, and address, with validation behaviors to ensure data integrity.

### AddContactPage

The `AddContactPage` allows users to add new contacts. It utilizes the `ContactControl` for data input.

### ContactsPage

The `ContactsPage` displays a list of contacts with options to add, edit, and delete contacts.

### EditContactPage

The `EditContactPage` allows users to edit existing contacts. It pre-fills the `ContactControl` with the selected contact's information.

## 7. Shell and Navigationℹ️

The application uses the .NET MAUI Shell for navigation. Routes are registered in the `AppShell` class, enabling seamless transitions between different pages.

## 8. Building and Running 🚀

Ensure the .NET MAUI workload is installed, then build and run the application using your preferred IDE or the command line:

```shell
dotnet build
```

```shell
dotnet maui run
```
