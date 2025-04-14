# 🧮 BMI & BMR Calculator Console App

Welcome to the **BMI (Body Mass Index)** and **BMR (Basal Metabolic Rate)** calculator written in **C#**!  
This console-based application helps users determine their BMI and BMR values based on input such as gender, age, weight, and height.

---

## 📋 Features

- ✅ Simple and interactive console interface
- 📊 Accurate BMI calculation with health classification
- 🔥 Calculates BMR based on gender (using Harris-Benedict equations)
- 🧠 Input validation for: - Gender (0 for Female, 1 for Male) - Age (18-70) - Weight (50-300 kg) - Height (10-250 cm)

---

## 🧠 What is BMI?

BMI is a measure of body fat based on height and weight.

| BMI Range  | Classification            |
| ---------- | ------------------------- |
| Below 18.5 | Underweight               |
| 18.5 – 25  | Healthy and Normal Weight |
| 25 – 30    | Overweight                |
| 30 – 40    | Severely Overweight       |
| Over 40    | Extremely Overweight      |

---

## 🔥 What is BMR?

BMR (Basal Metabolic Rate) represents the number of calories your body needs to maintain basic functions (like breathing, circulation) while at rest.

📌 **Formulas used:**

- **Female:** `BMR = 655.1 + (9.563 × weight) + (1.85 × height) − (4.676 × age)`
- **Male:** `BMR = 66.47 + (13.75 × weight) + (5.003 × height) − (6.755 × age)`

---

## 🚀 Getting Started

1. Clone the repository or copy the `.cs` file.

```bash
git clone https://github.com/huseyineskan/bmi-bmr-calculator.git
```

2. Run the program in your preferred C# development environment.

```bash
dotnet run
```

3. Follow the prompts to calculate your BMI and BMR.

## 💡 Example Output

```
Welcome to BMI and BMR calculator

BMI table
The table below applies to men and women over 18 years of age with a normal body build.

BMI below 18.5 - underweight
BMI 18.5–25 - healthy and normal weight
BMI 25–30 - overweight
BMI 30–40 - severely overweight
BMI over 40 - extremendously overweight

Please select gender (Female: 0, Male: 1): 1
Please enter your age (18-70): 30
Please enter your weight (50-300kg): 80
Please write your height (10-250cm): 180

Congratulations! Your BMI and BMR values ​​have been calculated:
Your IBM: 24.3 - Healthy and Normal Weight
Your BMR: 1816.97
```

## 📌 Notes

- This project is for educational and personal use purposes.
- Always consult with a medical professional for accurate health evaluations.

## 🛠️ Technologies Used

- 👨‍💻 Language: C#
- 💻 Environment: .NET Console App

## 📄 License

This project is licensed under the MIT License.

## 🙌 Contributions

Feel free to fork this repository and make improvements! Pull requests are welcome. 🚀
