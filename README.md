![Fizzbuzz Kata Example](bubbles.png)

# FizzBuzz Kata Example

This is a very small, simple solution to the Fizzbuzz programming problem.

*"Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”."*

The solution here is aimed at .Net developers.  It is written in C# and compiles with any modern version of Visual Studio on .Net Framework 4.6.1.  It's supporting tests are written using MS Test to make running the solution very easy.

## Why *another* Fizzbuzz solution

This project was developed to support a blog post I authored which is located [here](https://www.amcrou.ch/a-clean-fizzbuzz-solution).

As I cover in the blog post, I created this solution while mentoring a junior level developer.  The projects aim was to show a clean implementation to the problem.  There are lots of very clever solutions (some in a single line of code) using a variety of approaches.  But, I found that not many of these solutions were clean or agile.  There are lots of *if* or *switch* statements which are hard to test and more importantly hard to maintain.

I wanted to show the developer a way to create a simple yet uncoupled and easily testable solution.  I wanted an example to solidify his current training focus.

I do not suggest this is the best solution to the problem and I welcome any feedback.  

## License

This code is provided under the MIT license, the details of which can be found in the [License](LICENSE.md) file.
