# LinqTutorial

Hello! 

My name is Krystyna and welcome to my GitHub.

This repository is part of my  "LINQ Tutorial: Master the Key C# Library" course, which you can find under this link: https://www.udemy.com/course/linq-tutorial-master-the-key-csharp-library/?referralCode=384B340D233F12F6A498

## FAQ:

### Q1: How do I download the files?
A: If you're not familiar with GitHub and just want to download the entire solution, click the green button saying "Code", and then select the "Download ZIP".

### Q2: What are the projects in this solution?
A: The solution consists of 4 main projects:
#### LinqTutorial
Contains the code shown in the course's videos.
#### Exercises
Contains coding exercises that you can solve to practice LINQ.
#### ExercisesSolutions
Contains solved versions of the coding exercises. You can take a look at them to check how some exercise can be solved.
#### ExercisesTests
Contains unit tests which validate if your solutions of exercises are correct (the solutions from the Exercises project are validated).

### Q3: How to approach solving coding exercises?
Let's say you want to practice using the Any method from LINQ. Go to Exercises project and open Any.cs file. 

If you want to solve coding exercise 1, find the method with a comment describing what this method should do.

Before you solve the exercise, you can run unit tests that validate if it is correct. To do it, build the solution first. Then you can click on Test in the top menu of Visual Studio, and then Run All Test. In the Test Explorer window that will be open, you can unfold the list of tests that has been run. The tests for the Any should fail, because you haven't yet implement it.The failed tests are marked in red.

You can also run or debug a single test, which is described in the next point.

Now, you can implement the method, so it does what the description of the exercise says. If your solution is correct, and you run the tests again, you will see that tests for the first exercise for the Any method should pass, and they will be marked in green.

### Q3: How to debug the code of the coding exercise?
Place a breakpoint in the place that you are interested in.

Now, find the unit test that you want to run. To run it in the Debug mode, you can either right-click on it the the Test Explorer and select debug, or you can left click on the test marker just at the test body and select debug. Both places are shown in the image:

![image](https://user-images.githubusercontent.com/89634343/218571108-b4cf876b-45a9-4c20-be73-1efd44dee9ad.png)

