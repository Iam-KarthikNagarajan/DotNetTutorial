using Coding_Questions;

//Write a function to calculate the sum of all elements in an array?
//int[] numbers = { 1, 2, 3, 4, 5 };

//SumOfArrayElements sumOfArrayElements = new SumOfArrayElements();
//int sum = sumOfArrayElements.CalculateSum(numbers);
//Console.WriteLine(sum); // Output: 15

//============================================================================

//Write a function to find the largest number in an array?
//int[] numbers = { 10, 7, 23, 45, 8 };

//LargestNumberFinder largestNumberFinder = new LargestNumberFinder();
//int largest = largestNumberFinder.FindLargestNumber(numbers);
//Console.WriteLine(largest); // Output: 45

//============================================================================

//Write a function to find the second largest number in an array?
//int[] numbers = { 10, 7, 23, 45, 8 };

//SecondLargestElement secondLargestElement = new SecondLargestElement();
//int secondLargest = secondLargestElement.FindSecondLargest(numbers);
//Console.WriteLine(secondLargest); // Output: 23

//============================================================================

//Write a function to merge two arrays into a single sorted array?
//int[] array1 = { 3, 5, 1, 4 };
//int[] array2 = { 8, 2, 7, 6 };

//MergeAndSortArray mergeAndSortArray = new MergeAndSortArray();
//int[] sortArray = mergeAndSortArray.MergeAndSort(array1, array2);
//Console.WriteLine(string.Join(", ", sortArray)); // Output: 1, 2, 3, 4, 5, 6, 7, 8

//============================================================================

//Write a function that returns the reverse of a string?
//string input = "Interview Happy";

//ReverseString reverseString = new ReverseString();
//string result = reverseString.ReverseStringMethod(input);
//Console.WriteLine(result); // Output: yppaH weivretnI

//============================================================================

//Write a function that checks whether a given string is a palindrome or not?
//string input = "level";

//PalindromeChecker palindromeChecker = new PalindromeChecker();
//bool isPalindrome = palindromeChecker.IsPalindrome(input);
//Console.WriteLine(isPalindrome);  // Output: True

//============================================================================

//Write a function that checks whether two strings are anagrams or not?
//string str1 = "listen";
//string str2 = "silent";

//AnagramChecker anagramChecker = new AnagramChecker();
//bool areAnagrams = anagramChecker.AreAnagrams(str1, str2);
//Console.WriteLine(areAnagrams);  // Output: True

//============================================================================

//Write a function to calculate the factorial of a number.
//int number = 5;

//Factorial factorialCalculator = new Factorial();
//long result = factorialCalculator.CalculateFactorial(number);
//Console.WriteLine(result);  // Output: 120

//============================================================================

//Write a function to calculate the Fibonacci sequence up to a given number.
int number = 7;

Fibonacic fibonacciCalculator = new Fibonacic();
fibonacciCalculator.GenerateFibonacci(number); // Output: 0, 1, 1, 2, 3, 5, 8
