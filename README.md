***

# Comic Bookstore Management System

A C# Windows Forms desktop application for managing a comic book store. This project was built to practice Object-Oriented Programming (OOP) and file-based data management.

## Features

### Customer Role
*   **Book Catalog:** Browse books, search by title, and filter by author/genre.
*   **Shopping Cart:** Add/remove items. Carts are saved to individual text files so they stay saved even if the app is closed.
*   **Checkout:** Generates a text-file receipt and automatically updates the store's stock.

### Admin Role
*   **Inventory Management:** Full CRUD (Create, Read, Update, Delete) for the book collection.
*   **Stock Tracking:** Changes made in the Admin panel update the master inventory list in real-time.

## Data Storage
This app uses a local file system for data persistence. Data is stored in text files using a tilde (`~`) as a delimiter to separate fields.

*   `accounts.txt`: Stores login credentials and user roles.
*   `books.txt`: Stores the master inventory (Title, Author, Genre, Price, Stock).
*   `/carts/`: Folder containing user-specific cart data.
*   `/receipts/`: Folder where generated transaction receipts are stored.

## Tech Stack
*   **Language:** C#
*   **Framework:** .NET (Windows Forms)
*   **IDE:** Visual Studio

---
*This is a student project developed for a Machine Problem in Object-Oriented Programming course.*
