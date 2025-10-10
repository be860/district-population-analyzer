# District Population Analyzer

A simple C# console application to analyze district population data in **Sierra Leone**.  
The program reads a CSV file containing district names and populations, then calculates:

- The district with the **largest population**  
- The district with the **smallest population**  
- The **average population** across all districts  

---

# 📂 Project Structure
```
district-population-analyzer/
│
├─ Program.cs # Main application logic
├─ District.cs # District class
├─ district_population.csv # Sample dataset
└─ README.md
```


# ⚙️ How to Run

1. Clone the repository:
```
git clone https://github.com/YOUR_USERNAME/district-population-analyzer.git
cd district-population-analyzer
```
Build and run the application using .NET 8:
```
dotnet run
```
The program will read district_population.csv and output the results:
```
Largest: Western Area Urban (1,150,000)
Smallest: Bonthe (200,000)
Average: 463,125
```

📝 CSV Format
The CSV file must have the following structure:
```
District,Population
Western Area Urban,1150000
Bo,575000
...
```
The first row is the header and will be skipped by the program.

---

# 👨‍💻 Author
### Francis Benjamin Turay – Third-year Computer Science student passionate about software engineering, backend development, and DevOps.
### GitHub: https://github.com/be860
