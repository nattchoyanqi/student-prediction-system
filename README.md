# Student Prediction System

A hybrid Machine Learning and C# solution designed to evaluate student metrics and predict final academic performance.

---

## 📌 Project Overview

The **Student Prediction System** leverages Machine Learning techniques to analyze student performance indicators and accurately predict final scores. The system classifies students into clear performance brackets based on their predicted outcomes:

* **🌟 Excellent** (>= 90%)
* **✨ Very Good** (80% – 89%)
* **👍 Good** (70% – 79%)
* **📊 Average** (60% – 69%)
* **⚠️ Poor** (< 60%)

---

## 📊 Features & Input Metrics

The prediction model evaluates student performance across four core metrics:

| Input Metric | Description |
| :--- | :--- |
| **Attendance** | Overall class attendance percentage |
| **Assignments** | Average assignment score |
| **Quizzes** | Average quiz score |
| **Study Hours** | Daily or weekly dedicated study hours |

---

## 🛠️ Project Structure & Tech Stack

```text
studentPredictionSystem/
├── PythonModel/
│   ├── student_scores.csv      # Training dataset
│   └── train_predict.py        # Machine learning model (scikit-learn)
├── Program.cs                  # C# Console application
├── Student.cs                  # Student object model, score logic, & category mapper
└── PredictionService.cs


---

## 🛠️ Built With

* **C#** – Backend logic and web application architecture.
* **Python -- Machine Learning Concepts** – Model training for performance prediction and score classification.
