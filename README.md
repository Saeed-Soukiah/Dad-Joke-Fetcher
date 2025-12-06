# DadJokeFetcher 🎉

## Overview
DadJokeFetcher is a simple C# console application that fetches random dad jokes from the [icanhazdadjoke API](https://icanhazdadjoke.com/) and displays them in the terminal.  
It demonstrates how to:
- Make HTTP requests in C#
- Handle JSON responses
- Deserialize JSON into strongly typed objects using **Newtonsoft.Json**

---

## Features
- 📡 Fetches jokes from a public API
- 🔄 Deserializes JSON into a `Rootobject` model
- 🖥️ Prints joke ID and text to the console
- 🛠️ Clean and reusable helper method for API calls

---

## Requirements
- .NET Framework or .NET Core SDK
- Newtonsoft.Json package (`Install-Package Newtonsoft.Json` via NuGet)

---

## Usage
1. Clone or download the repository.
2. Ensure you have the `Rootobject` class defined to match the API response:
   ```csharp
   public class Rootobject
   {
       public string id { get; set; }
       public string joke { get; set; }
   }
