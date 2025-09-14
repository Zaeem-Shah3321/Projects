from flask import Flask, render_template, request
import joblib
import numpy as np
import google.generativeai as genai

app = Flask(__name__)

# Load ML model
model = joblib.load("model.pkl")

# Configure Gemini API
genai.configure(api_key="Your-API-Key")
gemini_model =  genai.GenerativeModel(model_name="gemini-2.5-flash-preview-05-20")
@app.route("/", methods=["GET", "POST"])
def index():
    prediction = None
    gemini_response = None

    if request.method == "POST":
        try:
            # Get input values from the form
            features = [float(request.form.get(f)) for f in [
                "age", "sex", "cp", "trestbps", "chol", "fbs",
                "restecg", "thalach", "exang", "oldpeak", "slope", "ca", "thal"
            ]]

            # Predict
            result = model.predict([features])[0]
            prediction = "Heart Disease Detected" if result == 1 else "No Heart Disease Detected"

            # Gemini: Query based on prediction
            query = f"A medical prediction result is: {prediction}. What should the patient do next?"
            response = gemini_model.generate_content(query)
            gemini_response = response.text

        except Exception as e:
            prediction = "Error: " + str(e)

    return render_template("index.html", prediction=prediction, gemini_response=gemini_response)

if __name__ == "__main__":
    app.run(debug=True)
