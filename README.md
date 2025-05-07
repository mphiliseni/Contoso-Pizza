
<img width="1439" alt="Screenshot 2025-05-07 at 15 35 49" src="https://github.com/user-attachments/assets/7633ed96-ed8b-450c-be13-9b95b2d08fbb" />

---

# Contoso Pizza - RESTful Service for Pizza Inventory Management

Welcome to the **Contoso Pizza** RESTful service! This application is designed to efficiently manage your pizza inventory, providing robust functionality for tracking, updating, and managing your pizza offerings.

---

## Features

- **Inventory Management**: Add, update, and delete pizzas from the inventory.
- **Order Tracking**: Manage customer orders and their statuses.
- **Customizable Menus**: Create menus tailored to your pizza offerings.
- **Real-Time Updates**: Ensure inventory data is always up-to-date.
- **RESTful API**: Seamless integration with third-party applications.

---

## Installation

To get started with the Contoso Pizza service, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/mphiliseni/Contoso-Pizza.git
   ```
2. Navigate to the project directory:
   ```bash
   cd Contoso-Pizza
   ```
3. Install dependencies:
   ```bash
   npm install
   ```
4. Start the server:
   ```bash
   npm start
   ```

The server will run on `http://localhost:3000` by default.

---

## API Endpoints

Here is a summary of the main API endpoints:

### Pizza Inventory
- **GET `/pizzas`** - Retrieve all pizzas in the inventory.
- **GET `/pizzas/{id}`** - Retrieve details of a specific pizza.
- **POST `/pizzas`** - Add a new pizza to the inventory.
- **PUT `/pizzas/{id}`** - Update details of an existing pizza.
- **DELETE `/pizzas/{id}`** - Remove a pizza from the inventory.

### Orders
- **GET `/orders`** - Retrieve all customer orders.
- **POST `/orders`** - Place a new order.
- **PUT `/orders/{id}`** - Update the status of an order.
- **DELETE `/orders/{id}`** - Cancel an order.

---

## Technologies Used

- **Node.js**: Backend runtime environment.
- **Express.js**: Web framework for building the RESTful APIs.
- **MongoDB**: Database for storing inventory and order data.
- **Docker**: Containerization for easy deployment.

---

## Usage

### Prerequisites
- [Node.js](https://nodejs.org/)
- [MongoDB](https://www.mongodb.com/)
- [Docker](https://www.docker.com/) (optional, for containerized deployment)

### Run Locally
1. Ensure MongoDB is running on your system.
2. Start the application by running:
   ```bash
   npm start
   ```
3. Access the API at `http://localhost:3000`.

---

## Contributing

We welcome contributions to improve the Contoso Pizza service! To contribute:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Commit your changes:
   ```bash
   git commit -m "Add your message here"
   ```
4. Push to the branch:
   ```bash
   git push origin feature/your-feature-name
   ```
5. Open a pull request.

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Contact

For any inquiries or support, please reach out to:
- **Author**: mphiliseni

---

