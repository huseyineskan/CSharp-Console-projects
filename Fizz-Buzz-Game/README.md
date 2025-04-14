# 🎮 Fizz Buzz Console Game

A classic **FizzBuzz game** implemented in C# as a console application. This project lets users play the FizzBuzz game with custom range input and tracks how many times each result occurs.

---

## 🧠 What is FizzBuzz?

FizzBuzz is a common programming problem often used in interviews. Here's how it works:

- 🔢 Print numbers from `1` up to the user’s input.
- 🟢 If a number is divisible by **3**, print `"Fizz"`.
- 🔵 If divisible by **5**, print `"Buzz"`.
- 🟣 If divisible by **both 3 and 5**, print `"FizzBuzz"`.
- Otherwise, just print the number.

---

## 🚀 How to Play

1. Run the application.
2. Enter a number to set how far the game should count.
3. See the results of Fizz, Buzz, and FizzBuzz.
4. Type `exit` to quit the game.

---

## 💻 Example

```
Welcome to Fizz Buzz Game
How long do you want the game to continue?: 15
1.
2.
3.Fizz
4.
5.Buzz
6.Fizz
7.
8.
9.Fizz
10.Buzz
11.
12.Fizz
13.
14.
15.Fizz Buzz

Final Report
Fizz: 1
Buzz: 4
FizzBuzz: 2
```

---

## 📌 Features

- ✅ Infinite loop until the user types `exit`
- ✅ Handles invalid input gracefully
- ✅ Tracks and displays a summary report:
  - Total number of Fizz
  - Total number of Buzz
  - Total number of FizzBuzz
