# JWT in .NET 6

### Introduction
JSON Web Tokens (JWT) are a compact, URL-safe means of representing claims to be transferred between two parties. They are commonly used for authentication and authorization purposes in web development. JWTs consist of three parts: a header, a payload, and a signature.

### How JWT Works
1. **Header:** Contains information about how the JWT is encoded, such as the algorithm used for the signature.

2. **Payload:** Holds the claims. Claims are statements about an entity (typically, the user) and additional data.

3. **Signature:** Verifies that the sender of the JWT is who it says it is and ensures that the message wasn't changed along the way.

### Usage in .NET 6
In a .NET 6 application, you can use libraries like `Microsoft.AspNetCore.Authentication.JwtBearer` for working with JWTs. The process generally involves creating and validating tokens for secure communication between parties.

### Key Concepts
- **Claims:** These are pieces of information asserted about a subject. For example, a claim might include information about the user's role or permissions.

- **Token Issuer:** The entity that issues the JWT.

- **Token Audience:** The intended recipient of the JWT.

### Security Considerations
- Always use secure algorithms for signing JWTs.
- Be cautious about the information stored in the JWT payload, especially sensitive data.

## Technology Stack
- .NET 6

## Installation

1. **Download Project:**
   - Download the project repository from GitHub. You can do this by clicking on the "Code" button and selecting "Download ZIP."

2. **Extract Project:**
   - Extract the downloaded ZIP file to a location of your choice.

3. **Create Database:**
   - Open SQL Server Management Studio (SSMS) or your preferred SQL tool.
   - Create a new database with the name `AuthenticationDemoDB`.

4. **Open Terminal:**
   - Open a terminal or command prompt at the project folder level.

5. **Run Entity Framework Migrations:**
   - Execute the following commands to set up the database schema.
     ```bash
     dotnet ef migrations add InitialMigration
     dotnet ef database update
     ```

6. **Run the Application:**
   - Start the application by running the following command:
     ```bash
     dotnet run
     ```
   
7. **Access the Application:**
   - Open a web browser and navigate to [http://localhost:5000](http://localhost:5000) to access the running application.

**Note:** Make sure you have the .NET 6 SDK installed on your machine before running the commands. If not, you can download it from [https://dotnet.microsoft.com/download/dotnet/6.0](https://dotnet.microsoft.com/download/dotnet/6.0).

### Additional Configuration (if needed)

- Adjust database connection strings or other settings in the `appsettings.json` file if required.

- For more information on Entity Framework Core migrations, refer to [Microsoft Docs - Migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli).

**Congratulations!** You have successfully set up and run the .NET 6 application with JWT authentication.
## LinkedIn Post

I have shared a detailed walkthrough of this project on LinkedIn. Check out the post for more insights and feel free to engage in the discussion.

🔗 [LinkedIn Post - JWT in .NET 6: AuthenticationDemo]()

Feel free to connect with me on LinkedIn for more updates and discussions.

## Contact Information
For questions or feedback, contact [Ayush Rudani] at [ayushrudani9499@gmail.com].
