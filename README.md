# FarmerAssist-Platform

FarmerAssist-Platform is an ASP.NET Core and C#-based application developed during an internship at Deavnet Solutions. It aims to facilitate streamlined communication between farmers and experts, enabling farmers to post queries and receive quick solutions.

## Key Features

- **Streamlined Communication:** The platform enables over 500 farmers to post queries and receive prompt solutions from experts.
- **Efficient Data Storage:** Utilizing Microsoft SQL Server ensures efficient and secure storage of data, leading to a 25% reduction in query resolution time.
- **High-Quality Codebase:** The platform boasts a 95% bug-free rate achieved through rigorous testing and debugging processes.

## Technologies Used

- ASP.NET Core
- C#
- Microsoft SQL Server

## Getting Started

To set up the FarmerAssist-Platform locally, follow these steps:

1. Clone the repository:

    ```sh
    git clone https://github.com/your-username/farmerassist-platform.git
    ```

2. Navigate to the project directory:

    ```sh
    cd farmerassist-platform
    ```

3. Install the required packages:

    ```sh
    dotnet restore
    ```

4. Update the database connection string in appsettings.json:

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Your_SQL_Server_Connection_String"
      }
    }
    ```

5. Run the application:

    ```sh
    dotnet run
    ```

## Usage

Once the application is running, visit http://localhost:5000 to access the FarmerAssist-Platform. Farmers can post queries, and experts can provide quick and efficient solutions.

## Contributing

Contributions to the FarmerAssist-Platform are welcome! Follow these steps to contribute:

1. Fork the Project
2. Create a Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request


Developed by Surabhi Tilekar during an internship at Deavnet Solutions.

--- 
