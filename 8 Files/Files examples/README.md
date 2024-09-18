# C# Files Examples

This project demonstrates basic file reading and string manipulation in C#. Each example illustrates different ways of reading from text files and processing their content.

## Important Setup Note: 
When working with files in this project, **don't forget to change the `Copy to Output Directory` property** of each input file to:

**`Copy always`**

This ensures that the file is copied to the Output Directory every time the application runs. The application will always start with the original version of the file.

## Example 1: Simple File Reading

This example demonstrates how to read a text file line by line using `StreamReader` in C#.

## Example 2: Parsing Data with Delimiters

In this example, each line of the file `example_2.txt` contains a first name and a last name separated by a semicolon. The program splits the line into two parts and displays the names with some padding for alignment.

## Example 3: Reading and Formatting Data from a File

This example reads a file where each line contains a person's name, height, and weight separated by semicolons. It then formats and prints the data with aligned columns for easy reading.

## Notes

- Example 3 can be expanded by modifying the code to handle multiple file formats or additional data fields.
- Ensure the file paths are correct relative to your project structure before running the examples.