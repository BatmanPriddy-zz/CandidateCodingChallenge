# Candidate Coding Challenge

Welcome to my coding challenge repository Imprivata reviewers!

At your earliest convenience, please feel free to review the above code samples related to the Coding Challenge document.  Programs were written in C# using Visual Studio 2013.

For each console application, going to briefly detail here the nuts and bolts of each one, as well as the purpose of the _Utilities_ project:

1. **_CandidateCodingChallenge1Console_**

   This console application will allow the user to enter an integer number.  Data-type will be checked to ensure value is correct.  The arrays are then concatenated together and placed in ascending order, using LINQ to perform these tasks.  Sorted/Merged array is outputted to the user.

1. **_CandidateCodingChallenge1.1Console_**

   This console application will allow the user to enter an integer number.  Data-type will be checked to ensure value is correct.  The arrays are then concatenated together and placed in ascending order, using Array Copy/Sort to perform these tasks. Sorted/Merged array is outputted to the user.

1. **_CandidateCodingChallenge2Console_**

   This console application will allow the user to enter any value they wish.  Constraint ensures that the value is greater than 0 characters, but less than 104.  Value is then determined to either be Pangram or non Pangram.  This determination is made using LINQ's _All_ method and lowercase alphabet.  1 for Pangram and 0 for non Pangram is outputted to the user, as well as an explicit message of Panagramness/non Panagramness.

1. **_CandidateCodingChallenge2.1Console_**

   This console application will allow the user to enter any value they wish.  Constraint ensures that the value is greater than 0 characters, but less than 104.  Value is then determined to either be Pangram or non Pangram.  To add some flavor, this determination is made using a generic list of integers to store the character ASCII values, and an enumerable range from 97 to 123, the ASCII equivalent of the lowercase alphabet. 1 for Pangram and 0 for non Pangram is outputted to the user, as well as an explicit message of Panagramness/non Panagramness.

1. **_CandidateCodingChallenge3Console_**

   This console application will allow jumping jack to jump a certain amount of steps.  Constraint ensures that the value is greater than 1, but less than 2001 for steps, and greater than 1, but less than 4,000,000 for the broken step.  Values are then determined for if jack can jump at all, which step will be skipped (if any) and returns the max step he can reach.  Either _Nowhere to jump my friend!_ or _The topmost step you can reach is: X_ is outputted to the user, as well as a few messages along the way.
   
1. **_CandidateCodingChallenge4Console_**

   This console application will allow clients of the World Health Organization (WHO), to determine how many people may be immunized per clinic.  Constraint ensures that the value is greater than 1, but less than 500,000 for cities, greater than 1, but less than 2,000,000 for clinics, and greater than 1, but less than 5,000,000 for each cities population.  Values are then determined for the maximum amount of people who can be immunized per clinic.  _The maximum number of people to be immunized in any single clinic is X_ is outputted to the user, as well as a few messages along the way.
   
1. **_Utilities_**

   This project is used to complement the above four console applications, by handling tasks such as writing to the console, executing the appropriate code for the console requesting it, and to centralize any potentially duplicated code.  There are **four** utility classes in this project:

   **ConsoleWriter** - Contains methods for displaying console messages
   
   **ConsoleReader** - Contains methods for reading console input, and verifying valid input

   **MergeArray** - Contains the methods for array creation, and merging/sorting of arrays either with LINQ or Array Copy/Sort 

   **PangramChecker** - Contains the methods for determining Pangramness either with explicit alphabet or ASCII enumerated range

**Pending Tasks**

1. Create Unit tests for all four coding challenges.
2. Having an MVC web application versions of the above code base would be a fun exercise!