# SmartStockAI.Api

SmartStockAI.Api is an ASP.NET Core Web API designed to manage jewelry inventory and prepare the system for future AI-powered features.

This project is part of my AI Engineering learning path. The goal is to build a backend API with a clean layered architecture and progressively integrate artificial intelligence features.

------------------------------------------------

## Current Version

### v1.4 - Real AI Provider Integration

This version integrates the API with a real external AI provider using `HttpClient`, `User Secrets`, and secure configuration practices.

The integration was successfully validated at a technical level: the backend reaches the OpenAI API and handles provider responses correctly.

Real text generation requires a valid API key with active quota or billing enabled.

------------------------------------------------

## Version History

### v1.1 - CRUD API + Simulated AI Layer

Initial version of the jewelry inventory API with a basic simulated AI layer.

Includes:

- ASP.NET Core Web API structure
- Jewelry product CRUD
- Swagger API documentation
- Dependency Injection
- In-memory repository
- Layered architecture
- `AiController`
- `AiService`
- Simulated product description generation
- Simulated stock suggestion endpoint

------------------------------------------------

### v1.2 - Provider Abstraction, PromptBuilder, Validation and Error Handling

Refactored the AI layer and added request validation to improve the reliability and future scalability of the API.

Includes:

- `IAIProvider`
- `SimulatedAIProvider`
- `PromptBuilder`
- Product description prompt
- Marketing caption prompt
- Product story prompt
- AI provider abstraction
- Required field validation
- Minimum length validation
- Price validation
- Stock validation
- Minimum stock validation
- Currency code validation
- Automatic `400 Bad Request` responses for invalid requests

------------------------------------------------

### v1.3 - Configuration and Security

This version prepares the API for future real AI provider integration by adding a configuration layer.

Includes:

- `AIProviderSettings`
- Configuration through `appsettings.json`
- Options Pattern
- Provider name configuration
- Model name configuration
- Preparation for secure API key management
- Avoiding hardcoded secrets in code

------------------------------------------------

### v1.4 - Real AI Provider Integration

Integrated a real external AI provider using a dedicated provider class.

Includes:

- `OpenAIProvider`
- `HttpClient` integration
- OpenAI Responses API request structure
- Secure API key handling with User Secrets
- Provider error handling
- Detection of authentication and quota-related errors
- Real provider communication through `IAIProvider`

------------------------------------------------

## Version Roadmap

- v1.1 - CRUD API + Simulated AI Layer
- v1.2 - Provider Abstraction, PromptBuilder, Validation and Error Handling
- v1.3 - Configuration and Security
- v1.4 - Real AI Provider Integration
- v2.0 - Database Integration with Entity Framework
- v2.1 - Authentication and Authorization
- v2.2 - AI-generated Marketing Captions Improvement
- v2.3 - RAG or Product Knowledge Base
- v2.4 - Docker and Deployment
- v3.0 - Production-ready Release

------------------------------------------------

## Current Features

- ASP.NET Core Web API project structure
- Layered architecture
- Jewelry product CRUD
- Swagger API documentation
- Dependency Injection
- In-memory repository
- Simulated AI product description
- Simulated AI stock suggestion
- AI provider abstraction
- PromptBuilder for AI prompts
- Marketing caption endpoint
- Product story endpoint
- Request validation with Data Annotations
- Automatic validation error responses
- AI provider configuration with Options Pattern
- Secure API key handling with User Secrets
- Real external AI provider integration with `HttpClient`
- Provider error handling

------------------------------------------------

## Technologies Used

- C#
- ASP.NET Core Web API
- Swagger / Swashbuckle
- Dependency Injection
- Data Annotations
- In-memory repository
  
------------------------------------------------

## Project Purpose

The purpose of this project is to create an AI-ready inventory API for jewelry products.

The current version focuses on:


- Backend architecture
- Product inventory management
- Jewelry-specific product data
- AI provider abstraction
- Prompt engineering structure
- Request validation
- Secure configuration
- External AI provider integration
- Clean separation of responsibilities
- Future integration with production-ready AI services

------------------------------------------------

## Notes

- The current version uses an in-memory repository.
- Products are stored only while the API is running.
- If the application stops or restarts, the product list will be reset.
- Future versions will include database persistence using Entity Framework.
- The API key is not stored in `appsettings.json`.
- API keys must be configured locally using User Secrets or environment variables.
- Real AI generation requires an API key with active quota or billing enabled.
- If the provider account has insufficient quota, the API returns a provider error instead of generated text.

------------------------------------------------
## Architecture

The project follows a layered architecture:

```text
Controllers → Services → Repositories → Data
Controllers → Services → Repositories → Data

