import pandas as pd
import numpy as np
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression
from sklearn.metrics import mean_absolute_error, r2_score

print("Loading student scores dataset...")

data = pd.read_csv('studentPredictionSystem\\PythonModel\\student_scores.csv')
print("Dataset loaded successfully.")
print("First 5 records:")
print(data.head())

X = data.drop('FinalScore', axis=1).values
y = data['FinalScore'].values

X_train, X_test, y_train, y_test = train_test_split(X, y, test_size = 0.2, random_state = 42)
print("\nDataset split completed.")
print("Training set size:", len(X_train))
print("Test set size:", len(X_test))

model = LinearRegression()
model.fit(X_train, y_train)
print("\nModel training completed.")


y_predict = model.predict(X_test)
mae = mean_absolute_error(y_test, y_predict)
r2 = r2_score(y_test, y_predict)

print(f"Mean Absolute Error: {mae:.2f}")
print(f"R-squared: {r2:.2f}")


print("\nPredict New Student Score:")
attendance = float(input("Enter Attendance Percentage: "))
assignment = float(input("Enter Assignment Score: "))
quiz = float(input("Enter Quiz Score: "))
studyHours = float(input("Enter Study Hours: "))

new_student = pd.DataFrame([[attendance, assignment, quiz, studyHours]], columns=['Attendance', 'Assignment', 'Quiz', 'StudyHours'])
predicted_score = model.predict(new_student)

print(f"\nPredicted Final Score for the new student: {predicted_score[0]:.2f}")

score = predicted_score[0]

if score >= 90:
    category = "Excellent"
elif score >= 80:
    category = "Very Good"
elif score >= 70:
    category = "Good"
elif score >= 60:
    category = "Average"
else:
    category = "Poor"

print(f"\nPerformance Category: {category}")

print("\nPrediction completed successfully.")